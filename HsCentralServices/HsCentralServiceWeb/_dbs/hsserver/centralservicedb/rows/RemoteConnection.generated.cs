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
	
	///<summary>DataRow([<c>CentralServiceDb</c>].[<c>RemoteConnections</c>]): row model of <see cref="RemoteConnectionsTable"/>.</summary>
	[Serializable]
	[DebuggerDisplay("DataRow(CentralServiceDb.RemoteConnections): Id = '{Id}'")]
	[CsDbDataRow(Database = "CentralServiceDb", TableName = "RemoteConnections", Generated = "17.01.21 17:31:31", Hash = "3D2C1CCDE0A4C5163EC87C830237EEB1")]
	public partial class RemoteConnection : CsDbTableRow, IRemoteConnection
	{
		#region statics
		private static Dictionary<string, System.Reflection.PropertyInfo> _nativeColumnName_To_Property;
		public static Dictionary<string, System.Reflection.PropertyInfo> NativeColumnName_To_Property
		{
			get
			{
				if (_nativeColumnName_To_Property != null)
					return _nativeColumnName_To_Property;
		
				var type = typeof(IRemoteConnection);
				_nativeColumnName_To_Property = new Dictionary<string, System.Reflection.PropertyInfo>
				{
					{ RemoteConnectionsTable.IdCol, type.GetProperty(nameof(Id)) },
					{ RemoteConnectionsTable.RemoteInstanceIdCol, type.GetProperty(nameof(RemoteInstanceId)) },
					{ RemoteConnectionsTable.ServerCol, type.GetProperty(nameof(Server)) },
					{ RemoteConnectionsTable.EstablishedCol, type.GetProperty(nameof(Established)) },
					{ RemoteConnectionsTable.EventsCol, type.GetProperty(nameof(Events)) }
				};
		
				return _nativeColumnName_To_Property;
			}
		}
		#endregion
	
	
		public RemoteConnection(DataRowBuilder builder) : base(builder){}
	
		
		///<summary>References the owning data context, this is equal to the database server. Use this to address databases on the same server.</summary>
		public new HsCentralServiceWeb._dbs.hsserver.HsServerContext DataContext => Table.DataContext;
	
		///<summary>References the owning dataset. Use this to address tables in the same database</summary>
		public new CentralServiceDb DataSet => Table.DataSet;
	
		///	<summary>Gets the owning table of type <see cref="RemoteConnectionsTable"/>.</summary>
		public new RemoteConnectionsTable Table => (RemoteConnectionsTable) base.Table;
	
	
	
	
		#region COLUMNS
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteConnections</c>].[<c>Id</c>] (Type = <c>uniqueidentifier</c>)
		///</summary>
		[CsDbDataColumn]
		[CsDbNativeDataColumn(Table = "RemoteConnections", Name = "Id", Type = "uniqueidentifier", IsNullable = "NO")]
		public Guid Id
		{
			[DebuggerStepThrough] get { return GetDbValue<Guid>(RemoteConnectionsTable.IdCol); }
			[DebuggerStepThrough] set { SetDbValue(value, RemoteConnectionsTable.IdCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteConnections</c>].[<c>RemoteInstanceId</c>] (Type = <c>uniqueidentifier</c>)
		///</summary>
		[CsDbDataColumn]
		[CsDbNativeDataColumn(Table = "RemoteConnections", Name = "RemoteInstanceId", Type = "uniqueidentifier", IsNullable = "NO")]
		public Guid RemoteInstanceId
		{
			[DebuggerStepThrough] get { return GetDbValue<Guid>(RemoteConnectionsTable.RemoteInstanceIdCol); }
			[DebuggerStepThrough] set { SetDbValue(value, RemoteConnectionsTable.RemoteInstanceIdCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteConnections</c>].[<c>Server</c>] (Type = <c>nvarchar</c>, MaxLength = <c>500</c>)
		///</summary>
		[CsDbDataColumn(MaxLength = 500)]
		[CsDbNativeDataColumn(Table = "RemoteConnections", Name = "Server", Type = "nvarchar", MaxLength = "500", IsNullable = "NO")]
		public String Server
		{
			[DebuggerStepThrough] get { return GetDbValue<String>(RemoteConnectionsTable.ServerCol); }
			[DebuggerStepThrough] set { SetDbValue(value, RemoteConnectionsTable.ServerCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteConnections</c>].[<c>Established</c>] (Type = <c>datetime2</c>)
		///</summary>
		[CsDbDataColumn]
		[CsDbNativeDataColumn(Table = "RemoteConnections", Name = "Established", Type = "datetime2", IsNullable = "NO")]
		public DateTime Established
		{
			[DebuggerStepThrough] get { return GetDbValue<DateTime>(RemoteConnectionsTable.EstablishedCol); }
			[DebuggerStepThrough] set { SetDbValue(value, RemoteConnectionsTable.EstablishedCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteConnections</c>].[<c>Events</c>] (Type = <c>nvarchar</c>, <c>NULLABLE</c>, MaxLength = <c>-1</c>)
		///</summary>
		[CsDbDataColumn(IsNullable = true)]
		[CsDbNativeDataColumn(Table = "RemoteConnections", Name = "Events", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES")]
		public String Events
		{
			[DebuggerStepThrough] get { return GetDbValue<String>(RemoteConnectionsTable.EventsCol); }
			[DebuggerStepThrough] set { SetDbValue(value, RemoteConnectionsTable.EventsCol); }
		}
		
		#endregion
	
	
	
	
	
		///	<summary>Reloads the <see cref="RemoteConnection"/> row by executing following command:<para/><c>$"SELECT * FROM RemoteConnections WHERE [Id] = '<see cref="Id"/>'</c></summary>
		public RemoteConnection Reload()
		{
			Table.DataSet.RemoteConnections.LoadThenFind(Id);
			return this;
		}
		
		
		
		
		#region PROPERTIES<Many to One>
		private RemoteInstance _remoteInstance;
		public bool IsRemoteInstanceLoaded => (_remoteInstance == null || _remoteInstance.RowState != DataRowState.Detached) && Equals(_remoteInstance?.Id, RemoteInstanceId);
		
		///	<summary>
		///		This field has cached Output.<para/>
		///		<c>SELECT * FROM RemoteInstances WHERE [Id] = '<paramref name="RemoteInstanceId"/>'</c><para/>[<c>RemoteConnections</c>].[<c>RemoteInstanceId</c>] &#62;&#62;&#62;&#62; [<c>RemoteInstances</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK_RemoteConnections_RemoteInstances", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteConnections", FkColumn = "RemoteInstanceId")][DependsOn("RemoteInstanceId")]
		public RemoteInstance RemoteInstance
		{
			[DebuggerStepThrough]
			get 
			{
				if (IsRemoteInstanceLoaded)
					return _remoteInstance;
				
				_remoteInstance = Table.DataSet.RemoteInstances.FindOrLoad(RemoteInstanceId);
				return _remoteInstance;
			}
			[DebuggerStepThrough]
			set 
			{
				if (value == null) throw new InvalidOperationException("The value cannot be null (FK: FK_RemoteConnections_RemoteInstances)");
				if (value != null && value.Table.DataSet != Table.DataSet) throw new InvalidOperationException("The owning data set have to be equal.");
				if (value == _remoteInstance) return;
		
				_remoteInstance = value;
		
				if (value == null)
					SetDbValue(default(Guid), RemoteConnectionsTable.RemoteInstanceIdCol, "RemoteInstanceId");
				else
					SetDbValue(value.Id, RemoteConnectionsTable.RemoteInstanceIdCol, "RemoteInstanceId");
			}
		}
		#endregion
		
		
		
		
		
		#region PROPERTIES<One to Many>
		
		#endregion
		
		
		
		
		
		#region FUNC<Overrides>
		protected void Invalidate()
		{
			if (!IsPropertyChangedHandled)
				return;
		
			OnPropertyChanged("Id");
			OnPropertyChanged("RemoteInstanceId");
			OnPropertyChanged("Server");
			OnPropertyChanged("Established");
			OnPropertyChanged("Events");
		}
		///	<summary> Set all values which have default values inside the database to their defaults. This method is automatically invoked if you call <see cref="RemoteConnectionsTable.NewRow"/>. </summary>
		public override void ApplyDefaults()
		{
			
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
		public void Copy_To(IRemoteConnection target, bool includePrimaryKey = false)
		{
			if (includePrimaryKey) target.Id = this.Id;
			target.RemoteInstanceId = this.RemoteInstanceId;
			target.Server = this.Server;
			target.Established = this.Established;
			target.Events = this.Events;
		}
		///	<summary> This method copy's each database field from the <paramref name="source"/> interface to this data row.</summary>
		public void Copy_From(IRemoteConnection source, bool includePrimaryKey = false)
		{
			if (includePrimaryKey) this.Id = source.Id;
			this.RemoteInstanceId = source.RemoteInstanceId;
			this.Server = source.Server;
			this.Established = source.Established;
			this.Events = source.Events;
		}
		///	<summary> 
		///		This method copy's each database field which is not in the <paramref name="excludedColumns"/> 
		///		from the <paramref name="source"/> interface to this data row.
		/// </summary>
		public void Copy_From_But_Ignore(IRemoteConnection source, params string[] excludedColumns)
		{
			if (!excludedColumns.Contains(RemoteConnectionsTable.IdCol)) this.Id = source.Id;
			if (!excludedColumns.Contains(RemoteConnectionsTable.RemoteInstanceIdCol)) this.RemoteInstanceId = source.RemoteInstanceId;
			if (!excludedColumns.Contains(RemoteConnectionsTable.ServerCol)) this.Server = source.Server;
			if (!excludedColumns.Contains(RemoteConnectionsTable.EstablishedCol)) this.Established = source.Established;
			if (!excludedColumns.Contains(RemoteConnectionsTable.EventsCol)) this.Events = source.Events;
		}
		///	<summary> 
		///		This method copy's each database field which is in the <paramref name="includedColumns"/> 
		///		from the <paramref name="source"/> interface to this data row.
		/// </summary>
		public void Copy_From_But_TakeOnly(IRemoteConnection source, params string[] includedColumns)
		{
			if (includedColumns.Contains(RemoteConnectionsTable.IdCol)) this.Id = source.Id;
			if (includedColumns.Contains(RemoteConnectionsTable.RemoteInstanceIdCol)) this.RemoteInstanceId = source.RemoteInstanceId;
			if (includedColumns.Contains(RemoteConnectionsTable.ServerCol)) this.Server = source.Server;
			if (includedColumns.Contains(RemoteConnectionsTable.EstablishedCol)) this.Established = source.Established;
			if (includedColumns.Contains(RemoteConnectionsTable.EventsCol)) this.Events = source.Events;
		}
		
		///	<summary>Creates a new instance of type <see cref="Poco_RemoteConnection" />.</summary>
		public Poco_RemoteConnection AsPoco()
		{
			Poco_RemoteConnection poco = new Poco_RemoteConnection();
			Copy_To(poco, true);
			return poco;
		}
	}
}