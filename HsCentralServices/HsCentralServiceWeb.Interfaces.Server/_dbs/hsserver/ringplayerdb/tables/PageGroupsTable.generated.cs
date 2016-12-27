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
//<date>2016-12-27 22:40:00</date>



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
using PageGroup=HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.rows.PageGroup;
using IPageGroup=HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.rowinterfaces.IPageGroup;
using HsCentralServiceWebInterfacesServer._dbs.hsserver;






namespace HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.tables
{
	#pragma warning disable 657
	#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	
	///	<summary>
	///		'[<c>HsServer</c>].[<c>#RingPlayerDb#</c>].[<c>PageGroups</c>]': A Table inside '[<c>HsServer</c>].[<c>#RingPlayerDb#</c>]' database with '<see cref="PageGroup"/>' as <see cref="DataRow"/>.<para/>
	///		[<c>PageGroups</c>].[<c>Id</c>] &#60;&#60;&#60;&#60; [<c>LastGeneratedBalancerStates</c>].[<c>PageGroupId</c>]<para/>
	///		[<c>PageGroups</c>].[<c>Id</c>] &#60;&#60;&#60;&#60; [<c>Pages</c>].[<c>PageGroupId</c>]
	///	</summary>
	[Serializable]
	[DebuggerStepThrough]
	[DebuggerDisplay("DataTable(RingPlayerDb.PageGroups): Rows[{Rows.Count}]")]
	[CsDbDataTable(Database = "RingPlayerDb", Name = "PageGroups", Generated = "16.12.27 22:40:00", Hash = "583D0F64ABE514A9B8953A4C1B77D9DA")]
	[CsDbResolvesRelation("FK_LastGeneratedBalancerStates_PageGroups", PkTable = "PageGroups", PkColumn = "Id", FkTable = "LastGeneratedBalancerStates", FkColumn = "PageGroupId")]
	[CsDbResolvesRelation("FK_Pages_PageGroups", PkTable = "PageGroups", PkColumn = "Id", FkTable = "Pages", FkColumn = "PageGroupId")]
	public partial class PageGroupsTable : CsDbTable<PageGroup>
	{
		#region CONSTANTS
		///<summary>The native table name (PageGroups).</summary>
		public const string NativeName = "PageGroups";
		///<summary>Holds native column name of <c>[RingPlayerDb].[PageGroups].[Id]</c> column. Property = <see cref="PageGroup.Id"/>.</summary>
		public const string IdCol = "Id";
		///<summary>Holds native column name of <c>[RingPlayerDb].[PageGroups].[Name]</c> column. Property = <see cref="PageGroup.Name"/>.</summary>
		public const string NameCol = "Name";
	
