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
//<date>2016-12-28 13:36:31</date>



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
using ISysdiagram=HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.rowinterfaces.ISysdiagram;






namespace HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.rowinterfaces
{
	///	<summary>Interface for <see cref="Sysdiagram"/> can be used to create POCO object or other models.</summary>
	[CsDbDataRowInterface(Database = "RingPlayerDb", TableName = "sysdiagrams", Generated = "16.12.28 13:36:31", Hash = "8F8565ADD52D8EE70DE289F8B0E19DD5")]
	public interface ISysdiagram
	{
		///	<summary>[<c>RingPlayerDb</c>].[<c>sysdiagrams</c>].[<c>name</c>]</summary>
		String Name { get; set; }
		///	<summary>[<c>RingPlayerDb</c>].[<c>sysdiagrams</c>].[<c>principal_id</c>]</summary>
		Int32 PrincipalId { get; set; }
		///	<summary>[<c>RingPlayerDb</c>].[<c>sysdiagrams</c>].[<c>diagram_id</c>]</summary>
		Int32 DiagramId { get; set; }
		///	<summary>[<c>RingPlayerDb</c>].[<c>sysdiagrams</c>].[<c>version</c>]</summary>
		Int32? Version { get; set; }
		///	<summary>[<c>RingPlayerDb</c>].[<c>sysdiagrams</c>].[<c>definition</c>]</summary>
		Byte[] Definition { get; set; }
	}
}