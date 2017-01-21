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
//<date>2017-01-21 17:31:32</date>



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
using RingPlayer24._dbs.hsserver.ringplayerdb.dataset;
using RingPlayer24._dbs.hsserver.ringplayerdb.tables;
using RingPlayer24._dbs.hsserver.ringplayerdb.rowinterfaces;
using RingPlayer24._dbs.hsserver.ringplayerdb.rowpocos;






namespace RingPlayer24._dbs.hsserver.ringplayerdb.rows
{
	#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	
	///<summary>DataRow([<c>RingPlayerDb</c>].[<c>Rings</c>]): row model of <see cref="RingsTable"/>.</summary>
	[Serializable]
	[DebuggerDisplay("DataRow(RingPlayerDb.Rings): Id = '{Id}'")]
	[CsDbDataRow(Database = "RingPlayerDb", TableName = "Rings", Generated = "17.01.21 17:31:32", Hash = "42D7A9A0B87CDA8CA66F81D30F6374D4")]
	public partial class Ring : CsDbTableRow, IRing
	{
		#region statics
		private static Dictionary<string, System.Reflection.PropertyInfo> _nativeColumnName_To_Property;
		public static Dictionary<string, System.Reflection.PropertyInfo> NativeColumnName_To_Property
		{
			get
			{
				if (_nativeColumnName_To_Property != null)
					return _nativeColumnName_To_Property;
		
				var type = typeof(IRing);
				_nativeColumnName_To_Property = new Dictionary<string, System.Reflection.PropertyInfo>
				{
					{ RingsTable.IdCol, type.GetProperty(nameof(Id)) },
					{ RingsTable.CreationDateCol, type.GetProperty(nameof(CreationDate)) },
					{ RingsTable.TargetDateCol, type.GetProperty(nameof(TargetDate)) },
					{ RingsTable.DiagnosticTextCol, type.GetProperty(nameof(DiagnosticText)) }
				};
		
				return _nativeColumnName_To_Property;
			}
		}
		#endregion
	
	
		public Ring(DataRowBuilder builder) : base(builder){}
	
		
		///<summary>References the owning data context, this is equal to the database server. Use this to address databases on the same server.</summary>
		public new RingPlayer24._dbs.hsserver.HsServerContext DataContext => Table.DataContext;
	
		///<summary>References the owning dataset. Use this to address tables in the same database</summary>
		public new RingPlayerDb DataSet => Table.DataSet;
	
