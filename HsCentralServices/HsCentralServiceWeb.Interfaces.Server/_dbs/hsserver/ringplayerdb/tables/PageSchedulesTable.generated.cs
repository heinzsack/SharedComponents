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
//<date>2016-10-11 19:18:26</date>



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
using HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.dataset;
using PageSchedule=HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.rows.PageSchedule;
using IPageSchedule=HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.rowinterfaces.IPageSchedule;
using HsCentralServiceWebInterfacesServer._dbs.hsserver;






namespace HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.tables
{
	#pragma warning disable 657
	#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	
	///	<summary>
	///		'[<c>HsServer</c>].[<c>#RingPlayerDb#</c>].[<c>PageSchedules</c>]': A Table inside '[<c>HsServer</c>].[<c>#RingPlayerDb#</c>]' database with '<see cref="PageSchedule"/>' as <see cref="DataRow"/>.<para/>
	///		[<c>PageSchedules</c>].[<c>PageId</c>] &#62;&#62;&#62;&#62; [<c>Pages</c>].[<c>Id</c>]<para/>
	///		[<c>PageSchedules</c>].[<c>RingMetaDataId</c>] &#62;&#62;&#62;&#62; [<c>RingMetaDatas</c>].[<c>Id</c>]
	///	</summary>
	[Serializable]
	
	[DebuggerDisplay("DataTable(RingPlayerDb.PageSchedules): Rows[{Rows.Count}]")]
	[CsDbDataTable(Database = "RingPlayerDb", Name = "PageSchedules", Generated = "16.10.11 19:18:26", Hash = "E996C7F0F3D0BC223A5AF1417A6D7769")]
	[CsDbResolvesRelation("FK_ScheduledPages_Pages", PkTable = "Pages", PkColumn = "Id", FkTable = "PageSchedules", FkColumn = "PageId")]
	[CsDbResolvesRelation("FK_PageSchedules_RingMetaDatas", PkTable = "RingMetaDatas", PkColumn = "Id", FkTable = "PageSchedules", FkColumn = "RingMetaDataId")]
	public partial class PageSchedulesTable : CsDbTable<PageSchedule>
	{
		#region CONSTANTS
		///<summary>The native table name (PageSchedules).</summary>
		public const string NativeName = "PageSchedules";
		///<summary>Holds native column name of <c>[RingPlayerDb].[PageSchedules].[Id]</c> column. Property = <see cref="PageSchedule.Id"/>.</summary>
		public const string IdCol = "Id";
		///<summary>Holds native column name of <c>[RingPlayerDb].[PageSchedules].[DiagnosticText]</c> column. Property = <see cref="PageSchedule.DiagnosticText"/>.</summary>
		public const string DiagnosticTextCol = "DiagnosticText";
		///<summary>Holds native column name of <c>[RingPlayerDb].[PageSchedules].[RingMetaDataId]</c> column. Property = <see cref="PageSchedule.RingMetaDataId"/>.</summary>
		public const string RingMetaDataIdCol = "RingMetaDataId";
		///<summary>Holds native column name of <c>[RingPlayerDb].[PageSchedules].[PageId]</c> column. Property = <see cref="PageSchedule.PageId"/>.</summary>
		public const string PageIdCol = "PageId";
		///<summary>Holds native column name of <c>[RingPlayerDb].[PageSchedules].[PageGroupScheduleId]</c> column. Property = <see cref="PageSchedule.PageGroupScheduleId"/>.</summary>
		public const string PageGroupScheduleIdCol = "PageGroupScheduleId";
		///<summary>Holds native column name of <c>[RingPlayerDb].[PageSchedules].[SlotId]</c> column. Property = <see cref="PageSchedule.SlotId"/>.</summary>
		public const string SlotIdCol = "SlotId";
		///<summary>Holds native column name of <c>[RingPlayerDb].[PageSchedules].[StartTime]</c> column. Property = <see cref="PageSchedule.StartTime"/>.</summary>
		public const string StartTimeCol = "StartTime";
	
