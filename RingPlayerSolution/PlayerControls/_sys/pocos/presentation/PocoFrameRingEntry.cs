// Copyright (c) 2015-2017 All rights reserved Christian Sack
// <author>Christian Sack</author>
// <email>christian@sack.at</email>
// <website>christian.sack.at</website>
// <created>2017-04-27</creation-date>
// <modified>2017-04-28 14:57</modify-date>

using System;
using System.Collections.Generic;
using CsWpfBase.Ev.Objects;
using Newtonsoft.Json;
using PlayerControls.Interfaces.presentation;
using PlayerControls.Interfaces.presentation.FrameItems;






namespace PlayerControls._sys.pocos.presentation
{



	[JsonObject(MemberSerialization.OptIn)]
	[Serializable]
	public class PocoFrameRingEntry : Base, IFrameRingEntry
	{
		/// <inheritdoc />
		[JsonProperty("Frame")] private PocoFrame _frame;
		/// <inheritdoc />
		private string _ringEntryInterrupt;
		/// <inheritdoc />
		private TimeSpan _ringEntryStartTime;


		#region Overrides/Interfaces
		/// <inheritdoc />
		[JsonIgnore]
		public IFrame Frame
		{
			get => _frame;
			set => SetProperty(ref _frame, (PocoFrame) value);
		}
		/// <inheritdoc />
		[JsonProperty("InterruptCallBack")]
		public string RingEntryInterrupt
		{
			get => _ringEntryInterrupt;
			set => SetProperty(ref _ringEntryInterrupt, value);
		}
		/// <inheritdoc />
		[JsonProperty("StartTime")]
		public TimeSpan RingEntryStartTime
		{
			get => _ringEntryStartTime;
			set => SetProperty(ref _ringEntryStartTime, value);
		}
		#endregion



		public static class Mock
		{
			public static List<PocoFrameRingEntry> Get(TimeSpan duration)
			{
				var framesPerMinute = 60;
				var secondsPerFrame = 60 / framesPerMinute;

				var entries = new List<PocoFrameRingEntry>();
				for (var i = 0; i < duration.Minutes * framesPerMinute; i++)
					entries.Add(new PocoFrameRingEntry
								{
									RingEntryStartTime = TimeSpan.FromSeconds(i * secondsPerFrame),
									Frame = PocoFrame.Mock.FullScreenPrefilled(i.ToString()),
								});
				return entries;
			}
		}
	}
}