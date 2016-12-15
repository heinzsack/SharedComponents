﻿using System;
using System.Collections.Generic;
using CsWpfBase.Utilitys;
using HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.rows;

namespace HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.tables
	{
	partial class PagesTable
		{

		public Page[] LoadAndFind_via_Ids(List<Guid> visualGuids)
			{
			if ((visualGuids == null)
				|| (visualGuids.Count == 0))
				return new Page[0];
			List<String> visualGuidStringList = new List<string>();
			foreach (Guid guid in visualGuids)
				{
				visualGuidStringList.Add($"{guid}");
				}
			String whereClauseForScreenGroups = " where Id = '" 
				+ String.Join("' or Id = '", visualGuidStringList) + "'";
			return DownloadRows($"select {DefaultSqlSelector} from " +
					$"{NativeName} {whereClauseForScreenGroups}");
			}


		}
	}
