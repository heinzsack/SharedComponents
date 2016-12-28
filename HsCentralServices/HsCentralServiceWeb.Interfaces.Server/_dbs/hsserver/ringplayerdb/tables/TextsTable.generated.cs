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
//<date>2016-12-28 13:36:31</date>



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
using Text=HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.rows.Text;
using IText=HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.rowinterfaces.IText;
using HsCentralServiceWebInterfacesServer._dbs.hsserver;






namespace HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.tables
{
	#pragma warning disable 657
	#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	
	///	<summary>
	///		'[<c>HsServer</c>].[<c>#RingPlayerDb#</c>].[<c>Texts</c>]': A Table inside '[<c>HsServer</c>].[<c>#RingPlayerDb#</c>]' database with '<see cref="Text"/>' as <see cref="DataRow"/>.<para/>
	///		[<c>Texts</c>].[<c>ParentPageId</c>] &#62;&#62;&#62;&#62; [<c>Pages</c>].[<c>Id</c>]
	///	</summary>
	[Serializable]
	[DebuggerDisplay("DataTable(RingPlayerDb.Texts): Rows[{Rows.Count}]")]
	[CsDbDataTable(Database = "RingPlayerDb", Name = "Texts", Generated = "16.12.28 13:36:31", Hash = "2D0F28C631FE7442E2651BEFF83E64A5")]
	[CsDbResolvesRelation("FK_Texts_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Texts", FkColumn = "ParentPageId")]
	public partial class TextsTable : CsDbTable<Text>
	{
		#region CONSTANTS
		///<summary>The native table name (Texts).</summary>
		public const string NativeName = "Texts";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Texts].[Id]</c> column. Property = <see cref="Text.Id"/>.</summary>
		public const string IdCol = "Id";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Texts].[DiagnosticText]</c> column. Property = <see cref="Text.DiagnosticText"/>.</summary>
		public const string DiagnosticTextCol = "DiagnosticText";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Texts].[ParentPageId]</c> column. Property = <see cref="Text.ParentPageId"/>.</summary>
		public const string ParentPageIdCol = "ParentPageId";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Texts].[SortOrder]</c> column. Property = <see cref="Text.SortOrder"/>.</summary>
		public const string SortOrderCol = "SortOrder";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Texts].[MarginThickness]</c> column. Property = <see cref="Text.MarginThickness"/>.</summary>
		public const string MarginThicknessCol = "MarginThickness";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Texts].[BorderThickness]</c> column. Property = <see cref="Text.BorderThickness"/>.</summary>
		public const string BorderThicknessCol = "BorderThickness";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Texts].[Background]</c> column. Property = <see cref="Text.Background"/>.</summary>
		public const string BackgroundCol = "Background";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Texts].[BorderColor]</c> column. Property = <see cref="Text.BorderColor"/>.</summary>
		public const string BorderColorCol = "BorderColor";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Texts].[Rotation]</c> column. Property = <see cref="Text.Rotation"/>.</summary>
		public const string RotationCol = "Rotation";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Texts].[Text]</c> column. Property = <see cref="Text.TextColumn"/>.</summary>
		public const string TextColumnCol = "Text";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Texts].[Foreground]</c> column. Property = <see cref="Text.Foreground"/>.</summary>
		public const string ForegroundCol = "Foreground";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Texts].[FontFamily]</c> column. Property = <see cref="Text.FontFamily"/>.</summary>
		public const string FontFamilyCol = "FontFamily";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Texts].[FontWeight]</c> column. Property = <see cref="Text.FontWeight"/>.</summary>
		public const string FontWeightCol = "FontWeight";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Texts].[FontStyle]</c> column. Property = <see cref="Text.FontStyle"/>.</summary>
		public const string FontStyleCol = "FontStyle";
	
		/// <summary> Contains attribute values for the columns</summary>
		public static class Cols
		{
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Texts</c>].[<c>Id</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Texts", Name = "Id", Type = "uniqueidentifier", Default = "(newid())", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute Id = new CsDbNativeDataColumnAttribute {Table = "Texts", Name = "Id", Type = "uniqueidentifier", Default = "(newid())", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Texts</c>].[<c>DiagnosticText</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Texts", Name = "DiagnosticText", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute DiagnosticText = new CsDbNativeDataColumnAttribute {Table = "Texts", Name = "DiagnosticText", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Texts</c>].[<c>ParentPageId</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Texts", Name = "ParentPageId", Type = "uniqueidentifier", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute ParentPageId = new CsDbNativeDataColumnAttribute {Table = "Texts", Name = "ParentPageId", Type = "uniqueidentifier", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Texts</c>].[<c>SortOrder</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Texts", Name = "SortOrder", Type = "int", Default = "((0))", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute SortOrder = new CsDbNativeDataColumnAttribute {Table = "Texts", Name = "SortOrder", Type = "int", Default = "((0))", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Texts</c>].[<c>MarginThickness</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Texts", Name = "MarginThickness", Type = "nvarchar", MaxLength = "256", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute MarginThickness = new CsDbNativeDataColumnAttribute {Table = "Texts", Name = "MarginThickness", Type = "nvarchar", MaxLength = "256", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Texts</c>].[<c>BorderThickness</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Texts", Name = "BorderThickness", Type = "nvarchar", MaxLength = "256", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute BorderThickness = new CsDbNativeDataColumnAttribute {Table = "Texts", Name = "BorderThickness", Type = "nvarchar", MaxLength = "256", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Texts</c>].[<c>Background</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Texts", Name = "Background", Type = "nvarchar", MaxLength = "50", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute Background = new CsDbNativeDataColumnAttribute {Table = "Texts", Name = "Background", Type = "nvarchar", MaxLength = "50", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Texts</c>].[<c>BorderColor</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Texts", Name = "BorderColor", Type = "nvarchar", MaxLength = "50", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute BorderColor = new CsDbNativeDataColumnAttribute {Table = "Texts", Name = "BorderColor", Type = "nvarchar", MaxLength = "50", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Texts</c>].[<c>Rotation</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Texts", Name = "Rotation", Type = "float", Default = "((0))", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute Rotation = new CsDbNativeDataColumnAttribute {Table = "Texts", Name = "Rotation", Type = "float", Default = "((0))", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Texts</c>].[<c>Text</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Texts", Name = "Text", Type = "nvarchar", MaxLength = "2048", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute TextColumn = new CsDbNativeDataColumnAttribute {Table = "Texts", Name = "Text", Type = "nvarchar", MaxLength = "2048", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Texts</c>].[<c>Foreground</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Texts", Name = "Foreground", Type = "nvarchar", MaxLength = "50", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute Foreground = new CsDbNativeDataColumnAttribute {Table = "Texts", Name = "Foreground", Type = "nvarchar", MaxLength = "50", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Texts</c>].[<c>FontFamily</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Texts", Name = "FontFamily", Type = "nvarchar", MaxLength = "50", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute FontFamily = new CsDbNativeDataColumnAttribute {Table = "Texts", Name = "FontFamily", Type = "nvarchar", MaxLength = "50", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Texts</c>].[<c>FontWeight</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Texts", Name = "FontWeight", Type = "nvarchar", MaxLength = "50", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute FontWeight = new CsDbNativeDataColumnAttribute {Table = "Texts", Name = "FontWeight", Type = "nvarchar", MaxLength = "50", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Texts</c>].[<c>FontStyle</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Texts", Name = "FontStyle", Type = "nvarchar", MaxLength = "50", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute FontStyle = new CsDbNativeDataColumnAttribute {Table = "Texts", Name = "FontStyle", Type = "nvarchar", MaxLength = "50", IsNullable = "YES"};
		}
		#endregion
	
	
	
	
	
	
	
		///<summary>Default constructor for save <see cref="DataTable"/> operations</summary>
		public TextsTable()
		{
			TableName = NativeName;
		}
	
		///<summary>References the owning data context, this is equal to the database server. Use this to address databases on the same server.</summary>
		public new HsCentralServiceWebInterfacesServer._dbs.hsserver.HsServerContext DataContext => DataSet.DataContext;
	
		///<summary>References the owning dataset. Use this to address tables in the same database</summary>
		public new RingPlayerDb DataSet => (RingPlayerDb) base.DataSet;
	
	
	
	
	
	
	
		#region FUNC<Overrides>
		
		///	<summary><c>SELECT (DefaultSqlSelector) FROM [Texts]</c><para>The default selector is the * operator</para></summary>
		[DebuggerStepThrough] 
		public override void DownloadRows()
		{
			DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}]", false);
			HasBeenLoaded = true;
		}
		///	<summary><c>SELECT <paramref name="top"/> (DefaultSqlSelector) FROM [Texts]</c><para>The default selector is the * operator</para></summary>
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
		///		find an item in local data where Id = '<paramref name="id"/>'. If nothing is found QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [Texts] WHERE [Id] = '<paramref name="id"/>'</c>.<para/>
		///		If no primary key is set execute <see cref="LoadThenFind"/> instead.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK_Texts_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Texts", FkColumn = "ParentPageId")]
		[DebuggerStepThrough] 
		public Text FindOrLoad(Guid? id)
		{
			if (id == null)
				return null;
		
			if (PrimaryKey.Length == 0)
				return LoadThenFind(id);
		
			return Find(id) ?? LoadThenFind(id);
		}
		
		
		///<summary>
		///		QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [Texts] WHERE [Id] = '<paramref name="id"/>'</c> THEN find an item in local data where Id = '<paramref name="id"/>'.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///</summary>
		[CsDbResolvesRelation("FK_Texts_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Texts", FkColumn = "ParentPageId")]
		[DebuggerStepThrough] 
		public Text LoadThenFind(Guid? id)
		{
			if (id == null)
				return null;
		
			DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}] WHERE [Id] = '{id}'", false);
			
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
		
			return Rows.Find(id.Value) as Text;
		}
		
		
		///	<summary>
		///		find an item in local data where Id = '<paramref name="id"/>'. IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK_Texts_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Texts", FkColumn = "ParentPageId")]
		[DebuggerStepThrough] 
		public Text Find(Guid? id)
		{
			if (id == null)
				return null;
		
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
		
			return Rows.Find(id.Value) as Text;
		}
		#endregion
		
		#region FUNC<Primary Key Many>
		///	<summary>
		///		find items in local data where Id IN '<paramref name="ids"/>'. If nothing is found QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [Texts] WHERE [Id] IN '<paramref name="ids"/>'</c>.<para/>
		///		If no primary key is set execute <see cref="LoadThenFind_Each"/> instead.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK_Texts_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Texts", FkColumn = "ParentPageId")]
		[DebuggerStepThrough] 
		public Text[] FindOrLoad_Each(params Guid[] ids)
		{
			if (ids == null || ids.Length == 0)
				return new Text[0];
		
			if (PrimaryKey.Length == 0)
				return LoadThenFind_Each(ids);
				
			var locallyFound = Find_Each(ids);
			var loaded = LoadThenFind_Each(ids.Except(locallyFound.Select(x=>x.Id)).ToArray());
			return locallyFound.Union(loaded).ToArray();
		}
		
		
		///<summary>
		///		QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [Texts] WHERE [Id] IN '<paramref name="ids"/>'</c> THEN find items in local data where Id IN '<paramref name="ids"/>'.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///</summary>
		[CsDbResolvesRelation("FK_Texts_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Texts", FkColumn = "ParentPageId")]
		[DebuggerStepThrough] 
		public Text[] LoadThenFind_Each(params Guid[] ids)
		{
			if (ids == null || ids.Length == 0)
				return new Text[0];
		
			DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}] WHERE [Id] IN ('{ids.Select(x=>x.ToString()).Join("', '")}')", false);
			
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
		
			return Find_Each(ids);
		}
		
		
		///	<summary>
		///		find items in local data where Id IN '<paramref name="ids"/>'. IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK_Texts_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Texts", FkColumn = "ParentPageId")]
		[DebuggerStepThrough] 
		public Text[] Find_Each(params Guid[] ids)
		{
			if (ids == null || ids.Length == 0)
				return new Text[0];
		
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
				
			return Select(ids.Select(key=>$"{IdCol} = '{key}'").Join(" OR "));
		}
		#endregion
		
		
		
		
		
		#region FUNC<Foreign Key>
		[field:NonSerialized] private Dictionary<Guid?, CsWeakReference<ContractCollection<Text>>> _byParentPageId = new Dictionary<Guid?, CsWeakReference<ContractCollection<Text>>>();
		
		///	<summary> 
		///		Query <c>SELECT (DefaultSqlSelector) FROM Texts WHERE [ParentPageId] = '<paramref name="parentPageId"/>'</c><para/>
		///		[<c>Texts</c>].[<c>ParentPageId</c>] &#62;&#62;&#62;&#62; [<c>Pages</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK_Texts_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Texts", FkColumn = "ParentPageId")]
		[DebuggerStepThrough]
		public ContractCollection<Text> FindOrLoad_By_ParentPageId(Guid? parentPageId)
		{
			if (parentPageId == null)
				return null;
			CsWeakReference<ContractCollection<Text>> weak;
			ContractCollection<Text> result;
		
			if (_byParentPageId.TryGetValue(parentPageId, out weak) && weak.TryGetTarget(out result))
				return result;
		
			if (HasBeenLoaded == true || weak != null)
				result = CreateContractCollection(@text => Equals(@text.ParentPageId, parentPageId));
			else 
			{
				DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}] WHERE [{ParentPageIdCol}] = '{parentPageId}'", false);
				result = CreateContractCollection(@text => Equals(@text.ParentPageId, parentPageId));
			}
		
			if (weak == null)
				_byParentPageId.Add(parentPageId, weak = new CsWeakReference<ContractCollection<Text>>(result));
			else
				weak.SetTarget(result);
		
			return result;
		}
		///	<summary> 
		///		Query <c>SELECT (DefaultSqlSelector) FROM Texts WHERE [ParentPageId] = '<paramref name="parentPageId"/>'</c><para/>
		///		[<c>Texts</c>].[<c>ParentPageId</c>] &#62;&#62;&#62;&#62; [<c>Pages</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK_Texts_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Texts", FkColumn = "ParentPageId")]
		[DebuggerStepThrough] 
		public ContractCollection<Text> LoadThenFind_By_ParentPageId(Guid? parentPageId)
		{
			if (parentPageId == null)
				return null;
			CsWeakReference<ContractCollection<Text>> weak;
			ContractCollection<Text> result;
		
			DownloadRows($"SELECT {DefaultSqlSelector} FROM {NativeName} WHERE [{ParentPageIdCol}] = '{parentPageId}'", false);
		
			if (_byParentPageId.TryGetValue(parentPageId, out weak) && weak.TryGetTarget(out result))
				return result;
		
			result = CreateContractCollection(@text => Equals(@text.ParentPageId, parentPageId));
		
			if (weak == null)
				_byParentPageId.Add(parentPageId, weak = new CsWeakReference<ContractCollection<Text>>(result));
			else
				weak.SetTarget(result);
		
			return result;
		}
		///	<summary> 
		///		Query <c>SELECT (DefaultSqlSelector) FROM Texts WHERE [ParentPageId] = '<paramref name="parentPageId"/>'</c><para/>
		///		[<c>Texts</c>].[<c>ParentPageId</c>] &#62;&#62;&#62;&#62; [<c>Pages</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK_Texts_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Texts", FkColumn = "ParentPageId")]
		[DebuggerStepThrough]
		public ContractCollection<Text> Find_By_ParentPageId(Guid? parentPageId)
		{
			if (parentPageId == null)
				return null;
			CsWeakReference<ContractCollection<Text>> weak;
			ContractCollection<Text> result;
		
			if (_byParentPageId.TryGetValue(parentPageId, out weak) && weak.TryGetTarget(out result))
				return result;
		
		
			result = CreateContractCollection(@text => Equals(@text.ParentPageId, parentPageId));
		
		    if (weak == null)
				_byParentPageId.Add(parentPageId, weak = new CsWeakReference<ContractCollection<Text>>(result));
			else
				weak.SetTarget(result);
		
			return result;
		}
		#endregion
		
		
		/// <summary>Creates a row then copy's the data from the <paramref name="item"/> and adds it to the row collection.</summary>
		public Text AddAsNewRow(IText item)
		{
			var row = NewRow();
			row.Copy_From(item, true);
			Add(row);
			return row;
		}
	}
}