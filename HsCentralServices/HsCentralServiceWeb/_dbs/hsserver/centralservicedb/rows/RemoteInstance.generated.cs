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
using HsCentralServiceWeb._dbs.hsserver.centralservicedb.tables;
using HsCentralServiceWeb._dbs.hsserver.centralservicedb.rowinterfaces;
using HsCentralServiceWeb._dbs.hsserver.centralservicedb.rowpocos;






namespace HsCentralServiceWeb._dbs.hsserver.centralservicedb.rows
{
	#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	
	///<summary>DataRow([<c>CentralServiceDb</c>].[<c>RemoteInstances</c>]): row model of <see cref="RemoteInstancesTable"/>.</summary>
	[Serializable]
	[DebuggerDisplay("DataRow(CentralServiceDb.RemoteInstances): Id = '{Id}'")]
	[CsDbDataRow(Database = "CentralServiceDb", TableName = "RemoteInstances", Generated = "17.01.21 17:31:31", Hash = "D3B49FBFD6DB0ACD53CDFF01725ABC06")]
	public partial class RemoteInstance : CsDbTableRow, IRemoteInstance
	{
		#region statics
		private static Dictionary<string, System.Reflection.PropertyInfo> _nativeColumnName_To_Property;
		public static Dictionary<string, System.Reflection.PropertyInfo> NativeColumnName_To_Property
		{
			get
			{
				if (_nativeColumnName_To_Property != null)
					return _nativeColumnName_To_Property;
		
				var type = typeof(IRemoteInstance);
				_nativeColumnName_To_Property = new Dictionary<string, System.Reflection.PropertyInfo>
				{
					{ RemoteInstancesTable.IdCol, type.GetProperty(nameof(Id)) },
					{ RemoteInstancesTable.ProcessFileCol, type.GetProperty(nameof(ProcessFile)) },
					{ RemoteInstancesTable.FirstExecutionTimeCol, type.GetProperty(nameof(FirstExecutionTime)) },
					{ RemoteInstancesTable.LastExecutionTimeCol, type.GetProperty(nameof(LastExecutionTime)) },
					{ RemoteInstancesTable.UnsignedStartupCountCol, type.GetProperty(nameof(UnsignedStartupCount)) },
					{ RemoteInstancesTable.TicksUseageTimeCol, type.GetProperty(nameof(TicksUseageTime)) },
					{ RemoteInstancesTable.VersionCol, type.GetProperty(nameof(Version)) },
					{ RemoteInstancesTable.CreatedCol, type.GetProperty(nameof(Created)) },
					{ RemoteInstancesTable.LastSeenCol, type.GetProperty(nameof(LastSeen)) },
					{ RemoteInstancesTable.RemoteUserIdCol, type.GetProperty(nameof(RemoteUserId)) },
					{ RemoteInstancesTable.RemoteApplicationIdCol, type.GetProperty(nameof(RemoteApplicationId)) }
				};
		
				return _nativeColumnName_To_Property;
			}
		}
		#endregion
	
	
		public RemoteInstance(DataRowBuilder builder) : base(builder){}
	
		
		///<summary>References the owning data context, this is equal to the database server. Use this to address databases on the same server.</summary>
		public new HsCentralServiceWeb._dbs.hsserver.HsServerContext DataContext => Table.DataContext;
	
		///<summary>References the owning dataset. Use this to address tables in the same database</summary>
		public new CentralServiceDb DataSet => Table.DataSet;
	