		/// <summary> Contains attribute values for the columns</summary>
		public static class Cols
		{
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>PageSchedules</c>].[<c>Id</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "PageSchedules", Name = "Id", Type = "uniqueidentifier", Default = "(newid())", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute Id = new CsDbNativeDataColumnAttribute {Table = "PageSchedules", Name = "Id", Type = "uniqueidentifier", Default = "(newid())", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>PageSchedules</c>].[<c>DiagnosticText</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "PageSchedules", Name = "DiagnosticText", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute DiagnosticText = new CsDbNativeDataColumnAttribute {Table = "PageSchedules", Name = "DiagnosticText", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>PageSchedules</c>].[<c>RingMetaDataId</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "PageSchedules", Name = "RingMetaDataId", Type = "int", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute RingMetaDataId = new CsDbNativeDataColumnAttribute {Table = "PageSchedules", Name = "RingMetaDataId", Type = "int", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>PageSchedules</c>].[<c>PageId</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "PageSchedules", Name = "PageId", Type = "uniqueidentifier", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute PageId = new CsDbNativeDataColumnAttribute {Table = "PageSchedules", Name = "PageId", Type = "uniqueidentifier", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>PageSchedules</c>].[<c>PageGroupScheduleId</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "PageSchedules", Name = "PageGroupScheduleId", Type = "uniqueidentifier", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute PageGroupScheduleId = new CsDbNativeDataColumnAttribute {Table = "PageSchedules", Name = "PageGroupScheduleId", Type = "uniqueidentifier", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>PageSchedules</c>].[<c>SlotId</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "PageSchedules", Name = "SlotId", Type = "uniqueidentifier", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute SlotId = new CsDbNativeDataColumnAttribute {Table = "PageSchedules", Name = "SlotId", Type = "uniqueidentifier", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>PageSchedules</c>].[<c>StartTime</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "PageSchedules", Name = "StartTime", Type = "datetime2", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute StartTime = new CsDbNativeDataColumnAttribute {Table = "PageSchedules", Name = "StartTime", Type = "datetime2", IsNullable = "NO"};
		}
		#endregion
	
	
	
	
	
	
	
		///<summary>Default constructor for save <see cref="DataTable"/> operations</summary>
		public PageSchedulesTable()
		{
			TableName = NativeName;
		}
	
		///<summary>References the owning data context, this is equal to the database server. Use this to address databases on the same server.</summary>
		public new HsCentralServiceWebInterfacesServer._dbs.hsserver.HsServerContext DataContext => DataSet.DataContext;
	
		///<summary>References the owning dataset. Use this to address tables in the same database</summary>
		public new RingPlayerDb DataSet => (RingPlayerDb) base.DataSet;
	
	
	
	
	
	
	
		#region FUNC<Overrides>
		
		///	<summary><c>SELECT (DefaultSqlSelector) FROM [PageSchedules]</c><para>The default selector is the * operator</para></summary>
		public override void DownloadRows()
		{
			DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}]", false);
			HasBeenLoaded = true;
		}
		///	<summary><c>SELECT <paramref name="top"/> (DefaultSqlSelector) FROM [PageSchedules]</c><para>The default selector is the * operator</para></summary>
		public override void DownloadRows(int top)
		{
			DownloadRows($"SELECT TOP {top} {DefaultSqlSelector} FROM [{NativeName}]", false);
		}
		
		
		///<summary>This method calls <see cref="FindOrLoad"/>.</summary>
		public override CsDbRowBase Generic_FindOrLoad(object id)
		{
			return id==null ? null : FindOrLoad((Guid?) id);
		}
		///<summary>This method calls <see cref="LoadThenFind"/>.</summary>
		public override CsDbRowBase Generic_LoadThenFind(object id)
		{
			return id==null ? null : LoadThenFind((Guid?) id);
		}
		///<summary>This method calls <see cref="Find"/>.</summary>
		public override CsDbRowBase Generic_Find(object id)
		{
			return id==null ? null : Find((Guid?) id);
		}
		
		
		
		///<summary>This method calls <see cref="FindOrLoad"/>.</summary>
		public override CsDbRowBase[] Generic_FindOrLoad(params object[] ids)
		{
			return FindOrLoad_Each(ids.OfType<Guid>().ToArray()).OfType<CsDbRowBase>().ToArray();
		}
		///<summary>This method calls <see cref="LoadThenFind"/>.</summary>
		public override CsDbRowBase[] Generic_LoadThenFind(params object[] ids)
		{
			return LoadThenFind_Each(ids.OfType<Guid>().ToArray()).OfType<CsDbRowBase>().ToArray();
		}
		///<summary>This method calls <see cref="Find"/>.</summary>
		public override CsDbRowBase[] Generic_Find(params object[] ids)
		{
			return Find_Each(ids.OfType<Guid>().ToArray()).OfType<CsDbRowBase>().ToArray();
		}
		#endregion
		
		
		
		
		#region FUNC<Primary Key>
		
		///	<summary>
		///		find an item in local data where Id = '<paramref name="id"/>'. If nothing is found QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [PageSchedules] WHERE [Id] = '<paramref name="id"/>'</c>.<para/>
		///		If no primary key is set execute <see cref="LoadThenFind"/> instead.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK_ScheduledPages_Pages", PkTable = "Pages", PkColumn = "Id", FkTable = "PageSchedules", FkColumn = "PageId")]
		[CsDbResolvesRelation("FK_PageSchedules_RingMetaDatas", PkTable = "RingMetaDatas", PkColumn = "Id", FkTable = "PageSchedules", FkColumn = "RingMetaDataId")]
		public PageSchedule FindOrLoad(Guid? id)
		{
			if (id == null)
				return null;
		
			if (PrimaryKey.Length == 0)
				return LoadThenFind(id);
		
			return Find(id) ?? LoadThenFind(id);
		}
		
		
		///<summary>
		///		QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [PageSchedules] WHERE [Id] = '<paramref name="id"/>'</c> THEN find an item in local data where Id = '<paramref name="id"/>'.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///</summary>
		[CsDbResolvesRelation("FK_ScheduledPages_Pages", PkTable = "Pages", PkColumn = "Id", FkTable = "PageSchedules", FkColumn = "PageId")]
		[CsDbResolvesRelation("FK_PageSchedules_RingMetaDatas", PkTable = "RingMetaDatas", PkColumn = "Id", FkTable = "PageSchedules", FkColumn = "RingMetaDataId")]
		public PageSchedule LoadThenFind(Guid? id)
		{
			if (id == null)
				return null;
		
			DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}] WHERE [Id] = '{id}'", false);
			
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
		
			return Rows.Find(id.Value) as PageSchedule;
		}
		
		
		///	<summary>
		///		find an item in local data where Id = '<paramref name="id"/>'. IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK_ScheduledPages_Pages", PkTable = "Pages", PkColumn = "Id", FkTable = "PageSchedules", FkColumn = "PageId")]
		[CsDbResolvesRelation("FK_PageSchedules_RingMetaDatas", PkTable = "RingMetaDatas", PkColumn = "Id", FkTable = "PageSchedules", FkColumn = "RingMetaDataId")]
		public PageSchedule Find(Guid? id)
		{
			if (id == null)
				return null;
		
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
		
			return Rows.Find(id.Value) as PageSchedule;
		}
		#endregion
		
		#region FUNC<Primary Key Many>
		///	<summary>
		///		find items in local data where Id IN '<paramref name="ids"/>'. If nothing is found QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [PageSchedules] WHERE [Id] IN '<paramref name="ids"/>'</c>.<para/>
		///		If no primary key is set execute <see cref="LoadThenFind_Each"/> instead.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK_ScheduledPages_Pages", PkTable = "Pages", PkColumn = "Id", FkTable = "PageSchedules", FkColumn = "PageId")]
		[CsDbResolvesRelation("FK_PageSchedules_RingMetaDatas", PkTable = "RingMetaDatas", PkColumn = "Id", FkTable = "PageSchedules", FkColumn = "RingMetaDataId")]
		public PageSchedule[] FindOrLoad_Each(params Guid[] ids)
		{
			if (ids == null || ids.Length == 0)
				return new PageSchedule[0];
		
			if (PrimaryKey.Length == 0)
				return LoadThenFind_Each(ids);
				
			var locallyFound = Find_Each(ids);
			var loaded = LoadThenFind_Each(ids.Except(locallyFound.Select(x=>x.Id)).ToArray());
			return locallyFound.Union(loaded).ToArray();
		}
		
		
		///<summary>
		///		QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [PageSchedules] WHERE [Id] IN '<paramref name="ids"/>'</c> THEN find items in local data where Id IN '<paramref name="ids"/>'.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///</summary>
		[CsDbResolvesRelation("FK_ScheduledPages_Pages", PkTable = "Pages", PkColumn = "Id", FkTable = "PageSchedules", FkColumn = "PageId")]
		[CsDbResolvesRelation("FK_PageSchedules_RingMetaDatas", PkTable = "RingMetaDatas", PkColumn = "Id", FkTable = "PageSchedules", FkColumn = "RingMetaDataId")]
		public PageSchedule[] LoadThenFind_Each(params Guid[] ids)
		{
			if (ids == null || ids.Length == 0)
				return new PageSchedule[0];
		
			DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}] WHERE [Id] IN ('{ids.Select(x=>x.ToString()).Join("', '")}')", false);
			
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
		
			return Find_Each(ids);
		}
		
		
		///	<summary>
		///		find items in local data where Id IN '<paramref name="ids"/>'. IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK_ScheduledPages_Pages", PkTable = "Pages", PkColumn = "Id", FkTable = "PageSchedules", FkColumn = "PageId")]
		[CsDbResolvesRelation("FK_PageSchedules_RingMetaDatas", PkTable = "RingMetaDatas", PkColumn = "Id", FkTable = "PageSchedules", FkColumn = "RingMetaDataId")]
		public PageSchedule[] Find_Each(params Guid[] ids)
		{
			if (ids == null || ids.Length == 0)
				return new PageSchedule[0];
		
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
				
			return Select(ids.Select(key=>$"{IdCol} = '{key}'").Join(" OR "));
		}
		#endregion
		
		
		
		
		
