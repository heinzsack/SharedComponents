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
//<date>2017-01-21 17:31:31</date>



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
using IRemoteLog=HsCentralServiceWeb._dbs.hsserver.centralservicedb.rowinterfaces.IRemoteLog;






namespace HsCentralServiceWeb._dbs.hsserver.centralservicedb.rowinterfaces
{
	///	<summary>Interface for <see cref="RemoteLog"/> can be used to create POCO object or other models.</summary>
	[CsDbDataRowInterface(Database = "CentralServiceDb", TableName = "RemoteLogs", Generated = "17.01.21 17:31:31", Hash = "7243FDCB6398B58F55B332FCC06945C5")]
	public interface IRemoteLog
	{
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteLogs</c>].[<c>Id</c>]</summary>
		Guid Id { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteLogs</c>].[<c>Created</c>]</summary>
		DateTime Created { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteLogs</c>].[<c>SeverityNumber</c>]</summary>
		Int32 SeverityNumber { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteLogs</c>].[<c>Title</c>]</summary>
		String Title { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteLogs</c>].[<c>Message</c>]</summary>
		String Message { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteLogs</c>].[<c>CodeFile</c>]</summary>
		String CodeFile { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteLogs</c>].[<c>CodeMethod</c>]</summary>
		String CodeMethod { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteLogs</c>].[<c>CodeLine</c>]</summary>
		Int32? CodeLine { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteLogs</c>].[<c>RemoteInstanceId</c>]</summary>
		Guid RemoteInstanceId { get; set; }
	}
}