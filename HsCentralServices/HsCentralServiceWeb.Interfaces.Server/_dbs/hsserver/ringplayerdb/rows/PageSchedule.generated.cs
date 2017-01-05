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
	
	///<summary>DataRow([<c>RingPlayerDb</c>].[<c>PageSchedules</c>]): row model of <see cref="PageSchedulesTable"/>.</summary>
	[Serializable]
	[DebuggerDisplay("DataRow(RingPlayerDb.PageSchedules): Id = '{Id}'")]
	[CsDbDataRow(Database = "RingPlayerDb", TableName = "PageSchedules", Generated = "17.01.04 13:12:48", Hash = "0A130054E5240C4F695602318B93CCE7")]
	public partial class PageSchedule : CsDbTableRow, IPageSchedule
	{
		#region statics
		private static Dictionary<string, System.Reflection.PropertyInfo> _nativeColumnName_To_Property;
		public static Dictionary<string, System.Reflection.PropertyInfo> NativeColumnName_To_Property
		{
			get
			{
				if (_nativeColumnName_To_Property != null)
					return _nativeColumnName_To_Property;
		
				var type = typeof(IPageSchedule);
				_nativeColumnName_To_Property = new Dictionary<string, System.Reflection.PropertyInfo>
				{
					{ PageSchedulesTable.IdCol, type.GetProperty(nameof(Id)) },
					{ PageSchedulesTable.DiagnosticTextCol, type.GetProperty(nameof(DiagnosticText)) },
					{ PageSchedulesTable.RingMetaDataIdCol, type.GetProperty(nameof(RingMetaDataId)) },
					{ PageSchedulesTable.PageIdCol, type.GetProperty(nameof(PageId)) },
					{ PageSchedulesTable.PageGroupScheduleIdCol, type.GetProperty(nameof(PageGroupScheduleId)) },
					{ PageSchedulesTable.SlotIdCol, type.GetProperty(nameof(SlotId)) },
					{ PageSchedulesTable.StartTimeCol, type.GetProperty(nameof(StartTime)) }
				};
		
				return _nativeColumnName_To_Property;
			}
		}
		#endregion
	
	
		public PageSchedule(DataRowBuilder builder) : base(builder){}
	
		
		///<summary>References the owning data context, this is equal to the database server. Use this to address databases on the same server.</summary>
		public new HsCentralServiceWebInterfacesServer._dbs.hsserver.HsServerContext DataContext => Table.DataContext;
	
		///<summary>References the owning dataset. Use this to address tables in the same database</summary>
		public new RingPlayerDb DataSet => Table.DataSet;
	
		///	<summary>Gets the owning table of type <see cref="PageSchedulesTable"/>.</summary>
		public new PageSchedulesTable Table => (PageSchedulesTable) base.Table;
	
	
	
	
		#region COLUMNS
		///<summary>
		///		[<c>RingPlayerDb</c>].[<c>PageSchedules</c>].[<c>Id</c>] (Type = <c>uniqueidentifier</c>, Default = '<c>(newid())</c>')
		///</summary>
		[CsDbDataColumn(Default = "Guid.NewGuid()")]
		[CsDbNativeDataColumn(Table = "PageSchedules", Name = "Id", Type = "uniqueidentifier", Default = "(newid())", IsNullable = "NO")]
		public Guid Id
		{
			[DebuggerStepThrough] get { return GetDbValue<Guid>(PageSchedulesTable.IdCol); }
			[DebuggerStepThrough] set { SetDbValue(value, PageSchedulesTable.IdCol); }
		}
		///<summary>
		///		[<c>RingPlayerDb</c>].[<c>PageSchedules</c>].[<c>DiagnosticText</c>] (Type = <c>nvarchar</c>, <c>NULLABLE</c>, MaxLength = <c>-1</c>)
		///</summary>
		[CsDbDataColumn(IsNullable = true)]
		[CsDbNativeDataColumn(Table = "PageSchedules", Name = "DiagnosticText", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES")]
		public String DiagnosticText
		{
			[DebuggerStepThrough] get { return GetDbValue<String>(PageSchedulesTable.DiagnosticTextCol); }
			[DebuggerStepThrough] set { SetDbValue(value, PageSchedulesTable.DiagnosticTextCol); }
		}
		///<summary>
		///		[<c>RingPlayerDb</c>].[<c>PageSchedules</c>].[<c>RingMetaDataId</c>] (Type = <c>int</c>)
		///</summary>
		[CsDbDataColumn]
		[CsDbNativeDataColumn(Table = "PageSchedules", Name = "RingMetaDataId", Type = "int", IsNullable = "NO")]
		public Int32 RingMetaDataId
		{
			[DebuggerStepThrough] get { return GetDbValue<Int32>(PageSchedulesTable.RingMetaDataIdCol); }
			[DebuggerStepThrough] set { SetDbValue(value, PageSchedulesTable.RingMetaDataIdCol); }
		}
		///<summary>
		///		[<c>RingPlayerDb</c>].[<c>PageSchedules</c>].[<c>PageId</c>] (Type = <c>uniqueidentifier</c>)
		///</summary>
		[CsDbDataColumn]
		[CsDbNativeDataColumn(Table = "PageSchedules", Name = "PageId", Type = "uniqueidentifier", IsNullable = "NO")]
		public Guid PageId
		{
			[DebuggerStepThrough] get { return GetDbValue<Guid>(PageSchedulesTable.PageIdCol); }
			[DebuggerStepThrough] set { SetDbValue(value, PageSchedulesTable.PageIdCol); }
		}
		///<summary>
		///		[<c>RingPlayerDb</c>].[<c>PageSchedules</c>].[<c>PageGroupScheduleId</c>] (Type = <c>uniqueidentifier</c>)
		///</summary>
		[CsDbDataColumn]
		[CsDbNativeDataColumn(Table = "PageSchedules", Name = "PageGroupScheduleId", Type = "uniqueidentifier", IsNullable = "NO")]
		public Guid PageGroupScheduleId
		{
			[DebuggerStepThrough] get { return GetDbValue<Guid>(PageSchedulesTable.PageGroupScheduleIdCol); }
			[DebuggerStepThrough] set { SetDbValue(value, PageSchedulesTable.PageGroupScheduleIdCol); }
		}
		///<summary>
		///		[<c>RingPlayerDb</c>].[<c>PageSchedules</c>].[<c>SlotId</c>] (Type = <c>uniqueidentifier</c>)
		///</summary>
		[CsDbDataColumn]
		[CsDbNativeDataColumn(Table = "PageSchedules", Name = "SlotId", Type = "uniqueidentifier", IsNullable = "NO")]
		public Guid SlotId
		{
			[DebuggerStepThrough] get { return GetDbValue<Guid>(PageSchedulesTable.SlotIdCol); }
			[DebuggerStepThrough] set { SetDbValue(value, PageSchedulesTable.SlotIdCol); }
		}
		///<summary>
		///		[<c>RingPlayerDb</c>].[<c>PageSchedules</c>].[<c>StartTime</c>] (Type = <c>datetime2</c>)
		///</summary>
		[CsDbDataColumn]
		[CsDbNativeDataColumn(Table = "PageSchedules", Name = "StartTime", Type = "datetime2", IsNullable = "NO")]
		public DateTime StartTime
		{
			[DebuggerStepThrough] get { return GetDbValue<DateTime>(PageSchedulesTable.StartTimeCol); }
			[DebuggerStepThrough] set { SetDbValue(value, PageSchedulesTable.StartTimeCol); }
		}
		
		#endregion
	
	
	
	
	
		///	<summary>Reloads the <see cref="PageSchedule"/> row by executing following command:<para/><c>$"SELECT * FROM PageSchedules WHERE [Id] = '<see cref="Id"/>'</c></summary>
		public PageSchedule Reload()
		{
			Table.DataSet.PageSchedules.LoadThenFind(Id);
			return this;
		}
		
		
		
		
		#region PROPERTIES<Many to One>
		private RingMetaData _ringMetaData;
		private Page _page;
		public bool IsRingMetaDataLoaded => (_ringMetaData == null || _ringMetaData.RowState != DataRowState.Detached) && Equals(_ringMetaData?.Id, RingMetaDataId);
		public bool IsPageLoaded => (_page == null || _page.RowState != DataRowState.Detached) && Equals(_page?.Id, PageId);
		
		///	<summary>
		///		This field has cached Output.<para/>
		///		<c>SELECT * FROM RingMetaDatas WHERE [Id] = '<paramref name="RingMetaDataId"/>'</c><para/>[<c>PageSchedules</c>].[<c>RingMetaDataId</c>] &#62;&#62;&#62;&#62; [<c>RingMetaDatas</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK_PageSchedules_RingMetaDatas", PkTable = "RingMetaDatas", PkColumn = "Id", FkTable = "PageSchedules", FkColumn = "RingMetaDataId")][DependsOn("RingMetaDataId")]
		public RingMetaData RingMetaData
		{
			[DebuggerStepThrough]
			get 
			{
				if (IsRingMetaDataLoaded)
					return _ringMetaData;
				
				_ringMetaData = Table.DataSet.RingMetaDatas.FindOrLoad(RingMetaDataId);
				return _ringMetaData;
			}
			[DebuggerStepThrough]
			set 
			{
				if (value == null) throw new InvalidOperationException("The value cannot be null (FK: FK_PageSchedules_RingMetaDatas)");
				if (value != null && value.Table.DataSet != Table.DataSet) throw new InvalidOperationException("The owning data set have to be equal.");
				if (value == _ringMetaData) return;
		
				_ringMetaData = value;
		
				if (value == null)
					SetDbValue(default(Int32), PageSchedulesTable.RingMetaDataIdCol, "RingMetaDataId");
				else
					SetDbValue(value.Id, PageSchedulesTable.RingMetaDataIdCol, "RingMetaDataId");
			}
		}
		///	<summary>
		///		This field has cached Output.<para/>
		///		<c>SELECT * FROM Pages WHERE [Id] = '<paramref name="PageId"/>'</c><para/>[<c>PageSchedules</c>].[<c>PageId</c>] &#62;&#62;&#62;&#62; [<c>Pages</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK_ScheduledPages_Pages", PkTable = "Pages", PkColumn = "Id", FkTable = "PageSchedules", FkColumn = "PageId")][DependsOn("PageId")]
		public Page Page
		{
			[DebuggerStepThrough]
			get 
			{
				if (IsPageLoaded)
					return _page;
				
				_page = Table.DataSet.Pages.FindOrLoad(PageId);
				return _page;
			}
			[DebuggerStepThrough]
			set 
			{
				if (value == null) throw new InvalidOperationException("The value cannot be null (FK: FK_ScheduledPages_Pages)");
				if (value != null && value.Table.DataSet != Table.DataSet) throw new InvalidOperationException("The owning data set have to be equal.");
				if (value == _page) return;
		
				_page = value;
		
				if (value == null)
					SetDbValue(default(Guid), PageSchedulesTable.PageIdCol, "PageId");
				else
					SetDbValue(value.Id, PageSchedulesTable.PageIdCol, "PageId");
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
			OnPropertyChanged("DiagnosticText");
			OnPropertyChanged("RingMetaDataId");
			OnPropertyChanged("PageId");
			OnPropertyChanged("PageGroupScheduleId");
			OnPropertyChanged("SlotId");
			OnPropertyChanged("StartTime");
		}
		///	<summary> Set all values which have default values inside the database to their defaults. This method is automatically invoked if you call <see cref="PageSchedulesTable.NewRow"/>. </summary>
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
		public void Copy_To(IPageSchedule target, bool includePrimaryKey = false)
		{
			if (includePrimaryKey) target.Id = this.Id;
			target.DiagnosticText = this.DiagnosticText;
			target.RingMetaDataId = this.RingMetaDataId;
			target.PageId = this.PageId;
			target.PageGroupScheduleId = this.PageGroupScheduleId;
			target.SlotId = this.SlotId;
			target.StartTime = this.StartTime;
		}
		///	<summary> This method copy's each database field from the <paramref name="source"/> interface to this data row.</summary>
		public void Copy_From(IPageSchedule source, bool includePrimaryKey = false)
		{
			if (includePrimaryKey) this.Id = source.Id;
			this.DiagnosticText = source.DiagnosticText;
			this.RingMetaDataId = source.RingMetaDataId;
			this.PageId = source.PageId;
			this.PageGroupScheduleId = source.PageGroupScheduleId;
			this.SlotId = source.SlotId;
			this.StartTime = source.StartTime;
		}
		///	<summary> 
		///		This method copy's each database field which is not in the <paramref name="excludedColumns"/> 
		///		from the <paramref name="source"/> interface to this data row.
		/// </summary>
		public void Copy_From_But_Ignore(IPageSchedule source, params string[] excludedColumns)
		{
			if (!excludedColumns.Contains(PageSchedulesTable.IdCol)) this.Id = source.Id;
			if (!excludedColumns.Contains(PageSchedulesTable.DiagnosticTextCol)) this.DiagnosticText = source.DiagnosticText;
			if (!excludedColumns.Contains(PageSchedulesTable.RingMetaDataIdCol)) this.RingMetaDataId = source.RingMetaDataId;
			if (!excludedColumns.Contains(PageSchedulesTable.PageIdCol)) this.PageId = source.PageId;
			if (!excludedColumns.Contains(PageSchedulesTable.PageGroupScheduleIdCol)) this.PageGroupScheduleId = source.PageGroupScheduleId;
			if (!excludedColumns.Contains(PageSchedulesTable.SlotIdCol)) this.SlotId = source.SlotId;
			if (!excludedColumns.Contains(PageSchedulesTable.StartTimeCol)) this.StartTime = source.StartTime;
		}
		///	<summary> 
		///		This method copy's each database field which is in the <paramref name="includedColumns"/> 
		///		from the <paramref name="source"/> interface to this data row.
		/// </summary>
		public void Copy_From_But_TakeOnly(IPageSchedule source, params string[] includedColumns)
		{
			if (includedColumns.Contains(PageSchedulesTable.IdCol)) this.Id = source.Id;
			if (includedColumns.Contains(PageSchedulesTable.DiagnosticTextCol)) this.DiagnosticText = source.DiagnosticText;
			if (includedColumns.Contains(PageSchedulesTable.RingMetaDataIdCol)) this.RingMetaDataId = source.RingMetaDataId;
			if (includedColumns.Contains(PageSchedulesTable.PageIdCol)) this.PageId = source.PageId;
			if (includedColumns.Contains(PageSchedulesTable.PageGroupScheduleIdCol)) this.PageGroupScheduleId = source.PageGroupScheduleId;
			if (includedColumns.Contains(PageSchedulesTable.SlotIdCol)) this.SlotId = source.SlotId;
			if (includedColumns.Contains(PageSchedulesTable.StartTimeCol)) this.StartTime = source.StartTime;
		}
		
		///	<summary>Creates a new instance of type <see cref="Poco_PageSchedule" />.</summary>
		public Poco_PageSchedule AsPoco()
		{
			Poco_PageSchedule poco = new Poco_PageSchedule();
			Copy_To(poco, true);
			return poco;
		}
	}
}