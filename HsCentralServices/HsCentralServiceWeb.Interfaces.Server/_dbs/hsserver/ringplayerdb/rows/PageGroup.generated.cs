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
//<date>2017-01-04 13:12:48</date>



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
using HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.dataset;
using HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.tables;
using HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.rowinterfaces;
using HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.rowpocos;






namespace HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.rows
{
	#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	
	///<summary>DataRow([<c>RingPlayerDb</c>].[<c>PageGroups</c>]): row model of <see cref="PageGroupsTable"/>.</summary>
	[Serializable]
	[DebuggerDisplay("DataRow(RingPlayerDb.PageGroups): Id = '{Id}'")]
	[CsDbDataRow(Database = "RingPlayerDb", TableName = "PageGroups", Generated = "17.01.04 13:12:48", Hash = "EA063C2D9E6F657458573F4849405DD5")]
	public partial class PageGroup : CsDbTableRow, IPageGroup
	{
		#region statics
		private static Dictionary<string, System.Reflection.PropertyInfo> _nativeColumnName_To_Property;
		public static Dictionary<string, System.Reflection.PropertyInfo> NativeColumnName_To_Property
		{
			get
			{
				if (_nativeColumnName_To_Property != null)
					return _nativeColumnName_To_Property;
		
				var type = typeof(IPageGroup);
				_nativeColumnName_To_Property = new Dictionary<string, System.Reflection.PropertyInfo>
				{
					{ PageGroupsTable.IdCol, type.GetProperty(nameof(Id)) },
					{ PageGroupsTable.NameCol, type.GetProperty(nameof(Name)) }
				};
		
				return _nativeColumnName_To_Property;
			}
		}
		#endregion
	
	
		public PageGroup(DataRowBuilder builder) : base(builder){}
	
		
		///<summary>References the owning data context, this is equal to the database server. Use this to address databases on the same server.</summary>
		public new HsCentralServiceWebInterfacesServer._dbs.hsserver.HsServerContext DataContext => Table.DataContext;
	
		///<summary>References the owning dataset. Use this to address tables in the same database</summary>
		public new RingPlayerDb DataSet => Table.DataSet;
	
		///	<summary>Gets the owning table of type <see cref="PageGroupsTable"/>.</summary>
		public new PageGroupsTable Table => (PageGroupsTable) base.Table;
	
	
	
	
		#region COLUMNS
		///<summary>
		///		[<c>RingPlayerDb</c>].[<c>PageGroups</c>].[<c>Id</c>] (Type = <c>uniqueidentifier</c>, Default = '<c>(newid())</c>')
		///</summary>
		[CsDbDataColumn(Default = "Guid.NewGuid()")]
		[CsDbNativeDataColumn(Table = "PageGroups", Name = "Id", Type = "uniqueidentifier", Default = "(newid())", IsNullable = "NO")]
		public Guid Id
		{
			[DebuggerStepThrough] get { return GetDbValue<Guid>(PageGroupsTable.IdCol); }
			[DebuggerStepThrough] set { SetDbValue(value, PageGroupsTable.IdCol); }
		}
		///<summary>
		///		[<c>RingPlayerDb</c>].[<c>PageGroups</c>].[<c>Name</c>] (Type = <c>nvarchar</c>, <c>NULLABLE</c>, MaxLength = <c>255</c>)
		///</summary>
		[CsDbDataColumn(MaxLength = 255, IsNullable = true)]
		[CsDbNativeDataColumn(Table = "PageGroups", Name = "Name", Type = "nvarchar", MaxLength = "255", IsNullable = "YES")]
		public String Name
		{
			[DebuggerStepThrough] get { return GetDbValue<String>(PageGroupsTable.NameCol); }
			[DebuggerStepThrough] set { SetDbValue(value, PageGroupsTable.NameCol); }
		}
		
		#endregion
	
	
	
	
	
		///	<summary>Reloads the <see cref="PageGroup"/> row by executing following command:<para/><c>$"SELECT * FROM PageGroups WHERE [Id] = '<see cref="Id"/>'</c></summary>
		public PageGroup Reload()
		{
			Table.DataSet.PageGroups.LoadThenFind(Id);
			return this;
		}
		
		
		
		
		#region PROPERTIES<Many to One>
		private ContractCollection<LastGeneratedBalancerState> _weakLastGeneratedBalancerStates;
		private ContractCollection<Page> _weakPages;
		
		
		
		#endregion
		
		
		
		
		
