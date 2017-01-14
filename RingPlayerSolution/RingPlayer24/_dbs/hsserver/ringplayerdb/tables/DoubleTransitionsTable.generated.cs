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
//<date>2017-01-14 15:59:27</date>



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
using RingPlayer24._dbs.hsserver.ringplayerdb.dataset;
using DoubleTransition=RingPlayer24._dbs.hsserver.ringplayerdb.rows.DoubleTransition;
using IDoubleTransition=RingPlayer24._dbs.hsserver.ringplayerdb.rowinterfaces.IDoubleTransition;
using RingPlayer24._dbs.hsserver;






namespace RingPlayer24._dbs.hsserver.ringplayerdb.tables
{
	#pragma warning disable 657
	#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	
	///	<summary>
	///		'[<c>HsServer</c>].[<c>#RingPlayerDb#</c>].[<c>DoubleTransitions</c>]': A Table inside '[<c>HsServer</c>].[<c>#RingPlayerDb#</c>]' database with '<see cref="DoubleTransition"/>' as <see cref="DataRow"/>.<para/>
	///		[<c>DoubleTransitions</c>].[<c>PageId</c>] &#62;&#62;&#62;&#62; [<c>Pages</c>].[<c>Id</c>]
	///	</summary>
	[Serializable]
	[DebuggerDisplay("DataTable(RingPlayerDb.DoubleTransitions): Rows[{Rows.Count}]")]
	[CsDbDataTable(Database = "RingPlayerDb", Name = "DoubleTransitions", Generated = "17.01.14 15:59:27", Hash = "458CF0562FA724D6D67A6A04D3F14965")]
	[CsDbResolvesRelation("FK_DoubleTransitions_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "DoubleTransitions", FkColumn = "PageId")]
	public partial class DoubleTransitionsTable : CsDbTable<DoubleTransition>
	{
		#region CONSTANTS
		///<summary>The native table name (DoubleTransitions).</summary>
		public const string NativeName = "DoubleTransitions";
		///<summary>Holds native column name of <c>[RingPlayerDb].[DoubleTransitions].[Id]</c> column. Property = <see cref="DoubleTransition.Id"/>.</summary>
		public const string IdCol = "Id";
		///<summary>Holds native column name of <c>[RingPlayerDb].[DoubleTransitions].[PageId]</c> column. Property = <see cref="DoubleTransition.PageId"/>.</summary>
		public const string PageIdCol = "PageId";
		///<summary>Holds native column name of <c>[RingPlayerDb].[DoubleTransitions].[BeginnTimeSeconds]</c> column. Property = <see cref="DoubleTransition.BeginnTimeSeconds"/>.</summary>
		public const string BeginnTimeSecondsCol = "BeginnTimeSeconds";
		///<summary>Holds native column name of <c>[RingPlayerDb].[DoubleTransitions].[DurationSeconds]</c> column. Property = <see cref="DoubleTransition.DurationSeconds"/>.</summary>
		public const string DurationSecondsCol = "DurationSeconds";
		///<summary>Holds native column name of <c>[RingPlayerDb].[DoubleTransitions].[FromValue]</c> column. Property = <see cref="DoubleTransition.FromValue"/>.</summary>
		public const string FromValueCol = "FromValue";
		///<summary>Holds native column name of <c>[RingPlayerDb].[DoubleTransitions].[ToValue]</c> column. Property = <see cref="DoubleTransition.ToValue"/>.</summary>
		public const string ToValueCol = "ToValue";
		///<summary>Holds native column name of <c>[RingPlayerDb].[DoubleTransitions].[PropertyPath]</c> column. Property = <see cref="DoubleTransition.PropertyPath"/>.</summary>
		public const string PropertyPathCol = "PropertyPath";
		///<summary>Holds native column name of <c>[RingPlayerDb].[DoubleTransitions].[TransitionType]</c> column. Property = <see cref="DoubleTransition.TransitionType"/>.</summary>
		public const string TransitionTypeCol = "TransitionType";
		///<summary>Holds native column name of <c>[RingPlayerDb].[DoubleTransitions].[DiagnosticText]</c> column. Property = <see cref="DoubleTransition.DiagnosticText"/>.</summary>
		public const string DiagnosticTextCol = "DiagnosticText";
	
		/// <summary> Contains attribute values for the columns</summary>
		public static class Cols
		{
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>DoubleTransitions</c>].[<c>Id</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "DoubleTransitions", Name = "Id", Type = "uniqueidentifier", Default = "(newid())", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute Id = new CsDbNativeDataColumnAttribute {Table = "DoubleTransitions", Name = "Id", Type = "uniqueidentifier", Default = "(newid())", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>DoubleTransitions</c>].[<c>PageId</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "DoubleTransitions", Name = "PageId", Type = "uniqueidentifier", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute PageId = new CsDbNativeDataColumnAttribute {Table = "DoubleTransitions", Name = "PageId", Type = "uniqueidentifier", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>DoubleTransitions</c>].[<c>BeginnTimeSeconds</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "DoubleTransitions", Name = "BeginnTimeSeconds", Type = "float", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute BeginnTimeSeconds = new CsDbNativeDataColumnAttribute {Table = "DoubleTransitions", Name = "BeginnTimeSeconds", Type = "float", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>DoubleTransitions</c>].[<c>DurationSeconds</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "DoubleTransitions", Name = "DurationSeconds", Type = "float", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute DurationSeconds = new CsDbNativeDataColumnAttribute {Table = "DoubleTransitions", Name = "DurationSeconds", Type = "float", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>DoubleTransitions</c>].[<c>FromValue</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "DoubleTransitions", Name = "FromValue", Type = "float", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute FromValue = new CsDbNativeDataColumnAttribute {Table = "DoubleTransitions", Name = "FromValue", Type = "float", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>DoubleTransitions</c>].[<c>ToValue</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "DoubleTransitions", Name = "ToValue", Type = "float", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute ToValue = new CsDbNativeDataColumnAttribute {Table = "DoubleTransitions", Name = "ToValue", Type = "float", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>DoubleTransitions</c>].[<c>PropertyPath</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "DoubleTransitions", Name = "PropertyPath", Type = "nvarchar", MaxLength = "-1", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute PropertyPath = new CsDbNativeDataColumnAttribute {Table = "DoubleTransitions", Name = "PropertyPath", Type = "nvarchar", MaxLength = "-1", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>DoubleTransitions</c>].[<c>TransitionType</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "DoubleTransitions", Name = "TransitionType", Type = "nvarchar", Default = "(N'Cubic')", MaxLength = "-1", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute TransitionType = new CsDbNativeDataColumnAttribute {Table = "DoubleTransitions", Name = "TransitionType", Type = "nvarchar", Default = "(N'Cubic')", MaxLength = "-1", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>DoubleTransitions</c>].[<c>DiagnosticText</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "DoubleTransitions", Name = "DiagnosticText", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute DiagnosticText = new CsDbNativeDataColumnAttribute {Table = "DoubleTransitions", Name = "DiagnosticText", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
		}
		#endregion
	
	
	
	
	
	
	
		///<summary>Default constructor for save <see cref="DataTable"/> operations</summary>
		public DoubleTransitionsTable()
		{
			TableName = NativeName;
		}
	
		///<summary>References the owning data context, this is equal to the database server. Use this to address databases on the same server.</summary>
		public new RingPlayer24._dbs.hsserver.HsServerContext DataContext => DataSet.DataContext;
	
		///<summary>References the owning dataset. Use this to address tables in the same database</summary>
		public new RingPlayerDb DataSet => (RingPlayerDb) base.DataSet;
	
	
	
	
	
	
	
		#region FUNC<Overrides>
		
		///	<summary><c>SELECT (DefaultSqlSelector) FROM [DoubleTransitions]</c><para>The default selector is the * operator</para></summary>
		[DebuggerStepThrough] 
		public override void DownloadRows()
		{
			DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}]", false);
			HasBeenLoaded = true;
		}
		///	<summary><c>SELECT <paramref name="top"/> (DefaultSqlSelector) FROM [DoubleTransitions]</c><para>The default selector is the * operator</para></summary>
		[DebuggerStepThrough] 
		public override void DownloadRows(int top)
		{
			DownloadRows($"SELECT TOP {top} {DefaultSqlSelector} FROM [{NativeName}]", false);
		}
		
		
		///<summary>This method calls <see cref="FindOrLoad"/>.</summary>
		[DebuggerStepThrough] 
		public override CsDbRowBase Generic_FindOrLoad(object id)
		{
			return id==null ? null : FindOrLoad((Guid?) id);
		}
		///<summary>This method calls <see cref="LoadThenFind"/>.</summary>
		[DebuggerStepThrough] 
		public override CsDbRowBase Generic_LoadThenFind(object id)
		{
			return id==null ? null : LoadThenFind((Guid?) id);
		}
		///<summary>This method calls <see cref="Find"/>.</summary>
		[DebuggerStepThrough] 
		public override CsDbRowBase Generic_Find(object id)
		{
			return id==null ? null : Find((Guid?) id);
		}
		
		
		
		///<summary>This method calls <see cref="FindOrLoad"/>.</summary>
		[DebuggerStepThrough] 
		public override CsDbRowBase[] Generic_FindOrLoad(params object[] ids)
		{
			return FindOrLoad_Each(ids.OfType<Guid>().ToArray()).OfType<CsDbRowBase>().ToArray();
		}
		///<summary>This method calls <see cref="LoadThenFind"/>.</summary>
		[DebuggerStepThrough] 
		public override CsDbRowBase[] Generic_LoadThenFind(params object[] ids)
		{
			return LoadThenFind_Each(ids.OfType<Guid>().ToArray()).OfType<CsDbRowBase>().ToArray();
		}
		///<summary>This method calls <see cref="Find"/>.</summary>
		[DebuggerStepThrough] 
		public override CsDbRowBase[] Generic_Find(params object[] ids)
		{
			return Find_Each(ids.OfType<Guid>().ToArray()).OfType<CsDbRowBase>().ToArray();
		}
		#endregion
		
		
		
		
		#region FUNC<Primary Key>
		
		///	<summary>
		///		find an item in local data where Id = '<paramref name="id"/>'. If nothing is found QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [DoubleTransitions] WHERE [Id] = '<paramref name="id"/>'</c>.<para/>
		///		If no primary key is set execute <see cref="LoadThenFind"/> instead.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK_DoubleTransitions_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "DoubleTransitions", FkColumn = "PageId")]
		[DebuggerStepThrough] 
		public DoubleTransition FindOrLoad(Guid? id)
		{
			if (id == null)
				return null;
		
			if (PrimaryKey.Length == 0)
				return LoadThenFind(id);
		
			return Find(id) ?? LoadThenFind(id);
		}
		
		
		///<summary>
		///		QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [DoubleTransitions] WHERE [Id] = '<paramref name="id"/>'</c> THEN find an item in local data where Id = '<paramref name="id"/>'.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///</summary>
		[CsDbResolvesRelation("FK_DoubleTransitions_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "DoubleTransitions", FkColumn = "PageId")]
		[DebuggerStepThrough] 
		public DoubleTransition LoadThenFind(Guid? id)
		{
			if (id == null)
				return null;
		
			DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}] WHERE [Id] = '{id}'", false);
			
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
		
			return Rows.Find(id.Value) as DoubleTransition;
		}
		
		
		///	<summary>
		///		find an item in local data where Id = '<paramref name="id"/>'. IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK_DoubleTransitions_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "DoubleTransitions", FkColumn = "PageId")]
		[DebuggerStepThrough] 
		public DoubleTransition Find(Guid? id)
		{
			if (id == null)
				return null;
		
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
		
			return Rows.Find(id.Value) as DoubleTransition;
		}
		#endregion
		
		#region FUNC<Primary Key Many>
		///	<summary>
		///		find items in local data where Id IN '<paramref name="ids"/>'. If nothing is found QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [DoubleTransitions] WHERE [Id] IN '<paramref name="ids"/>'</c>.<para/>
		///		If no primary key is set execute <see cref="LoadThenFind_Each"/> instead.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK_DoubleTransitions_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "DoubleTransitions", FkColumn = "PageId")]
		[DebuggerStepThrough] 
		public DoubleTransition[] FindOrLoad_Each(params Guid[] ids)
		{
			if (ids == null || ids.Length == 0)
				return new DoubleTransition[0];
		
			if (PrimaryKey.Length == 0)
				return LoadThenFind_Each(ids);
				
			var locallyFound = Find_Each(ids);
			var loaded = LoadThenFind_Each(ids.Except(locallyFound.Select(x=>x.Id)).ToArray());
			return locallyFound.Union(loaded).ToArray();
		}
		
		
		///<summary>
		///		QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [DoubleTransitions] WHERE [Id] IN '<paramref name="ids"/>'</c> THEN find items in local data where Id IN '<paramref name="ids"/>'.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///</summary>
		[CsDbResolvesRelation("FK_DoubleTransitions_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "DoubleTransitions", FkColumn = "PageId")]
		[DebuggerStepThrough] 
		public DoubleTransition[] LoadThenFind_Each(params Guid[] ids)
		{
			if (ids == null || ids.Length == 0)
				return new DoubleTransition[0];
		
			DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}] WHERE [Id] IN ('{ids.Select(x=>x.ToString()).Join("', '")}')", false);
			
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
		
			return Find_Each(ids);
		}
		
		
		///	<summary>
		///		find items in local data where Id IN '<paramref name="ids"/>'. IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK_DoubleTransitions_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "DoubleTransitions", FkColumn = "PageId")]
		[DebuggerStepThrough] 
		public DoubleTransition[] Find_Each(params Guid[] ids)
		{
			if (ids == null || ids.Length == 0)
				return new DoubleTransition[0];
		
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
				
			return Select(ids.Select(key=>$"{IdCol} = '{key}'").Join(" OR "));
		}
		#endregion
		
		
		
		
		
		#region FUNC<Foreign Key>
		[field:NonSerialized] private Dictionary<Guid?, CsWeakReference<ContractCollection<DoubleTransition>>> _byPageId = new Dictionary<Guid?, CsWeakReference<ContractCollection<DoubleTransition>>>();
		
		///	<summary> 
		///		Query <c>SELECT (DefaultSqlSelector) FROM DoubleTransitions WHERE [PageId] = '<paramref name="pageId"/>'</c><para/>
		///		[<c>DoubleTransitions</c>].[<c>PageId</c>] &#62;&#62;&#62;&#62; [<c>Pages</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK_DoubleTransitions_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "DoubleTransitions", FkColumn = "PageId")]
		[DebuggerStepThrough]
		public ContractCollection<DoubleTransition> FindOrLoad_By_PageId(Guid? pageId)
		{
			if (pageId == null)
				return null;
			CsWeakReference<ContractCollection<DoubleTransition>> weak;
			ContractCollection<DoubleTransition> result;
		
			if (_byPageId.TryGetValue(pageId, out weak) && weak.TryGetTarget(out result))
				return result;
		
			if (HasBeenLoaded == true || weak != null)
				result = CreateContractCollection(@doubleTransition => Equals(@doubleTransition.PageId, pageId));
			else 
			{
				DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}] WHERE [{PageIdCol}] = '{pageId}'", false);
				result = CreateContractCollection(@doubleTransition => Equals(@doubleTransition.PageId, pageId));
			}
		
			if (weak == null)
				_byPageId.Add(pageId, weak = new CsWeakReference<ContractCollection<DoubleTransition>>(result));
			else
				weak.SetTarget(result);
		
			return result;
		}
		///	<summary> 
		///		Query <c>SELECT (DefaultSqlSelector) FROM DoubleTransitions WHERE [PageId] = '<paramref name="pageId"/>'</c><para/>
		///		[<c>DoubleTransitions</c>].[<c>PageId</c>] &#62;&#62;&#62;&#62; [<c>Pages</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK_DoubleTransitions_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "DoubleTransitions", FkColumn = "PageId")]
		[DebuggerStepThrough] 
		public ContractCollection<DoubleTransition> LoadThenFind_By_PageId(Guid? pageId)
		{
			if (pageId == null)
				return null;
			CsWeakReference<ContractCollection<DoubleTransition>> weak;
			ContractCollection<DoubleTransition> result;
		
			DownloadRows($"SELECT {DefaultSqlSelector} FROM {NativeName} WHERE [{PageIdCol}] = '{pageId}'", false);
		
			if (_byPageId.TryGetValue(pageId, out weak) && weak.TryGetTarget(out result))
				return result;
		
			result = CreateContractCollection(@doubleTransition => Equals(@doubleTransition.PageId, pageId));
		
			if (weak == null)
				_byPageId.Add(pageId, weak = new CsWeakReference<ContractCollection<DoubleTransition>>(result));
			else
				weak.SetTarget(result);
		
			return result;
		}
		///	<summary> 
		///		Query <c>SELECT (DefaultSqlSelector) FROM DoubleTransitions WHERE [PageId] = '<paramref name="pageId"/>'</c><para/>
		///		[<c>DoubleTransitions</c>].[<c>PageId</c>] &#62;&#62;&#62;&#62; [<c>Pages</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK_DoubleTransitions_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "DoubleTransitions", FkColumn = "PageId")]
		[DebuggerStepThrough]
		public ContractCollection<DoubleTransition> Find_By_PageId(Guid? pageId)
		{
			if (pageId == null)
				return null;
			CsWeakReference<ContractCollection<DoubleTransition>> weak;
			ContractCollection<DoubleTransition> result;
		
			if (_byPageId.TryGetValue(pageId, out weak) && weak.TryGetTarget(out result))
				return result;
		
		
			result = CreateContractCollection(@doubleTransition => Equals(@doubleTransition.PageId, pageId));
		
		    if (weak == null)
				_byPageId.Add(pageId, weak = new CsWeakReference<ContractCollection<DoubleTransition>>(result));
			else
				weak.SetTarget(result);
		
			return result;
		}
		#endregion
		
		
		/// <summary>Creates a row then copy's the data from the <paramref name="item"/> and adds it to the row collection.</summary>
		public DoubleTransition AddAsNewRow(IDoubleTransition item)
		{
			var row = NewRow();
			row.Copy_From(item, true);
			Add(row);
			return row;
		}
	}
}