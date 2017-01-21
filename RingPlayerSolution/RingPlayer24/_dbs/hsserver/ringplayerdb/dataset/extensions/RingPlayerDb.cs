// Copyright (c) 2016 All rights reserved Christian Sack
// <author>Christian Sack</author>
// <email>christian@sack.at</email>
// <website>christian.sack.at</website>
// <date>2017-01-14</date>

using System;
using System.Linq;
using CsWpfBase.Global;
using CsWpfBase.Global.remote.services.fileRepository.components.tasks;






namespace RingPlayer24._dbs.hsserver.ringplayerdb.dataset
{
	public partial class RingPlayerDb
	{
		/// <summary>returns a <see cref="FileDownloadTask" /> if there are missing dependencys otherwise returns NULL.</summary>
		public FileDownloadTask DownloadDependencys()
		{
			var dependencys = Images.Select(x => x.ImageId).Where(x => !CsGlobal.Remote.FileRepository.IsCached(x))
									.Union
									(
										Videos.Select(x => x.VideoId).Where(x => !CsGlobal.Remote.FileRepository.IsCached(x))
									)
									.Distinct().ToArray();
			if (dependencys.Length == 0)
				return null;

			return CsGlobal.Remote.FileRepository.FindOrDownloadAsync(dependencys);
		}
	}
}