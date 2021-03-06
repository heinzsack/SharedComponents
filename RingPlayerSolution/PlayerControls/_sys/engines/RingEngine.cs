﻿// Copyright (c) 2015-2017 All rights reserved Christian Sack
// <author>Christian Sack</author>
// <email>christian@sack.at</email>
// <website>christian.sack.at</website>
// <created>2017-04-27</creation-date>
// <modified>2017-05-03 12:03</modify-date>

using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Threading;
using CsWpfBase.env._base;
using PlayerControls.Interfaces.ringEngine;
using PlayerControls._sys.extensions.ring;
using CsWpfBase.env.extensions;

namespace PlayerControls._sys.engines
{
	/// <summary>
	///     Used for scheduling <see cref="IRingEntry" /> over a specific <see cref="IRing.RingPeriod" />. After the
	///     <see cref="IRing.RingPeriod" /> is over it will loop through the <see cref="IRing" /> forever.
	/// </summary>
	public class RingEngine<TItem> : Base where TItem : IRingEntry
	{
		private int _bufferFrontIndex;

		private bool _isRunning;
		private IRing<TItem> _ring;
		private int _ringIndex;
		private TItem[] _ringItems;

		/// <summary>Contains the <see cref="DateTime.Now" /> value for all subsequent calculation. This avoids millisecond problems.</summary>
		private DateTime DateTimeNow { get; set; }

		/// <summary>The timer which switches the active <see cref="IRingEntry" /> with a bufferd <see cref="IRingEntry" />.</summary>
		private DispatcherTimer SwitchTimer { get; }
		///<summary>The ring items loaded as array.</summary>
		private TItem[] RingItems
		{
			get => _ringItems;
			set => SetProperty(ref _ringItems, value);
		}


		#region EVENTS
		/// <summary>Occurs whenever the current playing <see cref="IRingEntry" /> changes.</summary>
		public event Delegate0 CurrentEntryChanged;
		/// <summary>Occurs whenever a <see cref="IRingEntry" /> is added to the <see cref="Buffer" />.</summary>
		public event Delegate1 BufferedEntryAdded;
		/// <summary>
		///     Occurs whenever a <see cref="IRingEntry" /> is needed to be added to the <see cref="Buffer" /> and the
		///     <see cref="IRingEntry.RingEntryInterrupt" /> is not null or empty.
		/// </summary>
		public event DelegateInterrupt InterruptEntryAvailable;
		#endregion


		public RingEngine(Dispatcher dispatcher = null)
		{
			if (dispatcher != null)
				SwitchTimer = new DispatcherTimer(DispatcherPriority.Normal, dispatcher);
			else
				SwitchTimer = new DispatcherTimer();


			SwitchTimer.Tick += SwitchTimerTicked;
		}

		/// <summary>The <see cref="IRing" /> which is meant to be played. This <see cref="IRing" /> can be changed at any time.</summary>
		public IRing<TItem> Ring
		{
			get => _ring;
			set
			{
				var before = _ring;
				if (!SetProperty(ref _ring, value))
					return;
				RingItems = value?.RingItems.OrderBy(x => x.RingEntryStartTime).ToArray();
				OnRingChanged(before, _ring);
			}
		}

		///<summary>Contains the buffered elements which are ready to be played. At the last index is the item which is meant to be played.</summary>
		public ObservableCollection<TItem> Buffer { get; } = new ObservableCollection<TItem>();


		/// <summary>The current index of the active <see cref="IRingEntry" />.</summary>
		public int RingIndex
		{
			get => _ringIndex;
			private set => SetProperty(ref _ringIndex, value);
		}

		///<summary>The index of the buffer front.</summary>
		public int BufferFrontIndex
		{
			get => _bufferFrontIndex;
			private set => SetProperty(ref _bufferFrontIndex, value);
		}

		/// <summary>
		///     True if the <see cref="RingEngine{TItem}" /> is currently running. Call <see cref="Start" /> to start the
		///     <see cref="RingEngine{TItem}" /> or
		///     <see cref="Stop" /> to stop the <see cref="RingEngine{TItem}" />.
		/// </summary>
		public bool IsRunning
		{
			get => _isRunning;
			private set => SetProperty(ref _isRunning, value);
		}

		/// <summary>Starts the <see cref="RingEngine{TItem}" /> if <see cref="IsRunning" /> is equal to false.</summary>
		public void Start()
		{
			if (IsRunning)
				return;

			IsRunning = true;

			if (Ring != null)
				OnRingChanged(Ring, Ring); // ensures that the ring starts at the correct position.
		}

		/// <summary>Stops the <see cref="RingEngine{TItem}" /> if <see cref="IsRunning" /> is equal to true.</summary>
		public void Stop()
		{
			if (!IsRunning)
				return;

			IsRunning = false;
			SwitchTimer.Stop();
		}

		/// <summary>Occurs whenever the <see cref="Ring" /> changes.</summary>
		private void OnRingChanged(IRing<TItem> oldRing, IRing<TItem> newRing)
		{
			SwitchTimer.Stop();


			if (newRing == null)
			{
				BufferClear();
				return;
			}

			SetDateTimeNow();

			var ringEntrySpecification = newRing.Find_Item_At_Time(RingItems, DateTimeNow);
			RingIndex = ringEntrySpecification.Index;

			BufferAdd(newRing, RingIndex);
			BufferRemove(oldRing);

			if (IsRunning)
				Start_SwitchTimer_At_RingIndex();
		}