		#region FUNC<Foreign Key>
		[field:NonSerialized] private Dictionary<Guid?, CsWeakReference<ContractCollection<PageSchedule>>> _byPageId = new Dictionary<Guid?, CsWeakReference<ContractCollection<PageSchedule>>>();
		
		///	<summary> 
		///		Query <c>SELECT (DefaultSqlSelector) FROM PageSchedules WHERE [PageId] = '<paramref name="pageId"/>'</c><para/>
		///		[<c>PageSchedules</c>].[<c>PageId</c>] &#62;&#62;&#62;&#62; [<c>Pages</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK_ScheduledPages_Pages", PkTable = "Pages", PkColumn = "Id", FkTable = "PageSchedules", FkColumn = "PageId")]
		public ContractCollection<PageSchedule> FindOrLoad_By_PageId(Guid? pageId)
		{
			if (pageId == null)
				return null;
			CsWeakReference<ContractCollection<PageSchedule>> weak;
			ContractCollection<PageSchedule> result;
		
			if (_byPageId.TryGetValue(pageId, out weak) && weak.TryGetTarget(out result))
				return result;
		
			if (HasBeenLoaded == true || weak != null)
				result = CreateContractCollection(@pageSchedule => Equals(@pageSchedule.PageId, pageId));
			else 
			{
				DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}] WHERE [{PageIdCol}] = '{pageId}'", false);
				result = CreateContractCollection(@pageSchedule => Equals(@pageSchedule.PageId, pageId));
			}
		
