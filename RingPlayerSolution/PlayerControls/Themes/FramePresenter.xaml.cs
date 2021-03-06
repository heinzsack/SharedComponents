﻿// Copyright (c) 2015-2017 All rights reserved Christian Sack
// <author>Christian Sack</author>
// <email>christian@sack.at</email>
// <website>christian.sack.at</website>
// <created>2017-01-28</creation-date>
// <modified>2017-05-05 14:49</modify-date>

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using CsWpfBase.csglobal;
using CsWpfBase.env.extensions;
using PlayerControls.Interfaces.presentation.FrameItems;
using PlayerControls.Themes._components;
using PlayerControls._sys.pocos.presentation.frame;






namespace PlayerControls.Themes
{
	/// <summary>Interaction logic for PageViewer.xaml</summary>
	public partial class FramePresenter : UserControl
	{


		#region DP Keys
		/// <summary>The <see cref="DependencyProperty" /> for the <see cref="IsDiagnostic" /> property.</summary>
		public static readonly DependencyProperty IsDiagnosticProperty = DependencyProperty.Register("IsDiagnostic", typeof(bool), typeof(FramePresenter), new FrameworkPropertyMetadata
																																							{
																																								BindsTwoWayByDefault = true,
																																								//PropertyChangedCallback = (o, args) => ((FramePresenter)o).IsDiagnosticDpChanged((bool)args.OldValue, (bool)args.NewValue),
																																								DefaultValue = default(bool),
																																								DefaultUpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
																																							});
		/// <summary>The <see cref="DependencyProperty" /> for the <see cref="Item" /> property.</summary>
		public static readonly DependencyProperty ItemProperty = DependencyProperty.Register("Item", typeof(IFrame), typeof(FramePresenter), new FrameworkPropertyMetadata
																																			{
																																				PropertyChangedCallback = (o, args) => ((FramePresenter) o).ItemDpChanged((IFrame) args.OldValue, (IFrame) args.NewValue),
																																				DefaultValue = default(IFrame),
																																				DefaultUpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
																																			});
		#endregion


		const string StartedTag = "Started";


		/// <summary>Returns a prefilled IFrame.</summary>
		public static IFrame GetMock()
		{
			return PocoFrame.Mock.FullScreen_ImageAndText();
		}

		private bool _animationsStarted;
		private bool _videosStarted;


		public FramePresenter()
		{
			InitializeComponent();
			var selector = (FrameItemTemplateSelector) Resources[typeof(FrameItemTemplateSelector)];
			selector.FrameTemplate = (DataTemplate) Resources[typeof(IFrame)];
			selector.FrameItemVideoTemplate = (DataTemplate) Resources[typeof(IFrameVideo)];
			selector.FrameItemTextTemplate = (DataTemplate) Resources[typeof(IFrameText)];
			selector.FrameItemImageTemplate = (DataTemplate) Resources[typeof(IFrameImage)];
		}


		/// <summary>The <see cref="IFrame" /> which should be displayed by the <see cref="FramePresenter" />.</summary>
		public IFrame Item
		{
			get => (IFrame) GetValue(ItemProperty);
			set => SetValue(ItemProperty, value);
		}

		/// <summary>If true a special diagnostic representation of the single elements will be applied.</summary>
		public bool IsDiagnostic
		{
			get => (bool) GetValue(IsDiagnosticProperty);
			set => SetValue(IsDiagnosticProperty, value);
		}


		#region DP Changed
		private void ItemDpChanged(IFrame oldValue, IFrame newValue)
		{
			_videosStarted = false;
			_animationsStarted = false;
		}
		#endregion


		/// <summary>
		///     Starts the videos of this page at a specific <paramref name="position" />. This method can safly be called multiple times.
		///     Only the first call will take effect.
		/// </summary>
		/// <param name="position">The position where the video should start.</param>
		public void StartVideos(TimeSpan? position = null)
		{
			if (_videosStarted)
				return;
			_videosStarted = true;
			var start = DateTime.Now;

			DoOnLoaded(() =>
			{
				foreach (var mediaElement in GetMediaElemente_FromPage())
				{
					mediaElement.Tag = StartedTag;
					mediaElement.Play();

					if (position != null && position.Value > TimeSpan.FromMilliseconds(100))
						mediaElement.Position = position.Value.Add(DateTime.Now - start);
				}
			});
		}

		/// <summary>
		///     Starts the transitions of this page at a specific <paramref name="position" />. This method can safly be called multiple
		///     times. Only the first call will take effect.
		/// </summary>
		/// <param name="position">The position where the transistions should start.</param>
		public void StartTransitions(TimeSpan? position = null)
		{
			if (_animationsStarted)
				return;
			_animationsStarted = true;

			foreach (var animationCover in GetTransistionCovers_FromPage())
				animationCover.Start(position ?? TimeSpan.Zero);
		}

		/// <summary>ensures that the videos are buffered.</summary>
		public void BufferVideos()
		{
			DoOnLoaded(() =>
			{
				foreach (var mediaElement in GetMediaElemente_FromPage())
					mediaElement.Stop();
			});
		}



		private void DoOnLoaded(Action action)
		{
			void OnLoaded(object sender, RoutedEventArgs routedEventArgs)
			{
				Loaded -= OnLoaded;
				action();
			}

			if (!IsLoaded)
				Loaded += OnLoaded;
			else
				action();
		}

		private MediaElement[] GetMediaElemente_FromPage()
		{
			var mediaElements = PagePresenter.VisualChilds_By_Condition<MediaElement>(cover => true);
			if (mediaElements == null)
				return new MediaElement[0];
			return mediaElements.ToArray();
		}

		private FrameItemContainer[] GetTransistionCovers_FromPage()
		{
			var animationCovers = PagePresenter.VisualChilds_By_Condition<FrameItemContainer>(cover => cover.Transitions != null && cover.Transitions.Count != 0);
			if (animationCovers == null)
				return new FrameItemContainer[0];
			return animationCovers.ToArray();
		}

		private void MediaElement_OnMediaFailed(object sender, ExceptionRoutedEventArgs e)
		{
			CsGlobal.Log.Error("Video file corrupted", e.ErrorException, $"The video file '{((MediaElement) sender).Source.AbsolutePath}' is corrupted.");
		}

		private void Image_OnImageFailed(object sender, ExceptionRoutedEventArgs e)
		{
			CsGlobal.Log.Error("Image file corrupted", e.ErrorException);
		}

		private void MediaElement_Unloaded(object sender, RoutedEventArgs e)
		{
			((MediaElement)sender).Close();
		}
	}
}