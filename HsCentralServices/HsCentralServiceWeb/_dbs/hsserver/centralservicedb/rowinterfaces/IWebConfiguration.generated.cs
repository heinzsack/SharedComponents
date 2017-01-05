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
//<date>2017-01-04 13:12:46</date>



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
using IWebConfiguration=HsCentralServiceWeb._dbs.hsserver.centralservicedb.rowinterfaces.IWebConfiguration;






namespace HsCentralServiceWeb._dbs.hsserver.centralservicedb.rowinterfaces
{
	///	<summary>Interface for <see cref="WebConfiguration"/> can be used to create POCO object or other models.</summary>
	[CsDbDataRowInterface(Database = "CentralServiceDb", TableName = "WebConfigurations", Generated = "17.01.04 13:12:46", Hash = "826D8D719C74D38F8635E57DF67A4600")]
	public interface IWebConfiguration
	{
		///	<summary>[<c>CentralServiceDb</c>].[<c>WebConfigurations</c>].[<c>PropertyName</c>]</summary>
		String PropertyName { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>WebConfigurations</c>].[<c>Value</c>]</summary>
		String Value { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>WebConfigurations</c>].[<c>UpdateCount</c>]</summary>
		Int32 UpdateCount { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>WebConfigurations</c>].[<c>LastUpdated</c>]</summary>
		DateTime LastUpdated { get; set; }
	}
}