		/// <summary>
		///     Occurs whenever a switch occurs. So an old <see cref="IRingEntry" /> will be popped from the buffer and a new one will
		///     be added.
		/// </summary>
		private void SwitchTimerTicked(object sender, EventArgs eventArgs)
		{
			SwitchTimer.Stop();
			if (!IsRunning)
				return;


			SetDateTimeNow();


			// Gets the index of the next item which should play after the current has finished.
			var nextBufferEntryIndex = Ring.IncreaseIndexBy(RingItems, RingIndex, Ring.RingBufferSize + 1);

			BufferPush(nextBufferEntryIndex);
			BufferPop();

			RingIndex = Ring.IncreaseIndexBy(RingItems, RingIndex, 1);
			Start_SwitchTimer_At_RingIndex();
		}

		/// <summary>Clears all elements from buffer.</summary>
		private void BufferClear()
		{
			Buffer.Clear();
		}

		/// <summary>Adds an element to the last position in the buffer. (This element will be played at the latest time possible).</summary>
		private void BufferPush(int index)
		{
			var ringItem = RingItems[index];

			if (!ringItem.RingEntryInterrupt.IsNullOrEmpty() && InterruptEntryAvailable != null)
			{
				var args = new InterruptArgs(ringItem.RingEntryInterrupt){Result = ringItem};
				InterruptEntryAvailable.Invoke(args);
			}

			Buffer.Insert(0, ringItem);
			BufferedEntryAdded?.Invoke(new NewBufferedElementArgs(ringItem));
		}

		/// <summary>Removes an element from the buffer.</summary>
		private void BufferPop()
		{
			Buffer.RemoveAt(Buffer.Count - 1);
		}


		/// <summary>Starts the timers for the specified <see cref="IRingEntry" /> at the <see cref="RingIndex" /> for the
		///     <see cref="Ring" />. </summary>
		private void Start_SwitchTimer_At_RingIndex()
		{
			var nextEntryIndex = Ring.IncreaseIndexBy(RingItems, RingIndex, 1);
			var nextEntryTime = Ring.Find_Time_At_NextPlay(RingItems, nextEntryIndex, DateTimeNow);

			var switchIntervall = nextEntryTime - DateTimeNow;




			SwitchTimer.Interval = switchIntervall;
			SwitchTimer.Start();
			CurrentEntryChanged?.Invoke(new CurrentEntryChangedArgs(RingItems[RingIndex], Ring.Find_LastRingStart(DateTimeNow).Add(RingItems[RingIndex].RingEntryStartTime), RingItems[nextEntryIndex], switchIntervall));
		}


		/// <summary>
		///     Sets the <see cref="DateTimeNow" /> property which should be used between each <see cref="IRingEntry" /> to avoid unexpected
		///     behaviour when millisecond changes and therefore another <see cref="IRingEntry" /> should be played.
		/// </summary>
		private void SetDateTimeNow()
		{
			DateTimeNow = DateTime.Now;
		}

		/// <summary>Adds the specified <paramref name="ring" /> to the <see cref="Buffer" />.</summary>
		/// <param name="ring">The <see cref="IRing" /> which should be added.</param>
		/// <param name="currentIndex">
		///     The index of the current playing <see cref="IRingEntry" />. This index is used to add the current playing and the next items
		///     which are meant to be buffered.
		/// </param>
		private void BufferAdd(IRing<TItem> ring, int currentIndex)
		{
			if (ring == null)
				return;

			for (var i = 0; i <= ring.RingBufferSize; i++)
			{
				var increaseIndexBy = ring.IncreaseIndexBy(RingItems, currentIndex, i);
				BufferPush(increaseIndexBy);
			}
		}

		/// <summary>Removes the specified <paramref name="ring" /> from the <see cref="Buffer" />.</summary>
		/// <param name="ring">The <see cref="IRing" /> which should be removed from <see cref="Buffer" />.</param>
		private void BufferRemove(IRing<TItem> ring)
		{
			if (ring == null)
				return;

			for (var i = 0; i <= ring.RingBufferSize; i++)
				BufferPop();
		}



		public delegate void Delegate0(CurrentEntryChangedArgs args);



		public delegate void Delegate1(NewBufferedElementArgs args);



		public delegate void DelegateInterrupt(InterruptArgs args);



		public class InterruptArgs
		{
			internal InterruptArgs(string interruptName)
			{
				InterruptName = interruptName;
			}

			public string InterruptName { get; }
			public TItem Result { get; set; }
		}

		public sealed class NewBufferedElementArgs : Base
		{
			public NewBufferedElementArgs(TItem entry)
			{
				Entry = entry;
			}

			/// <summary>The new <see cref="IRingEntry" /> inside the <see cref="RingEngine{TItem}.Buffer" />.</summary>
			public TItem Entry { get; }
		}



		public sealed class CurrentEntryChangedArgs : Base
		{
			/// <inheritdoc />
			internal CurrentEntryChangedArgs(TItem entry, DateTime entryStartTime, TItem nextEntry, TimeSpan duration)
			{
				Entry = entry;
				Duration = duration;
				EntryStartTime = entryStartTime;
				NextEntry = nextEntry;
			}

			/// <summary>The time when the entry should have been started.</summary>
			public DateTime EntryStartTime { get; }

			/// <summary>The <see cref="IRingEntry" /> which is currently playing for the <see cref="Duration" /> until the
			///     <see cref="NextEntry" /> will be played.</summary>
			public TItem Entry { get; }

			/// <summary>
			///     The <see cref="Duration" /> of the currently played <see cref="Entry" /> until the <see cref="NextEntry" /> will be
			///     played.
			/// </summary>
			public TimeSpan Duration { get; }

			/// <summary>The <see cref="NextEntry" /> which will be played after the <see cref="Entry" /> has finished in <see cref="Duration" />
			///     .</summary>
			public TItem NextEntry { get; }
		}
	}




}