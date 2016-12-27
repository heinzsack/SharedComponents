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
//<date>2016-12-27 22:39:59</date>



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
	
	///<summary>DataRow([<c>CentralServiceDb</c>].[<c>WebLogs</c>]): row model of <see cref="WebLogsTable"/>.</summary>
	[Serializable]
	[DebuggerStepThrough]
	[DebuggerDisplay("DataRow(CentralServiceDb.WebLogs): Id = '{Id}'")]
	[CsDbDataRow(Database = "CentralServiceDb", TableName = "WebLogs", Generated = "16.12.27 22:39:59", Hash = "4CC03BC5973EBF22978D774676BEAD15")]
	public partial class WebLog : CsDbTableRow, IWebLog
	{
		#region statics
		private static Dictionary<string, System.Reflection.PropertyInfo> _nativeColumnName_To_Property;
		public static Dictionary<string, System.Reflection.PropertyInfo> NativeColumnName_To_Property
		{
			get
			{
				if (_nativeColumnName_To_Property != null)
					return _nativeColumnName_To_Property;
		
				var type = typeof(IWebLog);
				_nativeColumnName_To_Property = new Dictionary<string, System.Reflection.PropertyInfo>
				{
					{ WebLogsTable.IdCol, type.GetProperty(nameof(Id)) },
					{ WebLogsTable.CreationDateCol, type.GetProperty(nameof(CreationDate)) },
					{ WebLogsTable.SeverityNumberCol, type.GetProperty(nameof(SeverityNumber)) },
					{ WebLogsTable.TitleCol, type.GetProperty(nameof(Title)) },
					{ WebLogsTable.MessageCol, type.GetProperty(nameof(Message)) },
					{ WebLogsTable.CodeFilePathCol, type.GetProperty(nameof(CodeFilePath)) },
					{ WebLogsTable.CodeMethodCol, type.GetProperty(nameof(CodeMethod)) },
					{ WebLogsTable.CodeLineCol, type.GetProperty(nameof(CodeLine)) }
				};
		
				return _nativeColumnName_To_Property;
			}
		}
		#endregion
	
	
		public WebLog(DataRowBuilder builder) : base(builder){}
	
		
		///<summary>References the owning data context, this is equal to the database server. Use this to address databases on the same server.</summary>
		public new HsCentralServiceWeb._dbs.hsserver.HsServerContext DataContext => Table.DataContext;
	
		///<summary>References the owning dataset. Use this to address tables in the same database</summary>
		public new CentralServiceDb DataSet => Table.DataSet;
	
		///	<summary>Gets the owning table of type <see cref="WebLogsTable"/>.</summary>
		public new WebLogsTable Table => (WebLogsTable) base.Table;
	
	
	
	
		#region COLUMNS
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>WebLogs</c>].[<c>Id</c>] (Type = <c>uniqueidentifier</c>, Default = '<c>(newid())</c>')
		///</summary>
		[CsDbDataColumn(Default = "Guid.NewGuid()")]
		[CsDbNativeDataColumn(Table = "WebLogs", Name = "Id", Type = "uniqueidentifier", Default = "(newid())", IsNullable = "NO")]
		public Guid Id
		{
			get { return GetDbValue<Guid>(WebLogsTable.IdCol); }
			set { SetDbValue(value, WebLogsTable.IdCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>WebLogs</c>].[<c>CreationDate</c>] (Type = <c>datetime</c>)
		///</summary>
		[CsDbDataColumn]
		[CsDbNativeDataColumn(Table = "WebLogs", Name = "CreationDate", Type = "datetime", IsNullable = "NO")]
		public DateTime CreationDate
		{
			get { return GetDbValue<DateTime>(WebLogsTable.CreationDateCol); }
			set { SetDbValue(value, WebLogsTable.CreationDateCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>WebLogs</c>].[<c>SeverityNumber</c>] (Type = <c>int</c>)
		///</summary>
		[CsDbDataColumn]
		[CsDbNativeDataColumn(Table = "WebLogs", Name = "SeverityNumber", Type = "int", IsNullable = "NO")]
		public Int32 SeverityNumber
		{
			get { return GetDbValue<Int32>(WebLogsTable.SeverityNumberCol); }
			set { SetDbValue(value, WebLogsTable.SeverityNumberCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>WebLogs</c>].[<c>Title</c>] (Type = <c>nvarchar</c>, MaxLength = <c>255</c>)
		///</summary>
		[CsDbDataColumn(MaxLength = 255)]
		[CsDbNativeDataColumn(Table = "WebLogs", Name = "Title", Type = "nvarchar", MaxLength = "255", IsNullable = "NO")]
		public String Title
		{
			get { return GetDbValue<String>(WebLogsTable.TitleCol); }
			set { SetDbValue(value, WebLogsTable.TitleCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>WebLogs</c>].[<c>Message</c>] (Type = <c>nvarchar</c>, MaxLength = <c>-1</c>)
		///</summary>
		[CsDbDataColumn]
		[CsDbNativeDataColumn(Table = "WebLogs", Name = "Message", Type = "nvarchar", MaxLength = "-1", IsNullable = "NO")]
		public String Message
		{
			get { return GetDbValue<String>(WebLogsTable.MessageCol); }
			set { SetDbValue(value, WebLogsTable.MessageCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>WebLogs</c>].[<c>CodeFilePath</c>] (Type = <c>nvarchar</c>, MaxLength = <c>1000</c>)
		///</summary>
		[CsDbDataColumn(MaxLength = 1000)]
		[CsDbNativeDataColumn(Table = "WebLogs", Name = "CodeFilePath", Type = "nvarchar", MaxLength = "1000", IsNullable = "NO")]
		public String CodeFilePath
		{
			get { return GetDbValue<String>(WebLogsTable.CodeFilePathCol); }
			set { SetDbValue(value, WebLogsTable.CodeFilePathCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>WebLogs</c>].[<c>CodeMethod</c>] (Type = <c>nvarchar</c>, MaxLength = <c>255</c>)
		///</summary>
		[CsDbDataColumn(MaxLength = 255)]
		[CsDbNativeDataColumn(Table = "WebLogs", Name = "CodeMethod", Type = "nvarchar", MaxLength = "255", IsNullable = "NO")]
		public String CodeMethod
		{
			get { return GetDbValue<String>(WebLogsTable.CodeMethodCol); }
			set { SetDbValue(value, WebLogsTable.CodeMethodCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>WebLogs</c>].[<c>CodeLine</c>] (Type = <c>int</c>)
		///</summary>
		[CsDbDataColumn]
		[CsDbNativeDataColumn(Table = "WebLogs", Name = "CodeLine", Type = "int", IsNullable = "NO")]
		public Int32 CodeLine
		{
			get { return GetDbValue<Int32>(WebLogsTable.CodeLineCol); }
			set { SetDbValue(value, WebLogsTable.CodeLineCol); }
		}
		
		#endregion
	
	
	
	
	
		///	<summary>Reloads the <see cref="WebLog"/> row by executing following command:<para/><c>$"SELECT * FROM WebLogs WHERE [Id] = '<see cref="Id"/>'</c></summary>
		public WebLog Reload()
		{
			Table.DataSet.WebLogs.LoadThenFind(Id);
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
		
			OnPropertyChanged("Id");
			OnPropertyChanged("CreationDate");
			OnPropertyChanged("SeverityNumber");
			OnPropertyChanged("Title");
			OnPropertyChanged("Message");
			OnPropertyChanged("CodeFilePath");
			OnPropertyChanged("CodeMethod");
			OnPropertyChanged("CodeLine");
		}
		///	<summary> Set all values which have default values inside the database to their defaults. This method is automatically invoked if you call <see cref="WebLogsTable.NewRow"/>. </summary>
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
		public void Copy_To(IWebLog target, bool includePrimaryKey = false)
		{
			if (includePrimaryKey) target.Id = this.Id;
			target.CreationDate = this.CreationDate;
			target.SeverityNumber = this.SeverityNumber;
			target.Title = this.Title;
			target.Message = this.Message;
			target.CodeFilePath = this.CodeFilePath;
			target.CodeMethod = this.CodeMethod;
			target.CodeLine = this.CodeLine;
		}
		///	<summary> This method copy's each database field from the <paramref name="source"/> interface to this data row.</summary>
		public void Copy_From(IWebLog source, bool includePrimaryKey = false)
		{
			if (includePrimaryKey) this.Id = source.Id;
			this.CreationDate = source.CreationDate;
			this.SeverityNumber = source.SeverityNumber;
			this.Title = source.Title;
			this.Message = source.Message;
			this.CodeFilePath = source.CodeFilePath;
			this.CodeMethod = source.CodeMethod;
			this.CodeLine = source.CodeLine;
		}
		///	<summary> 
		///		This method copy's each database field which is not in the <paramref name="excludedColumns"/> 
		///		from the <paramref name="source"/> interface to this data row.
		/// </summary>
		public void Copy_From_But_Ignore(IWebLog source, params string[] excludedColumns)
		{
			if (!excludedColumns.Contains(WebLogsTable.IdCol)) this.Id = source.Id;
			if (!excludedColumns.Contains(WebLogsTable.CreationDateCol)) this.CreationDate = source.CreationDate;
			if (!excludedColumns.Contains(WebLogsTable.SeverityNumberCol)) this.SeverityNumber = source.SeverityNumber;
			if (!excludedColumns.Contains(WebLogsTable.TitleCol)) this.Title = source.Title;
			if (!excludedColumns.Contains(WebLogsTable.MessageCol)) this.Message = source.Message;
			if (!excludedColumns.Contains(WebLogsTable.CodeFilePathCol)) this.CodeFilePath = source.CodeFilePath;
			if (!excludedColumns.Contains(WebLogsTable.CodeMethodCol)) this.CodeMethod = source.CodeMethod;
			if (!excludedColumns.Contains(WebLogsTable.CodeLineCol)) this.CodeLine = source.CodeLine;
		}
		///	<summary> 
		///		This method copy's each database field which is in the <paramref name="includedColumns"/> 
		///		from the <paramref name="source"/> interface to this data row.
		/// </summary>
		public void Copy_From_But_TakeOnly(IWebLog source, params string[] includedColumns)
		{
			if (includedColumns.Contains(WebLogsTable.IdCol)) this.Id = source.Id;
			if (includedColumns.Contains(WebLogsTable.CreationDateCol)) this.CreationDate = source.CreationDate;
			if (includedColumns.Contains(WebLogsTable.SeverityNumberCol)) this.SeverityNumber = source.SeverityNumber;
			if (includedColumns.Contains(WebLogsTable.TitleCol)) this.Title = source.Title;
			if (includedColumns.Contains(WebLogsTable.MessageCol)) this.Message = source.Message;
			if (includedColumns.Contains(WebLogsTable.CodeFilePathCol)) this.CodeFilePath = source.CodeFilePath;
			if (includedColumns.Contains(WebLogsTable.CodeMethodCol)) this.CodeMethod = source.CodeMethod;
			if (includedColumns.Contains(WebLogsTable.CodeLineCol)) this.CodeLine = source.CodeLine;
		}
		
		///	<summary>Creates a new instance of type <see cref="Poco_WebLog" />.</summary>
		public Poco_WebLog AsPoco()
		{
			Poco_WebLog poco = new Poco_WebLog();
			Copy_To(poco, true);
			return poco;
		}
	}
}