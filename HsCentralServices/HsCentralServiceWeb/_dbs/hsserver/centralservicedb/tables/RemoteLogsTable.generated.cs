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
using HsCentralServiceWeb._dbs.hsserver.centralservicedb.dataset;
using RemoteLog=HsCentralServiceWeb._dbs.hsserver.centralservicedb.rows.RemoteLog;
using IRemoteLog=HsCentralServiceWeb._dbs.hsserver.centralservicedb.rowinterfaces.IRemoteLog;
using HsCentralServiceWeb._dbs.hsserver;






namespace HsCentralServiceWeb._dbs.hsserver.centralservicedb.tables
{
	#pragma warning disable 657
	#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	
	///	<summary>
	///		'[<c>HsServer</c>].[<c>#CentralServiceDb#</c>].[<c>RemoteLogs</c>]': A Table inside '[<c>HsServer</c>].[<c>#CentralServiceDb#</c>]' database with '<see cref="RemoteLog"/>' as <see cref="DataRow"/>.<para/>
	///		[<c>RemoteLogs</c>].[<c>RemoteInstanceId</c>] &#62;&#62;&#62;&#62; [<c>RemoteInstances</c>].[<c>Id</c>]
	///	</summary>
	[Serializable]
	[DebuggerDisplay("DataTable(CentralServiceDb.RemoteLogs): Rows[{Rows.Count}]")]
	[CsDbDataTable(Database = "CentralServiceDb", Name = "RemoteLogs", Generated = "17.01.15 00:09:46", Hash = "EE934BDCCC11E228DD7A22DFA02D6281")]
	[CsDbResolvesRelation("FK__RemoteLog__Remot__1BC821DD", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteLogs", FkColumn = "RemoteInstanceId")]
	public partial class RemoteLogsTable : CsDbTable<RemoteLog>
	{
		#region CONSTANTS
		///<summary>The native table name (RemoteLogs).</summary>
		public const string NativeName = "RemoteLogs";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteLogs].[Id]</c> column. Property = <see cref="RemoteLog.Id"/>.</summary>
		public const string IdCol = "Id";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteLogs].[Created]</c> column. Property = <see cref="RemoteLog.Created"/>.</summary>
		public const string CreatedCol = "Created";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteLogs].[SeverityNumber]</c> column. Property = <see cref="RemoteLog.SeverityNumber"/>.</summary>
		public const string SeverityNumberCol = "SeverityNumber";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteLogs].[Title]</c> column. Property = <see cref="RemoteLog.Title"/>.</summary>
		public const string TitleCol = "Title";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteLogs].[Message]</c> column. Property = <see cref="RemoteLog.Message"/>.</summary>
		public const string MessageCol = "Message";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteLogs].[CodeFile]</c> column. Property = <see cref="RemoteLog.CodeFile"/>.</summary>
		public const string CodeFileCol = "CodeFile";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteLogs].[CodeMethod]</c> column. Property = <see cref="RemoteLog.CodeMethod"/>.</summary>
		public const string CodeMethodCol = "CodeMethod";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteLogs].[CodeLine]</c> column. Property = <see cref="RemoteLog.CodeLine"/>.</summary>
		public const string CodeLineCol = "CodeLine";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteLogs].[RemoteInstanceId]</c> column. Property = <see cref="RemoteLog.RemoteInstanceId"/>.</summary>
		public const string RemoteInstanceIdCol = "RemoteInstanceId";
	
		/// <summary> Contains attribute values for the columns</summary>
		public static class Cols
		{
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteLogs</c>].[<c>Id</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteLogs", Name = "Id", Type = "uniqueidentifier", Default = "(newid())", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute Id = new CsDbNativeDataColumnAttribute {Table = "RemoteLogs", Name = "Id", Type = "uniqueidentifier", Default = "(newid())", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteLogs</c>].[<c>Created</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteLogs", Name = "Created", Type = "datetime2", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute Created = new CsDbNativeDataColumnAttribute {Table = "RemoteLogs", Name = "Created", Type = "datetime2", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteLogs</c>].[<c>SeverityNumber</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteLogs", Name = "SeverityNumber", Type = "int", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute SeverityNumber = new CsDbNativeDataColumnAttribute {Table = "RemoteLogs", Name = "SeverityNumber", Type = "int", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteLogs</c>].[<c>Title</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteLogs", Name = "Title", Type = "nvarchar", MaxLength = "-1", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute Title = new CsDbNativeDataColumnAttribute {Table = "RemoteLogs", Name = "Title", Type = "nvarchar", MaxLength = "-1", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteLogs</c>].[<c>Message</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteLogs", Name = "Message", Type = "nvarchar", MaxLength = "-1", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute Message = new CsDbNativeDataColumnAttribute {Table = "RemoteLogs", Name = "Message", Type = "nvarchar", MaxLength = "-1", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteLogs</c>].[<c>CodeFile</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteLogs", Name = "CodeFile", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute CodeFile = new CsDbNativeDataColumnAttribute {Table = "RemoteLogs", Name = "CodeFile", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteLogs</c>].[<c>CodeMethod</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteLogs", Name = "CodeMethod", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute CodeMethod = new CsDbNativeDataColumnAttribute {Table = "RemoteLogs", Name = "CodeMethod", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteLogs</c>].[<c>CodeLine</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteLogs", Name = "CodeLine", Type = "int", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute CodeLine = new CsDbNativeDataColumnAttribute {Table = "RemoteLogs", Name = "CodeLine", Type = "int", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteLogs</c>].[<c>RemoteInstanceId</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteLogs", Name = "RemoteInstanceId", Type = "uniqueidentifier", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute RemoteInstanceId = new CsDbNativeDataColumnAttribute {Table = "RemoteLogs", Name = "RemoteInstanceId", Type = "uniqueidentifier", IsNullable = "NO"};
		}
		#endregion
	
	
	
	
	
	
	
		///<summary>Default constructor for save <see cref="DataTable"/> operations</summary>
		public RemoteLogsTable()
		{
			TableName = NativeName;
		}
	
		///<summary>References the owning data context, this is equal to the database server. Use this to address databases on the same server.</summary>
		public new HsCentralServiceWeb._dbs.hsserver.HsServerContext DataContext => DataSet.DataContext;
	
		///<summary>References the owning dataset. Use this to address tables in the same database</summary>
		public new CentralServiceDb DataSet => (CentralServiceDb) base.DataSet;
	
	
	
	
	
	
	
		#region FUNC<Overrides>
		
		///	<summary><c>SELECT (DefaultSqlSelector) FROM [RemoteLogs]</c><para>The default selector is the * operator</para></summary>
		[DebuggerStepThrough] 
		public override void DownloadRows()
		{
			DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}]", false);
			HasBeenLoaded = true;
		}
		///	<summary><c>SELECT <paramref name="top"/> (DefaultSqlSelector) FROM [RemoteLogs]</c><para>The default selector is the * operator</para></summary>
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
		///		find an item in local data where Id = '<paramref name="id"/>'. If nothing is found QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [RemoteLogs] WHERE [Id] = '<paramref name="id"/>'</c>.<para/>
		///		If no primary key is set execute <see cref="LoadThenFind"/> instead.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK__RemoteLog__Remot__1BC821DD", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteLogs", FkColumn = "RemoteInstanceId")]
		[DebuggerStepThrough] 
		public RemoteLog FindOrLoad(Guid? id)
		{
			if (id == null)
				return null;
		
			if (PrimaryKey.Length == 0)
				return LoadThenFind(id);
		
			return Find(id) ?? LoadThenFind(id);
		}
		
		
		///<summary>
		///		QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [RemoteLogs] WHERE [Id] = '<paramref name="id"/>'</c> THEN find an item in local data where Id = '<paramref name="id"/>'.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///</summary>
		[CsDbResolvesRelation("FK__RemoteLog__Remot__1BC821DD", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteLogs", FkColumn = "RemoteInstanceId")]
		[DebuggerStepThrough] 
		public RemoteLog LoadThenFind(Guid? id)
		{
			if (id == null)
				return null;
		
			DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}] WHERE [Id] = '{id}'", false);
			
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
		
			return Rows.Find(id.Value) as RemoteLog;
		}
		
		
		///	<summary>
		///		find an item in local data where Id = '<paramref name="id"/>'. IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK__RemoteLog__Remot__1BC821DD", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteLogs", FkColumn = "RemoteInstanceId")]
		[DebuggerStepThrough] 
		public RemoteLog Find(Guid? id)
		{
			if (id == null)
				return null;
		
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
		
			return Rows.Find(id.Value) as RemoteLog;
		}
		#endregion
		
		#region FUNC<Primary Key Many>
		///	<summary>
		///		find items in local data where Id IN '<paramref name="ids"/>'. If nothing is found QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [RemoteLogs] WHERE [Id] IN '<paramref name="ids"/>'</c>.<para/>
		///		If no primary key is set execute <see cref="LoadThenFind_Each"/> instead.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK__RemoteLog__Remot__1BC821DD", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteLogs", FkColumn = "RemoteInstanceId")]
		[DebuggerStepThrough] 
		public RemoteLog[] FindOrLoad_Each(params Guid[] ids)
		{
			if (ids == null || ids.Length == 0)
				return new RemoteLog[0];
		
			if (PrimaryKey.Length == 0)
				return LoadThenFind_Each(ids);
				
			var locallyFound = Find_Each(ids);
			var loaded = LoadThenFind_Each(ids.Except(locallyFound.Select(x=>x.Id)).ToArray());
			return locallyFound.Union(loaded).ToArray();
		}
		
		
		///<summary>
		///		QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [RemoteLogs] WHERE [Id] IN '<paramref name="ids"/>'</c> THEN find items in local data where Id IN '<paramref name="ids"/>'.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///</summary>
		[CsDbResolvesRelation("FK__RemoteLog__Remot__1BC821DD", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteLogs", FkColumn = "RemoteInstanceId")]
		[DebuggerStepThrough] 
		public RemoteLog[] LoadThenFind_Each(params Guid[] ids)
		{
			if (ids == null || ids.Length == 0)
				return new RemoteLog[0];
		
			DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}] WHERE [Id] IN ('{ids.Select(x=>x.ToString()).Join("', '")}')", false);
			
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
		
			return Find_Each(ids);
		}
		
		
		///	<summary>
		///		find items in local data where Id IN '<paramref name="ids"/>'. IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK__RemoteLog__Remot__1BC821DD", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteLogs", FkColumn = "RemoteInstanceId")]
		[DebuggerStepThrough] 
		public RemoteLog[] Find_Each(params Guid[] ids)
		{
			if (ids == null || ids.Length == 0)
				return new RemoteLog[0];
		
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
				
			return Select(ids.Select(key=>$"{IdCol} = '{key}'").Join(" OR "));
		}
		#endregion
		
		
		
		
		
		#region FUNC<Foreign Key>
		[field:NonSerialized] private Dictionary<Guid?, CsWeakReference<ContractCollection<RemoteLog>>> _byRemoteInstanceId = new Dictionary<Guid?, CsWeakReference<ContractCollection<RemoteLog>>>();
		
		///	<summary> 
		///		Query <c>SELECT (DefaultSqlSelector) FROM RemoteLogs WHERE [RemoteInstanceId] = '<paramref name="remoteInstanceId"/>'</c><para/>
		///		[<c>RemoteLogs</c>].[<c>RemoteInstanceId</c>] &#62;&#62;&#62;&#62; [<c>RemoteInstances</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK__RemoteLog__Remot__1BC821DD", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteLogs", FkColumn = "RemoteInstanceId")]
		[DebuggerStepThrough]
		public ContractCollection<RemoteLog> FindOrLoad_By_RemoteInstanceId(Guid? remoteInstanceId)
		{
			if (remoteInstanceId == null)
				return null;
			CsWeakReference<ContractCollection<RemoteLog>> weak;
			ContractCollection<RemoteLog> result;
		
			if (_byRemoteInstanceId.TryGetValue(remoteInstanceId, out weak) && weak.TryGetTarget(out result))
				return result;
		
			if (HasBeenLoaded == true || weak != null)
				result = CreateContractCollection(@remoteLog => Equals(@remoteLog.RemoteInstanceId, remoteInstanceId));
			else 
			{
				DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}] WHERE [{RemoteInstanceIdCol}] = '{remoteInstanceId}'", false);
				result = CreateContractCollection(@remoteLog => Equals(@remoteLog.RemoteInstanceId, remoteInstanceId));
			}
		
			if (weak == null)
				_byRemoteInstanceId.Add(remoteInstanceId, weak = new CsWeakReference<ContractCollection<RemoteLog>>(result));
			else
				weak.SetTarget(result);
		
			return result;
		}
		///	<summary> 
		///		Query <c>SELECT (DefaultSqlSelector) FROM RemoteLogs WHERE [RemoteInstanceId] = '<paramref name="remoteInstanceId"/>'</c><para/>
		///		[<c>RemoteLogs</c>].[<c>RemoteInstanceId</c>] &#62;&#62;&#62;&#62; [<c>RemoteInstances</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK__RemoteLog__Remot__1BC821DD", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteLogs", FkColumn = "RemoteInstanceId")]
		[DebuggerStepThrough] 
		public ContractCollection<RemoteLog> LoadThenFind_By_RemoteInstanceId(Guid? remoteInstanceId)
		{
			if (remoteInstanceId == null)
				return null;
			CsWeakReference<ContractCollection<RemoteLog>> weak;
			ContractCollection<RemoteLog> result;
		
			DownloadRows($"SELECT {DefaultSqlSelector} FROM {NativeName} WHERE [{RemoteInstanceIdCol}] = '{remoteInstanceId}'", false);
		
			if (_byRemoteInstanceId.TryGetValue(remoteInstanceId, out weak) && weak.TryGetTarget(out result))
				return result;
		
			result = CreateContractCollection(@remoteLog => Equals(@remoteLog.RemoteInstanceId, remoteInstanceId));
		
			if (weak == null)
				_byRemoteInstanceId.Add(remoteInstanceId, weak = new CsWeakReference<ContractCollection<RemoteLog>>(result));
			else
				weak.SetTarget(result);
		
			return result;
		}
		///	<summary> 
		///		Query <c>SELECT (DefaultSqlSelector) FROM RemoteLogs WHERE [RemoteInstanceId] = '<paramref name="remoteInstanceId"/>'</c><para/>
		///		[<c>RemoteLogs</c>].[<c>RemoteInstanceId</c>] &#62;&#62;&#62;&#62; [<c>RemoteInstances</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK__RemoteLog__Remot__1BC821DD", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteLogs", FkColumn = "RemoteInstanceId")]
		[DebuggerStepThrough]
		public ContractCollection<RemoteLog> Find_By_RemoteInstanceId(Guid? remoteInstanceId)
		{
			if (remoteInstanceId == null)
				return null;
			CsWeakReference<ContractCollection<RemoteLog>> weak;
			ContractCollection<RemoteLog> result;
		
			if (_byRemoteInstanceId.TryGetValue(remoteInstanceId, out weak) && weak.TryGetTarget(out result))
				return result;
		
		
			result = CreateContractCollection(@remoteLog => Equals(@remoteLog.RemoteInstanceId, remoteInstanceId));
		
		    if (weak == null)
				_byRemoteInstanceId.Add(remoteInstanceId, weak = new CsWeakReference<ContractCollection<RemoteLog>>(result));
			else
				weak.SetTarget(result);
		
			return result;
		}
		#endregion
		
		
		/// <summary>Creates a row then copy's the data from the <paramref name="item"/> and adds it to the row collection.</summary>
		public RemoteLog AddAsNewRow(IRemoteLog item)
		{
			var row = NewRow();
			row.Copy_From(item, true);
			Add(row);
			return row;
		}
	}
}