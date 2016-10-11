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
//<date>2016-10-11 19:18:25</date>



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
using RemoteRingPlayerManagement=HsCentralServiceWeb._dbs.hsserver.centralservicedb.rows.RemoteRingPlayerManagement;
using IRemoteRingPlayerManagement=HsCentralServiceWeb._dbs.hsserver.centralservicedb.rowinterfaces.IRemoteRingPlayerManagement;
using HsCentralServiceWeb._dbs.hsserver;






namespace HsCentralServiceWeb._dbs.hsserver.centralservicedb.tables
{
	#pragma warning disable 657
	#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	
	///	<summary>
	///		'[<c>HsServer</c>].[<c>#CentralServiceDb#</c>].[<c>RemoteRingPlayerManagements</c>]': A Table inside '[<c>HsServer</c>].[<c>#CentralServiceDb#</c>]' database with '<see cref="RemoteRingPlayerManagement"/>' as <see cref="DataRow"/>.<para/>
	///		[<c>RemoteRingPlayerManagements</c>].[<c>RemoteInstanceId</c>] &#62;&#62;&#62;&#62; [<c>RemoteInstances</c>].[<c>Id</c>]
	///	</summary>
	[Serializable]
	[DebuggerStepThrough]
	[DebuggerDisplay("DataTable(CentralServiceDb.RemoteRingPlayerManagements): Rows[{Rows.Count}]")]
	[CsDbDataTable(Database = "CentralServiceDb", Name = "RemoteRingPlayerManagements", Generated = "16.10.11 19:18:25", Hash = "52879CCAD000DBC7BA671511582D57F4")]
	[CsDbResolvesRelation("FK_RemoteRingPlayerInstanceArgs_RemoteInstances", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteRingPlayerManagements", FkColumn = "RemoteInstanceId")]
	public partial class RemoteRingPlayerManagementsTable : CsDbTable<RemoteRingPlayerManagement>
	{
		#region CONSTANTS
		///<summary>The native table name (RemoteRingPlayerManagements).</summary>
		public const string NativeName = "RemoteRingPlayerManagements";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteRingPlayerManagements].[Id]</c> column. Property = <see cref="RemoteRingPlayerManagement.Id"/>.</summary>
		public const string IdCol = "Id";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteRingPlayerManagements].[RemoteInstanceId]</c> column. Property = <see cref="RemoteRingPlayerManagement.RemoteInstanceId"/>.</summary>
		public const string RemoteInstanceIdCol = "RemoteInstanceId";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteRingPlayerManagements].[LastUpdated]</c> column. Property = <see cref="RemoteRingPlayerManagement.LastUpdated"/>.</summary>
		public const string LastUpdatedCol = "LastUpdated";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteRingPlayerManagements].[LatestGeneratedRingId]</c> column. Property = <see cref="RemoteRingPlayerManagement.LatestGeneratedRingId"/>.</summary>
		public const string LatestGeneratedRingIdCol = "LatestGeneratedRingId";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteRingPlayerManagements].[LatestTransmittedRingId]</c> column. Property = <see cref="RemoteRingPlayerManagement.LatestTransmittedRingId"/>.</summary>
		public const string LatestTransmittedRingIdCol = "LatestTransmittedRingId";
	
		/// <summary> Contains attribute values for the columns</summary>
		public static class Cols
		{
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteRingPlayerManagements</c>].[<c>Id</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteRingPlayerManagements", Name = "Id", Type = "uniqueidentifier", Default = "(newid())", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute Id = new CsDbNativeDataColumnAttribute {Table = "RemoteRingPlayerManagements", Name = "Id", Type = "uniqueidentifier", Default = "(newid())", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteRingPlayerManagements</c>].[<c>RemoteInstanceId</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteRingPlayerManagements", Name = "RemoteInstanceId", Type = "uniqueidentifier", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute RemoteInstanceId = new CsDbNativeDataColumnAttribute {Table = "RemoteRingPlayerManagements", Name = "RemoteInstanceId", Type = "uniqueidentifier", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteRingPlayerManagements</c>].[<c>LastUpdated</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteRingPlayerManagements", Name = "LastUpdated", Type = "datetime2", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute LastUpdated = new CsDbNativeDataColumnAttribute {Table = "RemoteRingPlayerManagements", Name = "LastUpdated", Type = "datetime2", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteRingPlayerManagements</c>].[<c>LatestGeneratedRingId</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteRingPlayerManagements", Name = "LatestGeneratedRingId", Type = "int", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute LatestGeneratedRingId = new CsDbNativeDataColumnAttribute {Table = "RemoteRingPlayerManagements", Name = "LatestGeneratedRingId", Type = "int", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteRingPlayerManagements</c>].[<c>LatestTransmittedRingId</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteRingPlayerManagements", Name = "LatestTransmittedRingId", Type = "int", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute LatestTransmittedRingId = new CsDbNativeDataColumnAttribute {Table = "RemoteRingPlayerManagements", Name = "LatestTransmittedRingId", Type = "int", IsNullable = "YES"};
		}
		#endregion
	
	
	
	
	
	
	
		///<summary>Default constructor for save <see cref="DataTable"/> operations</summary>
		public RemoteRingPlayerManagementsTable()
		{
			TableName = NativeName;
		}
	
		///<summary>References the owning data context, this is equal to the database server. Use this to address databases on the same server.</summary>
		public new HsCentralServiceWeb._dbs.hsserver.HsServerContext DataContext => DataSet.DataContext;
	
		///<summary>References the owning dataset. Use this to address tables in the same database</summary>
		public new CentralServiceDb DataSet => (CentralServiceDb) base.DataSet;
	
	
	
	
	
	
	
		#region FUNC<Overrides>
		
		///	<summary><c>SELECT (DefaultSqlSelector) FROM [RemoteRingPlayerManagements]</c><para>The default selector is the * operator</para></summary>
		public override void DownloadRows()
		{
			DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}]", false);
			HasBeenLoaded = true;
		}
		///	<summary><c>SELECT <paramref name="top"/> (DefaultSqlSelector) FROM [RemoteRingPlayerManagements]</c><para>The default selector is the * operator</para></summary>
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
		///		find an item in local data where Id = '<paramref name="id"/>'. If nothing is found QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [RemoteRingPlayerManagements] WHERE [Id] = '<paramref name="id"/>'</c>.<para/>
		///		If no primary key is set execute <see cref="LoadThenFind"/> instead.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK_RemoteRingPlayerInstanceArgs_RemoteInstances", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteRingPlayerManagements", FkColumn = "RemoteInstanceId")]
		public RemoteRingPlayerManagement FindOrLoad(Guid? id)
		{
			if (id == null)
				return null;
		
			if (PrimaryKey.Length == 0)
				return LoadThenFind(id);
		
			return Find(id) ?? LoadThenFind(id);
		}
		
		
		///<summary>
		///		QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [RemoteRingPlayerManagements] WHERE [Id] = '<paramref name="id"/>'</c> THEN find an item in local data where Id = '<paramref name="id"/>'.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///</summary>
		[CsDbResolvesRelation("FK_RemoteRingPlayerInstanceArgs_RemoteInstances", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteRingPlayerManagements", FkColumn = "RemoteInstanceId")]
		public RemoteRingPlayerManagement LoadThenFind(Guid? id)
		{
			if (id == null)
				return null;
		
			DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}] WHERE [Id] = '{id}'", false);
			
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
		
			return Rows.Find(id.Value) as RemoteRingPlayerManagement;
		}
		
		
		///	<summary>
		///		find an item in local data where Id = '<paramref name="id"/>'. IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK_RemoteRingPlayerInstanceArgs_RemoteInstances", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteRingPlayerManagements", FkColumn = "RemoteInstanceId")]
		public RemoteRingPlayerManagement Find(Guid? id)
		{
			if (id == null)
				return null;
		
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
		
			return Rows.Find(id.Value) as RemoteRingPlayerManagement;
		}
		#endregion
		
		#region FUNC<Primary Key Many>
		///	<summary>
		///		find items in local data where Id IN '<paramref name="ids"/>'. If nothing is found QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [RemoteRingPlayerManagements] WHERE [Id] IN '<paramref name="ids"/>'</c>.<para/>
		///		If no primary key is set execute <see cref="LoadThenFind_Each"/> instead.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK_RemoteRingPlayerInstanceArgs_RemoteInstances", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteRingPlayerManagements", FkColumn = "RemoteInstanceId")]
		public RemoteRingPlayerManagement[] FindOrLoad_Each(params Guid[] ids)
		{
			if (ids == null || ids.Length == 0)
				return new RemoteRingPlayerManagement[0];
		
			if (PrimaryKey.Length == 0)
				return LoadThenFind_Each(ids);
				
			var locallyFound = Find_Each(ids);
			var loaded = LoadThenFind_Each(ids.Except(locallyFound.Select(x=>x.Id)).ToArray());
			return locallyFound.Union(loaded).ToArray();
		}
		
		
		///<summary>
		///		QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [RemoteRingPlayerManagements] WHERE [Id] IN '<paramref name="ids"/>'</c> THEN find items in local data where Id IN '<paramref name="ids"/>'.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///</summary>
		[CsDbResolvesRelation("FK_RemoteRingPlayerInstanceArgs_RemoteInstances", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteRingPlayerManagements", FkColumn = "RemoteInstanceId")]
		public RemoteRingPlayerManagement[] LoadThenFind_Each(params Guid[] ids)
		{
			if (ids == null || ids.Length == 0)
				return new RemoteRingPlayerManagement[0];
		
			DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}] WHERE [Id] IN ('{ids.Select(x=>x.ToString()).Join("', '")}')", false);
			
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
		
			return Find_Each(ids);
		}
		
		
		///	<summary>
		///		find items in local data where Id IN '<paramref name="ids"/>'. IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK_RemoteRingPlayerInstanceArgs_RemoteInstances", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteRingPlayerManagements", FkColumn = "RemoteInstanceId")]
		public RemoteRingPlayerManagement[] Find_Each(params Guid[] ids)
		{
			if (ids == null || ids.Length == 0)
				return new RemoteRingPlayerManagement[0];
		
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
				
			return Select(ids.Select(key=>$"{IdCol} = '{key}'").Join(" OR "));
		}
		#endregion
		
		
		
		
		
		#region FUNC<Foreign Key>
		[field:NonSerialized] private Dictionary<Guid?, CsWeakReference<ContractCollection<RemoteRingPlayerManagement>>> _byRemoteInstanceId = new Dictionary<Guid?, CsWeakReference<ContractCollection<RemoteRingPlayerManagement>>>();
		
		///	<summary> 
		///		Query <c>SELECT (DefaultSqlSelector) FROM RemoteRingPlayerManagements WHERE [RemoteInstanceId] = '<paramref name="remoteInstanceId"/>'</c><para/>
		///		[<c>RemoteRingPlayerManagements</c>].[<c>RemoteInstanceId</c>] &#62;&#62;&#62;&#62; [<c>RemoteInstances</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK_RemoteRingPlayerInstanceArgs_RemoteInstances", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteRingPlayerManagements", FkColumn = "RemoteInstanceId")]
		public ContractCollection<RemoteRingPlayerManagement> FindOrLoad_By_RemoteInstanceId(Guid? remoteInstanceId)
		{
			if (remoteInstanceId == null)
				return null;
			CsWeakReference<ContractCollection<RemoteRingPlayerManagement>> weak;
			ContractCollection<RemoteRingPlayerManagement> result;
		
			if (_byRemoteInstanceId.TryGetValue(remoteInstanceId, out weak) && weak.TryGetTarget(out result))
				return result;
		
			if (HasBeenLoaded == true || weak != null)
				result = CreateContractCollection(@remoteRingPlayerManagement => Equals(@remoteRingPlayerManagement.RemoteInstanceId, remoteInstanceId));
			else 
			{
				DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}] WHERE [{RemoteInstanceIdCol}] = '{remoteInstanceId}'", false);
				result = CreateContractCollection(@remoteRingPlayerManagement => Equals(@remoteRingPlayerManagement.RemoteInstanceId, remoteInstanceId));
			}
		
			if (weak == null)
				_byRemoteInstanceId.Add(remoteInstanceId, weak = new CsWeakReference<ContractCollection<RemoteRingPlayerManagement>>(result));
			else
				weak.SetTarget(result);
		
			return result;
		}
		///	<summary> 
		///		Query <c>SELECT (DefaultSqlSelector) FROM RemoteRingPlayerManagements WHERE [RemoteInstanceId] = '<paramref name="remoteInstanceId"/>'</c><para/>
		///		[<c>RemoteRingPlayerManagements</c>].[<c>RemoteInstanceId</c>] &#62;&#62;&#62;&#62; [<c>RemoteInstances</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK_RemoteRingPlayerInstanceArgs_RemoteInstances", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteRingPlayerManagements", FkColumn = "RemoteInstanceId")]
		public ContractCollection<RemoteRingPlayerManagement> LoadThenFind_By_RemoteInstanceId(Guid? remoteInstanceId)
		{
			if (remoteInstanceId == null)
				return null;
			CsWeakReference<ContractCollection<RemoteRingPlayerManagement>> weak;
			ContractCollection<RemoteRingPlayerManagement> result;
		
			DownloadRows($"SELECT {DefaultSqlSelector} FROM {NativeName} WHERE [{RemoteInstanceIdCol}] = '{remoteInstanceId}'", false);
		
			if (_byRemoteInstanceId.TryGetValue(remoteInstanceId, out weak) && weak.TryGetTarget(out result))
				return result;
		
			result = CreateContractCollection(@remoteRingPlayerManagement => Equals(@remoteRingPlayerManagement.RemoteInstanceId, remoteInstanceId));
		
			if (weak == null)
				_byRemoteInstanceId.Add(remoteInstanceId, weak = new CsWeakReference<ContractCollection<RemoteRingPlayerManagement>>(result));
			else
				weak.SetTarget(result);
		
			return result;
		}
		///	<summary> 
		///		Query <c>SELECT (DefaultSqlSelector) FROM RemoteRingPlayerManagements WHERE [RemoteInstanceId] = '<paramref name="remoteInstanceId"/>'</c><para/>
		///		[<c>RemoteRingPlayerManagements</c>].[<c>RemoteInstanceId</c>] &#62;&#62;&#62;&#62; [<c>RemoteInstances</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK_RemoteRingPlayerInstanceArgs_RemoteInstances", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteRingPlayerManagements", FkColumn = "RemoteInstanceId")]
		public ContractCollection<RemoteRingPlayerManagement> Find_By_RemoteInstanceId(Guid? remoteInstanceId)
		{
			if (remoteInstanceId == null)
				return null;
			CsWeakReference<ContractCollection<RemoteRingPlayerManagement>> weak;
			ContractCollection<RemoteRingPlayerManagement> result;
		
			if (_byRemoteInstanceId.TryGetValue(remoteInstanceId, out weak) && weak.TryGetTarget(out result))
				return result;
		
		
			result = CreateContractCollection(@remoteRingPlayerManagement => Equals(@remoteRingPlayerManagement.RemoteInstanceId, remoteInstanceId));
		
		    if (weak == null)
				_byRemoteInstanceId.Add(remoteInstanceId, weak = new CsWeakReference<ContractCollection<RemoteRingPlayerManagement>>(result));
			else
				weak.SetTarget(result);
		
			return result;
		}
		#endregion
		
		
		/// <summary>Creates a row then copy's the data from the <paramref name="item"/> and adds it to the row collection.</summary>
		public RemoteRingPlayerManagement AddAsNewRow(IRemoteRingPlayerManagement item)
		{
			var row = NewRow();
			row.Copy_From(item, true);
			Add(row);
			return row;
		}
	}
}