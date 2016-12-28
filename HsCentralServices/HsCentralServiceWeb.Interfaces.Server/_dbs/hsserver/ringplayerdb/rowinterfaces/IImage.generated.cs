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
using IImage=HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.rowinterfaces.IImage;






namespace HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.rowinterfaces
{
	///	<summary>Interface for <see cref="Image"/> can be used to create POCO object or other models.</summary>
	[CsDbDataRowInterface(Database = "RingPlayerDb", TableName = "Images", Generated = "16.12.28 13:36:31", Hash = "8057CB5EFEF36F16BDADF5D26A2463D3")]
	public interface IImage
	{
		///	<summary>[<c>RingPlayerDb</c>].[<c>Images</c>].[<c>Id</c>]</summary>
		Guid Id { get; set; }
		///	<summary>[<c>RingPlayerDb</c>].[<c>Images</c>].[<c>DiagnosticText</c>]</summary>
		String DiagnosticText { get; set; }
		///	<summary>[<c>RingPlayerDb</c>].[<c>Images</c>].[<c>Extension</c>]</summary>
		String Extension { get; set; }
		///	<summary>[<c>RingPlayerDb</c>].[<c>Images</c>].[<c>ImageId</c>]</summary>
		Guid? ImageId { get; set; }
		///	<summary>[<c>RingPlayerDb</c>].[<c>Images</c>].[<c>ParentPageId</c>]</summary>
		Guid ParentPageId { get; set; }
		///	<summary>[<c>RingPlayerDb</c>].[<c>Images</c>].[<c>SortOrder</c>]</summary>
		Int32 SortOrder { get; set; }
		///	<summary>[<c>RingPlayerDb</c>].[<c>Images</c>].[<c>MarginThickness</c>]</summary>
		String MarginThickness { get; set; }
		///	<summary>[<c>RingPlayerDb</c>].[<c>Images</c>].[<c>BorderThickness</c>]</summary>
		String BorderThickness { get; set; }
		///	<summary>[<c>RingPlayerDb</c>].[<c>Images</c>].[<c>Background</c>]</summary>
		String Background { get; set; }
		///	<summary>[<c>RingPlayerDb</c>].[<c>Images</c>].[<c>BorderColor</c>]</summary>
		String BorderColor { get; set; }
		///	<summary>[<c>RingPlayerDb</c>].[<c>Images</c>].[<c>Rotation</c>]</summary>
		Double Rotation { get; set; }
		///	<summary>[<c>RingPlayerDb</c>].[<c>Images</c>].[<c>FileIdentifier</c>]</summary>
		Guid FileIdentifier { get; set; }
	}
}