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
using IRemoteRingPlayerManagement=HsCentralServiceWeb._dbs.hsserver.centralservicedb.rowinterfaces.IRemoteRingPlayerManagement;






namespace HsCentralServiceWeb._dbs.hsserver.centralservicedb.rowinterfaces
{
	///	<summary>Interface for <see cref="RemoteRingPlayerManagement"/> can be used to create POCO object or other models.</summary>
	[CsDbDataRowInterface(Database = "CentralServiceDb", TableName = "RemoteRingPlayerManagements", Generated = "16.12.28 13:36:30", Hash = "75107B9F7C93D2AD5CD26CFD77C21AFF")]
	public interface IRemoteRingPlayerManagement
	{
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteRingPlayerManagements</c>].[<c>Id</c>]</summary>
		Guid Id { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteRingPlayerManagements</c>].[<c>RemoteInstanceId</c>]</summary>
		Guid RemoteInstanceId { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteRingPlayerManagements</c>].[<c>LastUpdated</c>]</summary>
		DateTime LastUpdated { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteRingPlayerManagements</c>].[<c>LatestGeneratedRingId</c>]</summary>
		Int32? LatestGeneratedRingId { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RemoteRingPlayerManagements</c>].[<c>LatestTransmittedRingId</c>]</summary>
		Int32? LatestTransmittedRingId { get; set; }
	}
}