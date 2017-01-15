//********************************************************************
//
//                 AUTOGENERATED CONTENT DO NOT MODIFY
//                      PRODUCED BY CsWpfBase.Db
//
//********************************************************************
//
//
//Copyright (c) 2014 - 2016 All rights reserved Christian Sack
//<author>Christian Sack</author>
//<email>service.christian@sack.at</email>
//<website>christian.sack.at</website>
//<date>2017-01-15 16:50:35</date>



using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Markup;
using CsWpfBase.Ev.Public.Extensions;
using CsWpfBase.Db.attributes;
using CsWpfBase.Db.attributes.columnAttributes;
using CsWpfBase.Db.models;
using CsWpfBase.Db.models.helper;
using CsWpfBase.Db.models.bases;
using CsWpfBase.Db.router;
using System.IO;
using System.Text;
using System.ComponentModel;
using IRemoteConnection=HsCentralServiceWeb._dbs.hsserver.centralservicedb.rowinterfaces.IRemoteConnection;






namespace HsCentralServiceWeb._dbs.hsserver.centralservicedb.rowinterfaces
{
	///	<summary>Interface for <see cref="RemoteConnection"/> can be used to create POCO object or other models.</summary>
	[CsDbDataRowInterface(Database = "CentralServiceDb", TableName = "RemoteConnections", Generated = "17.01.15 16:50:35", Hash = "A1F46719600889E8D6E3245EC87368E8")]
	public interface IRemoteConnection
	{
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteConnections</c>].[<c>Id</c>]</summary>
		Guid Id { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteConnections</c>].[<c>RemoteInstanceId</c>]</summary>
		Guid RemoteInstanceId { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteConnections</c>].[<c>Server</c>]</summary>
		String Server { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteConnections</c>].[<c>Established</c>]</summary>
		DateTime Established { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteConnections</c>].[<c>Events</c>]</summary>
		String Events { get; set; }
	}
}