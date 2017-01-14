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
//<date>2017-01-14 15:59:27</date>



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
using IVideo=RingPlayer24._dbs.hsserver.ringplayerdb.rowinterfaces.IVideo;






namespace RingPlayer24._dbs.hsserver.ringplayerdb.rowinterfaces
{
	///	<summary>Interface for <see cref="Video"/> can be used to create POCO object or other models.</summary>
	[CsDbDataRowInterface(Database = "RingPlayerDb", TableName = "Videos", Generated = "17.01.14 15:59:27", Hash = "FBC603710E477EA1AFC896127FA0A496")]
	public interface IVideo
	{
		///	<summary>[<c>RingPlayerDb</c>].[<c>Videos</c>].[<c>Id</c>]</summary>
		Guid Id { get; set; }
		///	<summary>[<c>RingPlayerDb</c>].[<c>Videos</c>].[<c>PageId</c>]</summary>
		Guid PageId { get; set; }
		///	<summary>[<c>RingPlayerDb</c>].[<c>Videos</c>].[<c>VideoId</c>]</summary>
		Guid VideoId { get; set; }
		///	<summary>[<c>RingPlayerDb</c>].[<c>Videos</c>].[<c>SortOrder</c>]</summary>
		Int32 SortOrder { get; set; }
		///	<summary>[<c>RingPlayerDb</c>].[<c>Videos</c>].[<c>MarginThickness</c>]</summary>
		String MarginThickness { get; set; }
		///	<summary>[<c>RingPlayerDb</c>].[<c>Videos</c>].[<c>BorderThickness</c>]</summary>
		String BorderThickness { get; set; }
		///	<summary>[<c>RingPlayerDb</c>].[<c>Videos</c>].[<c>Background</c>]</summary>
		String Background { get; set; }
		///	<summary>[<c>RingPlayerDb</c>].[<c>Videos</c>].[<c>BorderColor</c>]</summary>
		String BorderColor { get; set; }
		///	<summary>[<c>RingPlayerDb</c>].[<c>Videos</c>].[<c>Rotation</c>]</summary>
		Double Rotation { get; set; }
		///	<summary>[<c>RingPlayerDb</c>].[<c>Videos</c>].[<c>DiagnosticText</c>]</summary>
		String DiagnosticText { get; set; }
	}
}