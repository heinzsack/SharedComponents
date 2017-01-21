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
using HsCentralServiceWeb._dbs.hsserver.centralservicedb.dataset;
using HsCentralServiceWeb._dbs.hsserver.centralservicedb.views;






namespace HsCentralServiceWeb._dbs.hsserver.centralservicedb.rows
{
	///<summary>!VIEW: DataRow([<c>CentralServiceDb</c>].[<c>ShowInstancenSituation</c>]): row model of <see cref="ShowInstancenSituationView"/>.</summary>
	[Serializable]
	[DebuggerDisplay("!VIEW: DataRow(CentralServiceDb.ShowInstancenSituation)")]
	[CsDbViewRow(Database = "CentralServiceDb", ViewName = "ShowInstancenSituation", Generated = "17.01.21 17:31:31", Hash = "38E250DC4C3A13E6BB7BA1849995A0F9")]
	public partial class ShowInstancenSituation : CsDbViewRow
	{
		public ShowInstancenSituation(DataRowBuilder builder) : base(builder){}
	
	
	
		///	<summary> gets the owning table of type <see cref="ShowInstancenSituationView"/>. </summary>
		public new ShowInstancenSituationView Table => (ShowInstancenSituationView) base.Table;
	
	
	
	
		#region COLUMNS
		///	<summary>[<c>CentralServiceDb</c>].[<c>ShowInstancenSituation</c>].[<c>RemoteInstanceId</c>] (Type = <c>uniqueidentifier</c>) (#TypeDescription#)</summary>
		[CsDbDataColumn][CsDbNativeDataColumn(Table = "ShowInstancenSituation", Name = "RemoteInstanceId", Type = "uniqueidentifier", IsNullable = "NO")] 
		public Guid RemoteInstanceId => GetDbValue<Guid>(ShowInstancenSituationView.RemoteInstanceIdCol);
	
