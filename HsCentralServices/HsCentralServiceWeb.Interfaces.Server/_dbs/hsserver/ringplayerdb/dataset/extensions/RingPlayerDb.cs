using System;
using System.Linq;
using PlayerControls.Interfaces;
using PlayerControls.Storage;
using PlayerControls.Storage.Utils;

namespace HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.dataset
	{
	public partial class RingPlayerDb
		{
		private bool _isConnectedWithLruStorage;

		public void ConnectWithLruStorage()
			{
			if (_isConnectedWithLruStorage)
				return;
			_isConnectedWithLruStorage = true;
			LruStorage.Install(1024*1024*1024*20L);
			Images.FileRequested += image => LruStorage.Instance.Image.GetFile_And_SetUsed(image).FullName;
			Videos.FileRequested += video => LruStorage.Instance.Video.GetFile_And_SetUsed(video).FullName;
			}
		/// <summary>
		/// returns a downloader if and only if files are missing. Otherwise retuns null.
		/// </summary>
		public DependencyDownloader GetDependencyDownloader()
			{
			ConnectWithLruStorage();
			IDownloadAble[] nonExistingImages =
				Images.Where(image => !LruStorage.Instance.Image.Exist(image)).OfType<IDownloadAble>().ToArray();
			IDownloadAble[] nonExistingVideos =
				Videos.Where(video => !LruStorage.Instance.Video.Exist(video)).OfType<IDownloadAble>().ToArray();

			if ((nonExistingImages.Length == 0 && nonExistingVideos.Length == 0))
				return null;

			return LruStorage.Instance.GetFileDownloader(nonExistingImages, nonExistingVideos, new TempDownloadInfos());
			}

		private class TempDownloadInfos : IContainDownloadInformations
			{
			public string ImageDownloadUrl
				=> "http://www.internettv.citynews.at/TempApp/RingDistribution/DownloadImage?imageId=REPLACEMENT";

			public string VideoDownloadUrl
				=> "http://www.internettv.citynews.at/TempApp/RingDistribution/DownloadVideo?videoId=REPLACEMENT";

			public string ReplacementString => "REPLACEMENT";
			}
		}
	}