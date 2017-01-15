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
//<date>2017-01-15 00:09:46</date>



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
using IRemoteApplication=HsCentralServiceWeb._dbs.hsserver.centralservicedb.rowinterfaces.IRemoteApplication;






namespace HsCentralServiceWeb._dbs.hsserver.centralservicedb.rowinterfaces
{
	///	<summary>Interface for <see cref="RemoteApplication"/> can be used to create POCO object or other models.</summary>
	[CsDbDataRowInterface(Database = "CentralServiceDb", TableName = "RemoteApplications", Generated = "17.01.15 00:09:46", Hash = "E770576E0BDC8BDAC80C64F4D80B9548")]
	public interface IRemoteApplication
	{
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteApplications</c>].[<c>Id</c>]</summary>
		Guid Id { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteApplications</c>].[<c>Name</c>]</summary>
		String Name { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteApplications</c>].[<c>Product</c>]</summary>
		String Product { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteApplications</c>].[<c>ProductTitle</c>]</summary>
		String ProductTitle { get; set; }
	}
}