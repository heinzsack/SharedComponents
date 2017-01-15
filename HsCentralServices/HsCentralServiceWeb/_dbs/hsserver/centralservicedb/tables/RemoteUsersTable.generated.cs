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
using RemoteUser=HsCentralServiceWeb._dbs.hsserver.centralservicedb.rows.RemoteUser;
using IRemoteUser=HsCentralServiceWeb._dbs.hsserver.centralservicedb.rowinterfaces.IRemoteUser;
using HsCentralServiceWeb._dbs.hsserver;






namespace HsCentralServiceWeb._dbs.hsserver.centralservicedb.tables
{
	#pragma warning disable 657
	#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	
	///	<summary>
	///		'[<c>HsServer</c>].[<c>#CentralServiceDb#</c>].[<c>RemoteUsers</c>]': A Table inside '[<c>HsServer</c>].[<c>#CentralServiceDb#</c>]' database with '<see cref="RemoteUser"/>' as <see cref="DataRow"/>.<para/>
	///		[<c>RemoteUsers</c>].[<c>RemoteComputerId</c>] &#62;&#62;&#62;&#62; [<c>RemoteComputers</c>].[<c>Id</c>]<para/>
	///		[<c>RemoteUsers</c>].[<c>Id</c>] &#60;&#60;&#60;&#60; [<c>RemoteInstances</c>].[<c>RemoteUserId</c>]
	///	</summary>
	[Serializable]
	[DebuggerDisplay("DataTable(CentralServiceDb.RemoteUsers): Rows[{Rows.Count}]")]
	[CsDbDataTable(Database = "CentralServiceDb", Name = "RemoteUsers", Generated = "17.01.15 00:09:46", Hash = "DB5B9C8CCF4FD11207D78614B4EEE026")]
	[CsDbResolvesRelation("FK__RemoteUse__Remot__18EBB532", PkTable = "RemoteComputers", PkColumn = "Id", FkTable = "RemoteUsers", FkColumn = "RemoteComputerId")]
	[CsDbResolvesRelation("FK__RemoteIns__Remot__19DFD96B", PkTable = "RemoteUsers", PkColumn = "Id", FkTable = "RemoteInstances", FkColumn = "RemoteUserId")]
	public partial class RemoteUsersTable : CsDbTable<RemoteUser>
	{
		#region CONSTANTS
		///<summary>The native table name (RemoteUsers).</summary>
		public const string NativeName = "RemoteUsers";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteUsers].[Id]</c> column. Property = <see cref="RemoteUser.Id"/>.</summary>
		public const string IdCol = "Id";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteUsers].[Sid]</c> column. Property = <see cref="RemoteUser.Sid"/>.</summary>
		public const string SidCol = "Sid";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteUsers].[Name]</c> column. Property = <see cref="RemoteUser.Name"/>.</summary>
		public const string NameCol = "Name";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteUsers].[FullName]</c> column. Property = <see cref="RemoteUser.FullName"/>.</summary>
		public const string FullNameCol = "FullName";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteUsers].[Domain]</c> column. Property = <see cref="RemoteUser.Domain"/>.</summary>
		public const string DomainCol = "Domain";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteUsers].[Description]</c> column. Property = <see cref="RemoteUser.Description"/>.</summary>
		public const string DescriptionCol = "Description";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteUsers].[Status]</c> column. Property = <see cref="RemoteUser.Status"/>.</summary>
		public const string StatusCol = "Status";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteUsers].[RemoteComputerId]</c> column. Property = <see cref="RemoteUser.RemoteComputerId"/>.</summary>
		public const string RemoteComputerIdCol = "RemoteComputerId";
	
		/// <summary> Contains attribute values for the columns</summary>
		public static class Cols
		{
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteUsers</c>].[<c>Id</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteUsers", Name = "Id", Type = "uniqueidentifier", Default = "(newid())", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute Id = new CsDbNativeDataColumnAttribute {Table = "RemoteUsers", Name = "Id", Type = "uniqueidentifier", Default = "(newid())", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteUsers</c>].[<c>Sid</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteUsers", Name = "Sid", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute Sid = new CsDbNativeDataColumnAttribute {Table = "RemoteUsers", Name = "Sid", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteUsers</c>].[<c>Name</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteUsers", Name = "Name", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute Name = new CsDbNativeDataColumnAttribute {Table = "RemoteUsers", Name = "Name", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteUsers</c>].[<c>FullName</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteUsers", Name = "FullName", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute FullName = new CsDbNativeDataColumnAttribute {Table = "RemoteUsers", Name = "FullName", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteUsers</c>].[<c>Domain</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteUsers", Name = "Domain", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute Domain = new CsDbNativeDataColumnAttribute {Table = "RemoteUsers", Name = "Domain", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteUsers</c>].[<c>Description</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteUsers", Name = "Description", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute Description = new CsDbNativeDataColumnAttribute {Table = "RemoteUsers", Name = "Description", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteUsers</c>].[<c>Status</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteUsers", Name = "Status", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute Status = new CsDbNativeDataColumnAttribute {Table = "RemoteUsers", Name = "Status", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteUsers</c>].[<c>RemoteComputerId</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteUsers", Name = "RemoteComputerId", Type = "uniqueidentifier", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute RemoteComputerId = new CsDbNativeDataColumnAttribute {Table = "RemoteUsers", Name = "RemoteComputerId", Type = "uniqueidentifier", IsNullable = "NO"};
		}
		#endregion
	
	
	
	
	
	
	
		///<summary>Default constructor for save <see cref="DataTable"/> operations</summary>
		public RemoteUsersTable()
		{
			TableName = NativeName;
		}
	
		///<summary>References the owning data context, this is equal to the database server. Use this to address databases on the same server.</summary>
		public new HsCentralServiceWeb._dbs.hsserver.HsServerContext DataContext => DataSet.DataContext;
	
		///<summary>References the owning dataset. Use this to address tables in the same database</summary>
		public new CentralServiceDb DataSet => (CentralServiceDb) base.DataSet;
	
	
	
	
	
	
	
		#region FUNC<Overrides>
		
		///	<summary><c>SELECT (DefaultSqlSelector) FROM [RemoteUsers]</c><para>The default selector is the * operator</para></summary>
		[DebuggerStepThrough] 
		public override void DownloadRows()
		{
			DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}]", false);
			HasBeenLoaded = true;
		}
		///	<summary><c>SELECT <paramref name="top"/> (DefaultSqlSelector) FROM [RemoteUsers]</c><para>The default selector is the * operator</para></summary>
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
		///		find an item in local data where Id = '<paramref name="id"/>'. If nothing is found QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [RemoteUsers] WHERE [Id] = '<paramref name="id"/>'</c>.<para/>
		///		If no primary key is set execute <see cref="LoadThenFind"/> instead.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK__RemoteUse__Remot__18EBB532", PkTable = "RemoteComputers", PkColumn = "Id", FkTable = "RemoteUsers", FkColumn = "RemoteComputerId")]
		[CsDbResolvesRelation("FK__RemoteIns__Remot__19DFD96B", PkTable = "RemoteUsers", PkColumn = "Id", FkTable = "RemoteInstances", FkColumn = "RemoteUserId")]
		[DebuggerStepThrough] 
		public RemoteUser FindOrLoad(Guid? id)
		{
			if (id == null)
				return null;
		
			if (PrimaryKey.Length == 0)
				return LoadThenFind(id);
		
			return Find(id) ?? LoadThenFind(id);
		}
		
		
		///<summary>
		///		QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [RemoteUsers] WHERE [Id] = '<paramref name="id"/>'</c> THEN find an item in local data where Id = '<paramref name="id"/>'.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///</summary>
		[CsDbResolvesRelation("FK__RemoteUse__Remot__18EBB532", PkTable = "RemoteComputers", PkColumn = "Id", FkTable = "RemoteUsers", FkColumn = "RemoteComputerId")]
		[CsDbResolvesRelation("FK__RemoteIns__Remot__19DFD96B", PkTable = "RemoteUsers", PkColumn = "Id", FkTable = "RemoteInstances", FkColumn = "RemoteUserId")]
		[DebuggerStepThrough] 
		public RemoteUser LoadThenFind(Guid? id)
		{
			if (id == null)
				return null;
		
			DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}] WHERE [Id] = '{id}'", false);
			
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
		
			return Rows.Find(id.Value) as RemoteUser;
		}
		
		
		///	<summary>
		///		find an item in local data where Id = '<paramref name="id"/>'. IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK__RemoteUse__Remot__18EBB532", PkTable = "RemoteComputers", PkColumn = "Id", FkTable = "RemoteUsers", FkColumn = "RemoteComputerId")]
		[CsDbResolvesRelation("FK__RemoteIns__Remot__19DFD96B", PkTable = "RemoteUsers", PkColumn = "Id", FkTable = "RemoteInstances", FkColumn = "RemoteUserId")]
		[DebuggerStepThrough] 
		public RemoteUser Find(Guid? id)
		{
			if (id == null)
				return null;
		
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
		
			return Rows.Find(id.Value) as RemoteUser;
		}
		#endregion
		
		#region FUNC<Primary Key Many>
		///	<summary>
		///		find items in local data where Id IN '<paramref name="ids"/>'. If nothing is found QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [RemoteUsers] WHERE [Id] IN '<paramref name="ids"/>'</c>.<para/>
		///		If no primary key is set execute <see cref="LoadThenFind_Each"/> instead.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK__RemoteUse__Remot__18EBB532", PkTable = "RemoteComputers", PkColumn = "Id", FkTable = "RemoteUsers", FkColumn = "RemoteComputerId")]
		[CsDbResolvesRelation("FK__RemoteIns__Remot__19DFD96B", PkTable = "RemoteUsers", PkColumn = "Id", FkTable = "RemoteInstances", FkColumn = "RemoteUserId")]
		[DebuggerStepThrough] 
		public RemoteUser[] FindOrLoad_Each(params Guid[] ids)
		{
			if (ids == null || ids.Length == 0)
				return new RemoteUser[0];
		
			if (PrimaryKey.Length == 0)
				return LoadThenFind_Each(ids);
				
			var locallyFound = Find_Each(ids);
			var loaded = LoadThenFind_Each(ids.Except(locallyFound.Select(x=>x.Id)).ToArray());
			return locallyFound.Union(loaded).ToArray();
		}
		
		
		///<summary>
		///		QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [RemoteUsers] WHERE [Id] IN '<paramref name="ids"/>'</c> THEN find items in local data where Id IN '<paramref name="ids"/>'.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///</summary>
		[CsDbResolvesRelation("FK__RemoteUse__Remot__18EBB532", PkTable = "RemoteComputers", PkColumn = "Id", FkTable = "RemoteUsers", FkColumn = "RemoteComputerId")]
		[CsDbResolvesRelation("FK__RemoteIns__Remot__19DFD96B", PkTable = "RemoteUsers", PkColumn = "Id", FkTable = "RemoteInstances", FkColumn = "RemoteUserId")]
		[DebuggerStepThrough] 
		public RemoteUser[] LoadThenFind_Each(params Guid[] ids)
		{
			if (ids == null || ids.Length == 0)
				return new RemoteUser[0];
		
			DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}] WHERE [Id] IN ('{ids.Select(x=>x.ToString()).Join("', '")}')", false);
			
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
		
			return Find_Each(ids);
		}
		
		
		///	<summary>
		///		find items in local data where Id IN '<paramref name="ids"/>'. IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK__RemoteUse__Remot__18EBB532", PkTable = "RemoteComputers", PkColumn = "Id", FkTable = "RemoteUsers", FkColumn = "RemoteComputerId")]
		[CsDbResolvesRelation("FK__RemoteIns__Remot__19DFD96B", PkTable = "RemoteUsers", PkColumn = "Id", FkTable = "RemoteInstances", FkColumn = "RemoteUserId")]
		[DebuggerStepThrough] 
		public RemoteUser[] Find_Each(params Guid[] ids)
		{
			if (ids == null || ids.Length == 0)
				return new RemoteUser[0];
		
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
				
			return Select(ids.Select(key=>$"{IdCol} = '{key}'").Join(" OR "));
		}
		#endregion
		
		
		
		
		
		#region FUNC<Foreign Key>
		[field:NonSerialized] private Dictionary<Guid?, CsWeakReference<ContractCollection<RemoteUser>>> _byRemoteComputerId = new Dictionary<Guid?, CsWeakReference<ContractCollection<RemoteUser>>>();
		
		///	<summary> 
		///		Query <c>SELECT (DefaultSqlSelector) FROM RemoteUsers WHERE [RemoteComputerId] = '<paramref name="remoteComputerId"/>'</c><para/>
		///		[<c>RemoteUsers</c>].[<c>RemoteComputerId</c>] &#62;&#62;&#62;&#62; [<c>RemoteComputers</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK__RemoteUse__Remot__18EBB532", PkTable = "RemoteComputers", PkColumn = "Id", FkTable = "RemoteUsers", FkColumn = "RemoteComputerId")]
		[DebuggerStepThrough]
		public ContractCollection<RemoteUser> FindOrLoad_By_RemoteComputerId(Guid? remoteComputerId)
		{
			if (remoteComputerId == null)
				return null;
			CsWeakReference<ContractCollection<RemoteUser>> weak;
			ContractCollection<RemoteUser> result;
		
			if (_byRemoteComputerId.TryGetValue(remoteComputerId, out weak) && weak.TryGetTarget(out result))
				return result;
		
			if (HasBeenLoaded == true || weak != null)
				result = CreateContractCollection(@remoteUser => Equals(@remoteUser.RemoteComputerId, remoteComputerId));
			else 
			{
				DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}] WHERE [{RemoteComputerIdCol}] = '{remoteComputerId}'", false);
				result = CreateContractCollection(@remoteUser => Equals(@remoteUser.RemoteComputerId, remoteComputerId));
			}
		
			if (weak == null)
				_byRemoteComputerId.Add(remoteComputerId, weak = new CsWeakReference<ContractCollection<RemoteUser>>(result));
			else
				weak.SetTarget(result);
		
			return result;
		}
		///	<summary> 
		///		Query <c>SELECT (DefaultSqlSelector) FROM RemoteUsers WHERE [RemoteComputerId] = '<paramref name="remoteComputerId"/>'</c><para/>
		///		[<c>RemoteUsers</c>].[<c>RemoteComputerId</c>] &#62;&#62;&#62;&#62; [<c>RemoteComputers</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK__RemoteUse__Remot__18EBB532", PkTable = "RemoteComputers", PkColumn = "Id", FkTable = "RemoteUsers", FkColumn = "RemoteComputerId")]
		[DebuggerStepThrough] 
		public ContractCollection<RemoteUser> LoadThenFind_By_RemoteComputerId(Guid? remoteComputerId)
		{
			if (remoteComputerId == null)
				return null;
			CsWeakReference<ContractCollection<RemoteUser>> weak;
			ContractCollection<RemoteUser> result;
		
			DownloadRows($"SELECT {DefaultSqlSelector} FROM {NativeName} WHERE [{RemoteComputerIdCol}] = '{remoteComputerId}'", false);
		
			if (_byRemoteComputerId.TryGetValue(remoteComputerId, out weak) && weak.TryGetTarget(out result))
				return result;
		
			result = CreateContractCollection(@remoteUser => Equals(@remoteUser.RemoteComputerId, remoteComputerId));
		
			if (weak == null)
				_byRemoteComputerId.Add(remoteComputerId, weak = new CsWeakReference<ContractCollection<RemoteUser>>(result));
			else
				weak.SetTarget(result);
		
			return result;
		}
		///	<summary> 
		///		Query <c>SELECT (DefaultSqlSelector) FROM RemoteUsers WHERE [RemoteComputerId] = '<paramref name="remoteComputerId"/>'</c><para/>
		///		[<c>RemoteUsers</c>].[<c>RemoteComputerId</c>] &#62;&#62;&#62;&#62; [<c>RemoteComputers</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK__RemoteUse__Remot__18EBB532", PkTable = "RemoteComputers", PkColumn = "Id", FkTable = "RemoteUsers", FkColumn = "RemoteComputerId")]
		[DebuggerStepThrough]
		public ContractCollection<RemoteUser> Find_By_RemoteComputerId(Guid? remoteComputerId)
		{
			if (remoteComputerId == null)
				return null;
			CsWeakReference<ContractCollection<RemoteUser>> weak;
			ContractCollection<RemoteUser> result;
		
			if (_byRemoteComputerId.TryGetValue(remoteComputerId, out weak) && weak.TryGetTarget(out result))
				return result;
		
		
			result = CreateContractCollection(@remoteUser => Equals(@remoteUser.RemoteComputerId, remoteComputerId));
		
		    if (weak == null)
				_byRemoteComputerId.Add(remoteComputerId, weak = new CsWeakReference<ContractCollection<RemoteUser>>(result));
			else
				weak.SetTarget(result);
		
			return result;
		}
		#endregion
		
		
		/// <summary>Creates a row then copy's the data from the <paramref name="item"/> and adds it to the row collection.</summary>
		public RemoteUser AddAsNewRow(IRemoteUser item)
		{
			var row = NewRow();
			row.Copy_From(item, true);
			Add(row);
			return row;
		}
	}
}