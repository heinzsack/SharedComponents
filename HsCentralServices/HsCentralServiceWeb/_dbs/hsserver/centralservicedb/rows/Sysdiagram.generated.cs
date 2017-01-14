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
	
	///<summary>DataRow([<c>CentralServiceDb</c>].[<c>sysdiagrams</c>]): row model of <see cref="SysdiagramsTable"/>.</summary>
	[Serializable]
	[DebuggerDisplay("DataRow(CentralServiceDb.sysdiagrams): DiagramId = '{DiagramId}'")]
	[CsDbDataRow(Database = "CentralServiceDb", TableName = "sysdiagrams", Generated = "17.01.14 15:59:26", Hash = "7982E3BCF5BBB5F3167BD9ABE6536CB1")]
	public partial class Sysdiagram : CsDbTableRow, ISysdiagram
	{
		#region statics
		private static Dictionary<string, System.Reflection.PropertyInfo> _nativeColumnName_To_Property;
		public static Dictionary<string, System.Reflection.PropertyInfo> NativeColumnName_To_Property
		{
			get
			{
				if (_nativeColumnName_To_Property != null)
					return _nativeColumnName_To_Property;
		
				var type = typeof(ISysdiagram);
				_nativeColumnName_To_Property = new Dictionary<string, System.Reflection.PropertyInfo>
				{
					{ SysdiagramsTable.NameCol, type.GetProperty(nameof(Name)) },
					{ SysdiagramsTable.PrincipalIdCol, type.GetProperty(nameof(PrincipalId)) },
					{ SysdiagramsTable.DiagramIdCol, type.GetProperty(nameof(DiagramId)) },
					{ SysdiagramsTable.VersionCol, type.GetProperty(nameof(Version)) },
					{ SysdiagramsTable.DefinitionCol, type.GetProperty(nameof(Definition)) }
				};
		
				return _nativeColumnName_To_Property;
			}
		}
		#endregion
	
	
		public Sysdiagram(DataRowBuilder builder) : base(builder){}
	
		
		///<summary>References the owning data context, this is equal to the database server. Use this to address databases on the same server.</summary>
		public new HsCentralServiceWeb._dbs.hsserver.HsServerContext DataContext => Table.DataContext;
	
		///<summary>References the owning dataset. Use this to address tables in the same database</summary>
		public new CentralServiceDb DataSet => Table.DataSet;
	
		///	<summary>Gets the owning table of type <see cref="SysdiagramsTable"/>.</summary>
		public new SysdiagramsTable Table => (SysdiagramsTable) base.Table;
	
	
	
	
		#region COLUMNS
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>sysdiagrams</c>].[<c>name</c>] (Type = <c>nvarchar</c>, MaxLength = <c>128</c>)
		///</summary>
		[CsDbDataColumn(MaxLength = 128)]
		[CsDbNativeDataColumn(Table = "sysdiagrams", Name = "name", Type = "nvarchar", MaxLength = "128", IsNullable = "NO")]
		public String Name
		{
			[DebuggerStepThrough] get { return GetDbValue<String>(SysdiagramsTable.NameCol); }
			[DebuggerStepThrough] set { SetDbValue(value, SysdiagramsTable.NameCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>sysdiagrams</c>].[<c>principal_id</c>] (Type = <c>int</c>)
		///</summary>
		[CsDbDataColumn]
		[CsDbNativeDataColumn(Table = "sysdiagrams", Name = "principal_id", Type = "int", IsNullable = "NO")]
		public Int32 PrincipalId
		{
			[DebuggerStepThrough] get { return GetDbValue<Int32>(SysdiagramsTable.PrincipalIdCol); }
			[DebuggerStepThrough] set { SetDbValue(value, SysdiagramsTable.PrincipalIdCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>sysdiagrams</c>].[<c>diagram_id</c>] (Type = <c>int</c>)
		///</summary>
		[CsDbDataColumn]
		[CsDbNativeDataColumn(Table = "sysdiagrams", Name = "diagram_id", Type = "int", IsNullable = "NO")]
		public Int32 DiagramId
		{
			[DebuggerStepThrough] get { return GetDbValue<Int32>(SysdiagramsTable.DiagramIdCol); }
			[DebuggerStepThrough] set { SetDbValue(value, SysdiagramsTable.DiagramIdCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>sysdiagrams</c>].[<c>version</c>] (Type = <c>int</c>, <c>NULLABLE</c>)
		///</summary>
		[CsDbDataColumn(IsNullable = true)]
		[CsDbNativeDataColumn(Table = "sysdiagrams", Name = "version", Type = "int", IsNullable = "YES")]
		public Int32? Version
		{
			[DebuggerStepThrough] get { return GetDbValue<Int32?>(SysdiagramsTable.VersionCol); }
			[DebuggerStepThrough] set { SetDbValue(value, SysdiagramsTable.VersionCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>sysdiagrams</c>].[<c>definition</c>] (Type = <c>varbinary</c>, <c>NULLABLE</c>, MaxLength = <c>-1</c>)
		///</summary>
		[CsDbDataColumn(IsNullable = true)]
		[CsDbNativeDataColumn(Table = "sysdiagrams", Name = "definition", Type = "varbinary", MaxLength = "-1", IsNullable = "YES")]
		public Byte[] Definition
		{
			[DebuggerStepThrough] get { return GetDbValue<Byte[]>(SysdiagramsTable.DefinitionCol); }
			[DebuggerStepThrough] set { SetDbValue(value, SysdiagramsTable.DefinitionCol); }
		}
		
		#endregion
	
	
	
	
	
		///	<summary>Reloads the <see cref="Sysdiagram"/> row by executing following command:<para/><c>$"SELECT * FROM sysdiagrams WHERE [diagram_id] = '<see cref="DiagramId"/>'</c></summary>
		public Sysdiagram Reload()
		{
			Table.DataSet.Sysdiagrams.LoadThenFind(DiagramId);
			return this;
		}
		
		
		
		
		#region PROPERTIES<Many to One>
		
		
		
		
		#endregion
		
		
		
		
		
		#region PROPERTIES<One to Many>
		
		#endregion
		
		
		
		
		
		#region FUNC<Overrides>
		protected void Invalidate()
		{
			if (!IsPropertyChangedHandled)
				return;
		
			OnPropertyChanged("Name");
			OnPropertyChanged("PrincipalId");
			OnPropertyChanged("DiagramId");
			OnPropertyChanged("Version");
			OnPropertyChanged("Definition");
		}
		///	<summary> Set all values which have default values inside the database to their defaults. This method is automatically invoked if you call <see cref="SysdiagramsTable.NewRow"/>. </summary>
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
		public void Copy_To(ISysdiagram target, bool includePrimaryKey = false)
		{
			target.Name = this.Name;
			target.PrincipalId = this.PrincipalId;
			if (includePrimaryKey) target.DiagramId = this.DiagramId;
			target.Version = this.Version;
			target.Definition = this.Definition;
		}
		///	<summary> This method copy's each database field from the <paramref name="source"/> interface to this data row.</summary>
		public void Copy_From(ISysdiagram source, bool includePrimaryKey = false)
		{
			this.Name = source.Name;
			this.PrincipalId = source.PrincipalId;
			if (includePrimaryKey) this.DiagramId = source.DiagramId;
			this.Version = source.Version;
			this.Definition = source.Definition;
		}
		///	<summary> 
		///		This method copy's each database field which is not in the <paramref name="excludedColumns"/> 
		///		from the <paramref name="source"/> interface to this data row.
		/// </summary>
		public void Copy_From_But_Ignore(ISysdiagram source, params string[] excludedColumns)
		{
			if (!excludedColumns.Contains(SysdiagramsTable.NameCol)) this.Name = source.Name;
			if (!excludedColumns.Contains(SysdiagramsTable.PrincipalIdCol)) this.PrincipalId = source.PrincipalId;
			if (!excludedColumns.Contains(SysdiagramsTable.DiagramIdCol)) this.DiagramId = source.DiagramId;
			if (!excludedColumns.Contains(SysdiagramsTable.VersionCol)) this.Version = source.Version;
			if (!excludedColumns.Contains(SysdiagramsTable.DefinitionCol)) this.Definition = source.Definition;
		}
		///	<summary> 
		///		This method copy's each database field which is in the <paramref name="includedColumns"/> 
		///		from the <paramref name="source"/> interface to this data row.
		/// </summary>
		public void Copy_From_But_TakeOnly(ISysdiagram source, params string[] includedColumns)
		{
			if (includedColumns.Contains(SysdiagramsTable.NameCol)) this.Name = source.Name;
			if (includedColumns.Contains(SysdiagramsTable.PrincipalIdCol)) this.PrincipalId = source.PrincipalId;
			if (includedColumns.Contains(SysdiagramsTable.DiagramIdCol)) this.DiagramId = source.DiagramId;
			if (includedColumns.Contains(SysdiagramsTable.VersionCol)) this.Version = source.Version;
			if (includedColumns.Contains(SysdiagramsTable.DefinitionCol)) this.Definition = source.Definition;
		}
		
		///	<summary>Creates a new instance of type <see cref="Poco_Sysdiagram" />.</summary>
		public Poco_Sysdiagram AsPoco()
		{
			Poco_Sysdiagram poco = new Poco_Sysdiagram();
			Copy_To(poco, true);
			return poco;
		}
	}
}