		///	<summary>Gets the owning table of type <see cref="RemoteInstancesTable"/>.</summary>
		public new RemoteInstancesTable Table => (RemoteInstancesTable) base.Table;
	
	
	
	
		#region COLUMNS
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteInstances</c>].[<c>Id</c>] (Type = <c>uniqueidentifier</c>, Default = '<c>(newid())</c>')
		///</summary>
		[CsDbDataColumn(Default = "Guid.NewGuid()")]
		[CsDbNativeDataColumn(Table = "RemoteInstances", Name = "Id", Type = "uniqueidentifier", Default = "(newid())", IsNullable = "NO")]
		public Guid Id
		{
			[DebuggerStepThrough] get { return GetDbValue<Guid>(RemoteInstancesTable.IdCol); }
			[DebuggerStepThrough] set { SetDbValue(value, RemoteInstancesTable.IdCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteInstances</c>].[<c>ProcessFile</c>] (Type = <c>nvarchar</c>, <c>NULLABLE</c>, MaxLength = <c>-1</c>)
		///</summary>
		[CsDbDataColumn(IsNullable = true)]
		[CsDbNativeDataColumn(Table = "RemoteInstances", Name = "ProcessFile", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES")]
		public String ProcessFile
		{
			[DebuggerStepThrough] get { return GetDbValue<String>(RemoteInstancesTable.ProcessFileCol); }
			[DebuggerStepThrough] set { SetDbValue(value, RemoteInstancesTable.ProcessFileCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteInstances</c>].[<c>FirstExecutionTime</c>] (Type = <c>datetime2</c>, <c>NULLABLE</c>)
		///</summary>
		[CsDbDataColumn(IsNullable = true)]
		[CsDbNativeDataColumn(Table = "RemoteInstances", Name = "FirstExecutionTime", Type = "datetime2", IsNullable = "YES")]
		public DateTime? FirstExecutionTime
		{
			[DebuggerStepThrough] get { return GetDbValue<DateTime?>(RemoteInstancesTable.FirstExecutionTimeCol); }
			[DebuggerStepThrough] set { SetDbValue(value, RemoteInstancesTable.FirstExecutionTimeCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteInstances</c>].[<c>LastExecutionTime</c>] (Type = <c>datetime2</c>, <c>NULLABLE</c>)
		///</summary>
		[CsDbDataColumn(IsNullable = true)]
		[CsDbNativeDataColumn(Table = "RemoteInstances", Name = "LastExecutionTime", Type = "datetime2", IsNullable = "YES")]
		public DateTime? LastExecutionTime
		{
			[DebuggerStepThrough] get { return GetDbValue<DateTime?>(RemoteInstancesTable.LastExecutionTimeCol); }
			[DebuggerStepThrough] set { SetDbValue(value, RemoteInstancesTable.LastExecutionTimeCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteInstances</c>].[<c>Unsigned_StartupCount</c>] (Type = <c>int</c>, <c>NULLABLE</c>)
		///</summary>
		[CsDbDataColumn(IsNullable = true)]
		[CsDbNativeDataColumn(Table = "RemoteInstances", Name = "Unsigned_StartupCount", Type = "int", IsNullable = "YES")]
		public Int32? UnsignedStartupCount
		{
			[DebuggerStepThrough] get { return GetDbValue<Int32?>(RemoteInstancesTable.UnsignedStartupCountCol); }
			[DebuggerStepThrough] set { SetDbValue(value, RemoteInstancesTable.UnsignedStartupCountCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteInstances</c>].[<c>Ticks_UseageTime</c>] (Type = <c>bigint</c>, <c>NULLABLE</c>)
		///</summary>
		[CsDbDataColumn(IsNullable = true)]
		[CsDbNativeDataColumn(Table = "RemoteInstances", Name = "Ticks_UseageTime", Type = "bigint", IsNullable = "YES")]
		public Int64? TicksUseageTime
		{
			[DebuggerStepThrough] get { return GetDbValue<Int64?>(RemoteInstancesTable.TicksUseageTimeCol); }
			[DebuggerStepThrough] set { SetDbValue(value, RemoteInstancesTable.TicksUseageTimeCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteInstances</c>].[<c>Version</c>] (Type = <c>nvarchar</c>, <c>NULLABLE</c>, MaxLength = <c>-1</c>)
		///</summary>
		[CsDbDataColumn(IsNullable = true)]
		[CsDbNativeDataColumn(Table = "RemoteInstances", Name = "Version", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES")]
		public String Version
		{
			[DebuggerStepThrough] get { return GetDbValue<String>(RemoteInstancesTable.VersionCol); }
			[DebuggerStepThrough] set { SetDbValue(value, RemoteInstancesTable.VersionCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteInstances</c>].[<c>Created</c>] (Type = <c>datetime2</c>)
		///</summary>
		[CsDbDataColumn]
		[CsDbNativeDataColumn(Table = "RemoteInstances", Name = "Created", Type = "datetime2", IsNullable = "NO")]
		public DateTime Created
		{
			[DebuggerStepThrough] get { return GetDbValue<DateTime>(RemoteInstancesTable.CreatedCol); }
			[DebuggerStepThrough] set { SetDbValue(value, RemoteInstancesTable.CreatedCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteInstances</c>].[<c>LastSeen</c>] (Type = <c>datetime2</c>)
		///</summary>
		[CsDbDataColumn]
		[CsDbNativeDataColumn(Table = "RemoteInstances", Name = "LastSeen", Type = "datetime2", IsNullable = "NO")]
		public DateTime LastSeen
		{
			[DebuggerStepThrough] get { return GetDbValue<DateTime>(RemoteInstancesTable.LastSeenCol); }
			[DebuggerStepThrough] set { SetDbValue(value, RemoteInstancesTable.LastSeenCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteInstances</c>].[<c>RemoteUserId</c>] (Type = <c>uniqueidentifier</c>)
		///</summary>
		[CsDbDataColumn]
		[CsDbNativeDataColumn(Table = "RemoteInstances", Name = "RemoteUserId", Type = "uniqueidentifier", IsNullable = "NO")]
		public Guid RemoteUserId
		{
			[DebuggerStepThrough] get { return GetDbValue<Guid>(RemoteInstancesTable.RemoteUserIdCol); }
			[DebuggerStepThrough] set { SetDbValue(value, RemoteInstancesTable.RemoteUserIdCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteInstances</c>].[<c>RemoteApplicationId</c>] (Type = <c>uniqueidentifier</c>)
		///</summary>
		[CsDbDataColumn]
		[CsDbNativeDataColumn(Table = "RemoteInstances", Name = "RemoteApplicationId", Type = "uniqueidentifier", IsNullable = "NO")]
		public Guid RemoteApplicationId
		{
			[DebuggerStepThrough] get { return GetDbValue<Guid>(RemoteInstancesTable.RemoteApplicationIdCol); }
			[DebuggerStepThrough] set { SetDbValue(value, RemoteInstancesTable.RemoteApplicationIdCol); }
		}
		
	
	
	
		#region Unsigned Extension
		///<summary>[<c>CentralServiceDb</c>].[<c>RemoteInstances</c>].[<c>Unsigned_StartupCount</c>] => Converts signed db version to unsigned version. Use this to set or get the unsigned value from db column."</summary>
		[DependsOn("UnsignedStartupCount")]
		public UInt32? StartupCount
		{
			[DebuggerStepThrough] get { return (UInt32?) UnsignedStartupCount; }
			[DebuggerStepThrough] set { UnsignedStartupCount = (Int32?) value; }
		}
		#endregion
		#endregion
	
	
	
	
	
		///	<summary>Reloads the <see cref="RemoteInstance"/> row by executing following command:<para/><c>$"SELECT * FROM RemoteInstances WHERE [Id] = '<see cref="Id"/>'</c></summary>
		public RemoteInstance Reload()
		{
			Table.DataSet.RemoteInstances.LoadThenFind(Id);
			return this;
		}
		
		
		
		
		#region PROPERTIES<Many to One>
		private RemoteApplication _remoteApplication;
		private RemoteUser _remoteUser;
		private ContractCollection<RemoteLog> _weakRemoteLogs;
		private ContractCollection<RemoteConnection> _weakRemoteConnections;
		public bool IsRemoteApplicationLoaded => (_remoteApplication == null || _remoteApplication.RowState != DataRowState.Detached) && Equals(_remoteApplication?.Id, RemoteApplicationId);
		public bool IsRemoteUserLoaded => (_remoteUser == null || _remoteUser.RowState != DataRowState.Detached) && Equals(_remoteUser?.Id, RemoteUserId);
		
		///	<summary>
		///		This field has cached Output.<para/>
		///		<c>SELECT * FROM RemoteApplications WHERE [Id] = '<paramref name="RemoteApplicationId"/>'</c><para/>[<c>RemoteInstances</c>].[<c>RemoteApplicationId</c>] &#62;&#62;&#62;&#62; [<c>RemoteApplications</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK__RemoteIns__Remot__1AD3FDA4", PkTable = "RemoteApplications", PkColumn = "Id", FkTable = "RemoteInstances", FkColumn = "RemoteApplicationId")][DependsOn("RemoteApplicationId")]
		public RemoteApplication RemoteApplication
		{
			[DebuggerStepThrough]
			get 
			{
				if (IsRemoteApplicationLoaded)
					return _remoteApplication;
				
				_remoteApplication = Table.DataSet.RemoteApplications.FindOrLoad(RemoteApplicationId);
				return _remoteApplication;
			}
			[DebuggerStepThrough]
			set 
			{
				if (value == null) throw new InvalidOperationException("The value cannot be null (FK: FK__RemoteIns__Remot__1AD3FDA4)");
				if (value != null && value.Table.DataSet != Table.DataSet) throw new InvalidOperationException("The owning data set have to be equal.");
				if (value == _remoteApplication) return;
		
				_remoteApplication = value;
		
				if (value == null)
					SetDbValue(default(Guid), RemoteInstancesTable.RemoteApplicationIdCol, "RemoteApplicationId");
				else
					SetDbValue(value.Id, RemoteInstancesTable.RemoteApplicationIdCol, "RemoteApplicationId");
			}
		}
		///	<summary>
		///		This field has cached Output.<para/>
		///		<c>SELECT * FROM RemoteUsers WHERE [Id] = '<paramref name="RemoteUserId"/>'</c><para/>[<c>RemoteInstances</c>].[<c>RemoteUserId</c>] &#62;&#62;&#62;&#62; [<c>RemoteUsers</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK__RemoteIns__Remot__19DFD96B", PkTable = "RemoteUsers", PkColumn = "Id", FkTable = "RemoteInstances", FkColumn = "RemoteUserId")][DependsOn("RemoteUserId")]
		public RemoteUser RemoteUser
		{
			[DebuggerStepThrough]
			get 
			{
				if (IsRemoteUserLoaded)
					return _remoteUser;
				
				_remoteUser = Table.DataSet.RemoteUsers.FindOrLoad(RemoteUserId);
				return _remoteUser;
			}
			[DebuggerStepThrough]
			set 
			{
				if (value == null) throw new InvalidOperationException("The value cannot be null (FK: FK__RemoteIns__Remot__19DFD96B)");
				if (value != null && value.Table.DataSet != Table.DataSet) throw new InvalidOperationException("The owning data set have to be equal.");
				if (value == _remoteUser) return;
		
				_remoteUser = value;
		
				if (value == null)
					SetDbValue(default(Guid), RemoteInstancesTable.RemoteUserIdCol, "RemoteUserId");
				else
					SetDbValue(value.Id, RemoteInstancesTable.RemoteUserIdCol, "RemoteUserId");
			}
		}
		#endregion
		
		
		
		
		
		#region PROPERTIES<One to Many>
		///	<summary>
		///		This field has cached Output. <para/>
		///		<c>SELECT * FROM RemoteLogs WHERE [RemoteInstanceId] = '<paramref name="Id"/>'</c><para/>[<c>RemoteInstances</c>].[<c>Id</c>] &#60;&#60;&#60;&#60; [<c>RemoteLogs</c>].[<c>RemoteInstanceId</c>]
		///	</summary>
		[CsDbResolvesRelation("FK__RemoteLog__Remot__1BC821DD", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteLogs", FkColumn = "RemoteInstanceId")]
		public ContractCollection<RemoteLog> RemoteLogs
		{
			[DebuggerStepThrough] get	{ return _weakRemoteLogs ?? (_weakRemoteLogs = Table.DataSet.RemoteLogs.FindOrLoad_By_RemoteInstanceId(Id)); }
		}
		///	<summary>
		///		This field has cached Output. <para/>
		///		<c>SELECT * FROM RemoteConnections WHERE [RemoteInstanceId] = '<paramref name="Id"/>'</c><para/>[<c>RemoteInstances</c>].[<c>Id</c>] &#60;&#60;&#60;&#60; [<c>RemoteConnections</c>].[<c>RemoteInstanceId</c>]
		///	</summary>
		[CsDbResolvesRelation("FK_RemoteConnections_RemoteInstances", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteConnections", FkColumn = "RemoteInstanceId")]
		public ContractCollection<RemoteConnection> RemoteConnections
		{
			[DebuggerStepThrough] get	{ return _weakRemoteConnections ?? (_weakRemoteConnections = Table.DataSet.RemoteConnections.FindOrLoad_By_RemoteInstanceId(Id)); }
		}
		#endregion
		
		
		
		
		
		#region FUNC<Overrides>
		protected void Invalidate()
		{
			if (!IsPropertyChangedHandled)
				return;
		
			OnPropertyChanged("Id");
			OnPropertyChanged("ProcessFile");
			OnPropertyChanged("FirstExecutionTime");
			OnPropertyChanged("LastExecutionTime");
			OnPropertyChanged("UnsignedStartupCount");
			OnPropertyChanged("TicksUseageTime");
			OnPropertyChanged("Version");
			OnPropertyChanged("Created");
			OnPropertyChanged("LastSeen");
			OnPropertyChanged("RemoteUserId");
			OnPropertyChanged("RemoteApplicationId");
		}
		///	<summary> Set all values which have default values inside the database to their defaults. This method is automatically invoked if you call <see cref="RemoteInstancesTable.NewRow"/>. </summary>
		public override void ApplyDefaults()
		{
			Id = Guid.NewGuid();
		}
		/// <summary>
		///     Loads the complete data bundle of the current row into a target data set.
		///     <para>A data bundle is defined as a set of all rows inside a database which are connected via relations.</para>
		///     <para>The currently selected row is the root of the bundle</para>
		/// </summary>
		public void Copy_BundledData_Into_DataSet(CentralServiceDb target)
		{
			base.Copy_BundledData_Into_DataSet(target);
		}
		
		
		/// <summary>
		///     Loads the complete data bundle of the current row into a new data set.
		///     <para>A data bundle is defined as a set of rows inside a database which are connected via relations.</para>
		///     <para>The currently selected row is the root of the bundle</para>
		/// </summary>
		public new CentralServiceDb Copy_BundledData_In_New_DataSet(bool cloneCompleteSchema = false)
		{
			return (CentralServiceDb) base.Copy_BundledData_In_New_DataSet(cloneCompleteSchema);
		}
		
		#endregion
		
		
		///	<summary> This method copy's each database field into the <paramref name="target"/> interface. </summary>
		public void Copy_To(IRemoteInstance target, bool includePrimaryKey = false)
		{
			if (includePrimaryKey) target.Id = this.Id;
			target.ProcessFile = this.ProcessFile;
			target.FirstExecutionTime = this.FirstExecutionTime;
			target.LastExecutionTime = this.LastExecutionTime;
			target.StartupCount = this.StartupCount;
			target.TicksUseageTime = this.TicksUseageTime;
			target.Version = this.Version;
			target.Created = this.Created;
			target.LastSeen = this.LastSeen;
			target.RemoteUserId = this.RemoteUserId;
			target.RemoteApplicationId = this.RemoteApplicationId;
		}
		///	<summary> This method copy's each database field from the <paramref name="source"/> interface to this data row.</summary>
		public void Copy_From(IRemoteInstance source, bool includePrimaryKey = false)
		{
			if (includePrimaryKey) this.Id = source.Id;
			this.ProcessFile = source.ProcessFile;
			this.FirstExecutionTime = source.FirstExecutionTime;
			this.LastExecutionTime = source.LastExecutionTime;
			this.StartupCount = source.StartupCount;
			this.TicksUseageTime = source.TicksUseageTime;
			this.Version = source.Version;
			this.Created = source.Created;
			this.LastSeen = source.LastSeen;
			this.RemoteUserId = source.RemoteUserId;
			this.RemoteApplicationId = source.RemoteApplicationId;
		}
		///	<summary> 
		///		This method copy's each database field which is not in the <paramref name="excludedColumns"/> 
		///		from the <paramref name="source"/> interface to this data row.
		/// </summary>
		public void Copy_From_But_Ignore(IRemoteInstance source, params string[] excludedColumns)
		{
			if (!excludedColumns.Contains(RemoteInstancesTable.IdCol)) this.Id = source.Id;
			if (!excludedColumns.Contains(RemoteInstancesTable.ProcessFileCol)) this.ProcessFile = source.ProcessFile;
			if (!excludedColumns.Contains(RemoteInstancesTable.FirstExecutionTimeCol)) this.FirstExecutionTime = source.FirstExecutionTime;
			if (!excludedColumns.Contains(RemoteInstancesTable.LastExecutionTimeCol)) this.LastExecutionTime = source.LastExecutionTime;
			if (!excludedColumns.Contains(RemoteInstancesTable.UnsignedStartupCountCol)) this.StartupCount = source.StartupCount;
			if (!excludedColumns.Contains(RemoteInstancesTable.TicksUseageTimeCol)) this.TicksUseageTime = source.TicksUseageTime;
			if (!excludedColumns.Contains(RemoteInstancesTable.VersionCol)) this.Version = source.Version;
			if (!excludedColumns.Contains(RemoteInstancesTable.CreatedCol)) this.Created = source.Created;
			if (!excludedColumns.Contains(RemoteInstancesTable.LastSeenCol)) this.LastSeen = source.LastSeen;
			if (!excludedColumns.Contains(RemoteInstancesTable.RemoteUserIdCol)) this.RemoteUserId = source.RemoteUserId;
			if (!excludedColumns.Contains(RemoteInstancesTable.RemoteApplicationIdCol)) this.RemoteApplicationId = source.RemoteApplicationId;
		}
		///	<summary> 
		///		This method copy's each database field which is in the <paramref name="includedColumns"/> 
		///		from the <paramref name="source"/> interface to this data row.
		/// </summary>
		public void Copy_From_But_TakeOnly(IRemoteInstance source, params string[] includedColumns)
		{
			if (includedColumns.Contains(RemoteInstancesTable.IdCol)) this.Id = source.Id;
			if (includedColumns.Contains(RemoteInstancesTable.ProcessFileCol)) this.ProcessFile = source.ProcessFile;
			if (includedColumns.Contains(RemoteInstancesTable.FirstExecutionTimeCol)) this.FirstExecutionTime = source.FirstExecutionTime;
			if (includedColumns.Contains(RemoteInstancesTable.LastExecutionTimeCol)) this.LastExecutionTime = source.LastExecutionTime;
			if (includedColumns.Contains(RemoteInstancesTable.UnsignedStartupCountCol)) this.StartupCount = source.StartupCount;
			if (includedColumns.Contains(RemoteInstancesTable.TicksUseageTimeCol)) this.TicksUseageTime = source.TicksUseageTime;
			if (includedColumns.Contains(RemoteInstancesTable.VersionCol)) this.Version = source.Version;
			if (includedColumns.Contains(RemoteInstancesTable.CreatedCol)) this.Created = source.Created;
			if (includedColumns.Contains(RemoteInstancesTable.LastSeenCol)) this.LastSeen = source.LastSeen;
			if (includedColumns.Contains(RemoteInstancesTable.RemoteUserIdCol)) this.RemoteUserId = source.RemoteUserId;
			if (includedColumns.Contains(RemoteInstancesTable.RemoteApplicationIdCol)) this.RemoteApplicationId = source.RemoteApplicationId;
		}
		
		///	<summary>Creates a new instance of type <see cref="Poco_RemoteInstance" />.</summary>
		public Poco_RemoteInstance AsPoco()
		{
			Poco_RemoteInstance poco = new Poco_RemoteInstance();
			Copy_To(poco, true);
			return poco;
		}
	}
}