		///	<summary>[<c>CentralServiceDb</c>].[<c>ShowInstancenSituation</c>].[<c>ProcessFile</c>] (Type = <c>nvarchar</c>, <c>NULLABLE</c>, MaxLength = <c>-1</c>) (#TypeDescription#)</summary>
		[CsDbDataColumn(IsNullable = true)][CsDbNativeDataColumn(Table = "ShowInstancenSituation", Name = "ProcessFile", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES")] 
		public String ProcessFile => GetDbValue<String>(ShowInstancenSituationView.ProcessFileCol);
	
		///	<summary>[<c>CentralServiceDb</c>].[<c>ShowInstancenSituation</c>].[<c>FirstExecutionTime</c>] (Type = <c>datetime2</c>, <c>NULLABLE</c>) (#TypeDescription#)</summary>
		[CsDbDataColumn(IsNullable = true)][CsDbNativeDataColumn(Table = "ShowInstancenSituation", Name = "FirstExecutionTime", Type = "datetime2", IsNullable = "YES")] 
		public DateTime? FirstExecutionTime => GetDbValue<DateTime?>(ShowInstancenSituationView.FirstExecutionTimeCol);
	
		///	<summary>[<c>CentralServiceDb</c>].[<c>ShowInstancenSituation</c>].[<c>LastExecutionTime</c>] (Type = <c>datetime2</c>, <c>NULLABLE</c>) (#TypeDescription#)</summary>
		[CsDbDataColumn(IsNullable = true)][CsDbNativeDataColumn(Table = "ShowInstancenSituation", Name = "LastExecutionTime", Type = "datetime2", IsNullable = "YES")] 
		public DateTime? LastExecutionTime => GetDbValue<DateTime?>(ShowInstancenSituationView.LastExecutionTimeCol);
	
		///	<summary>[<c>CentralServiceDb</c>].[<c>ShowInstancenSituation</c>].[<c>Unsigned_StartupCount</c>] (Type = <c>int</c>, <c>NULLABLE</c>) (#TypeDescription#)</summary>
		[CsDbDataColumn(IsNullable = true)][CsDbNativeDataColumn(Table = "ShowInstancenSituation", Name = "Unsigned_StartupCount", Type = "int", IsNullable = "YES")] 
		public Int32? UnsignedStartupCount => GetDbValue<Int32?>(ShowInstancenSituationView.UnsignedStartupCountCol);
	
		///	<summary>[<c>CentralServiceDb</c>].[<c>ShowInstancenSituation</c>].[<c>Ticks_UseageTime</c>] (Type = <c>bigint</c>, <c>NULLABLE</c>) (#TypeDescription#)</summary>
		[CsDbDataColumn(IsNullable = true)][CsDbNativeDataColumn(Table = "ShowInstancenSituation", Name = "Ticks_UseageTime", Type = "bigint", IsNullable = "YES")] 
		public Int64? TicksUseageTime => GetDbValue<Int64?>(ShowInstancenSituationView.TicksUseageTimeCol);
	
		///	<summary>[<c>CentralServiceDb</c>].[<c>ShowInstancenSituation</c>].[<c>Version</c>] (Type = <c>nvarchar</c>, <c>NULLABLE</c>, MaxLength = <c>-1</c>) (#TypeDescription#)</summary>
		[CsDbDataColumn(IsNullable = true)][CsDbNativeDataColumn(Table = "ShowInstancenSituation", Name = "Version", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES")] 
		public String Version => GetDbValue<String>(ShowInstancenSituationView.VersionCol);
	
		///	<summary>[<c>CentralServiceDb</c>].[<c>ShowInstancenSituation</c>].[<c>Created</c>] (Type = <c>datetime2</c>) (#TypeDescription#)</summary>
		[CsDbDataColumn][CsDbNativeDataColumn(Table = "ShowInstancenSituation", Name = "Created", Type = "datetime2", IsNullable = "NO")] 
		public DateTime Created => GetDbValue<DateTime>(ShowInstancenSituationView.CreatedCol);
	
		///	<summary>[<c>CentralServiceDb</c>].[<c>ShowInstancenSituation</c>].[<c>LastSeen</c>] (Type = <c>datetime2</c>) (#TypeDescription#)</summary>
		[CsDbDataColumn][CsDbNativeDataColumn(Table = "ShowInstancenSituation", Name = "LastSeen", Type = "datetime2", IsNullable = "NO")] 
		public DateTime LastSeen => GetDbValue<DateTime>(ShowInstancenSituationView.LastSeenCol);
	
		///	<summary>[<c>CentralServiceDb</c>].[<c>ShowInstancenSituation</c>].[<c>RemoteUserId</c>] (Type = <c>uniqueidentifier</c>) (#TypeDescription#)</summary>
		[CsDbDataColumn][CsDbNativeDataColumn(Table = "ShowInstancenSituation", Name = "RemoteUserId", Type = "uniqueidentifier", IsNullable = "NO")] 
		public Guid RemoteUserId => GetDbValue<Guid>(ShowInstancenSituationView.RemoteUserIdCol);
	
		///	<summary>[<c>CentralServiceDb</c>].[<c>ShowInstancenSituation</c>].[<c>RemoteApplicationId</c>] (Type = <c>uniqueidentifier</c>) (#TypeDescription#)</summary>
		[CsDbDataColumn][CsDbNativeDataColumn(Table = "ShowInstancenSituation", Name = "RemoteApplicationId", Type = "uniqueidentifier", IsNullable = "NO")] 
		public Guid RemoteApplicationId => GetDbValue<Guid>(ShowInstancenSituationView.RemoteApplicationIdCol);
	
		///	<summary>[<c>CentralServiceDb</c>].[<c>ShowInstancenSituation</c>].[<c>RemoteApplicxationId</c>] (Type = <c>uniqueidentifier</c>) (#TypeDescription#)</summary>
		[CsDbDataColumn][CsDbNativeDataColumn(Table = "ShowInstancenSituation", Name = "RemoteApplicxationId", Type = "uniqueidentifier", IsNullable = "NO")] 
		public Guid RemoteApplicxationId => GetDbValue<Guid>(ShowInstancenSituationView.RemoteApplicxationIdCol);
	
		///	<summary>[<c>CentralServiceDb</c>].[<c>ShowInstancenSituation</c>].[<c>Product</c>] (Type = <c>nvarchar</c>, <c>NULLABLE</c>, MaxLength = <c>-1</c>) (#TypeDescription#)</summary>
		[CsDbDataColumn(IsNullable = true)][CsDbNativeDataColumn(Table = "ShowInstancenSituation", Name = "Product", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES")] 
		public String Product => GetDbValue<String>(ShowInstancenSituationView.ProductCol);
	
		///	<summary>[<c>CentralServiceDb</c>].[<c>ShowInstancenSituation</c>].[<c>ProductTitle</c>] (Type = <c>nvarchar</c>, <c>NULLABLE</c>, MaxLength = <c>-1</c>) (#TypeDescription#)</summary>
		[CsDbDataColumn(IsNullable = true)][CsDbNativeDataColumn(Table = "ShowInstancenSituation", Name = "ProductTitle", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES")] 
		public String ProductTitle => GetDbValue<String>(ShowInstancenSituationView.ProductTitleCol);
	
		///	<summary>[<c>CentralServiceDb</c>].[<c>ShowInstancenSituation</c>].[<c>RemteApplicationName</c>] (Type = <c>nvarchar</c>, <c>NULLABLE</c>, MaxLength = <c>-1</c>) (#TypeDescription#)</summary>
		[CsDbDataColumn(IsNullable = true)][CsDbNativeDataColumn(Table = "ShowInstancenSituation", Name = "RemteApplicationName", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES")] 
		public String RemteApplicationName => GetDbValue<String>(ShowInstancenSituationView.RemteApplicationNameCol);
		
		///<summary>#DefaultDescription# <para/> => Converts signed to unsigned version. Use this to get the unsigned value from property <see cref="UnsignedStartupCount"/>.</summary>
		[DependsOn("UnsignedStartupCount")]public UInt32? StartupCount => (UInt32?) UnsignedStartupCount; 
		
		#endregion
	}
}