		#region PROPERTIES<One to Many>
		///	<summary>
		///		This field has cached Output. <para/>
		///		<c>SELECT * FROM LastGeneratedBalancerStates WHERE [PageGroupId] = '<paramref name="Id"/>'</c><para/>[<c>PageGroups</c>].[<c>Id</c>] &#60;&#60;&#60;&#60; [<c>LastGeneratedBalancerStates</c>].[<c>PageGroupId</c>]
		///	</summary>
		[CsDbResolvesRelation("FK_LastGeneratedBalancerStates_PageGroups", PkTable = "PageGroups", PkColumn = "Id", FkTable = "LastGeneratedBalancerStates", FkColumn = "PageGroupId")]
		public ContractCollection<LastGeneratedBalancerState> LastGeneratedBalancerStates
		{
			[DebuggerStepThrough] get	{ return _weakLastGeneratedBalancerStates ?? (_weakLastGeneratedBalancerStates = Table.DataSet.LastGeneratedBalancerStates.FindOrLoad_By_PageGroupId(Id)); }
		}
		///	<summary>
		///		This field has cached Output. <para/>
		///		<c>SELECT * FROM Pages WHERE [PageGroupId] = '<paramref name="Id"/>'</c><para/>[<c>PageGroups</c>].[<c>Id</c>] &#60;&#60;&#60;&#60; [<c>Pages</c>].[<c>PageGroupId</c>]
		///	</summary>
		[CsDbResolvesRelation("FK_Pages_PageGroups", PkTable = "PageGroups", PkColumn = "Id", FkTable = "Pages", FkColumn = "PageGroupId")]
		public ContractCollection<Page> Pages
		{
			[DebuggerStepThrough] get	{ return _weakPages ?? (_weakPages = Table.DataSet.Pages.FindOrLoad_By_PageGroupId(Id)); }
		}
		#endregion
		
		
		
		
		
		#region FUNC<Overrides>
		protected void Invalidate()
		{
			if (!IsPropertyChangedHandled)
				return;
		
			OnPropertyChanged("Id");
			OnPropertyChanged("Name");
		}
		///	<summary> Set all values which have default values inside the database to their defaults. This method is automatically invoked if you call <see cref="PageGroupsTable.NewRow"/>. </summary>
		public override void ApplyDefaults()
		{
			Id = Guid.NewGuid();
		}
		/// <summary>
		///     Loads the complete data bundle of the current row into a target data set.
		///     <para>A data bundle is defined as a set of all rows inside a database which are connected via relations.</para>
		///     <para>The currently selected row is the root of the bundle</para>
		/// </summary>
		public void Copy_BundledData_Into_DataSet(RingPlayerDb target)
		{
			base.Copy_BundledData_Into_DataSet(target);
		}
		
		
		/// <summary>
		///     Loads the complete data bundle of the current row into a new data set.
		///     <para>A data bundle is defined as a set of rows inside a database which are connected via relations.</para>
		///     <para>The currently selected row is the root of the bundle</para>
		/// </summary>
		public new RingPlayerDb Copy_BundledData_In_New_DataSet(bool cloneCompleteSchema = false)
		{
			return (RingPlayerDb) base.Copy_BundledData_In_New_DataSet(cloneCompleteSchema);
		}
		
		#endregion
		
		
		///	<summary> This method copy's each database field into the <paramref name="target"/> interface. </summary>
		public void Copy_To(IPageGroup target, bool includePrimaryKey = false)
		{
			if (includePrimaryKey) target.Id = this.Id;
			target.Name = this.Name;
		}
		///	<summary> This method copy's each database field from the <paramref name="source"/> interface to this data row.</summary>
		public void Copy_From(IPageGroup source, bool includePrimaryKey = false)
		{
			if (includePrimaryKey) this.Id = source.Id;
			this.Name = source.Name;
		}
		///	<summary> 
		///		This method copy's each database field which is not in the <paramref name="excludedColumns"/> 
		///		from the <paramref name="source"/> interface to this data row.
		/// </summary>
		public void Copy_From_But_Ignore(IPageGroup source, params string[] excludedColumns)
		{
			if (!excludedColumns.Contains(PageGroupsTable.IdCol)) this.Id = source.Id;
			if (!excludedColumns.Contains(PageGroupsTable.NameCol)) this.Name = source.Name;
		}
		///	<summary> 
		///		This method copy's each database field which is in the <paramref name="includedColumns"/> 
		///		from the <paramref name="source"/> interface to this data row.
		/// </summary>
		public void Copy_From_But_TakeOnly(IPageGroup source, params string[] includedColumns)
		{
			if (includedColumns.Contains(PageGroupsTable.IdCol)) this.Id = source.Id;
			if (includedColumns.Contains(PageGroupsTable.NameCol)) this.Name = source.Name;
		}
		
		///	<summary>Creates a new instance of type <see cref="Poco_PageGroup" />.</summary>
		public Poco_PageGroup AsPoco()
		{
			Poco_PageGroup poco = new Poco_PageGroup();
			Copy_To(poco, true);
			return poco;
		}
	}
}