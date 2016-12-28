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
using HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.dataset;
using Sysdiagram=HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.rows.Sysdiagram;
using ISysdiagram=HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.rowinterfaces.ISysdiagram;
using HsCentralServiceWebInterfacesServer._dbs.hsserver;






namespace HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.tables
{
	#pragma warning disable 657
	#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	
	///	<summary>
	///		'[<c>HsServer</c>].[<c>#RingPlayerDb#</c>].[<c>sysdiagrams</c>]': A Table inside '[<c>HsServer</c>].[<c>#RingPlayerDb#</c>]' database with '<see cref="Sysdiagram"/>' as <see cref="DataRow"/>.<para/>
	///		
	///	</summary>
	[Serializable]
	[DebuggerDisplay("DataTable(RingPlayerDb.sysdiagrams): Rows[{Rows.Count}]")]
	[CsDbDataTable(Database = "RingPlayerDb", Name = "sysdiagrams", Generated = "16.12.28 13:36:31", Hash = "F2A5BB95486DB08B66AFA111CE000A68")]
	
	public partial class SysdiagramsTable : CsDbTable<Sysdiagram>
	{
		#region CONSTANTS
		///<summary>The native table name (sysdiagrams).</summary>
		public const string NativeName = "sysdiagrams";
		///<summary>Holds native column name of <c>[RingPlayerDb].[sysdiagrams].[name]</c> column. Property = <see cref="Sysdiagram.Name"/>.</summary>
		public const string NameCol = "name";
		///<summary>Holds native column name of <c>[RingPlayerDb].[sysdiagrams].[principal_id]</c> column. Property = <see cref="Sysdiagram.PrincipalId"/>.</summary>
		public const string PrincipalIdCol = "principal_id";
		///<summary>Holds native column name of <c>[RingPlayerDb].[sysdiagrams].[diagram_id]</c> column. Property = <see cref="Sysdiagram.DiagramId"/>.</summary>
		public const string DiagramIdCol = "diagram_id";
		///<summary>Holds native column name of <c>[RingPlayerDb].[sysdiagrams].[version]</c> column. Property = <see cref="Sysdiagram.Version"/>.</summary>
		public const string VersionCol = "version";
		///<summary>Holds native column name of <c>[RingPlayerDb].[sysdiagrams].[definition]</c> column. Property = <see cref="Sysdiagram.Definition"/>.</summary>
		public const string DefinitionCol = "definition";
	
		/// <summary> Contains attribute values for the columns</summary>
		public static class Cols
		{
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>sysdiagrams</c>].[<c>name</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "sysdiagrams", Name = "name", Type = "nvarchar", MaxLength = "128", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute Name = new CsDbNativeDataColumnAttribute {Table = "sysdiagrams", Name = "name", Type = "nvarchar", MaxLength = "128", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>sysdiagrams</c>].[<c>principal_id</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "sysdiagrams", Name = "principal_id", Type = "int", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute PrincipalId = new CsDbNativeDataColumnAttribute {Table = "sysdiagrams", Name = "principal_id", Type = "int", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>sysdiagrams</c>].[<c>diagram_id</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "sysdiagrams", Name = "diagram_id", Type = "int", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute DiagramId = new CsDbNativeDataColumnAttribute {Table = "sysdiagrams", Name = "diagram_id", Type = "int", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>sysdiagrams</c>].[<c>version</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "sysdiagrams", Name = "version", Type = "int", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute Version = new CsDbNativeDataColumnAttribute {Table = "sysdiagrams", Name = "version", Type = "int", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>sysdiagrams</c>].[<c>definition</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "sysdiagrams", Name = "definition", Type = "varbinary", MaxLength = "-1", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute Definition = new CsDbNativeDataColumnAttribute {Table = "sysdiagrams", Name = "definition", Type = "varbinary", MaxLength = "-1", IsNullable = "YES"};
		}
		#endregion
	
	
	
	
	
	
	
		///<summary>Default constructor for save <see cref="DataTable"/> operations</summary>
		public SysdiagramsTable()
		{
			TableName = NativeName;
		}
	
		///<summary>References the owning data context, this is equal to the database server. Use this to address databases on the same server.</summary>
		public new HsCentralServiceWebInterfacesServer._dbs.hsserver.HsServerContext DataContext => DataSet.DataContext;
	
		///<summary>References the owning dataset. Use this to address tables in the same database</summary>
		public new RingPlayerDb DataSet => (RingPlayerDb) base.DataSet;
	
	
	
	
	
	
	
		#region FUNC<Overrides>
		
		///	<summary><c>SELECT (DefaultSqlSelector) FROM [sysdiagrams]</c><para>The default selector is the * operator</para></summary>
		[DebuggerStepThrough] 
		public override void DownloadRows()
		{
			DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}]", false);
			HasBeenLoaded = true;
		}
		///	<summary><c>SELECT <paramref name="top"/> (DefaultSqlSelector) FROM [sysdiagrams]</c><para>The default selector is the * operator</para></summary>
		[DebuggerStepThrough] 
		public override void DownloadRows(int top)
		{
			DownloadRows($"SELECT TOP {top} {DefaultSqlSelector} FROM [{NativeName}]", false);
		}
		
		
		///<summary>This method calls <see cref="FindOrLoad"/>.</summary>
		[DebuggerStepThrough] 
		public override CsDbRowBase Generic_FindOrLoad(object diagramId)
		{
			return diagramId==null ? null : FindOrLoad((Int32?) diagramId);
		}
		///<summary>This method calls <see cref="LoadThenFind"/>.</summary>
		[DebuggerStepThrough] 
		public override CsDbRowBase Generic_LoadThenFind(object diagramId)
		{
			return diagramId==null ? null : LoadThenFind((Int32?) diagramId);
		}
		///<summary>This method calls <see cref="Find"/>.</summary>
		[DebuggerStepThrough] 
		public override CsDbRowBase Generic_Find(object diagramId)
		{
			return diagramId==null ? null : Find((Int32?) diagramId);
		}
		
		
		
		///<summary>This method calls <see cref="FindOrLoad"/>.</summary>
		[DebuggerStepThrough] 
		public override CsDbRowBase[] Generic_FindOrLoad(params object[] diagramIds)
		{
			return FindOrLoad_Each(diagramIds.OfType<Int32>().ToArray()).OfType<CsDbRowBase>().ToArray();
		}
		///<summary>This method calls <see cref="LoadThenFind"/>.</summary>
		[DebuggerStepThrough] 
		public override CsDbRowBase[] Generic_LoadThenFind(params object[] diagramIds)
		{
			return LoadThenFind_Each(diagramIds.OfType<Int32>().ToArray()).OfType<CsDbRowBase>().ToArray();
		}
		///<summary>This method calls <see cref="Find"/>.</summary>
		[DebuggerStepThrough] 
		public override CsDbRowBase[] Generic_Find(params object[] diagramIds)
		{
			return Find_Each(diagramIds.OfType<Int32>().ToArray()).OfType<CsDbRowBase>().ToArray();
		}
		#endregion
		
		
		
		
		#region FUNC<Primary Key>
		
		///	<summary>
		///		find an item in local data where DiagramId = '<paramref name="diagramId"/>'. If nothing is found QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [sysdiagrams] WHERE [DiagramId] = '<paramref name="diagramId"/>'</c>.<para/>
		///		If no primary key is set execute <see cref="LoadThenFind"/> instead.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		
		[DebuggerStepThrough] 
		public Sysdiagram FindOrLoad(Int32? diagramId)
		{
			if (diagramId == null)
				return null;
		
			if (PrimaryKey.Length == 0)
				return LoadThenFind(diagramId);
		
			return Find(diagramId) ?? LoadThenFind(diagramId);
		}
		
		
		///<summary>
		///		QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [sysdiagrams] WHERE [DiagramId] = '<paramref name="diagramId"/>'</c> THEN find an item in local data where DiagramId = '<paramref name="diagramId"/>'.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///</summary>
		
		[DebuggerStepThrough] 
		public Sysdiagram LoadThenFind(Int32? diagramId)
		{
			if (diagramId == null)
				return null;
		
			DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}] WHERE [diagram_id] = '{diagramId}'", false);
			
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[DiagramIdCol] };
		
