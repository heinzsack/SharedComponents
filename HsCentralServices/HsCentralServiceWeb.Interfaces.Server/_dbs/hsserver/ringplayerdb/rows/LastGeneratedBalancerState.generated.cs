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
//<date>2016-12-27 22:40:01</date>



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
	
	///<summary>DataRow([<c>RingPlayerDb</c>].[<c>LastGeneratedBalancerStates</c>]): row model of <see cref="LastGeneratedBalancerStatesTable"/>.</summary>
	[Serializable]
	[DebuggerStepThrough]
	[DebuggerDisplay("DataRow(RingPlayerDb.LastGeneratedBalancerStates): Id = '{Id}'")]
	[CsDbDataRow(Database = "RingPlayerDb", TableName = "LastGeneratedBalancerStates", Generated = "16.12.27 22:40:01", Hash = "0F9409A080CE2188D745E7F3DFE6A675")]
	public partial class LastGeneratedBalancerState : CsDbTableRow, ILastGeneratedBalancerState
	{
		#region statics
		private static Dictionary<string, System.Reflection.PropertyInfo> _nativeColumnName_To_Property;
		public static Dictionary<string, System.Reflection.PropertyInfo> NativeColumnName_To_Property
		{
			get
			{
				if (_nativeColumnName_To_Property != null)
					return _nativeColumnName_To_Property;
		
				var type = typeof(ILastGeneratedBalancerState);
				_nativeColumnName_To_Property = new Dictionary<string, System.Reflection.PropertyInfo>
				{
					{ LastGeneratedBalancerStatesTable.IdCol, type.GetProperty(nameof(Id)) },
					{ LastGeneratedBalancerStatesTable.PageGroupIdCol, type.GetProperty(nameof(PageGroupId)) },
					{ LastGeneratedBalancerStatesTable.SlotIdCol, type.GetProperty(nameof(SlotId)) },
					{ LastGeneratedBalancerStatesTable.PercentageToAverageLineCol, type.GetProperty(nameof(PercentageToAverageLine)) }
				};
		
				return _nativeColumnName_To_Property;
			}
		}
		#endregion
	
	
		public LastGeneratedBalancerState(DataRowBuilder builder) : base(builder){}
	
		
		///<summary>References the owning data context, this is equal to the database server. Use this to address databases on the same server.</summary>
		public new HsCentralServiceWebInterfacesServer._dbs.hsserver.HsServerContext DataContext => Table.DataContext;
	
		///<summary>References the owning dataset. Use this to address tables in the same database</summary>
		public new RingPlayerDb DataSet => Table.DataSet;
	
		///	<summary>Gets the owning table of type <see cref="LastGeneratedBalancerStatesTable"/>.</summary>
		public new LastGeneratedBalancerStatesTable Table => (LastGeneratedBalancerStatesTable) base.Table;
	
	
	
	
		#region COLUMNS
		///<summary>
		///		[<c>RingPlayerDb</c>].[<c>LastGeneratedBalancerStates</c>].[<c>Id</c>] (Type = <c>uniqueidentifier</c>, Default = '<c>(newid())</c>')
		///</summary>
		[CsDbDataColumn(Default = "Guid.NewGuid()")]
		[CsDbNativeDataColumn(Table = "LastGeneratedBalancerStates", Name = "Id", Type = "uniqueidentifier", Default = "(newid())", IsNullable = "NO")]
		public Guid Id
		{
			get { return GetDbValue<Guid>(LastGeneratedBalancerStatesTable.IdCol); }
			set { SetDbValue(value, LastGeneratedBalancerStatesTable.IdCol); }
		}
		///<summary>
		///		[<c>RingPlayerDb</c>].[<c>LastGeneratedBalancerStates</c>].[<c>PageGroupId</c>] (Type = <c>uniqueidentifier</c>)
		///</summary>
		[CsDbDataColumn]
		[CsDbNativeDataColumn(Table = "LastGeneratedBalancerStates", Name = "PageGroupId", Type = "uniqueidentifier", IsNullable = "NO")]
		public Guid PageGroupId
		{
			get { return GetDbValue<Guid>(LastGeneratedBalancerStatesTable.PageGroupIdCol); }
			set { SetDbValue(value, LastGeneratedBalancerStatesTable.PageGroupIdCol); }
		}
		///<summary>
		///		[<c>RingPlayerDb</c>].[<c>LastGeneratedBalancerStates</c>].[<c>SlotId</c>] (Type = <c>uniqueidentifier</c>, <c>NULLABLE</c>)
		///</summary>
		[CsDbDataColumn(IsNullable = true)]
		[CsDbNativeDataColumn(Table = "LastGeneratedBalancerStates", Name = "SlotId", Type = "uniqueidentifier", IsNullable = "YES")]
		public Guid? SlotId
		{
			get { return GetDbValue<Guid?>(LastGeneratedBalancerStatesTable.SlotIdCol); }
			set { SetDbValue(value, LastGeneratedBalancerStatesTable.SlotIdCol); }
		}
		///<summary>
		///		[<c>RingPlayerDb</c>].[<c>LastGeneratedBalancerStates</c>].[<c>PercentageToAverageLine</c>] (Type = <c>float</c>)
		///</summary>
		[CsDbDataColumn]
		[CsDbNativeDataColumn(Table = "LastGeneratedBalancerStates", Name = "PercentageToAverageLine", Type = "float", IsNullable = "NO")]
		public Double PercentageToAverageLine
		{
			get { return GetDbValue<Double>(LastGeneratedBalancerStatesTable.PercentageToAverageLineCol); }
			set { SetDbValue(value, LastGeneratedBalancerStatesTable.PercentageToAverageLineCol); }
		}
		
		#endregion
	
	
	
	
	
		///	<summary>Reloads the <see cref="LastGeneratedBalancerState"/> row by executing following command:<para/><c>$"SELECT * FROM LastGeneratedBalancerStates WHERE [Id] = '<see cref="Id"/>'</c></summary>
		public LastGeneratedBalancerState Reload()
		{
			Table.DataSet.LastGeneratedBalancerStates.LoadThenFind(Id);
			return this;
		}
		
		
		
		
		#region PROPERTIES<Many to One>
		private PageGroup _pageGroup;
		public bool IsPageGroupLoaded => (_pageGroup == null || _pageGroup.RowState != DataRowState.Detached) && Equals(_pageGroup?.Id, PageGroupId);
		
		///	<summary>
		///		This field has cached Output.<para/>
		///		<c>SELECT * FROM PageGroups WHERE [Id] = '<paramref name="PageGroupId"/>'</c><para/>[<c>LastGeneratedBalancerStates</c>].[<c>PageGroupId</c>] &#62;&#62;&#62;&#62; [<c>PageGroups</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK_LastGeneratedBalancerStates_PageGroups", PkTable = "PageGroups", PkColumn = "Id", FkTable = "LastGeneratedBalancerStates", FkColumn = "PageGroupId")][DependsOn("PageGroupId")]
		public PageGroup PageGroup
		{
			get 
			{
				if (IsPageGroupLoaded)
					return _pageGroup;
				
				_pageGroup = Table.DataSet.PageGroups.FindOrLoad(PageGroupId);
				return _pageGroup;
			}
			set 
			{
				if (value == null) throw new InvalidOperationException("The value cannot be null (FK: FK_LastGeneratedBalancerStates_PageGroups)");
				if (value != null && value.Table.DataSet != Table.DataSet) throw new InvalidOperationException("The owning data set have to be equal.");
				if (value == _pageGroup) return;
		
				_pageGroup = value;
		
				if (value == null)
					SetDbValue(default(Guid), LastGeneratedBalancerStatesTable.PageGroupIdCol, "PageGroupId");
				else
					SetDbValue(value.Id, LastGeneratedBalancerStatesTable.PageGroupIdCol, "PageGroupId");
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
			OnPropertyChanged("PageGroupId");
			OnPropertyChanged("SlotId");
			OnPropertyChanged("PercentageToAverageLine");
		}
		///	<summary> Set all values which have default values inside the database to their defaults. This method is automatically invoked if you call <see cref="LastGeneratedBalancerStatesTable.NewRow"/>. </summary>
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
		public void Copy_To(ILastGeneratedBalancerState target, bool includePrimaryKey = false)
		{
			if (includePrimaryKey) target.Id = this.Id;
			target.PageGroupId = this.PageGroupId;
			target.SlotId = this.SlotId;
			target.PercentageToAverageLine = this.PercentageToAverageLine;
		}
		///	<summary> This method copy's each database field from the <paramref name="source"/> interface to this data row.</summary>
		public void Copy_From(ILastGeneratedBalancerState source, bool includePrimaryKey = false)
		{
			if (includePrimaryKey) this.Id = source.Id;
			this.PageGroupId = source.PageGroupId;
			this.SlotId = source.SlotId;
			this.PercentageToAverageLine = source.PercentageToAverageLine;
		}
		///	<summary> 
		///		This method copy's each database field which is not in the <paramref name="excludedColumns"/> 
		///		from the <paramref name="source"/> interface to this data row.
		/// </summary>
		public void Copy_From_But_Ignore(ILastGeneratedBalancerState source, params string[] excludedColumns)
		{
			if (!excludedColumns.Contains(LastGeneratedBalancerStatesTable.IdCol)) this.Id = source.Id;
			if (!excludedColumns.Contains(LastGeneratedBalancerStatesTable.PageGroupIdCol)) this.PageGroupId = source.PageGroupId;
			if (!excludedColumns.Contains(LastGeneratedBalancerStatesTable.SlotIdCol)) this.SlotId = source.SlotId;
			if (!excludedColumns.Contains(LastGeneratedBalancerStatesTable.PercentageToAverageLineCol)) this.PercentageToAverageLine = source.PercentageToAverageLine;
		}
		///	<summary> 
		///		This method copy's each database field which is in the <paramref name="includedColumns"/> 
		///		from the <paramref name="source"/> interface to this data row.
		/// </summary>
		public void Copy_From_But_TakeOnly(ILastGeneratedBalancerState source, params string[] includedColumns)
		{
			if (includedColumns.Contains(LastGeneratedBalancerStatesTable.IdCol)) this.Id = source.Id;
			if (includedColumns.Contains(LastGeneratedBalancerStatesTable.PageGroupIdCol)) this.PageGroupId = source.PageGroupId;
			if (includedColumns.Contains(LastGeneratedBalancerStatesTable.SlotIdCol)) this.SlotId = source.SlotId;
			if (includedColumns.Contains(LastGeneratedBalancerStatesTable.PercentageToAverageLineCol)) this.PercentageToAverageLine = source.PercentageToAverageLine;
		}
		
		///	<summary>Creates a new instance of type <see cref="Poco_LastGeneratedBalancerState" />.</summary>
		public Poco_LastGeneratedBalancerState AsPoco()
		{
			Poco_LastGeneratedBalancerState poco = new Poco_LastGeneratedBalancerState();
			Copy_To(poco, true);
			return poco;
		}
	}
}