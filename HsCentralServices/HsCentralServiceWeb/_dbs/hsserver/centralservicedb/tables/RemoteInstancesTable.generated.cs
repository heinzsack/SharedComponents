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
using RemoteInstance=HsCentralServiceWeb._dbs.hsserver.centralservicedb.rows.RemoteInstance;
using IRemoteInstance=HsCentralServiceWeb._dbs.hsserver.centralservicedb.rowinterfaces.IRemoteInstance;
using HsCentralServiceWeb._dbs.hsserver;






namespace HsCentralServiceWeb._dbs.hsserver.centralservicedb.tables
{
	#pragma warning disable 657
	#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	
	///	<summary>
	///		'[<c>HsServer</c>].[<c>#CentralServiceDb#</c>].[<c>RemoteInstances</c>]': A Table inside '[<c>HsServer</c>].[<c>#CentralServiceDb#</c>]' database with '<see cref="RemoteInstance"/>' as <see cref="DataRow"/>.<para/>
	///		[<c>RemoteInstances</c>].[<c>RemoteApplicationId</c>] &#62;&#62;&#62;&#62; [<c>RemoteApplications</c>].[<c>Id</c>]<para/>
	///		[<c>RemoteInstances</c>].[<c>RemoteUserId</c>] &#62;&#62;&#62;&#62; [<c>RemoteUsers</c>].[<c>Id</c>]<para/>
	///		[<c>RemoteInstances</c>].[<c>Id</c>] &#60;&#60;&#60;&#60; [<c>RemoteLogs</c>].[<c>RemoteInstanceId</c>]<para/>
	///		[<c>RemoteInstances</c>].[<c>Id</c>] &#60;&#60;&#60;&#60; [<c>RemoteConnections</c>].[<c>RemoteInstanceId</c>]
	///	</summary>
	[Serializable]
	[DebuggerDisplay("DataTable(CentralServiceDb.RemoteInstances): Rows[{Rows.Count}]")]
	[CsDbDataTable(Database = "CentralServiceDb", Name = "RemoteInstances", Generated = "17.01.15 00:09:46", Hash = "64E0539998231C6D0AC7E5BEF7C72876")]
	[CsDbResolvesRelation("FK__RemoteIns__Remot__1AD3FDA4", PkTable = "RemoteApplications", PkColumn = "Id", FkTable = "RemoteInstances", FkColumn = "RemoteApplicationId")]
	[CsDbResolvesRelation("FK__RemoteIns__Remot__19DFD96B", PkTable = "RemoteUsers", PkColumn = "Id", FkTable = "RemoteInstances", FkColumn = "RemoteUserId")]
	[CsDbResolvesRelation("FK__RemoteLog__Remot__1BC821DD", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteLogs", FkColumn = "RemoteInstanceId")]
	[CsDbResolvesRelation("FK_RemoteConnections_RemoteInstances", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteConnections", FkColumn = "RemoteInstanceId")]
	public partial class RemoteInstancesTable : CsDbTable<RemoteInstance>
	{
		#region CONSTANTS
		///<summary>The native table name (RemoteInstances).</summary>
		public const string NativeName = "RemoteInstances";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteInstances].[Id]</c> column. Property = <see cref="RemoteInstance.Id"/>.</summary>
		public const string IdCol = "Id";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteInstances].[ProcessFile]</c> column. Property = <see cref="RemoteInstance.ProcessFile"/>.</summary>
		public const string ProcessFileCol = "ProcessFile";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteInstances].[FirstExecutionTime]</c> column. Property = <see cref="RemoteInstance.FirstExecutionTime"/>.</summary>
		public const string FirstExecutionTimeCol = "FirstExecutionTime";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteInstances].[LastExecutionTime]</c> column. Property = <see cref="RemoteInstance.LastExecutionTime"/>.</summary>
		public const string LastExecutionTimeCol = "LastExecutionTime";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteInstances].[Unsigned_StartupCount]</c> column. Property = <see cref="RemoteInstance.UnsignedStartupCount"/>.</summary>
		public const string UnsignedStartupCountCol = "Unsigned_StartupCount";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteInstances].[Ticks_UseageTime]</c> column. Property = <see cref="RemoteInstance.TicksUseageTime"/>.</summary>
		public const string TicksUseageTimeCol = "Ticks_UseageTime";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteInstances].[Version]</c> column. Property = <see cref="RemoteInstance.Version"/>.</summary>
		public const string VersionCol = "Version";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteInstances].[Created]</c> column. Property = <see cref="RemoteInstance.Created"/>.</summary>
		public const string CreatedCol = "Created";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteInstances].[LastSeen]</c> column. Property = <see cref="RemoteInstance.LastSeen"/>.</summary>
		public const string LastSeenCol = "LastSeen";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteInstances].[RemoteUserId]</c> column. Property = <see cref="RemoteInstance.RemoteUserId"/>.</summary>
		public const string RemoteUserIdCol = "RemoteUserId";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteInstances].[RemoteApplicationId]</c> column. Property = <see cref="RemoteInstance.RemoteApplicationId"/>.</summary>
		public const string RemoteApplicationIdCol = "RemoteApplicationId";
	
		/// <summary> Contains attribute values for the columns</summary>
		public static class Cols
		{
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteInstances</c>].[<c>Id</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteInstances", Name = "Id", Type = "uniqueidentifier", Default = "(newid())", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute Id = new CsDbNativeDataColumnAttribute {Table = "RemoteInstances", Name = "Id", Type = "uniqueidentifier", Default = "(newid())", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteInstances</c>].[<c>ProcessFile</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteInstances", Name = "ProcessFile", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute ProcessFile = new CsDbNativeDataColumnAttribute {Table = "RemoteInstances", Name = "ProcessFile", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteInstances</c>].[<c>FirstExecutionTime</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteInstances", Name = "FirstExecutionTime", Type = "datetime2", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute FirstExecutionTime = new CsDbNativeDataColumnAttribute {Table = "RemoteInstances", Name = "FirstExecutionTime", Type = "datetime2", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteInstances</c>].[<c>LastExecutionTime</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteInstances", Name = "LastExecutionTime", Type = "datetime2", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute LastExecutionTime = new CsDbNativeDataColumnAttribute {Table = "RemoteInstances", Name = "LastExecutionTime", Type = "datetime2", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteInstances</c>].[<c>Unsigned_StartupCount</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteInstances", Name = "Unsigned_StartupCount", Type = "int", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute UnsignedStartupCount = new CsDbNativeDataColumnAttribute {Table = "RemoteInstances", Name = "Unsigned_StartupCount", Type = "int", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteInstances</c>].[<c>Ticks_UseageTime</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteInstances", Name = "Ticks_UseageTime", Type = "bigint", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute TicksUseageTime = new CsDbNativeDataColumnAttribute {Table = "RemoteInstances", Name = "Ticks_UseageTime", Type = "bigint", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteInstances</c>].[<c>Version</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteInstances", Name = "Version", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute Version = new CsDbNativeDataColumnAttribute {Table = "RemoteInstances", Name = "Version", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteInstances</c>].[<c>Created</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteInstances", Name = "Created", Type = "datetime2", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute Created = new CsDbNativeDataColumnAttribute {Table = "RemoteInstances", Name = "Created", Type = "datetime2", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteInstances</c>].[<c>LastSeen</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteInstances", Name = "LastSeen", Type = "datetime2", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute LastSeen = new CsDbNativeDataColumnAttribute {Table = "RemoteInstances", Name = "LastSeen", Type = "datetime2", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteInstances</c>].[<c>RemoteUserId</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteInstances", Name = "RemoteUserId", Type = "uniqueidentifier", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute RemoteUserId = new CsDbNativeDataColumnAttribute {Table = "RemoteInstances", Name = "RemoteUserId", Type = "uniqueidentifier", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteInstances</c>].[<c>RemoteApplicationId</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteInstances", Name = "RemoteApplicationId", Type = "uniqueidentifier", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute RemoteApplicationId = new CsDbNativeDataColumnAttribute {Table = "RemoteInstances", Name = "RemoteApplicationId", Type = "uniqueidentifier", IsNullable = "NO"};
		}
		#endregion
	
	
	
	
	
	
	
		///<summary>Default constructor for save <see cref="DataTable"/> operations</summary>
		public RemoteInstancesTable()
		{
			TableName = NativeName;
		}
	
		///<summary>References the owning data context, this is equal to the database server. Use this to address databases on the same server.</summary>
		public new HsCentralServiceWeb._dbs.hsserver.HsServerContext DataContext => DataSet.DataContext;
	
		///<summary>References the owning dataset. Use this to address tables in the same database</summary>
		public new CentralServiceDb DataSet => (CentralServiceDb) base.DataSet;
	
	
	
	
	
	
	
		#region FUNC<Overrides>
		
		///	<summary><c>SELECT (DefaultSqlSelector) FROM [RemoteInstances]</c><para>The default selector is the * operator</para></summary>
		[DebuggerStepThrough] 
		public override void DownloadRows()
		{
			DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}]", false);
			HasBeenLoaded = true;
		}
		///	<summary><c>SELECT <paramref name="top"/> (DefaultSqlSelector) FROM [RemoteInstances]</c><para>The default selector is the * operator</para></summary>
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
		///		find an item in local data where Id = '<paramref name="id"/>'. If nothing is found QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [RemoteInstances] WHERE [Id] = '<paramref name="id"/>'</c>.<para/>
		///		If no primary key is set execute <see cref="LoadThenFind"/> instead.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK__RemoteIns__Remot__1AD3FDA4", PkTable = "RemoteApplications", PkColumn = "Id", FkTable = "RemoteInstances", FkColumn = "RemoteApplicationId")]
		[CsDbResolvesRelation("FK__RemoteIns__Remot__19DFD96B", PkTable = "RemoteUsers", PkColumn = "Id", FkTable = "RemoteInstances", FkColumn = "RemoteUserId")]
		[CsDbResolvesRelation("FK__RemoteLog__Remot__1BC821DD", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteLogs", FkColumn = "RemoteInstanceId")]
		[CsDbResolvesRelation("FK_RemoteConnections_RemoteInstances", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteConnections", FkColumn = "RemoteInstanceId")]
		[DebuggerStepThrough] 
		public RemoteInstance FindOrLoad(Guid? id)
		{
			if (id == null)
				return null;
		
			if (PrimaryKey.Length == 0)
				return LoadThenFind(id);
		
			return Find(id) ?? LoadThenFind(id);
		}
		
		
		///<summary>
		///		QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [RemoteInstances] WHERE [Id] = '<paramref name="id"/>'</c> THEN find an item in local data where Id = '<paramref name="id"/>'.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///</summary>
		[CsDbResolvesRelation("FK__RemoteIns__Remot__1AD3FDA4", PkTable = "RemoteApplications", PkColumn = "Id", FkTable = "RemoteInstances", FkColumn = "RemoteApplicationId")]
		[CsDbResolvesRelation("FK__RemoteIns__Remot__19DFD96B", PkTable = "RemoteUsers", PkColumn = "Id", FkTable = "RemoteInstances", FkColumn = "RemoteUserId")]
		[CsDbResolvesRelation("FK__RemoteLog__Remot__1BC821DD", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteLogs", FkColumn = "RemoteInstanceId")]
		[CsDbResolvesRelation("FK_RemoteConnections_RemoteInstances", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteConnections", FkColumn = "RemoteInstanceId")]
		[DebuggerStepThrough] 
		public RemoteInstance LoadThenFind(Guid? id)
		{
			if (id == null)
				return null;
		
			DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}] WHERE [Id] = '{id}'", false);
			
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
		
			return Rows.Find(id.Value) as RemoteInstance;
		}
		
		
		///	<summary>
		///		find an item in local data where Id = '<paramref name="id"/>'. IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK__RemoteIns__Remot__1AD3FDA4", PkTable = "RemoteApplications", PkColumn = "Id", FkTable = "RemoteInstances", FkColumn = "RemoteApplicationId")]
		[CsDbResolvesRelation("FK__RemoteIns__Remot__19DFD96B", PkTable = "RemoteUsers", PkColumn = "Id", FkTable = "RemoteInstances", FkColumn = "RemoteUserId")]
		[CsDbResolvesRelation("FK__RemoteLog__Remot__1BC821DD", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteLogs", FkColumn = "RemoteInstanceId")]
		[CsDbResolvesRelation("FK_RemoteConnections_RemoteInstances", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteConnections", FkColumn = "RemoteInstanceId")]
		[DebuggerStepThrough] 
		public RemoteInstance Find(Guid? id)
		{
			if (id == null)
				return null;
		
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
		
			return Rows.Find(id.Value) as RemoteInstance;
		}
		#endregion
		
		#region FUNC<Primary Key Many>
		///	<summary>
		///		find items in local data where Id IN '<paramref name="ids"/>'. If nothing is found QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [RemoteInstances] WHERE [Id] IN '<paramref name="ids"/>'</c>.<para/>
		///		If no primary key is set execute <see cref="LoadThenFind_Each"/> instead.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK__RemoteIns__Remot__1AD3FDA4", PkTable = "RemoteApplications", PkColumn = "Id", FkTable = "RemoteInstances", FkColumn = "RemoteApplicationId")]
		[CsDbResolvesRelation("FK__RemoteIns__Remot__19DFD96B", PkTable = "RemoteUsers", PkColumn = "Id", FkTable = "RemoteInstances", FkColumn = "RemoteUserId")]
		[CsDbResolvesRelation("FK__RemoteLog__Remot__1BC821DD", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteLogs", FkColumn = "RemoteInstanceId")]
		[CsDbResolvesRelation("FK_RemoteConnections_RemoteInstances", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteConnections", FkColumn = "RemoteInstanceId")]
		[DebuggerStepThrough] 
		public RemoteInstance[] FindOrLoad_Each(params Guid[] ids)
		{
			if (ids == null || ids.Length == 0)
				return new RemoteInstance[0];
		
			if (PrimaryKey.Length == 0)
				return LoadThenFind_Each(ids);
				
			var locallyFound = Find_Each(ids);
			var loaded = LoadThenFind_Each(ids.Except(locallyFound.Select(x=>x.Id)).ToArray());
			return locallyFound.Union(loaded).ToArray();
		}
		
		
		///<summary>
		///		QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [RemoteInstances] WHERE [Id] IN '<paramref name="ids"/>'</c> THEN find items in local data where Id IN '<paramref name="ids"/>'.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///</summary>
		[CsDbResolvesRelation("FK__RemoteIns__Remot__1AD3FDA4", PkTable = "RemoteApplications", PkColumn = "Id", FkTable = "RemoteInstances", FkColumn = "RemoteApplicationId")]
		[CsDbResolvesRelation("FK__RemoteIns__Remot__19DFD96B", PkTable = "RemoteUsers", PkColumn = "Id", FkTable = "RemoteInstances", FkColumn = "RemoteUserId")]
		[CsDbResolvesRelation("FK__RemoteLog__Remot__1BC821DD", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteLogs", FkColumn = "RemoteInstanceId")]
		[CsDbResolvesRelation("FK_RemoteConnections_RemoteInstances", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteConnections", FkColumn = "RemoteInstanceId")]
		[DebuggerStepThrough] 
		public RemoteInstance[] LoadThenFind_Each(params Guid[] ids)
		{
			if (ids == null || ids.Length == 0)
				return new RemoteInstance[0];
		
			DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}] WHERE [Id] IN ('{ids.Select(x=>x.ToString()).Join("', '")}')", false);
			
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
		
			return Find_Each(ids);
		}
		
		
		///	<summary>
		///		find items in local data where Id IN '<paramref name="ids"/>'. IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK__RemoteIns__Remot__1AD3FDA4", PkTable = "RemoteApplications", PkColumn = "Id", FkTable = "RemoteInstances", FkColumn = "RemoteApplicationId")]
		[CsDbResolvesRelation("FK__RemoteIns__Remot__19DFD96B", PkTable = "RemoteUsers", PkColumn = "Id", FkTable = "RemoteInstances", FkColumn = "RemoteUserId")]
		[CsDbResolvesRelation("FK__RemoteLog__Remot__1BC821DD", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteLogs", FkColumn = "RemoteInstanceId")]
		[CsDbResolvesRelation("FK_RemoteConnections_RemoteInstances", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteConnections", FkColumn = "RemoteInstanceId")]
		[DebuggerStepThrough] 
		public RemoteInstance[] Find_Each(params Guid[] ids)
		{
			if (ids == null || ids.Length == 0)
				return new RemoteInstance[0];
		
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
				
			return Select(ids.Select(key=>$"{IdCol} = '{key}'").Join(" OR "));
		}
		#endregion
		
		
		
		
		
		#region FUNC<Foreign Key>
		[field:NonSerialized] private Dictionary<Guid?, CsWeakReference<ContractCollection<RemoteInstance>>> _byRemoteApplicationId = new Dictionary<Guid?, CsWeakReference<ContractCollection<RemoteInstance>>>();
		
		///	<summary> 
		///		Query <c>SELECT (DefaultSqlSelector) FROM RemoteInstances WHERE [RemoteApplicationId] = '<paramref name="remoteApplicationId"/>'</c><para/>
		///		[<c>RemoteInstances</c>].[<c>RemoteApplicationId</c>] &#62;&#62;&#62;&#62; [<c>RemoteApplications</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK__RemoteIns__Remot__1AD3FDA4", PkTable = "RemoteApplications", PkColumn = "Id", FkTable = "RemoteInstances", FkColumn = "RemoteApplicationId")]
		[DebuggerStepThrough]
		public ContractCollection<RemoteInstance> FindOrLoad_By_RemoteApplicationId(Guid? remoteApplicationId)
		{
			if (remoteApplicationId == null)
				return null;
			CsWeakReference<ContractCollection<RemoteInstance>> weak;
			ContractCollection<RemoteInstance> result;
		
			if (_byRemoteApplicationId.TryGetValue(remoteApplicationId, out weak) && weak.TryGetTarget(out result))
				return result;
		
			if (HasBeenLoaded == true || weak != null)
				result = CreateContractCollection(@remoteInstance => Equals(@remoteInstance.RemoteApplicationId, remoteApplicationId));
			else 
			{
				DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}] WHERE [{RemoteApplicationIdCol}] = '{remoteApplicationId}'", false);
				result = CreateContractCollection(@remoteInstance => Equals(@remoteInstance.RemoteApplicationId, remoteApplicationId));
			}
		
			if (weak == null)
				_byRemoteApplicationId.Add(remoteApplicationId, weak = new CsWeakReference<ContractCollection<RemoteInstance>>(result));
			else
				weak.SetTarget(result);
		
			return result;
		}
		///	<summary> 
		///		Query <c>SELECT (DefaultSqlSelector) FROM RemoteInstances WHERE [RemoteApplicationId] = '<paramref name="remoteApplicationId"/>'</c><para/>
		///		[<c>RemoteInstances</c>].[<c>RemoteApplicationId</c>] &#62;&#62;&#62;&#62; [<c>RemoteApplications</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK__RemoteIns__Remot__1AD3FDA4", PkTable = "RemoteApplications", PkColumn = "Id", FkTable = "RemoteInstances", FkColumn = "RemoteApplicationId")]
		[DebuggerStepThrough] 
		public ContractCollection<RemoteInstance> LoadThenFind_By_RemoteApplicationId(Guid? remoteApplicationId)
		{
			if (remoteApplicationId == null)
				return null;
			CsWeakReference<ContractCollection<RemoteInstance>> weak;
			ContractCollection<RemoteInstance> result;
		
			DownloadRows($"SELECT {DefaultSqlSelector} FROM {NativeName} WHERE [{RemoteApplicationIdCol}] = '{remoteApplicationId}'", false);
		
			if (_byRemoteApplicationId.TryGetValue(remoteApplicationId, out weak) && weak.TryGetTarget(out result))
				return result;
		
			result = CreateContractCollection(@remoteInstance => Equals(@remoteInstance.RemoteApplicationId, remoteApplicationId));
		
			if (weak == null)
				_byRemoteApplicationId.Add(remoteApplicationId, weak = new CsWeakReference<ContractCollection<RemoteInstance>>(result));
			else
				weak.SetTarget(result);
		
			return result;
		}
		///	<summary> 
		///		Query <c>SELECT (DefaultSqlSelector) FROM RemoteInstances WHERE [RemoteApplicationId] = '<paramref name="remoteApplicationId"/>'</c><para/>
		///		[<c>RemoteInstances</c>].[<c>RemoteApplicationId</c>] &#62;&#62;&#62;&#62; [<c>RemoteApplications</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK__RemoteIns__Remot__1AD3FDA4", PkTable = "RemoteApplications", PkColumn = "Id", FkTable = "RemoteInstances", FkColumn = "RemoteApplicationId")]
		[DebuggerStepThrough]
		public ContractCollection<RemoteInstance> Find_By_RemoteApplicationId(Guid? remoteApplicationId)
		{
			if (remoteApplicationId == null)
				return null;
			CsWeakReference<ContractCollection<RemoteInstance>> weak;
			ContractCollection<RemoteInstance> result;
		
			if (_byRemoteApplicationId.TryGetValue(remoteApplicationId, out weak) && weak.TryGetTarget(out result))
				return result;
		
		
			result = CreateContractCollection(@remoteInstance => Equals(@remoteInstance.RemoteApplicationId, remoteApplicationId));
		
		    if (weak == null)
				_byRemoteApplicationId.Add(remoteApplicationId, weak = new CsWeakReference<ContractCollection<RemoteInstance>>(result));
			else
				weak.SetTarget(result);
		
			return result;
		}
		[field:NonSerialized] private Dictionary<Guid?, CsWeakReference<ContractCollection<RemoteInstance>>> _byRemoteUserId = new Dictionary<Guid?, CsWeakReference<ContractCollection<RemoteInstance>>>();
		
		///	<summary> 
		///		Query <c>SELECT (DefaultSqlSelector) FROM RemoteInstances WHERE [RemoteUserId] = '<paramref name="remoteUserId"/>'</c><para/>
		///		[<c>RemoteInstances</c>].[<c>RemoteUserId</c>] &#62;&#62;&#62;&#62; [<c>RemoteUsers</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK__RemoteIns__Remot__19DFD96B", PkTable = "RemoteUsers", PkColumn = "Id", FkTable = "RemoteInstances", FkColumn = "RemoteUserId")]
		[DebuggerStepThrough]
		public ContractCollection<RemoteInstance> FindOrLoad_By_RemoteUserId(Guid? remoteUserId)
		{
			if (remoteUserId == null)
				return null;
			CsWeakReference<ContractCollection<RemoteInstance>> weak;
			ContractCollection<RemoteInstance> result;
		
			if (_byRemoteUserId.TryGetValue(remoteUserId, out weak) && weak.TryGetTarget(out result))
				return result;
		
			if (HasBeenLoaded == true || weak != null)
				result = CreateContractCollection(@remoteInstance => Equals(@remoteInstance.RemoteUserId, remoteUserId));
			else 
			{
				DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}] WHERE [{RemoteUserIdCol}] = '{remoteUserId}'", false);
				result = CreateContractCollection(@remoteInstance => Equals(@remoteInstance.RemoteUserId, remoteUserId));
			}
		
			if (weak == null)
				_byRemoteUserId.Add(remoteUserId, weak = new CsWeakReference<ContractCollection<RemoteInstance>>(result));
			else
				weak.SetTarget(result);
		
			return result;
		}
		///	<summary> 
		///		Query <c>SELECT (DefaultSqlSelector) FROM RemoteInstances WHERE [RemoteUserId] = '<paramref name="remoteUserId"/>'</c><para/>
		///		[<c>RemoteInstances</c>].[<c>RemoteUserId</c>] &#62;&#62;&#62;&#62; [<c>RemoteUsers</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK__RemoteIns__Remot__19DFD96B", PkTable = "RemoteUsers", PkColumn = "Id", FkTable = "RemoteInstances", FkColumn = "RemoteUserId")]
		[DebuggerStepThrough] 
		public ContractCollection<RemoteInstance> LoadThenFind_By_RemoteUserId(Guid? remoteUserId)
		{
			if (remoteUserId == null)
				return null;
			CsWeakReference<ContractCollection<RemoteInstance>> weak;
			ContractCollection<RemoteInstance> result;
		
			DownloadRows($"SELECT {DefaultSqlSelector} FROM {NativeName} WHERE [{RemoteUserIdCol}] = '{remoteUserId}'", false);
		
			if (_byRemoteUserId.TryGetValue(remoteUserId, out weak) && weak.TryGetTarget(out result))
				return result;
		
			result = CreateContractCollection(@remoteInstance => Equals(@remoteInstance.RemoteUserId, remoteUserId));
		
			if (weak == null)
				_byRemoteUserId.Add(remoteUserId, weak = new CsWeakReference<ContractCollection<RemoteInstance>>(result));
			else
				weak.SetTarget(result);
		
			return result;
		}
		///	<summary> 
		///		Query <c>SELECT (DefaultSqlSelector) FROM RemoteInstances WHERE [RemoteUserId] = '<paramref name="remoteUserId"/>'</c><para/>
		///		[<c>RemoteInstances</c>].[<c>RemoteUserId</c>] &#62;&#62;&#62;&#62; [<c>RemoteUsers</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK__RemoteIns__Remot__19DFD96B", PkTable = "RemoteUsers", PkColumn = "Id", FkTable = "RemoteInstances", FkColumn = "RemoteUserId")]
		[DebuggerStepThrough]
		public ContractCollection<RemoteInstance> Find_By_RemoteUserId(Guid? remoteUserId)
		{
			if (remoteUserId == null)
				return null;
			CsWeakReference<ContractCollection<RemoteInstance>> weak;
			ContractCollection<RemoteInstance> result;
		
			if (_byRemoteUserId.TryGetValue(remoteUserId, out weak) && weak.TryGetTarget(out result))
				return result;
		
		
			result = CreateContractCollection(@remoteInstance => Equals(@remoteInstance.RemoteUserId, remoteUserId));
		
		    if (weak == null)
				_byRemoteUserId.Add(remoteUserId, weak = new CsWeakReference<ContractCollection<RemoteInstance>>(result));
			else
				weak.SetTarget(result);
		
			return result;
		}
		#endregion
		
		
		/// <summary>Creates a row then copy's the data from the <paramref name="item"/> and adds it to the row collection.</summary>
		public RemoteInstance AddAsNewRow(IRemoteInstance item)
		{
			var row = NewRow();
			row.Copy_From(item, true);
			Add(row);
			return row;
		}
	}
}