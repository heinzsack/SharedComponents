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
//<date>2017-01-04 13:12:47</date>



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
using Image=HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.rows.Image;
using IImage=HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.rowinterfaces.IImage;
using HsCentralServiceWebInterfacesServer._dbs.hsserver;






namespace HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.tables
{
	#pragma warning disable 657
	#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	
	///	<summary>
	///		'[<c>HsServer</c>].[<c>#RingPlayerDb#</c>].[<c>Images</c>]': A Table inside '[<c>HsServer</c>].[<c>#RingPlayerDb#</c>]' database with '<see cref="Image"/>' as <see cref="DataRow"/>.<para/>
	///		[<c>Images</c>].[<c>ParentPageId</c>] &#62;&#62;&#62;&#62; [<c>Pages</c>].[<c>Id</c>]
	///	</summary>
	[Serializable]
	[DebuggerDisplay("DataTable(RingPlayerDb.Images): Rows[{Rows.Count}]")]
	[CsDbDataTable(Database = "RingPlayerDb", Name = "Images", Generated = "17.01.04 13:12:47", Hash = "648057E9E0A9AD67601801B1BF5C1ED6")]
	[CsDbResolvesRelation("FK_Images_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Images", FkColumn = "ParentPageId")]
	public partial class ImagesTable : CsDbTable<Image>
	{
		#region CONSTANTS
		///<summary>The native table name (Images).</summary>
		public const string NativeName = "Images";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Images].[Id]</c> column. Property = <see cref="Image.Id"/>.</summary>
		public const string IdCol = "Id";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Images].[DiagnosticText]</c> column. Property = <see cref="Image.DiagnosticText"/>.</summary>
		public const string DiagnosticTextCol = "DiagnosticText";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Images].[Extension]</c> column. Property = <see cref="Image.Extension"/>.</summary>
		public const string ExtensionCol = "Extension";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Images].[ImageId]</c> column. Property = <see cref="Image.ImageId"/>.</summary>
		public const string ImageIdCol = "ImageId";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Images].[ParentPageId]</c> column. Property = <see cref="Image.ParentPageId"/>.</summary>
		public const string ParentPageIdCol = "ParentPageId";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Images].[SortOrder]</c> column. Property = <see cref="Image.SortOrder"/>.</summary>
		public const string SortOrderCol = "SortOrder";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Images].[MarginThickness]</c> column. Property = <see cref="Image.MarginThickness"/>.</summary>
		public const string MarginThicknessCol = "MarginThickness";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Images].[BorderThickness]</c> column. Property = <see cref="Image.BorderThickness"/>.</summary>
		public const string BorderThicknessCol = "BorderThickness";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Images].[Background]</c> column. Property = <see cref="Image.Background"/>.</summary>
		public const string BackgroundCol = "Background";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Images].[BorderColor]</c> column. Property = <see cref="Image.BorderColor"/>.</summary>
		public const string BorderColorCol = "BorderColor";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Images].[Rotation]</c> column. Property = <see cref="Image.Rotation"/>.</summary>
		public const string RotationCol = "Rotation";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Images].[FileIdentifier]</c> column. Property = <see cref="Image.FileIdentifier"/>.</summary>
		public const string FileIdentifierCol = "FileIdentifier";
	
		/// <summary> Contains attribute values for the columns</summary>
		public static class Cols
		{
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Images</c>].[<c>Id</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Images", Name = "Id", Type = "uniqueidentifier", Default = "(newid())", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute Id = new CsDbNativeDataColumnAttribute {Table = "Images", Name = "Id", Type = "uniqueidentifier", Default = "(newid())", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Images</c>].[<c>DiagnosticText</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Images", Name = "DiagnosticText", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute DiagnosticText = new CsDbNativeDataColumnAttribute {Table = "Images", Name = "DiagnosticText", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Images</c>].[<c>Extension</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Images", Name = "Extension", Type = "nvarchar", MaxLength = "50", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute Extension = new CsDbNativeDataColumnAttribute {Table = "Images", Name = "Extension", Type = "nvarchar", MaxLength = "50", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Images</c>].[<c>ImageId</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Images", Name = "ImageId", Type = "uniqueidentifier", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute ImageId = new CsDbNativeDataColumnAttribute {Table = "Images", Name = "ImageId", Type = "uniqueidentifier", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Images</c>].[<c>ParentPageId</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Images", Name = "ParentPageId", Type = "uniqueidentifier", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute ParentPageId = new CsDbNativeDataColumnAttribute {Table = "Images", Name = "ParentPageId", Type = "uniqueidentifier", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Images</c>].[<c>SortOrder</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Images", Name = "SortOrder", Type = "int", Default = "((0))", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute SortOrder = new CsDbNativeDataColumnAttribute {Table = "Images", Name = "SortOrder", Type = "int", Default = "((0))", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Images</c>].[<c>MarginThickness</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Images", Name = "MarginThickness", Type = "nvarchar", MaxLength = "256", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute MarginThickness = new CsDbNativeDataColumnAttribute {Table = "Images", Name = "MarginThickness", Type = "nvarchar", MaxLength = "256", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Images</c>].[<c>BorderThickness</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Images", Name = "BorderThickness", Type = "nvarchar", MaxLength = "256", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute BorderThickness = new CsDbNativeDataColumnAttribute {Table = "Images", Name = "BorderThickness", Type = "nvarchar", MaxLength = "256", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Images</c>].[<c>Background</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Images", Name = "Background", Type = "nvarchar", MaxLength = "50", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute Background = new CsDbNativeDataColumnAttribute {Table = "Images", Name = "Background", Type = "nvarchar", MaxLength = "50", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Images</c>].[<c>BorderColor</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Images", Name = "BorderColor", Type = "nvarchar", MaxLength = "50", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute BorderColor = new CsDbNativeDataColumnAttribute {Table = "Images", Name = "BorderColor", Type = "nvarchar", MaxLength = "50", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Images</c>].[<c>Rotation</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Images", Name = "Rotation", Type = "float", Default = "((0))", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute Rotation = new CsDbNativeDataColumnAttribute {Table = "Images", Name = "Rotation", Type = "float", Default = "((0))", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Images</c>].[<c>FileIdentifier</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Images", Name = "FileIdentifier", Type = "uniqueidentifier", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute FileIdentifier = new CsDbNativeDataColumnAttribute {Table = "Images", Name = "FileIdentifier", Type = "uniqueidentifier", IsNullable = "NO"};
		}
		#endregion
	
	
	
	
	
	
	
		///<summary>Default constructor for save <see cref="DataTable"/> operations</summary>
		public ImagesTable()
		{
			TableName = NativeName;
		}
	
		///<summary>References the owning data context, this is equal to the database server. Use this to address databases on the same server.</summary>
		public new HsCentralServiceWebInterfacesServer._dbs.hsserver.HsServerContext DataContext => DataSet.DataContext;
	
		///<summary>References the owning dataset. Use this to address tables in the same database</summary>
		public new RingPlayerDb DataSet => (RingPlayerDb) base.DataSet;
	
	
	
	
	
	
	
		#region FUNC<Overrides>
		
		///	<summary><c>SELECT (DefaultSqlSelector) FROM [Images]</c><para>The default selector is the * operator</para></summary>
		[DebuggerStepThrough] 
		public override void DownloadRows()
		{
			DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}]", false);
			HasBeenLoaded = true;
		}
		///	<summary><c>SELECT <paramref name="top"/> (DefaultSqlSelector) FROM [Images]</c><para>The default selector is the * operator</para></summary>
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
		///		find an item in local data where Id = '<paramref name="id"/>'. If nothing is found QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [Images] WHERE [Id] = '<paramref name="id"/>'</c>.<para/>
		///		If no primary key is set execute <see cref="LoadThenFind"/> instead.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK_Images_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Images", FkColumn = "ParentPageId")]
		[DebuggerStepThrough] 
		public Image FindOrLoad(Guid? id)
		{
			if (id == null)
				return null;
		
			if (PrimaryKey.Length == 0)
				return LoadThenFind(id);
		
			return Find(id) ?? LoadThenFind(id);
		}
		
		
		///<summary>
		///		QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [Images] WHERE [Id] = '<paramref name="id"/>'</c> THEN find an item in local data where Id = '<paramref name="id"/>'.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///</summary>
		[CsDbResolvesRelation("FK_Images_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Images", FkColumn = "ParentPageId")]
		[DebuggerStepThrough] 
		public Image LoadThenFind(Guid? id)
		{
			if (id == null)
				return null;
		
			DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}] WHERE [Id] = '{id}'", false);
			
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
		
			return Rows.Find(id.Value) as Image;
		}
		
		
		///	<summary>
		///		find an item in local data where Id = '<paramref name="id"/>'. IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK_Images_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Images", FkColumn = "ParentPageId")]
		[DebuggerStepThrough] 
		public Image Find(Guid? id)
		{
			if (id == null)
				return null;
		
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
		
			return Rows.Find(id.Value) as Image;
		}
		#endregion
		
		#region FUNC<Primary Key Many>
		///	<summary>
		///		find items in local data where Id IN '<paramref name="ids"/>'. If nothing is found QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [Images] WHERE [Id] IN '<paramref name="ids"/>'</c>.<para/>
		///		If no primary key is set execute <see cref="LoadThenFind_Each"/> instead.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK_Images_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Images", FkColumn = "ParentPageId")]
		[DebuggerStepThrough] 
		public Image[] FindOrLoad_Each(params Guid[] ids)
		{
			if (ids == null || ids.Length == 0)
				return new Image[0];
		
			if (PrimaryKey.Length == 0)
				return LoadThenFind_Each(ids);
				
			var locallyFound = Find_Each(ids);
			var loaded = LoadThenFind_Each(ids.Except(locallyFound.Select(x=>x.Id)).ToArray());
			return locallyFound.Union(loaded).ToArray();
		}
		
		
		///<summary>
		///		QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [Images] WHERE [Id] IN '<paramref name="ids"/>'</c> THEN find items in local data where Id IN '<paramref name="ids"/>'.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///</summary>
		[CsDbResolvesRelation("FK_Images_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Images", FkColumn = "ParentPageId")]
		[DebuggerStepThrough] 
		public Image[] LoadThenFind_Each(params Guid[] ids)
		{
			if (ids == null || ids.Length == 0)
				return new Image[0];
		
			DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}] WHERE [Id] IN ('{ids.Select(x=>x.ToString()).Join("', '")}')", false);
			
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
		
			return Find_Each(ids);
		}
		
		
		///	<summary>
		///		find items in local data where Id IN '<paramref name="ids"/>'. IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK_Images_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Images", FkColumn = "ParentPageId")]
		[DebuggerStepThrough] 
		public Image[] Find_Each(params Guid[] ids)
		{
			if (ids == null || ids.Length == 0)
				return new Image[0];
		
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
				
			return Select(ids.Select(key=>$"{IdCol} = '{key}'").Join(" OR "));
		}
		#endregion
		
		
		
		
		
		#region FUNC<Foreign Key>
		[field:NonSerialized] private Dictionary<Guid?, CsWeakReference<ContractCollection<Image>>> _byParentPageId = new Dictionary<Guid?, CsWeakReference<ContractCollection<Image>>>();
		
		///	<summary> 
		///		Query <c>SELECT (DefaultSqlSelector) FROM Images WHERE [ParentPageId] = '<paramref name="parentPageId"/>'</c><para/>
		///		[<c>Images</c>].[<c>ParentPageId</c>] &#62;&#62;&#62;&#62; [<c>Pages</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK_Images_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Images", FkColumn = "ParentPageId")]
		[DebuggerStepThrough]
		public ContractCollection<Image> FindOrLoad_By_ParentPageId(Guid? parentPageId)
		{
			if (parentPageId == null)
				return null;
			CsWeakReference<ContractCollection<Image>> weak;
			ContractCollection<Image> result;
		
			if (_byParentPageId.TryGetValue(parentPageId, out weak) && weak.TryGetTarget(out result))
				return result;
		
			if (HasBeenLoaded == true || weak != null)
				result = CreateContractCollection(@image => Equals(@image.ParentPageId, parentPageId));
			else 
			{
				DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}] WHERE [{ParentPageIdCol}] = '{parentPageId}'", false);
				result = CreateContractCollection(@image => Equals(@image.ParentPageId, parentPageId));
			}
		
			if (weak == null)
				_byParentPageId.Add(parentPageId, weak = new CsWeakReference<ContractCollection<Image>>(result));
			else
				weak.SetTarget(result);
		
			return result;
		}
		///	<summary> 
		///		Query <c>SELECT (DefaultSqlSelector) FROM Images WHERE [ParentPageId] = '<paramref name="parentPageId"/>'</c><para/>
		///		[<c>Images</c>].[<c>ParentPageId</c>] &#62;&#62;&#62;&#62; [<c>Pages</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK_Images_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Images", FkColumn = "ParentPageId")]
		[DebuggerStepThrough] 
		public ContractCollection<Image> LoadThenFind_By_ParentPageId(Guid? parentPageId)
		{
			if (parentPageId == null)
				return null;
			CsWeakReference<ContractCollection<Image>> weak;
			ContractCollection<Image> result;
		
			DownloadRows($"SELECT {DefaultSqlSelector} FROM {NativeName} WHERE [{ParentPageIdCol}] = '{parentPageId}'", false);
		
			if (_byParentPageId.TryGetValue(parentPageId, out weak) && weak.TryGetTarget(out result))
				return result;
		
			result = CreateContractCollection(@image => Equals(@image.ParentPageId, parentPageId));
		
			if (weak == null)
				_byParentPageId.Add(parentPageId, weak = new CsWeakReference<ContractCollection<Image>>(result));
			else
				weak.SetTarget(result);
		
			return result;
		}
		///	<summary> 
		///		Query <c>SELECT (DefaultSqlSelector) FROM Images WHERE [ParentPageId] = '<paramref name="parentPageId"/>'</c><para/>
		///		[<c>Images</c>].[<c>ParentPageId</c>] &#62;&#62;&#62;&#62; [<c>Pages</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK_Images_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Images", FkColumn = "ParentPageId")]
		[DebuggerStepThrough]
		public ContractCollection<Image> Find_By_ParentPageId(Guid? parentPageId)
		{
			if (parentPageId == null)
				return null;
			CsWeakReference<ContractCollection<Image>> weak;
			ContractCollection<Image> result;
		
			if (_byParentPageId.TryGetValue(parentPageId, out weak) && weak.TryGetTarget(out result))
				return result;
		
		
			result = CreateContractCollection(@image => Equals(@image.ParentPageId, parentPageId));
		
		    if (weak == null)
				_byParentPageId.Add(parentPageId, weak = new CsWeakReference<ContractCollection<Image>>(result));
			else
				weak.SetTarget(result);
		
			return result;
		}
		#endregion
		
		
		/// <summary>Creates a row then copy's the data from the <paramref name="item"/> and adds it to the row collection.</summary>
		public Image AddAsNewRow(IImage item)
		{
			var row = NewRow();
			row.Copy_From(item, true);
			Add(row);
			return row;
		}
	}
}