		///	<summary>Gets the owning table of type <see cref="RingsTable"/>.</summary>
		public new RingsTable Table => (RingsTable) base.Table;
	
	
	
	
		#region COLUMNS
		///<summary>
		///		[<c>RingPlayerDb</c>].[<c>Rings</c>].[<c>Id</c>] (Type = <c>uniqueidentifier</c>)
		///</summary>
		[CsDbDataColumn]
		[CsDbNativeDataColumn(Table = "Rings", Name = "Id", Type = "uniqueidentifier", IsNullable = "NO")]
		public Guid Id
		{
			[DebuggerStepThrough] get { return GetDbValue<Guid>(RingsTable.IdCol); }
			[DebuggerStepThrough] set { SetDbValue(value, RingsTable.IdCol); }
		}
		///<summary>
		///		[<c>RingPlayerDb</c>].[<c>Rings</c>].[<c>CreationDate</c>] (Type = <c>datetime2</c>)
		///</summary>
		[CsDbDataColumn]
		[CsDbNativeDataColumn(Table = "Rings", Name = "CreationDate", Type = "datetime2", IsNullable = "NO")]
		public DateTime CreationDate
		{
			[DebuggerStepThrough] get { return GetDbValue<DateTime>(RingsTable.CreationDateCol); }
			[DebuggerStepThrough] set { SetDbValue(value, RingsTable.CreationDateCol); }
		}
		///<summary>
		///		[<c>RingPlayerDb</c>].[<c>Rings</c>].[<c>TargetDate</c>] (Type = <c>datetime2</c>)
		///</summary>
		[CsDbDataColumn]
		[CsDbNativeDataColumn(Table = "Rings", Name = "TargetDate", Type = "datetime2", IsNullable = "NO")]
		public DateTime TargetDate
		{
			[DebuggerStepThrough] get { return GetDbValue<DateTime>(RingsTable.TargetDateCol); }
			[DebuggerStepThrough] set { SetDbValue(value, RingsTable.TargetDateCol); }
		}
		///<summary>
		///		[<c>RingPlayerDb</c>].[<c>Rings</c>].[<c>DiagnosticText</c>] (Type = <c>nvarchar</c>, <c>NULLABLE</c>, MaxLength = <c>-1</c>)
		///</summary>
		[CsDbDataColumn(IsNullable = true)]
		[CsDbNativeDataColumn(Table = "Rings", Name = "DiagnosticText", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES")]
		public String DiagnosticText
		{
			[DebuggerStepThrough] get { return GetDbValue<String>(RingsTable.DiagnosticTextCol); }
			[DebuggerStepThrough] set { SetDbValue(value, RingsTable.DiagnosticTextCol); }
		}
		
		#endregion
	
	
	
	
	
		///	<summary>Reloads the <see cref="Ring"/> row by executing following command:<para/><c>$"SELECT * FROM Rings WHERE [Id] = '<see cref="Id"/>'</c></summary>
		public Ring Reload()
		{
			Table.DataSet.Rings.LoadThenFind(Id);
			return this;
		}
		
		
		
		
		#region PROPERTIES<Many to One>
		private ContractCollection<RingEntry> _weakRingEntries;
		
		
		
		#endregion
		
		
		
		
		
		#region PROPERTIES<One to Many>
		///	<summary>
		///		This field has cached Output. <para/>
		///		<c>SELECT * FROM RingEntries WHERE [RingId] = '<paramref name="Id"/>'</c><para/>[<c>Rings</c>].[<c>Id</c>] &#60;&#60;&#60;&#60; [<c>RingEntries</c>].[<c>RingId</c>]
		///	</summary>
		[CsDbResolvesRelation("FK_RingEntries_Rings", PkTable = "Rings", PkColumn = "Id", FkTable = "RingEntries", FkColumn = "RingId")]
		public ContractCollection<RingEntry> RingEntries
		{
			[DebuggerStepThrough] get	{ return _weakRingEntries ?? (_weakRingEntries = Table.DataSet.RingEntries.FindOrLoad_By_RingId(Id)); }
		}
		#endregion
		
		
		
		
		
		#region FUNC<Overrides>
		protected void Invalidate()
		{
			if (!IsPropertyChangedHandled)
				return;
		
			OnPropertyChanged("Id");
			OnPropertyChanged("CreationDate");
			OnPropertyChanged("TargetDate");
			OnPropertyChanged("DiagnosticText");
		}
		///	<summary> Set all values which have default values inside the database to their defaults. This method is automatically invoked if you call <see cref="RingsTable.NewRow"/>. </summary>
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
		public void Copy_To(IRing target, bool includePrimaryKey = false)
		{
			if (includePrimaryKey) target.Id = this.Id;
			target.CreationDate = this.CreationDate;
			target.TargetDate = this.TargetDate;
			target.DiagnosticText = this.DiagnosticText;
		}
		///	<summary> This method copy's each database field from the <paramref name="source"/> interface to this data row.</summary>
		public void Copy_From(IRing source, bool includePrimaryKey = false)
		{
			if (includePrimaryKey) this.Id = source.Id;
			this.CreationDate = source.CreationDate;
			this.TargetDate = source.TargetDate;
			this.DiagnosticText = source.DiagnosticText;
		}
		///	<summary> 
		///		This method copy's each database field which is not in the <paramref name="excludedColumns"/> 
		///		from the <paramref name="source"/> interface to this data row.
		/// </summary>
		public void Copy_From_But_Ignore(IRing source, params string[] excludedColumns)
		{
			if (!excludedColumns.Contains(RingsTable.IdCol)) this.Id = source.Id;
			if (!excludedColumns.Contains(RingsTable.CreationDateCol)) this.CreationDate = source.CreationDate;
			if (!excludedColumns.Contains(RingsTable.TargetDateCol)) this.TargetDate = source.TargetDate;
			if (!excludedColumns.Contains(RingsTable.DiagnosticTextCol)) this.DiagnosticText = source.DiagnosticText;
		}
		///	<summary> 
		///		This method copy's each database field which is in the <paramref name="includedColumns"/> 
		///		from the <paramref name="source"/> interface to this data row.
		/// </summary>
		public void Copy_From_But_TakeOnly(IRing source, params string[] includedColumns)
		{
			if (includedColumns.Contains(RingsTable.IdCol)) this.Id = source.Id;
			if (includedColumns.Contains(RingsTable.CreationDateCol)) this.CreationDate = source.CreationDate;
			if (includedColumns.Contains(RingsTable.TargetDateCol)) this.TargetDate = source.TargetDate;
			if (includedColumns.Contains(RingsTable.DiagnosticTextCol)) this.DiagnosticText = source.DiagnosticText;
		}
		
		///	<summary>Creates a new instance of type <see cref="Poco_Ring" />.</summary>
		public Poco_Ring AsPoco()
		{
			Poco_Ring poco = new Poco_Ring();
			Copy_To(poco, true);
			return poco;
		}
	}
}