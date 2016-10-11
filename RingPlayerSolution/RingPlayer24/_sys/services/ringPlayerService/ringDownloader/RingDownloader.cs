﻿// Copyright (c) 2016 All rights reserved Christian Sack
// <author>Christian Sack</author>
// <email>christian@sack.at</email>
// <website>christian.sack.at</website>
// <date>2016-09-18</date>

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using CsWpfBase.Ev.Public.Extensions;
using CsWpfBase.Global.transmission.clientIdentification;
using CsWpfBase.Utilitys;
using HsCentralServiceWebInterfacesClient.steadyConnection.hubs.ringDistribution.newRingAvailableArgs;
using HsCentralServiceWebInterfacesClient.steadyConnection.hubs.ringDistribution.ringValidationArgs;
using HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.dataset;
using HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.rows;
using PlayerControls.Interfaces;
using PlayerControls.Storage.Utils;






namespace RingPlayer24._sys.services.ringPlayerService.ringDownloader
	{
	public class RingDownloader
		{
		private readonly object _syncLock = new object();
		private bool _isCanceled = false;
		private List<WebClient> ActiveDownloads { get; set; } = new List<WebClient>();

		public RingDownloader(NewRingAvailableArgs arguments)
			{
			Arguments = arguments;
			}

		public ProcessLock IsFileDownloading { get; } = new ProcessLock();
		public ProcessLock IsRingDownloading { get; } = new ProcessLock();
		public ProcessLock IsRingValidating { get; } = new ProcessLock();

		public NewRingAvailableArgs Arguments { get; set; }
		private RingMetaData CurrentRing { get; set; }
		private IDownloadAble[] MissingImages { get; set; }
		private IDownloadAble[] MissingVideos { get; set; }
		private DependencyDownloader DependencyDownloader { get; set; }

		public Task<RingMetaData> Start()
			{
			Task<RingMetaData> t = new Task<RingMetaData>(() =>
				{
				DownloadRing();
				FindMissingFiles();
				DownloadMissingFiles();
				ApproveNewRing();

					if (_isCanceled)
					throw new OperationCanceledException();

				return CurrentRing;
				}, TaskCreationOptions.LongRunning);
			t.Start(TaskScheduler.Default);
			return t;
			}

		public void Stop()
			{
			lock (_syncLock)
				{
				if (_isCanceled)
					return;

				_isCanceled = true;
				foreach (WebClient activeDownload in ActiveDownloads)
					{
					activeDownload.CancelAsync();
					}
				DependencyDownloader?.Stop();
				}
			}

		private void DownloadRing()
			{
			using (IsRingDownloading.Activate())
				{
				Sys.Services.RingPlayerService.SendInstanceArgs();
				FileInfo tempFilePath =
					new FileInfo(Path.Combine(Sys.Storage.Lru.DownloadsFolder.FullName,
					Arguments.RingId + ".dataset"));
				Task task = DownloadFile(Arguments.DownloadUrl, tempFilePath);
				if ((task != null) && task.Status == TaskStatus.RanToCompletion)
					Sys.Storage.Ring.Add(Arguments.RingId, tempFilePath);

				tempFilePath.Delete();

				if (task == null)
					throw new OperationCanceledException();
				if (task.Exception != null)
					throw task.Exception;
				if (task.Status != TaskStatus.RanToCompletion)
					throw new OperationCanceledException();

				CurrentRing =
					Sys.Storage.Ring.GetFile_And_SetUsed(Arguments.RingId)
						.LoadAs_Object_From_SerializedBinary<RingPlayerDb>()
						.RingMetaDatas[0];
				}
			}

		private void FindMissingFiles()
			{
			MissingImages =
				CurrentRing.DataSet.Images.Where(i => Sys.Storage.Lru.Image.GetFile_And_SetUsed(i) == null)
					.OfType<IDownloadAble>()
					.ToArray();
			MissingVideos =
				CurrentRing.DataSet.Videos.Where(i => Sys.Storage.Lru.Video.GetFile_And_SetUsed(i) == null)
					.OfType<IDownloadAble>()
					.ToArray();
			}

		private void DownloadMissingFiles()
			{
			using (IsFileDownloading.Activate())
				{
				Sys.Services.RingPlayerService.SendInstanceArgs();
				DownloadInformations downloadInformations = new DownloadInformations
					(Arguments.ImageDownloadUrl, Arguments.VideoDownloadUrl,
					Arguments.ImageVideoReplacementString);
				DependencyDownloader downloader = Sys.Storage.Lru.GetFileDownloader
					(MissingImages, MissingVideos, downloadInformations);
				downloader.Start().Wait();
				}
			}


		private void ApproveNewRing()
			{
			if (_isCanceled)
				return;
			using (IsRingValidating.Activate())
				{
				Sys.Services.RingPlayerService.SendInstanceArgs();
				RingValidationResultArgs resultArgs =
					Sys.ServerConnection.RingDistribution.RingValidation(new RingValidationArgs {RingId = Arguments.RingId})?.Result;
				if (resultArgs == null || !resultArgs.Valid)
					throw new InvalidOperationException("the ring is invalid and should not be played");
				}
			}

		private Task DownloadFile(string website, FileInfo targetFile)
			{
			Task task;
			WebClient wc;
			lock (_syncLock)
				{
				if (_isCanceled)
					return null;
				targetFile.CreateDirectory_IfNotExists();
				targetFile.DeleteFile_IfExists();
				wc = new WebClient();
				CsClientIdentification.Transmission.Set(wc);
				ActiveDownloads.Add(wc);
				task = wc.DownloadFileTaskAsync(website, targetFile.FullName);
				}
			try
				{
				Task.WaitAll(task);
				}
			catch (Exception exc)
				{

				}
			lock (_syncLock)
				{
				ActiveDownloads.Remove(wc);
				}
			return task;

			}
		private class DownloadInformations : IContainDownloadInformations
			{
			public DownloadInformations(string imageDownloadUrl, string videoDownloadUrl, string replacementString)
				{
				ImageDownloadUrl = imageDownloadUrl;
				VideoDownloadUrl = videoDownloadUrl;
				ReplacementString = replacementString;
				}

			public string ImageDownloadUrl { get; }
			public string VideoDownloadUrl { get; }
			public string ReplacementString { get; }
			}


		}

	public class HsLocalLogging
		{
		private  StreamWriter _localLog;

		private String StreamWriterFileName {
			get
				{
				FileInfo newLogFile = new FileInfo(@"D:\WPMediaSender\Temp\PlayerLog.log");
				newLogFile.CreateDirectory_IfNotExists();
				return newLogFile.FullName;
				}
			}

		private StreamWriter LocalLog
			{
			get
				{
				if (_localLog == null)
					_localLog = new StreamWriter(StreamWriterFileName);
				return _localLog;
				}
			}

		public void Log(String Message, [CallerMemberName] string method = null, [CallerFilePath] string filepath = null, [CallerLineNumber] int line = 0)
			{
			LocalLog.WriteLine($"{DateTime.Now.TimeOfDay} {method}, {line} - {Message}");
			LocalLog.Flush();
			}
		}
	}