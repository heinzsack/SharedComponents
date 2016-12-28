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
using ILastGeneratedBalancerState=HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.rowinterfaces.ILastGeneratedBalancerState;






namespace HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.rowinterfaces
{
	///	<summary>Interface for <see cref="LastGeneratedBalancerState"/> can be used to create POCO object or other models.</summary>
	[CsDbDataRowInterface(Database = "RingPlayerDb", TableName = "LastGeneratedBalancerStates", Generated = "16.12.28 13:36:31", Hash = "550E29BD1747777A7253AB9A4E5FF7E0")]
	public interface ILastGeneratedBalancerState
	{
		///	<summary>[<c>RingPlayerDb</c>].[<c>LastGeneratedBalancerStates</c>].[<c>Id</c>]</summary>
		Guid Id { get; set; }
		///	<summary>[<c>RingPlayerDb</c>].[<c>LastGeneratedBalancerStates</c>].[<c>PageGroupId</c>]</summary>
		Guid PageGroupId { get; set; }
		///	<summary>[<c>RingPlayerDb</c>].[<c>LastGeneratedBalancerStates</c>].[<c>SlotId</c>]</summary>
		Guid? SlotId { get; set; }
		///	<summary>[<c>RingPlayerDb</c>].[<c>LastGeneratedBalancerStates</c>].[<c>PercentageToAverageLine</c>]</summary>
		Double PercentageToAverageLine { get; set; }
	}
}