		/// <summary> Contains attribute values for the columns</summary>
		public static class Cols
		{
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>PageGroups</c>].[<c>Id</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "PageGroups", Name = "Id", Type = "uniqueidentifier", Default = "(newid())", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute Id = new CsDbNativeDataColumnAttribute {Table = "PageGroups", Name = "Id", Type = "uniqueidentifier", Default = "(newid())", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>PageGroups</c>].[<c>Name</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "PageGroups", Name = "Name", Type = "nvarchar", MaxLength = "255", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute Name = new CsDbNativeDataColumnAttribute {Table = "PageGroups", Name = "Name", Type = "nvarchar", MaxLength = "255", IsNullable = "YES"};
		}
		#endregion
	
	
	
	
	
	
	
		///<summary>Default constructor for save <see cref="DataTable"/> operations</summary>
		public PageGroupsTable()
		{
			TableName = NativeName;
		}
	
		///<summary>References the owning data context, this is equal to the database server. Use this to address databases on the same server.</summary>
		public new HsCentralServiceWebInterfacesServer._dbs.hsserver.HsServerContext DataContext => DataSet.DataContext;
	
		///<summary>References the owning dataset. Use this to address tables in the same database</summary>
		public new RingPlayerDb DataSet => (RingPlayerDb) base.DataSet;
	
	
	
	
	
	
	
		#region FUNC<Overrides>
		
		///	<summary><c>SELECT (DefaultSqlSelector) FROM [PageGroups]</c><para>The default selector is the * operator</para></summary>
		public override void DownloadRows()
		{
			DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}]", false);
			HasBeenLoaded = true;
		}
		///	<summary><c>SELECT <paramref name="top"/> (DefaultSqlSelector) FROM [PageGroups]</c><para>The default selector is the * operator</para></summary>
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
		///		find an item in local data where Id = '<paramref name="id"/>'. If nothing is found QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [PageGroups] WHERE [Id] = '<paramref name="id"/>'</c>.<para/>
		///		If no primary key is set execute <see cref="LoadThenFind"/> instead.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK_LastGeneratedBalancerStates_PageGroups", PkTable = "PageGroups", PkColumn = "Id", FkTable = "LastGeneratedBalancerStates", FkColumn = "PageGroupId")]
		[CsDbResolvesRelation("FK_Pages_PageGroups", PkTable = "PageGroups", PkColumn = "Id", FkTable = "Pages", FkColumn = "PageGroupId")]
		public PageGroup FindOrLoad(Guid? id)
		{
			if (id == null)
				return null;
		
			if (PrimaryKey.Length == 0)
				return LoadThenFind(id);
		
			return Find(id) ?? LoadThenFind(id);
		}
		
		
		///<summary>
		///		QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [PageGroups] WHERE [Id] = '<paramref name="id"/>'</c> THEN find an item in local data where Id = '<paramref name="id"/>'.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///</summary>
		[CsDbResolvesRelation("FK_LastGeneratedBalancerStates_PageGroups", PkTable = "PageGroups", PkColumn = "Id", FkTable = "LastGeneratedBalancerStates", FkColumn = "PageGroupId")]
		[CsDbResolvesRelation("FK_Pages_PageGroups", PkTable = "PageGroups", PkColumn = "Id", FkTable = "Pages", FkColumn = "PageGroupId")]
		public PageGroup LoadThenFind(Guid? id)
		{
			if (id == null)
				return null;
		
			DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}] WHERE [Id] = '{id}'", false);
			
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
		
			return Rows.Find(id.Value) as PageGroup;
		}
		
		
		///	<summary>
		///		find an item in local data where Id = '<paramref name="id"/>'. IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK_LastGeneratedBalancerStates_PageGroups", PkTable = "PageGroups", PkColumn = "Id", FkTable = "LastGeneratedBalancerStates", FkColumn = "PageGroupId")]
		[CsDbResolvesRelation("FK_Pages_PageGroups", PkTable = "PageGroups", PkColumn = "Id", FkTable = "Pages", FkColumn = "PageGroupId")]
		public PageGroup Find(Guid? id)
		{
			if (id == null)
				return null;
		
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
		
			return Rows.Find(id.Value) as PageGroup;
		}
		#endregion
		
		#region FUNC<Primary Key Many>
		///	<summary>
		///		find items in local data where Id IN '<paramref name="ids"/>'. If nothing is found QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [PageGroups] WHERE [Id] IN '<paramref name="ids"/>'</c>.<para/>
		///		If no primary key is set execute <see cref="LoadThenFind_Each"/> instead.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK_LastGeneratedBalancerStates_PageGroups", PkTable = "PageGroups", PkColumn = "Id", FkTable = "LastGeneratedBalancerStates", FkColumn = "PageGroupId")]
		[CsDbResolvesRelation("FK_Pages_PageGroups", PkTable = "PageGroups", PkColumn = "Id", FkTable = "Pages", FkColumn = "PageGroupId")]
		public PageGroup[] FindOrLoad_Each(params Guid[] ids)
		{
			if (ids == null || ids.Length == 0)
				return new PageGroup[0];
		
			if (PrimaryKey.Length == 0)
				return LoadThenFind_Each(ids);
				
			var locallyFound = Find_Each(ids);
			var loaded = LoadThenFind_Each(ids.Except(locallyFound.Select(x=>x.Id)).ToArray());
			return locallyFound.Union(loaded).ToArray();
		}
		
		
		///<summary>
		///		QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [PageGroups] WHERE [Id] IN '<paramref name="ids"/>'</c> THEN find items in local data where Id IN '<paramref name="ids"/>'.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///</summary>
		[CsDbResolvesRelation("FK_LastGeneratedBalancerStates_PageGroups", PkTable = "PageGroups", PkColumn = "Id", FkTable = "LastGeneratedBalancerStates", FkColumn = "PageGroupId")]
		[CsDbResolvesRelation("FK_Pages_PageGroups", PkTable = "PageGroups", PkColumn = "Id", FkTable = "Pages", FkColumn = "PageGroupId")]
		public PageGroup[] LoadThenFind_Each(params Guid[] ids)
		{
			if (ids == null || ids.Length == 0)
				return new PageGroup[0];
		
			DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}] WHERE [Id] IN ('{ids.Select(x=>x.ToString()).Join("', '")}')", false);
			
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
		
			return Find_Each(ids);
		}
		
		
		///	<summary>
		///		find items in local data where Id IN '<paramref name="ids"/>'. IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK_LastGeneratedBalancerStates_PageGroups", PkTable = "PageGroups", PkColumn = "Id", FkTable = "LastGeneratedBalancerStates", FkColumn = "PageGroupId")]
		[CsDbResolvesRelation("FK_Pages_PageGroups", PkTable = "PageGroups", PkColumn = "Id", FkTable = "Pages", FkColumn = "PageGroupId")]
		public PageGroup[] Find_Each(params Guid[] ids)
		{
			if (ids == null || ids.Length == 0)
				return new PageGroup[0];
		
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
				
			return Select(ids.Select(key=>$"{IdCol} = '{key}'").Join(" OR "));
		}
		#endregion
		
		
		
		
		
		#region FUNC<Foreign Key>
		
		#endregion
		
		
		/// <summary>Creates a row then copy's the data from the <paramref name="item"/> and adds it to the row collection.</summary>
		public PageGroup AddAsNewRow(IPageGroup item)
		{
			var row = NewRow();
			row.Copy_From(item, true);
			Add(row);
			return row;
		}
	}
}