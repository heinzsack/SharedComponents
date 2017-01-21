﻿// Copyright (c) 2016 All rights reserved Christian Sack
// <author>Christian Sack</author>
// <email>christian@sack.at</email>
// <website>christian.sack.at</website>
// <date>2017-01-05</date>

using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Windows;
using CsWpfBase.Global;
using CsWpfBase.Themes.Controls.Containers;
using CsWpfBase.Themes.Controls.Editors._baseControls;






namespace TestApplication
{
	/// <summary>Interaction logic for MainWindow.xaml</summary>
	public partial class MainWindow : CsWindow
	{
		public MainWindow()
		{
			CsGlobal.Install(GlobalFunctions.Storage);
			CsGlobal.InstallRemote("service.wpmedia.at", "<RSAKeyValue><Modulus>7bTXJULjf3ELHOv/57LyGUTBpgQ7CucbdSXusgy+270FPbK0Iboqkqrhs4rbeKkH6AWA6BwXGqUqAwwVNKHPEtXTpLe9GKM41eZOJyhU7QCw0X8BAQXLbTQbc+QGFn/J/t6wlh7cgrYgqe/3Q9u7yW9+j16Q8Uj4OG4N20fsqX0=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");


			CsGlobal.Remote.EventHub.Connect();
			CsGlobal.Remote.EventHub.AfterConnectionEstablished += AfterConnectionEstablished;

			InitializeComponent();
			FileSelector.ValuePath = new FileInfo(@"C:\Data\Personal\OneDrive\Bilder\Wallpaper\6.jpg");
			IdSelector.Value = "0A2D546F-B976-4566-8BAD-E910B3DF96E3";
		}

		private void AfterConnectionEstablished()
		{
			CsGlobal.Remote.EventHub.Handle<int>("SimpleEvent", SimpleEvent);
			CsGlobal.Remote.EventHub.Handle<int>("SimpleEvent1", SimpleEvent);
			CsGlobal.Remote.EventHub.Handle<int>("SimpleEvent2", SimpleEvent);
			CsGlobal.Remote.EventHub.Handle<int>("SimpleEvent3", SimpleEvent);
		}

		private void SendEventClick(object sender, RoutedEventArgs e)
		{
			CsGlobal.Remote.EventHub.Raise("SimpleEvent", Process.GetCurrentProcess().Id);
		}

		private void SimpleEvent(int eventData)
		{
			CsGlobal.Message.Push(eventData);
		}

		private void DownloadClick(object sender, RoutedEventArgs e)
		{
			var filedownload = CsGlobal.Remote.FileRepository.FindOrDownloadAsync(Guid.Parse(IdSelector.Value));
			filedownload.ShowDialog();
		}

		private void UploadClick(object sender, RoutedEventArgs e)
		{
			var fileupload = CsGlobal.Remote.FileRepository.UploadAsync(FileSelector.ValuePath, null, null, "MyGroup1", DateTime.Now.AddSeconds(30));
			fileupload.ShowDialog();
			if (fileupload.IsSucceeded)
			IdSelector.Value = fileupload.Result[0].Id.ToString();
		}

		private ValidationResult IdSelector_OnValidation(object value)
		{
			Guid id;
			if (Guid.TryParse(value?.ToString() ?? "", out id))
				return ValidationResult.Ok;
			return ValidationResult.Error("not an id");
		}

		
	}
}