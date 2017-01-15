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
//<date>2017-01-15 00:09:47</date>



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
	
	///<summary>DataRow([<c>CentralServiceDb</c>].[<c>RemoteLogs</c>]): row model of <see cref="RemoteLogsTable"/>.</summary>
	[Serializable]
	[DebuggerDisplay("DataRow(CentralServiceDb.RemoteLogs): Id = '{Id}'")]
	[CsDbDataRow(Database = "CentralServiceDb", TableName = "RemoteLogs", Generated = "17.01.15 00:09:47", Hash = "8198F62FFEB487E79C1D3102DAB60F30")]
	public partial class RemoteLog : CsDbTableRow, IRemoteLog
	{
		#region statics
		private static Dictionary<string, System.Reflection.PropertyInfo> _nativeColumnName_To_Property;
		public static Dictionary<string, System.Reflection.PropertyInfo> NativeColumnName_To_Property
		{
			get
			{
				if (_nativeColumnName_To_Property != null)
					return _nativeColumnName_To_Property;
		
				var type = typeof(IRemoteLog);
				_nativeColumnName_To_Property = new Dictionary<string, System.Reflection.PropertyInfo>
				{
					{ RemoteLogsTable.IdCol, type.GetProperty(nameof(Id)) },
					{ RemoteLogsTable.CreatedCol, type.GetProperty(nameof(Created)) },
					{ RemoteLogsTable.SeverityNumberCol, type.GetProperty(nameof(SeverityNumber)) },
					{ RemoteLogsTable.TitleCol, type.GetProperty(nameof(Title)) },
					{ RemoteLogsTable.MessageCol, type.GetProperty(nameof(Message)) },
					{ RemoteLogsTable.CodeFileCol, type.GetProperty(nameof(CodeFile)) },
					{ RemoteLogsTable.CodeMethodCol, type.GetProperty(nameof(CodeMethod)) },
					{ RemoteLogsTable.CodeLineCol, type.GetProperty(nameof(CodeLine)) },
					{ RemoteLogsTable.RemoteInstanceIdCol, type.GetProperty(nameof(RemoteInstanceId)) }
				};
		
				return _nativeColumnName_To_Property;
			}
		}
		#endregion
	
	
		public RemoteLog(DataRowBuilder builder) : base(builder){}
	
		
		///<summary>References the owning data context, this is equal to the database server. Use this to address databases on the same server.</summary>
		public new HsCentralServiceWeb._dbs.hsserver.HsServerContext DataContext => Table.DataContext;
	
		///<summary>References the owning dataset. Use this to address tables in the same database</summary>
		public new CentralServiceDb DataSet => Table.DataSet;
	
		///	<summary>Gets the owning table of type <see cref="RemoteLogsTable"/>.</summary>
		public new RemoteLogsTable Table => (RemoteLogsTable) base.Table;
	
	
	
	
		#region COLUMNS
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteLogs</c>].[<c>Id</c>] (Type = <c>uniqueidentifier</c>, Default = '<c>(newid())</c>')
		///</summary>
		[CsDbDataColumn(Default = "Guid.NewGuid()")]
		[CsDbNativeDataColumn(Table = "RemoteLogs", Name = "Id", Type = "uniqueidentifier", Default = "(newid())", IsNullable = "NO")]
		public Guid Id
		{
			[DebuggerStepThrough] get { return GetDbValue<Guid>(RemoteLogsTable.IdCol); }
			[DebuggerStepThrough] set { SetDbValue(value, RemoteLogsTable.IdCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteLogs</c>].[<c>Created</c>] (Type = <c>datetime2</c>)
		///</summary>
		[CsDbDataColumn]
		[CsDbNativeDataColumn(Table = "RemoteLogs", Name = "Created", Type = "datetime2", IsNullable = "NO")]
		public DateTime Created
		{
			[DebuggerStepThrough] get { return GetDbValue<DateTime>(RemoteLogsTable.CreatedCol); }
			[DebuggerStepThrough] set { SetDbValue(value, RemoteLogsTable.CreatedCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteLogs</c>].[<c>SeverityNumber</c>] (Type = <c>int</c>)
		///</summary>
		[CsDbDataColumn]
		[CsDbNativeDataColumn(Table = "RemoteLogs", Name = "SeverityNumber", Type = "int", IsNullable = "NO")]
		public Int32 SeverityNumber
		{
			[DebuggerStepThrough] get { return GetDbValue<Int32>(RemoteLogsTable.SeverityNumberCol); }
			[DebuggerStepThrough] set { SetDbValue(value, RemoteLogsTable.SeverityNumberCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteLogs</c>].[<c>Title</c>] (Type = <c>nvarchar</c>, MaxLength = <c>-1</c>)
		///</summary>
		[CsDbDataColumn]
		[CsDbNativeDataColumn(Table = "RemoteLogs", Name = "Title", Type = "nvarchar", MaxLength = "-1", IsNullable = "NO")]
		public String Title
		{
			[DebuggerStepThrough] get { return GetDbValue<String>(RemoteLogsTable.TitleCol); }
			[DebuggerStepThrough] set { SetDbValue(value, RemoteLogsTable.TitleCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteLogs</c>].[<c>Message</c>] (Type = <c>nvarchar</c>, MaxLength = <c>-1</c>)
		///</summary>
		[CsDbDataColumn]
		[CsDbNativeDataColumn(Table = "RemoteLogs", Name = "Message", Type = "nvarchar", MaxLength = "-1", IsNullable = "NO")]
		public String Message
		{
			[DebuggerStepThrough] get { return GetDbValue<String>(RemoteLogsTable.MessageCol); }
			[DebuggerStepThrough] set { SetDbValue(value, RemoteLogsTable.MessageCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteLogs</c>].[<c>CodeFile</c>] (Type = <c>nvarchar</c>, <c>NULLABLE</c>, MaxLength = <c>-1</c>)
		///</summary>
		[CsDbDataColumn(IsNullable = true)]
		[CsDbNativeDataColumn(Table = "RemoteLogs", Name = "CodeFile", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES")]
		public String CodeFile
		{
			[DebuggerStepThrough] get { return GetDbValue<String>(RemoteLogsTable.CodeFileCol); }
			[DebuggerStepThrough] set { SetDbValue(value, RemoteLogsTable.CodeFileCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteLogs</c>].[<c>CodeMethod</c>] (Type = <c>nvarchar</c>, <c>NULLABLE</c>, MaxLength = <c>-1</c>)
		///</summary>
		[CsDbDataColumn(IsNullable = true)]
		[CsDbNativeDataColumn(Table = "RemoteLogs", Name = "CodeMethod", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES")]
		public String CodeMethod
		{
			[DebuggerStepThrough] get { return GetDbValue<String>(RemoteLogsTable.CodeMethodCol); }
			[DebuggerStepThrough] set { SetDbValue(value, RemoteLogsTable.CodeMethodCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteLogs</c>].[<c>CodeLine</c>] (Type = <c>int</c>, <c>NULLABLE</c>)
		///</summary>
		[CsDbDataColumn(IsNullable = true)]
		[CsDbNativeDataColumn(Table = "RemoteLogs", Name = "CodeLine", Type = "int", IsNullable = "YES")]
		public Int32? CodeLine
		{
			[DebuggerStepThrough] get { return GetDbValue<Int32?>(RemoteLogsTable.CodeLineCol); }
			[DebuggerStepThrough] set { SetDbValue(value, RemoteLogsTable.CodeLineCol); }
		}
		///<summary>
		///		[<c>CentralServiceDb</c>].[<c>RemoteLogs</c>].[<c>RemoteInstanceId</c>] (Type = <c>uniqueidentifier</c>)
		///</summary>
		[CsDbDataColumn]
		[CsDbNativeDataColumn(Table = "RemoteLogs", Name = "RemoteInstanceId", Type = "uniqueidentifier", IsNullable = "NO")]
		public Guid RemoteInstanceId
		{
			[DebuggerStepThrough] get { return GetDbValue<Guid>(RemoteLogsTable.RemoteInstanceIdCol); }
			[DebuggerStepThrough] set { SetDbValue(value, RemoteLogsTable.RemoteInstanceIdCol); }
		}
		
		#endregion
	
	
	
	
	
		///	<summary>Reloads the <see cref="RemoteLog"/> row by executing following command:<para/><c>$"SELECT * FROM RemoteLogs WHERE [Id] = '<see cref="Id"/>'</c></summary>
		public RemoteLog Reload()
		{
			Table.DataSet.RemoteLogs.LoadThenFind(Id);
			return this;
		}
		
		
		
		
		#region PROPERTIES<Many to One>
		private RemoteInstance _remoteInstance;
		public bool IsRemoteInstanceLoaded => (_remoteInstance == null || _remoteInstance.RowState != DataRowState.Detached) && Equals(_remoteInstance?.Id, RemoteInstanceId);
		
		///	<summary>
		///		This field has cached Output.<para/>
		///		<c>SELECT * FROM RemoteInstances WHERE [Id] = '<paramref name="RemoteInstanceId"/>'</c><para/>[<c>RemoteLogs</c>].[<c>RemoteInstanceId</c>] &#62;&#62;&#62;&#62; [<c>RemoteInstances</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK__RemoteLog__Remot__1BC821DD", PkTable = "RemoteInstances", PkColumn = "Id", FkTable = "RemoteLogs", FkColumn = "RemoteInstanceId")][DependsOn("RemoteInstanceId")]
		public RemoteInstance RemoteInstance
		{
			[DebuggerStepThrough]
			get 
			{
				if (IsRemoteInstanceLoaded)
					return _remoteInstance;
				
				_remoteInstance = Table.DataSet.RemoteInstances.FindOrLoad(RemoteInstanceId);
				return _remoteInstance;
			}
			[DebuggerStepThrough]
			set 
			{
				if (value == null) throw new InvalidOperationException("The value cannot be null (FK: FK__RemoteLog__Remot__1BC821DD)");
				if (value != null && value.Table.DataSet != Table.DataSet) throw new InvalidOperationException("The owning data set have to be equal.");
				if (value == _remoteInstance) return;
		
				_remoteInstance = value;
		
				if (value == null)
					SetDbValue(default(Guid), RemoteLogsTable.RemoteInstanceIdCol, "RemoteInstanceId");
				else
					SetDbValue(value.Id, RemoteLogsTable.RemoteInstanceIdCol, "RemoteInstanceId");
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
			OnPropertyChanged("Created");
			OnPropertyChanged("SeverityNumber");
			OnPropertyChanged("Title");
			OnPropertyChanged("Message");
			OnPropertyChanged("CodeFile");
			OnPropertyChanged("CodeMethod");
			OnPropertyChanged("CodeLine");
			OnPropertyChanged("RemoteInstanceId");
		}
		///	<summary> Set all values which have default values inside the database to their defaults. This method is automatically invoked if you call <see cref="RemoteLogsTable.NewRow"/>. </summary>
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
		public void Copy_To(IRemoteLog target, bool includePrimaryKey = false)
		{
			if (includePrimaryKey) target.Id = this.Id;
			target.Created = this.Created;
			target.SeverityNumber = this.SeverityNumber;
			target.Title = this.Title;
			target.Message = this.Message;
			target.CodeFile = this.CodeFile;
			target.CodeMethod = this.CodeMethod;
			target.CodeLine = this.CodeLine;
			target.RemoteInstanceId = this.RemoteInstanceId;
		}
		///	<summary> This method copy's each database field from the <paramref name="source"/> interface to this data row.</summary>
		public void Copy_From(IRemoteLog source, bool includePrimaryKey = false)
		{
			if (includePrimaryKey) this.Id = source.Id;
			this.Created = source.Created;
			this.SeverityNumber = source.SeverityNumber;
			this.Title = source.Title;
			this.Message = source.Message;
			this.CodeFile = source.CodeFile;
			this.CodeMethod = source.CodeMethod;
			this.CodeLine = source.CodeLine;
			this.RemoteInstanceId = source.RemoteInstanceId;
		}
		///	<summary> 
		///		This method copy's each database field which is not in the <paramref name="excludedColumns"/> 
		///		from the <paramref name="source"/> interface to this data row.
		/// </summary>
		public void Copy_From_But_Ignore(IRemoteLog source, params string[] excludedColumns)
		{
			if (!excludedColumns.Contains(RemoteLogsTable.IdCol)) this.Id = source.Id;
			if (!excludedColumns.Contains(RemoteLogsTable.CreatedCol)) this.Created = source.Created;
			if (!excludedColumns.Contains(RemoteLogsTable.SeverityNumberCol)) this.SeverityNumber = source.SeverityNumber;
			if (!excludedColumns.Contains(RemoteLogsTable.TitleCol)) this.Title = source.Title;
			if (!excludedColumns.Contains(RemoteLogsTable.MessageCol)) this.Message = source.Message;
			if (!excludedColumns.Contains(RemoteLogsTable.CodeFileCol)) this.CodeFile = source.CodeFile;
			if (!excludedColumns.Contains(RemoteLogsTable.CodeMethodCol)) this.CodeMethod = source.CodeMethod;
			if (!excludedColumns.Contains(RemoteLogsTable.CodeLineCol)) this.CodeLine = source.CodeLine;
			if (!excludedColumns.Contains(RemoteLogsTable.RemoteInstanceIdCol)) this.RemoteInstanceId = source.RemoteInstanceId;
		}
		///	<summary> 
		///		This method copy's each database field which is in the <paramref name="includedColumns"/> 
		///		from the <paramref name="source"/> interface to this data row.
		/// </summary>
		public void Copy_From_But_TakeOnly(IRemoteLog source, params string[] includedColumns)
		{
			if (includedColumns.Contains(RemoteLogsTable.IdCol)) this.Id = source.Id;
			if (includedColumns.Contains(RemoteLogsTable.CreatedCol)) this.Created = source.Created;
			if (includedColumns.Contains(RemoteLogsTable.SeverityNumberCol)) this.SeverityNumber = source.SeverityNumber;
			if (includedColumns.Contains(RemoteLogsTable.TitleCol)) this.Title = source.Title;
			if (includedColumns.Contains(RemoteLogsTable.MessageCol)) this.Message = source.Message;
			if (includedColumns.Contains(RemoteLogsTable.CodeFileCol)) this.CodeFile = source.CodeFile;
			if (includedColumns.Contains(RemoteLogsTable.CodeMethodCol)) this.CodeMethod = source.CodeMethod;
			if (includedColumns.Contains(RemoteLogsTable.CodeLineCol)) this.CodeLine = source.CodeLine;
			if (includedColumns.Contains(RemoteLogsTable.RemoteInstanceIdCol)) this.RemoteInstanceId = source.RemoteInstanceId;
		}
		
		///	<summary>Creates a new instance of type <see cref="Poco_RemoteLog" />.</summary>
		public Poco_RemoteLog AsPoco()
		{
			Poco_RemoteLog poco = new Poco_RemoteLog();
			Copy_To(poco, true);
			return poco;
		}
	}
}