			if (weak == null)
				_byPageId.Add(pageId, weak = new CsWeakReference<ContractCollection<PageSchedule>>(result));
			else
				weak.SetTarget(result);
		
			return result;
		}
		///	<summary> 
		///		Query <c>SELECT (DefaultSqlSelector) FROM PageSchedules WHERE [PageId] = '<paramref name="pageId"/>'</c><para/>
		///		[<c>PageSchedules</c>].[<c>PageId</c>] &#62;&#62;&#62;&#62; [<c>Pages</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK_ScheduledPages_Pages", PkTable = "Pages", PkColumn = "Id", FkTable = "PageSchedules", FkColumn = "PageId")]
		public ContractCollection<PageSchedule> LoadThenFind_By_PageId(Guid? pageId)
		{
			if (pageId == null)
				return null;
			CsWeakReference<ContractCollection<PageSchedule>> weak;
			ContractCollection<PageSchedule> result;
		
			DownloadRows($"SELECT {DefaultSqlSelector} FROM {NativeName} WHERE [{PageIdCol}] = '{pageId}'", false);
		
			if (_byPageId.TryGetValue(pageId, out weak) && weak.TryGetTarget(out result))
				return result;
		
			result = CreateContractCollection(@pageSchedule => Equals(@pageSchedule.PageId, pageId));
		
			if (weak == null)
				_byPageId.Add(pageId, weak = new CsWeakReference<ContractCollection<PageSchedule>>(result));
			else
				weak.SetTarget(result);
		
			return result;
		}
		///	<summary> 
		///		Query <c>SELECT (DefaultSqlSelector) FROM PageSchedules WHERE [PageId] = '<paramref name="pageId"/>'</c><para/>
		///		[<c>PageSchedules</c>].[<c>PageId</c>] &#62;&#62;&#62;&#62; [<c>Pages</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK_ScheduledPages_Pages", PkTable = "Pages", PkColumn = "Id", FkTable = "PageSchedules", FkColumn = "PageId")]
		public ContractCollection<PageSchedule> Find_By_PageId(Guid? pageId)
		{
			if (pageId == null)
				return null;
			CsWeakReference<ContractCollection<PageSchedule>> weak;
			ContractCollection<PageSchedule> result;
		
			if (_byPageId.TryGetValue(pageId, out weak) && weak.TryGetTarget(out result))
				return result;
		
		
			result = CreateContractCollection(@pageSchedule => Equals(@pageSchedule.PageId, pageId));
		
		    if (weak == null)
				_byPageId.Add(pageId, weak = new CsWeakReference<ContractCollection<PageSchedule>>(result));
			else
				weak.SetTarget(result);
		
			return result;
		}
		[field:NonSerialized] private Dictionary<Int32?, CsWeakReference<ContractCollection<PageSchedule>>> _byRingMetaDataId = new Dictionary<Int32?, CsWeakReference<ContractCollection<PageSchedule>>>();
		
		///	<summary> 
		///		Query <c>SELECT (DefaultSqlSelector) FROM PageSchedules WHERE [RingMetaDataId] = '<paramref name="ringMetaDataId"/>'</c><para/>
		///		[<c>PageSchedules</c>].[<c>RingMetaDataId</c>] &#62;&#62;&#62;&#62; [<c>RingMetaDatas</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK_PageSchedules_RingMetaDatas", PkTable = "RingMetaDatas", PkColumn = "Id", FkTable = "PageSchedules", FkColumn = "RingMetaDataId")]
		public ContractCollection<PageSchedule> FindOrLoad_By_RingMetaDataId(Int32? ringMetaDataId)
		{
			if (ringMetaDataId == null)
				return null;
			CsWeakReference<ContractCollection<PageSchedule>> weak;
			ContractCollection<PageSchedule> result;
		
			if (_byRingMetaDataId.TryGetValue(ringMetaDataId, out weak) && weak.TryGetTarget(out result))
				return result;
		
			if (HasBeenLoaded == true || weak != null)
				result = CreateContractCollection(@pageSchedule => Equals(@pageSchedule.RingMetaDataId, ringMetaDataId));
			else 
			{
				DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}] WHERE [{RingMetaDataIdCol}] = '{ringMetaDataId}'", false);
				result = CreateContractCollection(@pageSchedule => Equals(@pageSchedule.RingMetaDataId, ringMetaDataId));
			}
		
			if (weak == null)
				_byRingMetaDataId.Add(ringMetaDataId, weak = new CsWeakReference<ContractCollection<PageSchedule>>(result));
			else
				weak.SetTarget(result);
		
			return result;
		}
		///	<summary> 
		///		Query <c>SELECT (DefaultSqlSelector) FROM PageSchedules WHERE [RingMetaDataId] = '<paramref name="ringMetaDataId"/>'</c><para/>
		///		[<c>PageSchedules</c>].[<c>RingMetaDataId</c>] &#62;&#62;&#62;&#62; [<c>RingMetaDatas</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK_PageSchedules_RingMetaDatas", PkTable = "RingMetaDatas", PkColumn = "Id", FkTable = "PageSchedules", FkColumn = "RingMetaDataId")]
		public ContractCollection<PageSchedule> LoadThenFind_By_RingMetaDataId(Int32? ringMetaDataId)
		{
			if (ringMetaDataId == null)
				return null;
			CsWeakReference<ContractCollection<PageSchedule>> weak;
			ContractCollection<PageSchedule> result;
		
			DownloadRows($"SELECT {DefaultSqlSelector} FROM {NativeName} WHERE [{RingMetaDataIdCol}] = '{ringMetaDataId}'", false);
		
			if (_byRingMetaDataId.TryGetValue(ringMetaDataId, out weak) && weak.TryGetTarget(out result))
				return result;
		
			result = CreateContractCollection(@pageSchedule => Equals(@pageSchedule.RingMetaDataId, ringMetaDataId));
		
			if (weak == null)
				_byRingMetaDataId.Add(ringMetaDataId, weak = new CsWeakReference<ContractCollection<PageSchedule>>(result));
			else
				weak.SetTarget(result);
		
			return result;
		}
		///	<summary> 
		///		Query <c>SELECT (DefaultSqlSelector) FROM PageSchedules WHERE [RingMetaDataId] = '<paramref name="ringMetaDataId"/>'</c><para/>
		///		[<c>PageSchedules</c>].[<c>RingMetaDataId</c>] &#62;&#62;&#62;&#62; [<c>RingMetaDatas</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK_PageSchedules_RingMetaDatas", PkTable = "RingMetaDatas", PkColumn = "Id", FkTable = "PageSchedules", FkColumn = "RingMetaDataId")]
		public ContractCollection<PageSchedule> Find_By_RingMetaDataId(Int32? ringMetaDataId)
		{
			if (ringMetaDataId == null)
				return null;
			CsWeakReference<ContractCollection<PageSchedule>> weak;
			ContractCollection<PageSchedule> result;
		
			if (_byRingMetaDataId.TryGetValue(ringMetaDataId, out weak) && weak.TryGetTarget(out result))
				return result;
		
		
			result = CreateContractCollection(@pageSchedule => Equals(@pageSchedule.RingMetaDataId, ringMetaDataId));
		
		    if (weak == null)
				_byRingMetaDataId.Add(ringMetaDataId, weak = new CsWeakReference<ContractCollection<PageSchedule>>(result));
			else
				weak.SetTarget(result);
		
			return result;
		}
		#endregion
		
		
		/// <summary>Creates a row then copy's the data from the <paramref name="item"/> and adds it to the row collection.</summary>
		public PageSchedule AddAsNewRow(IPageSchedule item)
		{
			var row = NewRow();
			row.Copy_From(item, true);
			Add(row);
			return row;
		}
	}
}