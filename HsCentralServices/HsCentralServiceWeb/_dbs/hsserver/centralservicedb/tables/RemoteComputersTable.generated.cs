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
//<date>2017-01-15 00:09:46</date>



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
using RemoteComputer=HsCentralServiceWeb._dbs.hsserver.centralservicedb.rows.RemoteComputer;
using IRemoteComputer=HsCentralServiceWeb._dbs.hsserver.centralservicedb.rowinterfaces.IRemoteComputer;
using HsCentralServiceWeb._dbs.hsserver;






namespace HsCentralServiceWeb._dbs.hsserver.centralservicedb.tables
{
	#pragma warning disable 657
	#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	
	///	<summary>
	///		'[<c>HsServer</c>].[<c>#CentralServiceDb#</c>].[<c>RemoteComputers</c>]': A Table inside '[<c>HsServer</c>].[<c>#CentralServiceDb#</c>]' database with '<see cref="RemoteComputer"/>' as <see cref="DataRow"/>.<para/>
	///		[<c>RemoteComputers</c>].[<c>Id</c>] &#60;&#60;&#60;&#60; [<c>RemoteUsers</c>].[<c>RemoteComputerId</c>]
	///	</summary>
	[Serializable]
	[DebuggerDisplay("DataTable(CentralServiceDb.RemoteComputers): Rows[{Rows.Count}]")]
	[CsDbDataTable(Database = "CentralServiceDb", Name = "RemoteComputers", Generated = "17.01.15 00:09:46", Hash = "C918A425F8A4A1D9AA04B28021BA80A2")]
	[CsDbResolvesRelation("FK__RemoteUse__Remot__18EBB532", PkTable = "RemoteComputers", PkColumn = "Id", FkTable = "RemoteUsers", FkColumn = "RemoteComputerId")]
	public partial class RemoteComputersTable : CsDbTable<RemoteComputer>
	{
		#region CONSTANTS
		///<summary>The native table name (RemoteComputers).</summary>
		public const string NativeName = "RemoteComputers";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteComputers].[Id]</c> column. Property = <see cref="RemoteComputer.Id"/>.</summary>
		public const string IdCol = "Id";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteComputers].[Name]</c> column. Property = <see cref="RemoteComputer.Name"/>.</summary>
		public const string NameCol = "Name";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteComputers].[OsName]</c> column. Property = <see cref="RemoteComputer.OsName"/>.</summary>
		public const string OsNameCol = "OsName";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteComputers].[OsRegisteredUser]</c> column. Property = <see cref="RemoteComputer.OsRegisteredUser"/>.</summary>
		public const string OsRegisteredUserCol = "OsRegisteredUser";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteComputers].[OsCountryCode]</c> column. Property = <see cref="RemoteComputer.OsCountryCode"/>.</summary>
		public const string OsCountryCodeCol = "OsCountryCode";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteComputers].[OsCodeSet]</c> column. Property = <see cref="RemoteComputer.OsCodeSet"/>.</summary>
		public const string OsCodeSetCol = "OsCodeSet";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteComputers].[OsProductType]</c> column. Property = <see cref="RemoteComputer.OsProductType"/>.</summary>
		public const string OsProductTypeCol = "OsProductType";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteComputers].[Manufacturer]</c> column. Property = <see cref="RemoteComputer.Manufacturer"/>.</summary>
		public const string ManufacturerCol = "Manufacturer";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteComputers].[Model]</c> column. Property = <see cref="RemoteComputer.Model"/>.</summary>
		public const string ModelCol = "Model";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteComputers].[Family]</c> column. Property = <see cref="RemoteComputer.Family"/>.</summary>
		public const string FamilyCol = "Family";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteComputers].[SkuNumber]</c> column. Property = <see cref="RemoteComputer.SkuNumber"/>.</summary>
		public const string SkuNumberCol = "SkuNumber";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteComputers].[BiosName]</c> column. Property = <see cref="RemoteComputer.BiosName"/>.</summary>
		public const string BiosNameCol = "BiosName";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteComputers].[BiosVersion]</c> column. Property = <see cref="RemoteComputer.BiosVersion"/>.</summary>
		public const string BiosVersionCol = "BiosVersion";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteComputers].[MainboardManufacturer]</c> column. Property = <see cref="RemoteComputer.MainboardManufacturer"/>.</summary>
		public const string MainboardManufacturerCol = "MainboardManufacturer";
		///<summary>Holds native column name of <c>[CentralServiceDb].[RemoteComputers].[MainboardProduct]</c> column. Property = <see cref="RemoteComputer.MainboardProduct"/>.</summary>
		public const string MainboardProductCol = "MainboardProduct";
	
		/// <summary> Contains attribute values for the columns</summary>
		public static class Cols
		{
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteComputers</c>].[<c>Id</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteComputers", Name = "Id", Type = "uniqueidentifier", Default = "(newid())", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute Id = new CsDbNativeDataColumnAttribute {Table = "RemoteComputers", Name = "Id", Type = "uniqueidentifier", Default = "(newid())", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteComputers</c>].[<c>Name</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteComputers", Name = "Name", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute Name = new CsDbNativeDataColumnAttribute {Table = "RemoteComputers", Name = "Name", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteComputers</c>].[<c>OsName</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteComputers", Name = "OsName", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute OsName = new CsDbNativeDataColumnAttribute {Table = "RemoteComputers", Name = "OsName", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteComputers</c>].[<c>OsRegisteredUser</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteComputers", Name = "OsRegisteredUser", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute OsRegisteredUser = new CsDbNativeDataColumnAttribute {Table = "RemoteComputers", Name = "OsRegisteredUser", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteComputers</c>].[<c>OsCountryCode</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteComputers", Name = "OsCountryCode", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute OsCountryCode = new CsDbNativeDataColumnAttribute {Table = "RemoteComputers", Name = "OsCountryCode", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteComputers</c>].[<c>OsCodeSet</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteComputers", Name = "OsCodeSet", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute OsCodeSet = new CsDbNativeDataColumnAttribute {Table = "RemoteComputers", Name = "OsCodeSet", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteComputers</c>].[<c>OsProductType</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteComputers", Name = "OsProductType", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute OsProductType = new CsDbNativeDataColumnAttribute {Table = "RemoteComputers", Name = "OsProductType", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteComputers</c>].[<c>Manufacturer</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteComputers", Name = "Manufacturer", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute Manufacturer = new CsDbNativeDataColumnAttribute {Table = "RemoteComputers", Name = "Manufacturer", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteComputers</c>].[<c>Model</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteComputers", Name = "Model", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute Model = new CsDbNativeDataColumnAttribute {Table = "RemoteComputers", Name = "Model", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteComputers</c>].[<c>Family</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteComputers", Name = "Family", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute Family = new CsDbNativeDataColumnAttribute {Table = "RemoteComputers", Name = "Family", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteComputers</c>].[<c>SkuNumber</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteComputers", Name = "SkuNumber", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute SkuNumber = new CsDbNativeDataColumnAttribute {Table = "RemoteComputers", Name = "SkuNumber", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteComputers</c>].[<c>BiosName</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteComputers", Name = "BiosName", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute BiosName = new CsDbNativeDataColumnAttribute {Table = "RemoteComputers", Name = "BiosName", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteComputers</c>].[<c>BiosVersion</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteComputers", Name = "BiosVersion", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute BiosVersion = new CsDbNativeDataColumnAttribute {Table = "RemoteComputers", Name = "BiosVersion", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteComputers</c>].[<c>MainboardManufacturer</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteComputers", Name = "MainboardManufacturer", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute MainboardManufacturer = new CsDbNativeDataColumnAttribute {Table = "RemoteComputers", Name = "MainboardManufacturer", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>CentralServiceDb</c>].[<c>RemoteComputers</c>].[<c>MainboardProduct</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "RemoteComputers", Name = "MainboardProduct", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute MainboardProduct = new CsDbNativeDataColumnAttribute {Table = "RemoteComputers", Name = "MainboardProduct", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
		}
		#endregion
	
	
	
	
	
	
	
		///<summary>Default constructor for save <see cref="DataTable"/> operations</summary>
		public RemoteComputersTable()
		{
			TableName = NativeName;
		}
	
		///<summary>References the owning data context, this is equal to the database server. Use this to address databases on the same server.</summary>
		public new HsCentralServiceWeb._dbs.hsserver.HsServerContext DataContext => DataSet.DataContext;
	
		///<summary>References the owning dataset. Use this to address tables in the same database</summary>
		public new CentralServiceDb DataSet => (CentralServiceDb) base.DataSet;
	
	
	
	
	
	
	
		#region FUNC<Overrides>
		
		///	<summary><c>SELECT (DefaultSqlSelector) FROM [RemoteComputers]</c><para>The default selector is the * operator</para></summary>
		[DebuggerStepThrough] 
		public override void DownloadRows()
		{
			DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}]", false);
			HasBeenLoaded = true;
		}
		///	<summary><c>SELECT <paramref name="top"/> (DefaultSqlSelector) FROM [RemoteComputers]</c><para>The default selector is the * operator</para></summary>
		[DebuggerStepThrough] 
		public override void DownloadRows(int top)
		{
			DownloadRows($"SELECT TOP {top} {DefaultSqlSelector} FROM [{NativeName}]", false);
		}
		
		
		///<summary>This method calls <see cref="FindOrLoad"/>.</summary>
		[DebuggerStepThrough] 
		public override CsDbRowBase Generic_FindOrLoad(object id)
		{
			return id==null ? null : FindOrLoad((Guid?) id);
		}
		///<summary>This method calls <see cref="LoadThenFind"/>.</summary>
		[DebuggerStepThrough] 
		public override CsDbRowBase Generic_LoadThenFind(object id)
		{
			return id==null ? null : LoadThenFind((Guid?) id);
		}
		///<summary>This method calls <see cref="Find"/>.</summary>
		[DebuggerStepThrough] 
		public override CsDbRowBase Generic_Find(object id)
		{
			return id==null ? null : Find((Guid?) id);
		}
		
		
		
		///<summary>This method calls <see cref="FindOrLoad"/>.</summary>
		[DebuggerStepThrough] 
		public override CsDbRowBase[] Generic_FindOrLoad(params object[] ids)
		{
			return FindOrLoad_Each(ids.OfType<Guid>().ToArray()).OfType<CsDbRowBase>().ToArray();
		}
		///<summary>This method calls <see cref="LoadThenFind"/>.</summary>
		[DebuggerStepThrough] 
		public override CsDbRowBase[] Generic_LoadThenFind(params object[] ids)
		{
			return LoadThenFind_Each(ids.OfType<Guid>().ToArray()).OfType<CsDbRowBase>().ToArray();
		}
		///<summary>This method calls <see cref="Find"/>.</summary>
		[DebuggerStepThrough] 
		public override CsDbRowBase[] Generic_Find(params object[] ids)
		{
			return Find_Each(ids.OfType<Guid>().ToArray()).OfType<CsDbRowBase>().ToArray();
		}
		#endregion
		
		
		
		
		#region FUNC<Primary Key>
		
		///	<summary>
		///		find an item in local data where Id = '<paramref name="id"/>'. If nothing is found QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [RemoteComputers] WHERE [Id] = '<paramref name="id"/>'</c>.<para/>
		///		If no primary key is set execute <see cref="LoadThenFind"/> instead.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK__RemoteUse__Remot__18EBB532", PkTable = "RemoteComputers", PkColumn = "Id", FkTable = "RemoteUsers", FkColumn = "RemoteComputerId")]
		[DebuggerStepThrough] 
		public RemoteComputer FindOrLoad(Guid? id)
		{
			if (id == null)
				return null;
		
			if (PrimaryKey.Length == 0)
				return LoadThenFind(id);
		
			return Find(id) ?? LoadThenFind(id);
		}
		
		
		///<summary>
		///		QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [RemoteComputers] WHERE [Id] = '<paramref name="id"/>'</c> THEN find an item in local data where Id = '<paramref name="id"/>'.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///</summary>
		[CsDbResolvesRelation("FK__RemoteUse__Remot__18EBB532", PkTable = "RemoteComputers", PkColumn = "Id", FkTable = "RemoteUsers", FkColumn = "RemoteComputerId")]
		[DebuggerStepThrough] 
		public RemoteComputer LoadThenFind(Guid? id)
		{
			if (id == null)
				return null;
		
			DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}] WHERE [Id] = '{id}'", false);
			
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
		
			return Rows.Find(id.Value) as RemoteComputer;
		}
		
		
		///	<summary>
		///		find an item in local data where Id = '<paramref name="id"/>'. IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK__RemoteUse__Remot__18EBB532", PkTable = "RemoteComputers", PkColumn = "Id", FkTable = "RemoteUsers", FkColumn = "RemoteComputerId")]
		[DebuggerStepThrough] 
		public RemoteComputer Find(Guid? id)
		{
			if (id == null)
				return null;
		
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
		
			return Rows.Find(id.Value) as RemoteComputer;
		}
		#endregion
		
		#region FUNC<Primary Key Many>
		///	<summary>
		///		find items in local data where Id IN '<paramref name="ids"/>'. If nothing is found QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [RemoteComputers] WHERE [Id] IN '<paramref name="ids"/>'</c>.<para/>
		///		If no primary key is set execute <see cref="LoadThenFind_Each"/> instead.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK__RemoteUse__Remot__18EBB532", PkTable = "RemoteComputers", PkColumn = "Id", FkTable = "RemoteUsers", FkColumn = "RemoteComputerId")]
		[DebuggerStepThrough] 
		public RemoteComputer[] FindOrLoad_Each(params Guid[] ids)
		{
			if (ids == null || ids.Length == 0)
				return new RemoteComputer[0];
		
			if (PrimaryKey.Length == 0)
				return LoadThenFind_Each(ids);
				
			var locallyFound = Find_Each(ids);
			var loaded = LoadThenFind_Each(ids.Except(locallyFound.Select(x=>x.Id)).ToArray());
			return locallyFound.Union(loaded).ToArray();
		}
		
		
		///<summary>
		///		QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [RemoteComputers] WHERE [Id] IN '<paramref name="ids"/>'</c> THEN find items in local data where Id IN '<paramref name="ids"/>'.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///</summary>
		[CsDbResolvesRelation("FK__RemoteUse__Remot__18EBB532", PkTable = "RemoteComputers", PkColumn = "Id", FkTable = "RemoteUsers", FkColumn = "RemoteComputerId")]
		[DebuggerStepThrough] 
		public RemoteComputer[] LoadThenFind_Each(params Guid[] ids)
		{
			if (ids == null || ids.Length == 0)
				return new RemoteComputer[0];
		
			DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}] WHERE [Id] IN ('{ids.Select(x=>x.ToString()).Join("', '")}')", false);
			
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
		
			return Find_Each(ids);
		}
		
		
		///	<summary>
		///		find items in local data where Id IN '<paramref name="ids"/>'. IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK__RemoteUse__Remot__18EBB532", PkTable = "RemoteComputers", PkColumn = "Id", FkTable = "RemoteUsers", FkColumn = "RemoteComputerId")]
		[DebuggerStepThrough] 
		public RemoteComputer[] Find_Each(params Guid[] ids)
		{
			if (ids == null || ids.Length == 0)
				return new RemoteComputer[0];
		
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
				
			return Select(ids.Select(key=>$"{IdCol} = '{key}'").Join(" OR "));
		}
		#endregion
		
		
		
		
		
		#region FUNC<Foreign Key>
		
		#endregion
		
		
		/// <summary>Creates a row then copy's the data from the <paramref name="item"/> and adds it to the row collection.</summary>
		public RemoteComputer AddAsNewRow(IRemoteComputer item)
		{
			var row = NewRow();
			row.Copy_From(item, true);
			Add(row);
			return row;
		}
	}
}