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
//<date>2017-01-14 14:31:33</date>



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
	
	///<summary>DataRow([<c>RingPlayerDb</c>].[<c>Images</c>]): row model of <see cref="ImagesTable"/>.</summary>
	[Serializable]
	[DebuggerDisplay("DataRow(RingPlayerDb.Images): Id = '{Id}'")]
	[CsDbDataRow(Database = "RingPlayerDb", TableName = "Images", Generated = "17.01.14 14:31:33", Hash = "A8769B21998319E220837D9086A6ECDA")]
	public partial class Image : CsDbTableRow, IImage
	{
		#region statics
		private static Dictionary<string, System.Reflection.PropertyInfo> _nativeColumnName_To_Property;
		public static Dictionary<string, System.Reflection.PropertyInfo> NativeColumnName_To_Property
		{
			get
			{
				if (_nativeColumnName_To_Property != null)
					return _nativeColumnName_To_Property;
		
				var type = typeof(IImage);
				_nativeColumnName_To_Property = new Dictionary<string, System.Reflection.PropertyInfo>
				{
					{ ImagesTable.IdCol, type.GetProperty(nameof(Id)) },
					{ ImagesTable.DiagnosticTextCol, type.GetProperty(nameof(DiagnosticText)) },
					{ ImagesTable.ImageIdCol, type.GetProperty(nameof(ImageId)) },
					{ ImagesTable.ParentPageIdCol, type.GetProperty(nameof(ParentPageId)) },
					{ ImagesTable.SortOrderCol, type.GetProperty(nameof(SortOrder)) },
					{ ImagesTable.MarginThicknessCol, type.GetProperty(nameof(MarginThickness)) },
					{ ImagesTable.BorderThicknessCol, type.GetProperty(nameof(BorderThickness)) },
					{ ImagesTable.BackgroundCol, type.GetProperty(nameof(Background)) },
					{ ImagesTable.BorderColorCol, type.GetProperty(nameof(BorderColor)) },
					{ ImagesTable.RotationCol, type.GetProperty(nameof(Rotation)) }
				};
		
				return _nativeColumnName_To_Property;
			}
		}
		#endregion
	
	
		public Image(DataRowBuilder builder) : base(builder){}
	
		
		///<summary>References the owning data context, this is equal to the database server. Use this to address databases on the same server.</summary>
		public new HsCentralServiceWebInterfacesServer._dbs.hsserver.HsServerContext DataContext => Table.DataContext;
	
		///<summary>References the owning dataset. Use this to address tables in the same database</summary>
		public new RingPlayerDb DataSet => Table.DataSet;
	
		///	<summary>Gets the owning table of type <see cref="ImagesTable"/>.</summary>
		public new ImagesTable Table => (ImagesTable) base.Table;
	
	
	
	
		#region COLUMNS
		///<summary>
		///		[<c>RingPlayerDb</c>].[<c>Images</c>].[<c>Id</c>] (Type = <c>uniqueidentifier</c>, Default = '<c>(newid())</c>')
		///</summary>
		[CsDbDataColumn(Default = "Guid.NewGuid()")]
		[CsDbNativeDataColumn(Table = "Images", Name = "Id", Type = "uniqueidentifier", Default = "(newid())", IsNullable = "NO")]
		public Guid Id
		{
			[DebuggerStepThrough] get { return GetDbValue<Guid>(ImagesTable.IdCol); }
			[DebuggerStepThrough] set { SetDbValue(value, ImagesTable.IdCol); }
		}
		///<summary>
		///		[<c>RingPlayerDb</c>].[<c>Images</c>].[<c>DiagnosticText</c>] (Type = <c>nvarchar</c>, <c>NULLABLE</c>, MaxLength = <c>-1</c>)
		///</summary>
		[CsDbDataColumn(IsNullable = true)]
		[CsDbNativeDataColumn(Table = "Images", Name = "DiagnosticText", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES")]
		public String DiagnosticText
		{
			[DebuggerStepThrough] get { return GetDbValue<String>(ImagesTable.DiagnosticTextCol); }
			[DebuggerStepThrough] set { SetDbValue(value, ImagesTable.DiagnosticTextCol); }
		}
		///<summary>
		///		[<c>RingPlayerDb</c>].[<c>Images</c>].[<c>ImageId</c>] (Type = <c>uniqueidentifier</c>)
		///</summary>
		[CsDbDataColumn]
		[CsDbNativeDataColumn(Table = "Images", Name = "ImageId", Type = "uniqueidentifier", IsNullable = "NO")]
		public Guid ImageId
		{
			[DebuggerStepThrough] get { return GetDbValue<Guid>(ImagesTable.ImageIdCol); }
			[DebuggerStepThrough] set { SetDbValue(value, ImagesTable.ImageIdCol); }
		}
		///<summary>
		///		[<c>RingPlayerDb</c>].[<c>Images</c>].[<c>ParentPageId</c>] (Type = <c>uniqueidentifier</c>)
		///</summary>
		[CsDbDataColumn]
		[CsDbNativeDataColumn(Table = "Images", Name = "ParentPageId", Type = "uniqueidentifier", IsNullable = "NO")]
		public Guid ParentPageId
		{
			[DebuggerStepThrough] get { return GetDbValue<Guid>(ImagesTable.ParentPageIdCol); }
			[DebuggerStepThrough] set { SetDbValue(value, ImagesTable.ParentPageIdCol); }
		}
		///<summary>
		///		[<c>RingPlayerDb</c>].[<c>Images</c>].[<c>SortOrder</c>] (Type = <c>int</c>, Default = '<c>((0))</c>')
		///</summary>
		[CsDbDataColumn(Default = 0)]
		[CsDbNativeDataColumn(Table = "Images", Name = "SortOrder", Type = "int", Default = "((0))", IsNullable = "NO")]
		public Int32 SortOrder
		{
			[DebuggerStepThrough] get { return GetDbValue<Int32>(ImagesTable.SortOrderCol); }
			[DebuggerStepThrough] set { SetDbValue(value, ImagesTable.SortOrderCol); }
		}
		///<summary>
		///		[<c>RingPlayerDb</c>].[<c>Images</c>].[<c>MarginThickness</c>] (Type = <c>nvarchar</c>, <c>NULLABLE</c>, MaxLength = <c>256</c>)
		///</summary>
		[CsDbDataColumn(MaxLength = 256, IsNullable = true)]
		[CsDbNativeDataColumn(Table = "Images", Name = "MarginThickness", Type = "nvarchar", MaxLength = "256", IsNullable = "YES")]
		public String MarginThickness
		{
			[DebuggerStepThrough] get { return GetDbValue<String>(ImagesTable.MarginThicknessCol); }
			[DebuggerStepThrough] set { SetDbValue(value, ImagesTable.MarginThicknessCol); }
		}
		///<summary>
		///		[<c>RingPlayerDb</c>].[<c>Images</c>].[<c>BorderThickness</c>] (Type = <c>nvarchar</c>, <c>NULLABLE</c>, MaxLength = <c>256</c>)
		///</summary>
		[CsDbDataColumn(MaxLength = 256, IsNullable = true)]
		[CsDbNativeDataColumn(Table = "Images", Name = "BorderThickness", Type = "nvarchar", MaxLength = "256", IsNullable = "YES")]
		public String BorderThickness
		{
			[DebuggerStepThrough] get { return GetDbValue<String>(ImagesTable.BorderThicknessCol); }
			[DebuggerStepThrough] set { SetDbValue(value, ImagesTable.BorderThicknessCol); }
		}
		///<summary>
		///		[<c>RingPlayerDb</c>].[<c>Images</c>].[<c>Background</c>] (Type = <c>nvarchar</c>, <c>NULLABLE</c>, MaxLength = <c>50</c>)
		///</summary>
		[CsDbDataColumn(MaxLength = 50, IsNullable = true)]
		[CsDbNativeDataColumn(Table = "Images", Name = "Background", Type = "nvarchar", MaxLength = "50", IsNullable = "YES")]
		public String Background
		{
			[DebuggerStepThrough] get { return GetDbValue<String>(ImagesTable.BackgroundCol); }
			[DebuggerStepThrough] set { SetDbValue(value, ImagesTable.BackgroundCol); }
		}
		///<summary>
		///		[<c>RingPlayerDb</c>].[<c>Images</c>].[<c>BorderColor</c>] (Type = <c>nvarchar</c>, <c>NULLABLE</c>, MaxLength = <c>50</c>)
		///</summary>
		[CsDbDataColumn(MaxLength = 50, IsNullable = true)]
		[CsDbNativeDataColumn(Table = "Images", Name = "BorderColor", Type = "nvarchar", MaxLength = "50", IsNullable = "YES")]
		public String BorderColor
		{
			[DebuggerStepThrough] get { return GetDbValue<String>(ImagesTable.BorderColorCol); }
			[DebuggerStepThrough] set { SetDbValue(value, ImagesTable.BorderColorCol); }
		}
		///<summary>
		///		[<c>RingPlayerDb</c>].[<c>Images</c>].[<c>Rotation</c>] (Type = <c>float</c>, Default = '<c>((0))</c>')
		///</summary>
		[CsDbDataColumn(Default = 0)]
		[CsDbNativeDataColumn(Table = "Images", Name = "Rotation", Type = "float", Default = "((0))", IsNullable = "NO")]
		public Double Rotation
		{
			[DebuggerStepThrough] get { return GetDbValue<Double>(ImagesTable.RotationCol); }
			[DebuggerStepThrough] set { SetDbValue(value, ImagesTable.RotationCol); }
		}
		
		#endregion
	
	
	
	
	
		///	<summary>Reloads the <see cref="Image"/> row by executing following command:<para/><c>$"SELECT * FROM Images WHERE [Id] = '<see cref="Id"/>'</c></summary>
		public Image Reload()
		{
			Table.DataSet.Images.LoadThenFind(Id);
			return this;
		}
		
		
		
		
		#region PROPERTIES<Many to One>
		private Page _page;
		public bool IsPageLoaded => (_page == null || _page.RowState != DataRowState.Detached) && Equals(_page?.Id, ParentPageId);
		
		///	<summary>
		///		This field has cached Output.<para/>
		///		<c>SELECT * FROM Pages WHERE [Id] = '<paramref name="ParentPageId"/>'</c><para/>[<c>Images</c>].[<c>ParentPageId</c>] &#62;&#62;&#62;&#62; [<c>Pages</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK_Images_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Images", FkColumn = "ParentPageId")][DependsOn("ParentPageId")]
		public Page Page
		{
			[DebuggerStepThrough]
			get 
			{
				if (IsPageLoaded)
					return _page;
				
				_page = Table.DataSet.Pages.FindOrLoad(ParentPageId);
				return _page;
			}
			[DebuggerStepThrough]
			set 
			{
				if (value == null) throw new InvalidOperationException("The value cannot be null (FK: FK_Images_Visuals)");
				if (value != null && value.Table.DataSet != Table.DataSet) throw new InvalidOperationException("The owning data set have to be equal.");
				if (value == _page) return;
		
				_page = value;
		
				if (value == null)
					SetDbValue(default(Guid), ImagesTable.ParentPageIdCol, "ParentPageId");
				else
					SetDbValue(value.Id, ImagesTable.ParentPageIdCol, "ParentPageId");
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
			OnPropertyChanged("ImageId");
			OnPropertyChanged("ParentPageId");
			OnPropertyChanged("SortOrder");
			OnPropertyChanged("MarginThickness");
			OnPropertyChanged("BorderThickness");
			OnPropertyChanged("Background");
			OnPropertyChanged("BorderColor");
			OnPropertyChanged("Rotation");
		}
		///	<summary> Set all values which have default values inside the database to their defaults. This method is automatically invoked if you call <see cref="ImagesTable.NewRow"/>. </summary>
		public override void ApplyDefaults()
		{
			Id = Guid.NewGuid();
				SortOrder = 0;
				Rotation = 0;
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
		public void Copy_To(IImage target, bool includePrimaryKey = false)
		{
			if (includePrimaryKey) target.Id = this.Id;
			target.DiagnosticText = this.DiagnosticText;
			target.ImageId = this.ImageId;
			target.ParentPageId = this.ParentPageId;
			target.SortOrder = this.SortOrder;
			target.MarginThickness = this.MarginThickness;
			target.BorderThickness = this.BorderThickness;
			target.Background = this.Background;
			target.BorderColor = this.BorderColor;
			target.Rotation = this.Rotation;
		}
		///	<summary> This method copy's each database field from the <paramref name="source"/> interface to this data row.</summary>
		public void Copy_From(IImage source, bool includePrimaryKey = false)
		{
			if (includePrimaryKey) this.Id = source.Id;
			this.DiagnosticText = source.DiagnosticText;
			this.ImageId = source.ImageId;
			this.ParentPageId = source.ParentPageId;
			this.SortOrder = source.SortOrder;
			this.MarginThickness = source.MarginThickness;
			this.BorderThickness = source.BorderThickness;
			this.Background = source.Background;
			this.BorderColor = source.BorderColor;
			this.Rotation = source.Rotation;
		}
		///	<summary> 
		///		This method copy's each database field which is not in the <paramref name="excludedColumns"/> 
		///		from the <paramref name="source"/> interface to this data row.
		/// </summary>
		public void Copy_From_But_Ignore(IImage source, params string[] excludedColumns)
		{
			if (!excludedColumns.Contains(ImagesTable.IdCol)) this.Id = source.Id;
			if (!excludedColumns.Contains(ImagesTable.DiagnosticTextCol)) this.DiagnosticText = source.DiagnosticText;
			if (!excludedColumns.Contains(ImagesTable.ImageIdCol)) this.ImageId = source.ImageId;
			if (!excludedColumns.Contains(ImagesTable.ParentPageIdCol)) this.ParentPageId = source.ParentPageId;
			if (!excludedColumns.Contains(ImagesTable.SortOrderCol)) this.SortOrder = source.SortOrder;
			if (!excludedColumns.Contains(ImagesTable.MarginThicknessCol)) this.MarginThickness = source.MarginThickness;
			if (!excludedColumns.Contains(ImagesTable.BorderThicknessCol)) this.BorderThickness = source.BorderThickness;
			if (!excludedColumns.Contains(ImagesTable.BackgroundCol)) this.Background = source.Background;
			if (!excludedColumns.Contains(ImagesTable.BorderColorCol)) this.BorderColor = source.BorderColor;
			if (!excludedColumns.Contains(ImagesTable.RotationCol)) this.Rotation = source.Rotation;
		}
		///	<summary> 
		///		This method copy's each database field which is in the <paramref name="includedColumns"/> 
		///		from the <paramref name="source"/> interface to this data row.
		/// </summary>
		public void Copy_From_But_TakeOnly(IImage source, params string[] includedColumns)
		{
			if (includedColumns.Contains(ImagesTable.IdCol)) this.Id = source.Id;
			if (includedColumns.Contains(ImagesTable.DiagnosticTextCol)) this.DiagnosticText = source.DiagnosticText;
			if (includedColumns.Contains(ImagesTable.ImageIdCol)) this.ImageId = source.ImageId;
			if (includedColumns.Contains(ImagesTable.ParentPageIdCol)) this.ParentPageId = source.ParentPageId;
			if (includedColumns.Contains(ImagesTable.SortOrderCol)) this.SortOrder = source.SortOrder;
			if (includedColumns.Contains(ImagesTable.MarginThicknessCol)) this.MarginThickness = source.MarginThickness;
			if (includedColumns.Contains(ImagesTable.BorderThicknessCol)) this.BorderThickness = source.BorderThickness;
			if (includedColumns.Contains(ImagesTable.BackgroundCol)) this.Background = source.Background;
			if (includedColumns.Contains(ImagesTable.BorderColorCol)) this.BorderColor = source.BorderColor;
			if (includedColumns.Contains(ImagesTable.RotationCol)) this.Rotation = source.Rotation;
		}
		
		///	<summary>Creates a new instance of type <see cref="Poco_Image" />.</summary>
		public Poco_Image AsPoco()
		{
			Poco_Image poco = new Poco_Image();
			Copy_To(poco, true);
			return poco;
		}
	}
}