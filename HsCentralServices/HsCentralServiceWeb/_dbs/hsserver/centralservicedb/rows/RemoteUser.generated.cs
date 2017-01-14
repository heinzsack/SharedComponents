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
//<date>2017-01-14 15:59:26</date>



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
	
	///<summary>DataRow([<c>CentralServiceDb</c>].[<c>RemoteUsers</c>]): row model of <see cref="RemoteUsersTable"/>.</summary>
	[Serializable]
	[DebuggerDisplay("DataRow(CentralServiceDb.RemoteUsers): Id = '{Id}'")]
	[CsDbDataRow(Database = "CentralServiceDb", TableName = "RemoteUsers", Generated = "17.01.14 15:59:26", Hash = "C80E34D4568A53385259CFB5895BAC98")]
	public partial class RemoteUser : CsDbTableRow, IRemoteUser
	{
		#region statics
		private static Dictionary<string, System.Reflection.PropertyInfo> _nativeColumnName_To_Property;
		public static Dictionary<string, System.Reflection.PropertyInfo> NativeColumnName_To_Property
		{
			get
			{
				if (_nativeColumnName_To_Property != null)
					return _nativeColumnName_To_Property;
		
				var type = typeof(IRemoteUser);
				_nativeColumnName_To_Property = new Dictionary<string, System.Reflection.PropertyInfo>
				{
					{ RemoteUsersTable.IdCol, type.GetProperty(nameof(Id)) },
					{ RemoteUsersTable.SidCol, type.GetProperty(nameof(Sid)) },
					{ RemoteUsersTable.NameCol, type.GetProperty(nameof(Name)) },
					{ RemoteUsersTable.FullNameCol, type.GetProperty(nameof(FullName)) },
					{ RemoteUsersTable.DomainCol, type.GetProperty(nameof(Domain)) },
					{ RemoteUsersTable.DescriptionCol, type.GetProperty(nameof(Description)) },
					{ RemoteUsersTable.StatusCol, type.GetProperty(nameof(Status)) },
					{ RemoteUsersTable.RemoteComputerIdCol, type.GetProperty(nameof(RemoteComputerId)) }
				};
		
				return _nativeColumnName_To_Property;
			}
		}
		#endregion
	
	
		public RemoteUser(DataRowBuilder builder) : base(builder){}
	
		
		///<summary>References the owning data context, this is equal to the database server. Use this to address databases on the same server.</summary>
		public new HsCentralServiceWeb._dbs.hsserver.HsServerContext DataContext => Table.DataContext;
	
		///<summary>References the owning dataset. Use this to address tables in the same database</summary>
		public new CentralServiceDb DataSet => Table.DataSet;
	
		///	<summary>Gets the owning table of type <see cref="RemoteUsersTable"/>.</summary>
		public new RemoteUsersTable Table => (RemoteUsersTable) base.Table;
	
	
	
	
		#region COLUMNS
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteUsers</c>].[<c>Id</c>] (Type = <c>uniqueidentifier</c>, Default = '<c>(newid())</c>')
		///</summary>
		[CsDbDataColumn(Default = "Guid.NewGuid()")]
		[CsDbNativeDataColumn(Table = "RemoteUsers", Name = "Id", Type = "uniqueidentifier", Default = "(newid())", IsNullable = "NO")]
		public Guid Id
		{
			[DebuggerStepThrough] get { return GetDbValue<Guid>(RemoteUsersTable.IdCol); }
			[DebuggerStepThrough] set { SetDbValue(value, RemoteUsersTable.IdCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteUsers</c>].[<c>Sid</c>] (Type = <c>nvarchar</c>, <c>NULLABLE</c>, MaxLength = <c>-1</c>)
		///</summary>
		[CsDbDataColumn(IsNullable = true)]
		[CsDbNativeDataColumn(Table = "RemoteUsers", Name = "Sid", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES")]
		public String Sid
		{
			[DebuggerStepThrough] get { return GetDbValue<String>(RemoteUsersTable.SidCol); }
			[DebuggerStepThrough] set { SetDbValue(value, RemoteUsersTable.SidCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteUsers</c>].[<c>Name</c>] (Type = <c>nvarchar</c>, <c>NULLABLE</c>, MaxLength = <c>-1</c>)
		///</summary>
		[CsDbDataColumn(IsNullable = true)]
		[CsDbNativeDataColumn(Table = "RemoteUsers", Name = "Name", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES")]
		public String Name
		{
			[DebuggerStepThrough] get { return GetDbValue<String>(RemoteUsersTable.NameCol); }
			[DebuggerStepThrough] set { SetDbValue(value, RemoteUsersTable.NameCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteUsers</c>].[<c>FullName</c>] (Type = <c>nvarchar</c>, <c>NULLABLE</c>, MaxLength = <c>-1</c>)
		///</summary>
		[CsDbDataColumn(IsNullable = true)]
		[CsDbNativeDataColumn(Table = "RemoteUsers", Name = "FullName", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES")]
		public String FullName
		{
			[DebuggerStepThrough] get { return GetDbValue<String>(RemoteUsersTable.FullNameCol); }
			[DebuggerStepThrough] set { SetDbValue(value, RemoteUsersTable.FullNameCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteUsers</c>].[<c>Domain</c>] (Type = <c>nvarchar</c>, <c>NULLABLE</c>, MaxLength = <c>-1</c>)
		///</summary>
		[CsDbDataColumn(IsNullable = true)]
		[CsDbNativeDataColumn(Table = "RemoteUsers", Name = "Domain", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES")]
		public String Domain
		{
			[DebuggerStepThrough] get { return GetDbValue<String>(RemoteUsersTable.DomainCol); }
			[DebuggerStepThrough] set { SetDbValue(value, RemoteUsersTable.DomainCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteUsers</c>].[<c>Description</c>] (Type = <c>nvarchar</c>, <c>NULLABLE</c>, MaxLength = <c>-1</c>)
		///</summary>
		[CsDbDataColumn(IsNullable = true)]
		[CsDbNativeDataColumn(Table = "RemoteUsers", Name = "Description", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES")]
		public String Description
		{
			[DebuggerStepThrough] get { return GetDbValue<String>(RemoteUsersTable.DescriptionCol); }
			[DebuggerStepThrough] set { SetDbValue(value, RemoteUsersTable.DescriptionCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteUsers</c>].[<c>Status</c>] (Type = <c>nvarchar</c>, <c>NULLABLE</c>, MaxLength = <c>-1</c>)
		///</summary>
		[CsDbDataColumn(IsNullable = true)]
		[CsDbNativeDataColumn(Table = "RemoteUsers", Name = "Status", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES")]
		public String Status
		{
			[DebuggerStepThrough] get { return GetDbValue<String>(RemoteUsersTable.StatusCol); }
			[DebuggerStepThrough] set { SetDbValue(value, RemoteUsersTable.StatusCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteUsers</c>].[<c>RemoteComputerId</c>] (Type = <c>uniqueidentifier</c>)
		///</summary>
		[CsDbDataColumn]
		[CsDbNativeDataColumn(Table = "RemoteUsers", Name = "RemoteComputerId", Type = "uniqueidentifier", IsNullable = "NO")]
		public Guid RemoteComputerId
		{
			[DebuggerStepThrough] get { return GetDbValue<Guid>(RemoteUsersTable.RemoteComputerIdCol); }
			[DebuggerStepThrough] set { SetDbValue(value, RemoteUsersTable.RemoteComputerIdCol); }
		}
		
		#endregion
	
	
	
	
	
		///	<summary>Reloads the <see cref="RemoteUser"/> row by executing following command:<para/><c>$"SELECT * FROM RemoteUsers WHERE [Id] = '<see cref="Id"/>'</c></summary>
		public RemoteUser Reload()
		{
			Table.DataSet.RemoteUsers.LoadThenFind(Id);
			return this;
		}
		
		
		
		
		#region PROPERTIES<Many to One>
		private RemoteComputer _remoteComputer;
		private ContractCollection<RemoteInstance> _weakRemoteInstances;
		public bool IsRemoteComputerLoaded => (_remoteComputer == null || _remoteComputer.RowState != DataRowState.Detached) && Equals(_remoteComputer?.Id, RemoteComputerId);
		
		///	<summary>
		///		This field has cached Output.<para/>
		///		<c>SELECT * FROM RemoteComputers WHERE [Id] = '<paramref name="RemoteComputerId"/>'</c><para/>[<c>RemoteUsers</c>].[<c>RemoteComputerId</c>] &#62;&#62;&#62;&#62; [<c>RemoteComputers</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK__RemoteUse__Remot__18EBB532", PkTable = "RemoteComputers", PkColumn = "Id", FkTable = "RemoteUsers", FkColumn = "RemoteComputerId")][DependsOn("RemoteComputerId")]
		public RemoteComputer RemoteComputer
		{
			[DebuggerStepThrough]
			get 
			{
				if (IsRemoteComputerLoaded)
					return _remoteComputer;
				
				_remoteComputer = Table.DataSet.RemoteComputers.FindOrLoad(RemoteComputerId);
				return _remoteComputer;
			}
			[DebuggerStepThrough]
			set 
			{
				if (value == null) throw new InvalidOperationException("The value cannot be null (FK: FK__RemoteUse__Remot__18EBB532)");
				if (value != null && value.Table.DataSet != Table.DataSet) throw new InvalidOperationException("The owning data set have to be equal.");
				if (value == _remoteComputer) return;
		
				_remoteComputer = value;
		
				if (value == null)
					SetDbValue(default(Guid), RemoteUsersTable.RemoteComputerIdCol, "RemoteComputerId");
				else
					SetDbValue(value.Id, RemoteUsersTable.RemoteComputerIdCol, "RemoteComputerId");
			}
		}
		#endregion
		
		
		
		
		
		#region PROPERTIES<One to Many>
		///	<summary>
		///		This field has cached Output. <para/>
		///		<c>SELECT * FROM RemoteInstances WHERE [RemoteUserId] = '<paramref name="Id"/>'</c><para/>[<c>RemoteUsers</c>].[<c>Id</c>] &#60;&#60;&#60;&#60; [<c>RemoteInstances</c>].[<c>RemoteUserId</c>]
		///	</summary>
		[CsDbResolvesRelation("FK__RemoteIns__Remot__19DFD96B", PkTable = "RemoteUsers", PkColumn = "Id", FkTable = "RemoteInstances", FkColumn = "RemoteUserId")]
		public ContractCollection<RemoteInstance> RemoteInstances
		{
			[DebuggerStepThrough] get	{ return _weakRemoteInstances ?? (_weakRemoteInstances = Table.DataSet.RemoteInstances.FindOrLoad_By_RemoteUserId(Id)); }
		}
		#endregion
		
		
		
		
		
		#region FUNC<Overrides>
		protected void Invalidate()
		{
			if (!IsPropertyChangedHandled)
				return;
		
			OnPropertyChanged("Id");
			OnPropertyChanged("Sid");
			OnPropertyChanged("Name");
			OnPropertyChanged("FullName");
			OnPropertyChanged("Domain");
			OnPropertyChanged("Description");
			OnPropertyChanged("Status");
			OnPropertyChanged("RemoteComputerId");
		}
		///	<summary> Set all values which have default values inside the database to their defaults. This method is automatically invoked if you call <see cref="RemoteUsersTable.NewRow"/>. </summary>
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
		public void Copy_To(IRemoteUser target, bool includePrimaryKey = false)
		{
			if (includePrimaryKey) target.Id = this.Id;
			target.Sid = this.Sid;
			target.Name = this.Name;
			target.FullName = this.FullName;
			target.Domain = this.Domain;
			target.Description = this.Description;
			target.Status = this.Status;
			target.RemoteComputerId = this.RemoteComputerId;
		}
		///	<summary> This method copy's each database field from the <paramref name="source"/> interface to this data row.</summary>
		public void Copy_From(IRemoteUser source, bool includePrimaryKey = false)
		{
			if (includePrimaryKey) this.Id = source.Id;
			this.Sid = source.Sid;
			this.Name = source.Name;
			this.FullName = source.FullName;
			this.Domain = source.Domain;
			this.Description = source.Description;
			this.Status = source.Status;
			this.RemoteComputerId = source.RemoteComputerId;
		}
		///	<summary> 
		///		This method copy's each database field which is not in the <paramref name="excludedColumns"/> 
		///		from the <paramref name="source"/> interface to this data row.
		/// </summary>
		public void Copy_From_But_Ignore(IRemoteUser source, params string[] excludedColumns)
		{
			if (!excludedColumns.Contains(RemoteUsersTable.IdCol)) this.Id = source.Id;
			if (!excludedColumns.Contains(RemoteUsersTable.SidCol)) this.Sid = source.Sid;
			if (!excludedColumns.Contains(RemoteUsersTable.NameCol)) this.Name = source.Name;
			if (!excludedColumns.Contains(RemoteUsersTable.FullNameCol)) this.FullName = source.FullName;
			if (!excludedColumns.Contains(RemoteUsersTable.DomainCol)) this.Domain = source.Domain;
			if (!excludedColumns.Contains(RemoteUsersTable.DescriptionCol)) this.Description = source.Description;
			if (!excludedColumns.Contains(RemoteUsersTable.StatusCol)) this.Status = source.Status;
			if (!excludedColumns.Contains(RemoteUsersTable.RemoteComputerIdCol)) this.RemoteComputerId = source.RemoteComputerId;
		}
		///	<summary> 
		///		This method copy's each database field which is in the <paramref name="includedColumns"/> 
		///		from the <paramref name="source"/> interface to this data row.
		/// </summary>
		public void Copy_From_But_TakeOnly(IRemoteUser source, params string[] includedColumns)
		{
			if (includedColumns.Contains(RemoteUsersTable.IdCol)) this.Id = source.Id;
			if (includedColumns.Contains(RemoteUsersTable.SidCol)) this.Sid = source.Sid;
			if (includedColumns.Contains(RemoteUsersTable.NameCol)) this.Name = source.Name;
			if (includedColumns.Contains(RemoteUsersTable.FullNameCol)) this.FullName = source.FullName;
			if (includedColumns.Contains(RemoteUsersTable.DomainCol)) this.Domain = source.Domain;
			if (includedColumns.Contains(RemoteUsersTable.DescriptionCol)) this.Description = source.Description;
			if (includedColumns.Contains(RemoteUsersTable.StatusCol)) this.Status = source.Status;
			if (includedColumns.Contains(RemoteUsersTable.RemoteComputerIdCol)) this.RemoteComputerId = source.RemoteComputerId;
		}
		
		///	<summary>Creates a new instance of type <see cref="Poco_RemoteUser" />.</summary>
		public Poco_RemoteUser AsPoco()
		{
			Poco_RemoteUser poco = new Poco_RemoteUser();
			Copy_To(poco, true);
			return poco;
		}
	}
}