			return Rows.Find(diagramId.Value) as Sysdiagram;
		}
		
		
		///	<summary>
		///		find an item in local data where DiagramId = '<paramref name="diagramId"/>'. IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		
		[DebuggerStepThrough] 
		public Sysdiagram Find(Int32? diagramId)
		{
			if (diagramId == null)
				return null;
		
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[DiagramIdCol] };
		
			return Rows.Find(diagramId.Value) as Sysdiagram;
		}
		#endregion
		
		#region FUNC<Primary Key Many>
		///	<summary>
		///		find items in local data where DiagramId IN '<paramref name="diagramIds"/>'. If nothing is found QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [sysdiagrams] WHERE [DiagramId] IN '<paramref name="diagramIds"/>'</c>.<para/>
		///		If no primary key is set execute <see cref="LoadThenFind_Each"/> instead.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		
		[DebuggerStepThrough] 
		public Sysdiagram[] FindOrLoad_Each(params Int32[] diagramIds)
		{
			if (diagramIds == null || diagramIds.Length == 0)
				return new Sysdiagram[0];
		
			if (PrimaryKey.Length == 0)
				return LoadThenFind_Each(diagramIds);
				
			var locallyFound = Find_Each(diagramIds);
			var loaded = LoadThenFind_Each(diagramIds.Except(locallyFound.Select(x=>x.DiagramId)).ToArray());
			return locallyFound.Union(loaded).ToArray();
		}
		
		
		///<summary>
		///		QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [sysdiagrams] WHERE [DiagramId] IN '<paramref name="diagramIds"/>'</c> THEN find items in local data where DiagramId IN '<paramref name="diagramIds"/>'.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///</summary>
		
		[DebuggerStepThrough] 
		public Sysdiagram[] LoadThenFind_Each(params Int32[] diagramIds)
		{
			if (diagramIds == null || diagramIds.Length == 0)
				return new Sysdiagram[0];
		
			DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}] WHERE [diagram_id] IN ('{diagramIds.Select(x=>x.ToString()).Join("', '")}')", false);
			
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[DiagramIdCol] };
		
			return Find_Each(diagramIds);
		}
		
		
		///	<summary>
		///		find items in local data where DiagramId IN '<paramref name="diagramIds"/>'. IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		
		[DebuggerStepThrough] 
		public Sysdiagram[] Find_Each(params Int32[] diagramIds)
		{
			if (diagramIds == null || diagramIds.Length == 0)
				return new Sysdiagram[0];
		
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[DiagramIdCol] };
				
			return Select(diagramIds.Select(key=>$"{DiagramIdCol} = '{key}'").Join(" OR "));
		}
		#endregion
		
		
		
		
		
		#region FUNC<Foreign Key>
		
		#endregion
		
		
		/// <summary>Creates a row then copy's the data from the <paramref name="item"/> and adds it to the row collection.</summary>
		public Sysdiagram AddAsNewRow(ISysdiagram item)
		{
			var row = NewRow();
			row.Copy_From(item, true);
			Add(row);
			return row;
		}
	}
}