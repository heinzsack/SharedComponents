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
//<date>2016-12-20 15:09:56</date>



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
	
	///<summary>DataRow([<c>CentralServiceDb</c>].[<c>RemoteRingPlayerManagements</c>]): row model of <see cref="RemoteRingPlayerManagementsTable"/>.</summary>
	[Serializable]
	[DebuggerStepThrough]
	[DebuggerDisplay("DataRow(CentralServiceDb.RemoteRingPlayerManagements): Id = '{Id}'")]
	[CsDbDataRow(Database = "CentralServiceDb", TableName = "RemoteRingPlayerManagements", Generated = "16.12.20 15:09:56", Hash = "D64BFC16FEBB941154D5DB9EC6F89D9C")]
	public partial class RemoteRingPlayerManagement : CsDbTableRow, IRemoteRingPlayerManagement
	{
		#region statics
		private static Dictionary<string, System.Reflection.PropertyInfo> _nativeColumnName_To_Property;
		public static Dictionary<string, System.Reflection.PropertyInfo> NativeColumnName_To_Property
		{
			get
			{
				if (_nativeColumnName_To_Property != null)
					return _nativeColumnName_To_Property;
		
				var type = typeof(IRemoteRingPlayerManagement);
				_nativeColumnName_To_Property = new Dictionary<string, System.Reflection.PropertyInfo>
				{
					{ RemoteRingPlayerManagementsTable.IdCol, type.GetProperty(nameof(Id)) },
					{ RemoteRingPlayerManagementsTable.RemoteInstanceIdCol, type.GetProperty(nameof(RemoteInstanceId)) },
					{ RemoteRingPlayerManagementsTable.LastUpdatedCol, type.GetProperty(nameof(LastUpdated)) },
					{ RemoteRingPlayerManagementsTable.LatestGeneratedRingIdCol, type.GetProperty(nameof(LatestGeneratedRingId)) },
					{ RemoteRingPlayerManagementsTable.LatestTransmittedRingIdCol, type.GetProperty(nameof(LatestTransmittedRingId)) }
				};
		
				return _nativeColumnName_To_Property;
			}
		}
		#endregion
	
	
		public RemoteRingPlayerManagement(DataRowBuilder builder) : base(builder){}
	
		
		///<summary>References the owning data context, this is equal to the database server. Use this to address databases on the same server.</summary>
		public new HsCentralServiceWeb._dbs.hsserver.HsServerContext DataContext => Table.DataContext;
	
		///<summary>References the owning dataset. Use this to address tables in the same database</summary>
		public new CentralServiceDb DataSet => Table.DataSet;
	
		///	<summary>Gets the owning table of type <see cref="RemoteRingPlayerManagementsTable"/>.</summary>
		public new RemoteRingPlayerManagementsTable Table => (RemoteRingPlayerManagementsTable) base.Table;
	
	
	
	
		#region COLUMNS
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteRingPlayerManagements</c>].[<c>Id</c>] (Type = <c>uniqueidentifier</c>, Default = '<c>(newid())</c>')
		///</summary>
		[CsDbDataColumn(Default = "Guid.NewGuid()")]
		[CsDbNativeDataColumn(Table = "RemoteRingPlayerManagements", Name = "Id", Type = "uniqueidentifier", Default = "(newid())", IsNullable = "NO")]
		public Guid Id
		{
			get { return GetDbValue<Guid>(RemoteRingPlayerManagementsTable.IdCol); }
			set { SetDbValue(value, RemoteRingPlayerManagementsTable.IdCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteRingPlayerManagements</c>].[<c>RemoteInstanceId</c>] (Type = <c>uniqueidentifier</c>)
		///</summary>
		[CsDbDataColumn]
		[CsDbNativeDataColumn(Table = "RemoteRingPlayerManagements", Name = "RemoteInstanceId", Type = "uniqueidentifier", IsNullable = "NO")]
		public Guid RemoteInstanceId
		{
			get { return GetDbValue<Guid>(RemoteRingPlayerManagementsTable.RemoteInstanceIdCol); }
			set { SetDbValue(value, RemoteRingPlayerManagementsTable.RemoteInstanceIdCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteRingPlayerManagements</c>].[<c>LastUpdated</c>] (Type = <c>datetime2</c>)
		///</summary>
		[CsDbDataColumn]
		[CsDbNativeDataColumn(Table = "RemoteRingPlayerManagements", Name = "LastUpdated", Type = "datetime2", IsNullable = "NO")]
		public DateTime LastUpdated
		{
			get { return GetDbValue<DateTime>(RemoteRingPlayerManagementsTable.LastUpdatedCol); }
			set { SetDbValue(value, RemoteRingPlayerManagementsTable.LastUpdatedCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteRingPlayerManagements</c>].[<c>LatestGeneratedRingId</c>] (Type = <c>int</c>, <c>NULLABLE</c>)
		///</summary>
		[CsDbDataColumn(IsNullable = true)]
		[CsDbNativeDataColumn(Table = "RemoteRingPlayerManagements", Name = "LatestGeneratedRingId", Type = "int", IsNullable = "YES")]
		public Int32? LatestGeneratedRingId
		{
			get { return GetDbValue<Int32?>(RemoteRingPlayerManagementsTable.LatestGeneratedRingIdCol); }
			set { SetDbValue(value, RemoteRingPlayerManagementsTable.LatestGeneratedRingIdCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteRingPlayerManagements</c>].[<c>LatestTransmittedRingId</c>] (Type = <c>int</c>, <c>NULLABLE</c>)
		///</summary>
		[CsDbDataColumn(IsNullable = true)]
		[CsDbNativeDataColumn(Table = "RemoteRingPlayerManagements", Name = "LatestTransmittedRingId", Type = "int", IsNullable = "YES")]
		public Int32? LatestTransmittedRingId
		{
			get { return GetDbValue<Int32?>(RemoteRingPlayerManagementsTable.LatestTransmittedRingIdCol); }
			set { SetDbValue(value, RemoteRingPlayerManagementsTable.LatestTransmittedRingIdCol); }
		}
		
		#endregion
	
	
	
	
	
		///	<summary>Reloads the <see cref="RemoteRingPlayerManagement"/> row by executing following command:<para/><c>$"SELECT * FROM RemoteRingPlayerManagements WHERE [Id] = '<see cref="Id"/>'</c></summary>
		public RemoteRingPlayerManagement Reload()
		{
			Table.DataSet.RemoteRingPlayerManagements.LoadThenFind(Id);
			return this;
		}
		
		
		
		
		#region PROPERTIES<Many to One>
		private RemoteInstance _remoteInstance;
		public bool IsRemoteInstanceLoaded => (_remoteInstance == null || _remoteInstance.RowState != DataRowState.Detached) && Equals(_remoteInstance?.Id, RemoteInstanceId);
		
		///	<summary>
		///		This field has cached Output.<para/>
		///		<c>SELECT * FROM RemoteInstances WHERE [Id] = '<paramref name="RemoteInstanceId"/>'</c><para/>[<c>RemoteRingPlayerManagements</c>].[<c>RemoteInstanceId</c>] &#62;&#62;&#62;&#62; [<c>RemoteInstances</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK_RemoteRingPlayerInstanceArgs_RemoteInstances", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteRingPlayerManagements", FkColumn = "RemoteInstanceId")][DependsOn("RemoteInstanceId")]
		public RemoteInstance RemoteInstance
		{
			get 
			{
				if (IsRemoteInstanceLoaded)
					return _remoteInstance;
				
				_remoteInstance = Table.DataSet.RemoteInstances.FindOrLoad(RemoteInstanceId);
				return _remoteInstance;
			}
			set 
			{
				if (value == null) throw new InvalidOperationException("The value cannot be null (FK: FK_RemoteRingPlayerInstanceArgs_RemoteInstances)");
				if (value != null && value.Table.DataSet != Table.DataSet) throw new InvalidOperationException("The owning data set have to be equal.");
				if (value == _remoteInstance) return;
		
				_remoteInstance = value;
		
				if (value == null)
					SetDbValue(default(Guid), RemoteRingPlayerManagementsTable.RemoteInstanceIdCol, "RemoteInstanceId");
				else
					SetDbValue(value.Id, RemoteRingPlayerManagementsTable.RemoteInstanceIdCol, "RemoteInstanceId");
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
			OnPropertyChanged("LastUpdated");
			OnPropertyChanged("LatestGeneratedRingId");
			OnPropertyChanged("LatestTransmittedRingId");
		}
		///	<summary> Set all values which have default values inside the database to their defaults. This method is automatically invoked if you call <see cref="RemoteRingPlayerManagementsTable.NewRow"/>. </summary>
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
		public void Copy_To(IRemoteRingPlayerManagement target, bool includePrimaryKey = false)
		{
			if (includePrimaryKey) target.Id = this.Id;
			target.RemoteInstanceId = this.RemoteInstanceId;
			target.LastUpdated = this.LastUpdated;
			target.LatestGeneratedRingId = this.LatestGeneratedRingId;
			target.LatestTransmittedRingId = this.LatestTransmittedRingId;
		}
		///	<summary> This method copy's each database field from the <paramref name="source"/> interface to this data row.</summary>
		public void Copy_From(IRemoteRingPlayerManagement source, bool includePrimaryKey = false)
		{
			if (includePrimaryKey) this.Id = source.Id;
			this.RemoteInstanceId = source.RemoteInstanceId;
			this.LastUpdated = source.LastUpdated;
			this.LatestGeneratedRingId = source.LatestGeneratedRingId;
			this.LatestTransmittedRingId = source.LatestTransmittedRingId;
		}
		///	<summary> 
		///		This method copy's each database field which is not in the <paramref name="excludedColumns"/> 
		///		from the <paramref name="source"/> interface to this data row.
		/// </summary>
		public void Copy_From_But_Ignore(IRemoteRingPlayerManagement source, params string[] excludedColumns)
		{
			if (!excludedColumns.Contains(RemoteRingPlayerManagementsTable.IdCol)) this.Id = source.Id;
			if (!excludedColumns.Contains(RemoteRingPlayerManagementsTable.RemoteInstanceIdCol)) this.RemoteInstanceId = source.RemoteInstanceId;
			if (!excludedColumns.Contains(RemoteRingPlayerManagementsTable.LastUpdatedCol)) this.LastUpdated = source.LastUpdated;
			if (!excludedColumns.Contains(RemoteRingPlayerManagementsTable.LatestGeneratedRingIdCol)) this.LatestGeneratedRingId = source.LatestGeneratedRingId;
			if (!excludedColumns.Contains(RemoteRingPlayerManagementsTable.LatestTransmittedRingIdCol)) this.LatestTransmittedRingId = source.LatestTransmittedRingId;
		}
		///	<summary> 
		///		This method copy's each database field which is in the <paramref name="includedColumns"/> 
		///		from the <paramref name="source"/> interface to this data row.
		/// </summary>
		public void Copy_From_But_TakeOnly(IRemoteRingPlayerManagement source, params string[] includedColumns)
		{
			if (includedColumns.Contains(RemoteRingPlayerManagementsTable.IdCol)) this.Id = source.Id;
			if (includedColumns.Contains(RemoteRingPlayerManagementsTable.RemoteInstanceIdCol)) this.RemoteInstanceId = source.RemoteInstanceId;
			if (includedColumns.Contains(RemoteRingPlayerManagementsTable.LastUpdatedCol)) this.LastUpdated = source.LastUpdated;
			if (includedColumns.Contains(RemoteRingPlayerManagementsTable.LatestGeneratedRingIdCol)) this.LatestGeneratedRingId = source.LatestGeneratedRingId;
			if (includedColumns.Contains(RemoteRingPlayerManagementsTable.LatestTransmittedRingIdCol)) this.LatestTransmittedRingId = source.LatestTransmittedRingId;
		}
		
		///	<summary>Creates a new instance of type <see cref="Poco_RemoteRingPlayerManagement" />.</summary>
		public Poco_RemoteRingPlayerManagement AsPoco()
		{
			Poco_RemoteRingPlayerManagement poco = new Poco_RemoteRingPlayerManagement();
			Copy_To(poco, true);
			return poco;
		}
	}
}