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
	
	///<summary>DataRow([<c>RingPlayerDb</c>].[<c>RingMetaDatas</c>]): row model of <see cref="RingMetaDatasTable"/>.</summary>
	[Serializable]
	[DebuggerStepThrough]
	[DebuggerDisplay("DataRow(RingPlayerDb.RingMetaDatas): Id = '{Id}'")]
	[CsDbDataRow(Database = "RingPlayerDb", TableName = "RingMetaDatas", Generated = "16.12.27 22:40:01", Hash = "A58F06403A46FB1F8F28D4A4C05D2A9B")]
	public partial class RingMetaData : CsDbTableRow, IRingMetaData
	{
		#region statics
		private static Dictionary<string, System.Reflection.PropertyInfo> _nativeColumnName_To_Property;
		public static Dictionary<string, System.Reflection.PropertyInfo> NativeColumnName_To_Property
		{
			get
			{
				if (_nativeColumnName_To_Property != null)
					return _nativeColumnName_To_Property;
		
				var type = typeof(IRingMetaData);
				_nativeColumnName_To_Property = new Dictionary<string, System.Reflection.PropertyInfo>
				{
					{ RingMetaDatasTable.IdCol, type.GetProperty(nameof(Id)) },
					{ RingMetaDatasTable.SenderIdCol, type.GetProperty(nameof(SenderId)) },
					{ RingMetaDatasTable.CreationDateCol, type.GetProperty(nameof(CreationDate)) },
					{ RingMetaDatasTable.TargetDateCol, type.GetProperty(nameof(TargetDate)) },
					{ RingMetaDatasTable.OccasionCol, type.GetProperty(nameof(Occasion)) }
				};
		
				return _nativeColumnName_To_Property;
			}
		}
		#endregion
	
	
		public RingMetaData(DataRowBuilder builder) : base(builder){}
	
		
		///<summary>References the owning data context, this is equal to the database server. Use this to address databases on the same server.</summary>
		public new HsCentralServiceWebInterfacesServer._dbs.hsserver.HsServerContext DataContext => Table.DataContext;
	
		///<summary>References the owning dataset. Use this to address tables in the same database</summary>
		public new RingPlayerDb DataSet => Table.DataSet;
	
		///	<summary>Gets the owning table of type <see cref="RingMetaDatasTable"/>.</summary>
		public new RingMetaDatasTable Table => (RingMetaDatasTable) base.Table;
	
	
	
	
		#region COLUMNS
		///<summary>
		///		[<c>RingPlayerDb</c>].[<c>RingMetaDatas</c>].[<c>Id</c>] (Type = <c>int</c>)
		///</summary>
		[CsDbDataColumn]
		[CsDbNativeDataColumn(Table = "RingMetaDatas", Name = "Id", Type = "int", IsNullable = "NO")]
		public Int32 Id
		{
			get { return GetDbValue<Int32>(RingMetaDatasTable.IdCol); }
			set { SetDbValue(value, RingMetaDatasTable.IdCol); }
		}
		///<summary>
		///		[<c>RingPlayerDb</c>].[<c>RingMetaDatas</c>].[<c>SenderId</c>] (Type = <c>uniqueidentifier</c>)
		///</summary>
		[CsDbDataColumn]
		[CsDbNativeDataColumn(Table = "RingMetaDatas", Name = "SenderId", Type = "uniqueidentifier", IsNullable = "NO")]
		public Guid SenderId
		{
			get { return GetDbValue<Guid>(RingMetaDatasTable.SenderIdCol); }
			set { SetDbValue(value, RingMetaDatasTable.SenderIdCol); }
		}
		///<summary>
		///		[<c>RingPlayerDb</c>].[<c>RingMetaDatas</c>].[<c>CreationDate</c>] (Type = <c>datetime2</c>)
		///</summary>
		[CsDbDataColumn]
		[CsDbNativeDataColumn(Table = "RingMetaDatas", Name = "CreationDate", Type = "datetime2", IsNullable = "NO")]
		public DateTime CreationDate
		{
			get { return GetDbValue<DateTime>(RingMetaDatasTable.CreationDateCol); }
			set { SetDbValue(value, RingMetaDatasTable.CreationDateCol); }
		}
		///<summary>
		///		[<c>RingPlayerDb</c>].[<c>RingMetaDatas</c>].[<c>TargetDate</c>] (Type = <c>datetime2</c>)
		///</summary>
		[CsDbDataColumn]
		[CsDbNativeDataColumn(Table = "RingMetaDatas", Name = "TargetDate", Type = "datetime2", IsNullable = "NO")]
		public DateTime TargetDate
		{
			get { return GetDbValue<DateTime>(RingMetaDatasTable.TargetDateCol); }
			set { SetDbValue(value, RingMetaDatasTable.TargetDateCol); }
		}
		///<summary>
		///		[<c>RingPlayerDb</c>].[<c>RingMetaDatas</c>].[<c>Occasion</c>] (Type = <c>nvarchar</c>, MaxLength = <c>255</c>)
		///</summary>
		[CsDbDataColumn(MaxLength = 255)]
		[CsDbNativeDataColumn(Table = "RingMetaDatas", Name = "Occasion", Type = "nvarchar", MaxLength = "255", IsNullable = "NO")]
		public String Occasion
		{
			get { return GetDbValue<String>(RingMetaDatasTable.OccasionCol); }
			set { SetDbValue(value, RingMetaDatasTable.OccasionCol); }
		}
		
		#endregion
	
	
	
	
	
		///	<summary>Reloads the <see cref="RingMetaData"/> row by executing following command:<para/><c>$"SELECT * FROM RingMetaDatas WHERE [Id] = '<see cref="Id"/>'</c></summary>
		public RingMetaData Reload()
		{
			Table.DataSet.RingMetaDatas.LoadThenFind(Id);
			return this;
		}
		
		
		
		
		#region PROPERTIES<Many to One>
		private ContractCollection<PageSchedule> _weakPageSchedules;
		
		
		
		#endregion
		
		
		
		
		
		#region PROPERTIES<One to Many>
		///	<summary>
		///		This field has cached Output. <para/>
		///		<c>SELECT * FROM PageSchedules WHERE [RingMetaDataId] = '<paramref name="Id"/>'</c><para/>[<c>RingMetaDatas</c>].[<c>Id</c>] &#60;&#60;&#60;&#60; [<c>PageSchedules</c>].[<c>RingMetaDataId</c>]
		///	</summary>
		[CsDbResolvesRelation("FK_PageSchedules_RingMetaDatas", PkTable = "RingMetaDatas", PkColumn = "Id", FkTable = "PageSchedules", FkColumn = "RingMetaDataId")]
		public ContractCollection<PageSchedule> PageSchedules
		{
			get	{ return _weakPageSchedules ?? (_weakPageSchedules = Table.DataSet.PageSchedules.FindOrLoad_By_RingMetaDataId(Id)); }
		}
		#endregion
		
		
		
		
		
		#region FUNC<Overrides>
		protected void Invalidate()
		{
			if (!IsPropertyChangedHandled)
				return;
		
			OnPropertyChanged("Id");
			OnPropertyChanged("SenderId");
			OnPropertyChanged("CreationDate");
			OnPropertyChanged("TargetDate");
			OnPropertyChanged("Occasion");
		}
		///	<summary> Set all values which have default values inside the database to their defaults. This method is automatically invoked if you call <see cref="RingMetaDatasTable.NewRow"/>. </summary>
		public override void ApplyDefaults()
		{
			
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
		public void Copy_To(IRingMetaData target, bool includePrimaryKey = false)
		{
			if (includePrimaryKey) target.Id = this.Id;
			target.SenderId = this.SenderId;
			target.CreationDate = this.CreationDate;
			target.TargetDate = this.TargetDate;
			target.Occasion = this.Occasion;
		}
		///	<summary> This method copy's each database field from the <paramref name="source"/> interface to this data row.</summary>
		public void Copy_From(IRingMetaData source, bool includePrimaryKey = false)
		{
			if (includePrimaryKey) this.Id = source.Id;
			this.SenderId = source.SenderId;
			this.CreationDate = source.CreationDate;
			this.TargetDate = source.TargetDate;
			this.Occasion = source.Occasion;
		}
		///	<summary> 
		///		This method copy's each database field which is not in the <paramref name="excludedColumns"/> 
		///		from the <paramref name="source"/> interface to this data row.
		/// </summary>
		public void Copy_From_But_Ignore(IRingMetaData source, params string[] excludedColumns)
		{
			if (!excludedColumns.Contains(RingMetaDatasTable.IdCol)) this.Id = source.Id;
			if (!excludedColumns.Contains(RingMetaDatasTable.SenderIdCol)) this.SenderId = source.SenderId;
			if (!excludedColumns.Contains(RingMetaDatasTable.CreationDateCol)) this.CreationDate = source.CreationDate;
			if (!excludedColumns.Contains(RingMetaDatasTable.TargetDateCol)) this.TargetDate = source.TargetDate;
			if (!excludedColumns.Contains(RingMetaDatasTable.OccasionCol)) this.Occasion = source.Occasion;
		}
		///	<summary> 
		///		This method copy's each database field which is in the <paramref name="includedColumns"/> 
		///		from the <paramref name="source"/> interface to this data row.
		/// </summary>
		public void Copy_From_But_TakeOnly(IRingMetaData source, params string[] includedColumns)
		{
			if (includedColumns.Contains(RingMetaDatasTable.IdCol)) this.Id = source.Id;
			if (includedColumns.Contains(RingMetaDatasTable.SenderIdCol)) this.SenderId = source.SenderId;
			if (includedColumns.Contains(RingMetaDatasTable.CreationDateCol)) this.CreationDate = source.CreationDate;
			if (includedColumns.Contains(RingMetaDatasTable.TargetDateCol)) this.TargetDate = source.TargetDate;
			if (includedColumns.Contains(RingMetaDatasTable.OccasionCol)) this.Occasion = source.Occasion;
		}
		
		///	<summary>Creates a new instance of type <see cref="Poco_RingMetaData" />.</summary>
		public Poco_RingMetaData AsPoco()
		{
			Poco_RingMetaData poco = new Poco_RingMetaData();
			Copy_To(poco, true);
			return poco;
		}
	}
}