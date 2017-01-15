﻿// Copyright (c) 2016 All rights reserved Christian Sack
// <author>Christian Sack</author>
// <email>christian@sack.at</email>
// <website>christian.sack.at</website>
// <date>2017-01-15</date>

using System;
using System.Web.Mvc;
using CsWpfBase.Global.remote._protocols;
using HsCentralServiceWeb._sys;






namespace HsCentralServiceWeb.Controllers.services
{
	public class DbAccessController : Controller
	{

		// GET: DbAccess
		[ActionName(nameof(RemoteProtocol.DbAccess.Http.Routes.Do))]
		public ActionResult Do()
		{
			Sys.RemoteServer.DbAccess.HandleRequest();
			return new ContentResult();
		}
	}
}