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
//<date>2016-12-28 13:36:30</date>



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
using IRemoteComputer=HsCentralServiceWeb._dbs.hsserver.centralservicedb.rowinterfaces.IRemoteComputer;






namespace HsCentralServiceWeb._dbs.hsserver.centralservicedb.rowinterfaces
{
	///	<summary>Interface for <see cref="RemoteComputer"/> can be used to create POCO object or other models.</summary>
	[CsDbDataRowInterface(Database = "CentralServiceDb", TableName = "RemoteComputers", Generated = "16.12.28 13:36:30", Hash = "43BD6A3AB205383FA6F81C746F741D9C")]
	public interface IRemoteComputer
	{
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteComputers</c>].[<c>Id</c>]</summary>
		Guid Id { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteComputers</c>].[<c>Name</c>]</summary>
		String Name { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteComputers</c>].[<c>OsName</c>]</summary>
		String OsName { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteComputers</c>].[<c>OsRegisteredUser</c>]</summary>
		String OsRegisteredUser { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteComputers</c>].[<c>OsCountryCode</c>]</summary>
		String OsCountryCode { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteComputers</c>].[<c>OsCodeSet</c>]</summary>
		String OsCodeSet { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteComputers</c>].[<c>OsProductType</c>]</summary>
		String OsProductType { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteComputers</c>].[<c>Manufacturer</c>]</summary>
		String Manufacturer { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteComputers</c>].[<c>Model</c>]</summary>
		String Model { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteComputers</c>].[<c>Family</c>]</summary>
		String Family { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteComputers</c>].[<c>SkuNumber</c>]</summary>
		String SkuNumber { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteComputers</c>].[<c>BiosName</c>]</summary>
		String BiosName { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteComputers</c>].[<c>BiosVersion</c>]</summary>
		String BiosVersion { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteComputers</c>].[<c>MainboardManufacturer</c>]</summary>
		String MainboardManufacturer { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteComputers</c>].[<c>MainboardProduct</c>]</summary>
		String MainboardProduct { get; set; }
	}
}