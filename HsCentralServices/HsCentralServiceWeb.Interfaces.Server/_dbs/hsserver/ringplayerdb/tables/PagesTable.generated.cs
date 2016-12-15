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
//<date>2016-10-11 19:18:26</date>



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
using Page=HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.rows.Page;
using IPage=HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.rowinterfaces.IPage;
using HsCentralServiceWebInterfacesServer._dbs.hsserver;






namespace HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.tables
{
	#pragma warning disable 657
	#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	
	///	<summary>
	///		'[<c>HsServer</c>].[<c>#RingPlayerDb#</c>].[<c>Pages</c>]': A Table inside '[<c>HsServer</c>].[<c>#RingPlayerDb#</c>]' database with '<see cref="Page"/>' as <see cref="DataRow"/>.<para/>
	///		[<c>Pages</c>].[<c>Id</c>] &#60;&#60;&#60;&#60; [<c>Images</c>].[<c>ParentPageId</c>]<para/>
	///		[<c>Pages</c>].[<c>PageGroupId</c>] &#62;&#62;&#62;&#62; [<c>PageGroups</c>].[<c>Id</c>]<para/>
	///		[<c>Pages</c>].[<c>Id</c>] &#60;&#60;&#60;&#60; [<c>Texts</c>].[<c>ParentPageId</c>]<para/>
	///		[<c>Pages</c>].[<c>Id</c>] &#60;&#60;&#60;&#60; [<c>DoubleTransitions</c>].[<c>PageId</c>]<para/>
	///		[<c>Pages</c>].[<c>Id</c>] &#60;&#60;&#60;&#60; [<c>Pages</c>].[<c>ParentPageId</c>]<para/>
	///		[<c>Pages</c>].[<c>Id</c>] &#60;&#60;&#60;&#60; [<c>PageSchedules</c>].[<c>PageId</c>]<para/>
	///		[<c>Pages</c>].[<c>Id</c>] &#60;&#60;&#60;&#60; [<c>Videos</c>].[<c>ParentPageId</c>]
	///	</summary>
	[Serializable]
	
	[DebuggerDisplay("DataTable(RingPlayerDb.Pages): Rows[{Rows.Count}]")]
	[CsDbDataTable(Database = "RingPlayerDb", Name = "Pages", Generated = "16.10.11 19:18:26", Hash = "624D448A857E38EFAFCE08D260B25784")]
	[CsDbResolvesRelation("FK_Images_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Images", FkColumn = "ParentPageId")]
	[CsDbResolvesRelation("FK_Pages_PageGroups", PkTable = "PageGroups", PkColumn = "Id", FkTable = "Pages", FkColumn = "PageGroupId")]
	[CsDbResolvesRelation("FK_Texts_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Texts", FkColumn = "ParentPageId")]
	[CsDbResolvesRelation("FK_DoubleTransitions_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "DoubleTransitions", FkColumn = "PageId")]
	[CsDbResolvesRelation("FK_Pages_Pages1", PkTable = "Pages", PkColumn = "Id", FkTable = "Pages", FkColumn = "ParentPageId")]
	[CsDbResolvesRelation("FK_ScheduledPages_Pages", PkTable = "Pages", PkColumn = "Id", FkTable = "PageSchedules", FkColumn = "PageId")]
	[CsDbResolvesRelation("FK_Videos_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Videos", FkColumn = "ParentPageId")]
	public partial class PagesTable : CsDbTable<Page>
	{
		#region CONSTANTS
		///<summary>The native table name (Pages).</summary>
		public const string NativeName = "Pages";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Pages].[Id]</c> column. Property = <see cref="Page.Id"/>.</summary>
		public const string IdCol = "Id";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Pages].[DiagnosticText]</c> column. Property = <see cref="Page.DiagnosticText"/>.</summary>
		public const string DiagnosticTextCol = "DiagnosticText";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Pages].[ParentPageId]</c> column. Property = <see cref="Page.ParentPageId"/>.</summary>
		public const string ParentPageIdCol = "ParentPageId";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Pages].[PageGroupId]</c> column. Property = <see cref="Page.PageGroupId"/>.</summary>
		public const string PageGroupIdCol = "PageGroupId";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Pages].[SortOrder]</c> column. Property = <see cref="Page.SortOrder"/>.</summary>
		public const string SortOrderCol = "SortOrder";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Pages].[MarginThickness]</c> column. Property = <see cref="Page.MarginThickness"/>.</summary>
		public const string MarginThicknessCol = "MarginThickness";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Pages].[BorderThickness]</c> column. Property = <see cref="Page.BorderThickness"/>.</summary>
		public const string BorderThicknessCol = "BorderThickness";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Pages].[Background]</c> column. Property = <see cref="Page.Background"/>.</summary>
		public const string BackgroundCol = "Background";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Pages].[BorderColor]</c> column. Property = <see cref="Page.BorderColor"/>.</summary>
		public const string BorderColorCol = "BorderColor";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Pages].[Rotation]</c> column. Property = <see cref="Page.Rotation"/>.</summary>
		public const string RotationCol = "Rotation";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Pages].[HasFixedRatio]</c> column. Property = <see cref="Page.HasFixedRatio"/>.</summary>
		public const string HasFixedRatioCol = "HasFixedRatio";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Pages].[RatioX]</c> column. Property = <see cref="Page.RatioX"/>.</summary>
		public const string RatioXCol = "RatioX";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Pages].[RatioY]</c> column. Property = <see cref="Page.RatioY"/>.</summary>
		public const string RatioYCol = "RatioY";
		///<summary>Holds native column name of <c>[RingPlayerDb].[Pages].[ExpectedDuration]</c> column. Property = <see cref="Page.ExpectedDuration"/>.</summary>
		public const string ExpectedDurationCol = "ExpectedDuration";
	
		/// <summary> Contains attribute values for the columns</summary>
		public static class Cols
		{
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Pages</c>].[<c>Id</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Pages", Name = "Id", Type = "uniqueidentifier", Default = "(newid())", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute Id = new CsDbNativeDataColumnAttribute {Table = "Pages", Name = "Id", Type = "uniqueidentifier", Default = "(newid())", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Pages</c>].[<c>DiagnosticText</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Pages", Name = "DiagnosticText", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute DiagnosticText = new CsDbNativeDataColumnAttribute {Table = "Pages", Name = "DiagnosticText", Type = "nvarchar", MaxLength = "-1", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Pages</c>].[<c>ParentPageId</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Pages", Name = "ParentPageId", Type = "uniqueidentifier", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute ParentPageId = new CsDbNativeDataColumnAttribute {Table = "Pages", Name = "ParentPageId", Type = "uniqueidentifier", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Pages</c>].[<c>PageGroupId</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Pages", Name = "PageGroupId", Type = "uniqueidentifier", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute PageGroupId = new CsDbNativeDataColumnAttribute {Table = "Pages", Name = "PageGroupId", Type = "uniqueidentifier", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Pages</c>].[<c>SortOrder</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Pages", Name = "SortOrder", Type = "int", Default = "((0))", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute SortOrder = new CsDbNativeDataColumnAttribute {Table = "Pages", Name = "SortOrder", Type = "int", Default = "((0))", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Pages</c>].[<c>MarginThickness</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Pages", Name = "MarginThickness", Type = "nvarchar", MaxLength = "256", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute MarginThickness = new CsDbNativeDataColumnAttribute {Table = "Pages", Name = "MarginThickness", Type = "nvarchar", MaxLength = "256", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Pages</c>].[<c>BorderThickness</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Pages", Name = "BorderThickness", Type = "nvarchar", MaxLength = "256", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute BorderThickness = new CsDbNativeDataColumnAttribute {Table = "Pages", Name = "BorderThickness", Type = "nvarchar", MaxLength = "256", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Pages</c>].[<c>Background</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Pages", Name = "Background", Type = "nvarchar", MaxLength = "255", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute Background = new CsDbNativeDataColumnAttribute {Table = "Pages", Name = "Background", Type = "nvarchar", MaxLength = "255", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Pages</c>].[<c>BorderColor</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Pages", Name = "BorderColor", Type = "nvarchar", MaxLength = "255", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute BorderColor = new CsDbNativeDataColumnAttribute {Table = "Pages", Name = "BorderColor", Type = "nvarchar", MaxLength = "255", IsNullable = "YES"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Pages</c>].[<c>Rotation</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Pages", Name = "Rotation", Type = "float", Default = "((0))", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute Rotation = new CsDbNativeDataColumnAttribute {Table = "Pages", Name = "Rotation", Type = "float", Default = "((0))", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Pages</c>].[<c>HasFixedRatio</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Pages", Name = "HasFixedRatio", Type = "bit", Default = "((0))", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute HasFixedRatio = new CsDbNativeDataColumnAttribute {Table = "Pages", Name = "HasFixedRatio", Type = "bit", Default = "((0))", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Pages</c>].[<c>RatioX</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Pages", Name = "RatioX", Type = "float", Default = "((0))", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute RatioX = new CsDbNativeDataColumnAttribute {Table = "Pages", Name = "RatioX", Type = "float", Default = "((0))", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Pages</c>].[<c>RatioY</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Pages", Name = "RatioY", Type = "float", Default = "((0))", IsNullable = "NO"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute RatioY = new CsDbNativeDataColumnAttribute {Table = "Pages", Name = "RatioY", Type = "float", Default = "((0))", IsNullable = "NO"};
			/// <summary>
			///		Get the attribute from the column [<c>RingPlayerDb</c>].[<c>Pages</c>].[<c>ExpectedDuration</c>]<para/>
			///		#Mode# = new CsDbNativeDataColumnAttribute {Table = "Pages", Name = "ExpectedDuration", Type = "float", IsNullable = "YES"};
			/// </summary>
			public static CsDbNativeDataColumnAttribute ExpectedDuration = new CsDbNativeDataColumnAttribute {Table = "Pages", Name = "ExpectedDuration", Type = "float", IsNullable = "YES"};
		}
		#endregion
	
	
	
	
	
	
	
		///<summary>Default constructor for save <see cref="DataTable"/> operations</summary>
		public PagesTable()
		{
			TableName = NativeName;
		}
	
		///<summary>References the owning data context, this is equal to the database server. Use this to address databases on the same server.</summary>
		public new HsCentralServiceWebInterfacesServer._dbs.hsserver.HsServerContext DataContext => DataSet.DataContext;
	
		///<summary>References the owning dataset. Use this to address tables in the same database</summary>
		public new RingPlayerDb DataSet => (RingPlayerDb) base.DataSet;
	
	
	
	
	
	
	
		#region FUNC<Overrides>
		
		///	<summary><c>SELECT (DefaultSqlSelector) FROM [Pages]</c><para>The default selector is the * operator</para></summary>
		public override void DownloadRows()
		{
			DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}]", false);
			HasBeenLoaded = true;
		}
		///	<summary><c>SELECT <paramref name="top"/> (DefaultSqlSelector) FROM [Pages]</c><para>The default selector is the * operator</para></summary>
		public override void DownloadRows(int top)
		{
			DownloadRows($"SELECT TOP {top} {DefaultSqlSelector} FROM [{NativeName}]", false);
		}
		
		
		///<summary>This method calls <see cref="FindOrLoad"/>.</summary>
		public override CsDbRowBase Generic_FindOrLoad(object id)
		{
			return id==null ? null : FindOrLoad((Guid?) id);
		}
		///<summary>This method calls <see cref="LoadThenFind"/>.</summary>
		public override CsDbRowBase Generic_LoadThenFind(object id)
		{
			return id==null ? null : LoadThenFind((Guid?) id);
		}
		///<summary>This method calls <see cref="Find"/>.</summary>
		public override CsDbRowBase Generic_Find(object id)
		{
			return id==null ? null : Find((Guid?) id);
		}
		
		
		
		///<summary>This method calls <see cref="FindOrLoad"/>.</summary>
		public override CsDbRowBase[] Generic_FindOrLoad(params object[] ids)
		{
			return FindOrLoad_Each(ids.OfType<Guid>().ToArray()).OfType<CsDbRowBase>().ToArray();
		}
		///<summary>This method calls <see cref="LoadThenFind"/>.</summary>
		public override CsDbRowBase[] Generic_LoadThenFind(params object[] ids)
		{
			return LoadThenFind_Each(ids.OfType<Guid>().ToArray()).OfType<CsDbRowBase>().ToArray();
		}
		///<summary>This method calls <see cref="Find"/>.</summary>
		public override CsDbRowBase[] Generic_Find(params object[] ids)
		{
			return Find_Each(ids.OfType<Guid>().ToArray()).OfType<CsDbRowBase>().ToArray();
		}
		#endregion
		
		
		
		
		#region FUNC<Primary Key>
		
		///	<summary>
		///		find an item in local data where Id = '<paramref name="id"/>'. If nothing is found QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [Pages] WHERE [Id] = '<paramref name="id"/>'</c>.<para/>
		///		If no primary key is set execute <see cref="LoadThenFind"/> instead.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK_Images_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Images", FkColumn = "ParentPageId")]
		[CsDbResolvesRelation("FK_Pages_PageGroups", PkTable = "PageGroups", PkColumn = "Id", FkTable = "Pages", FkColumn = "PageGroupId")]
		[CsDbResolvesRelation("FK_Texts_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Texts", FkColumn = "ParentPageId")]
		[CsDbResolvesRelation("FK_DoubleTransitions_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "DoubleTransitions", FkColumn = "PageId")]
		[CsDbResolvesRelation("FK_Pages_Pages1", PkTable = "Pages", PkColumn = "Id", FkTable = "Pages", FkColumn = "ParentPageId")]
		[CsDbResolvesRelation("FK_ScheduledPages_Pages", PkTable = "Pages", PkColumn = "Id", FkTable = "PageSchedules", FkColumn = "PageId")]
		[CsDbResolvesRelation("FK_Videos_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Videos", FkColumn = "ParentPageId")]
		public Page FindOrLoad(Guid? id)
		{
			if (id == null)
				return null;
		
			if (PrimaryKey.Length == 0)
				return LoadThenFind(id);
		
			return Find(id) ?? LoadThenFind(id);
		}
		
		
		///<summary>
		///		QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [Pages] WHERE [Id] = '<paramref name="id"/>'</c> THEN find an item in local data where Id = '<paramref name="id"/>'.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///</summary>
		[CsDbResolvesRelation("FK_Images_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Images", FkColumn = "ParentPageId")]
		[CsDbResolvesRelation("FK_Pages_PageGroups", PkTable = "PageGroups", PkColumn = "Id", FkTable = "Pages", FkColumn = "PageGroupId")]
		[CsDbResolvesRelation("FK_Texts_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Texts", FkColumn = "ParentPageId")]
		[CsDbResolvesRelation("FK_DoubleTransitions_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "DoubleTransitions", FkColumn = "PageId")]
		[CsDbResolvesRelation("FK_Pages_Pages1", PkTable = "Pages", PkColumn = "Id", FkTable = "Pages", FkColumn = "ParentPageId")]
		[CsDbResolvesRelation("FK_ScheduledPages_Pages", PkTable = "Pages", PkColumn = "Id", FkTable = "PageSchedules", FkColumn = "PageId")]
		[CsDbResolvesRelation("FK_Videos_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Videos", FkColumn = "ParentPageId")]
		public Page LoadThenFind(Guid? id)
		{
			if (id == null)
				return null;
		
			DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}] WHERE [Id] = '{id}'", false);
			
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
		
			return Rows.Find(id.Value) as Page;
		}
		
		
		///	<summary>
		///		find an item in local data where Id = '<paramref name="id"/>'. IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK_Images_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Images", FkColumn = "ParentPageId")]
		[CsDbResolvesRelation("FK_Pages_PageGroups", PkTable = "PageGroups", PkColumn = "Id", FkTable = "Pages", FkColumn = "PageGroupId")]
		[CsDbResolvesRelation("FK_Texts_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Texts", FkColumn = "ParentPageId")]
		[CsDbResolvesRelation("FK_DoubleTransitions_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "DoubleTransitions", FkColumn = "PageId")]
		[CsDbResolvesRelation("FK_Pages_Pages1", PkTable = "Pages", PkColumn = "Id", FkTable = "Pages", FkColumn = "ParentPageId")]
		[CsDbResolvesRelation("FK_ScheduledPages_Pages", PkTable = "Pages", PkColumn = "Id", FkTable = "PageSchedules", FkColumn = "PageId")]
		[CsDbResolvesRelation("FK_Videos_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Videos", FkColumn = "ParentPageId")]
		public Page Find(Guid? id)
		{
			if (id == null)
				return null;
		
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
		
			return Rows.Find(id.Value) as Page;
		}
		#endregion
		
		#region FUNC<Primary Key Many>
		///	<summary>
		///		find items in local data where Id IN '<paramref name="ids"/>'. If nothing is found QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [Pages] WHERE [Id] IN '<paramref name="ids"/>'</c>.<para/>
		///		If no primary key is set execute <see cref="LoadThenFind_Each"/> instead.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK_Images_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Images", FkColumn = "ParentPageId")]
		[CsDbResolvesRelation("FK_Pages_PageGroups", PkTable = "PageGroups", PkColumn = "Id", FkTable = "Pages", FkColumn = "PageGroupId")]
		[CsDbResolvesRelation("FK_Texts_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Texts", FkColumn = "ParentPageId")]
		[CsDbResolvesRelation("FK_DoubleTransitions_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "DoubleTransitions", FkColumn = "PageId")]
		[CsDbResolvesRelation("FK_Pages_Pages1", PkTable = "Pages", PkColumn = "Id", FkTable = "Pages", FkColumn = "ParentPageId")]
		[CsDbResolvesRelation("FK_ScheduledPages_Pages", PkTable = "Pages", PkColumn = "Id", FkTable = "PageSchedules", FkColumn = "PageId")]
		[CsDbResolvesRelation("FK_Videos_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Videos", FkColumn = "ParentPageId")]
		public Page[] FindOrLoad_Each(params Guid[] ids)
		{
			if (ids == null || ids.Length == 0)
				return new Page[0];
		
			if (PrimaryKey.Length == 0)
				return LoadThenFind_Each(ids);
				
			var locallyFound = Find_Each(ids);
			var loaded = LoadThenFind_Each(ids.Except(locallyFound.Select(x=>x.Id)).ToArray());
			return locallyFound.Union(loaded).ToArray();
		}
		
		
		///<summary>
		///		QUERY WITH <c>SELECT {DefaultSqlSelector} FROM [Pages] WHERE [Id] IN '<paramref name="ids"/>'</c> THEN find items in local data where Id IN '<paramref name="ids"/>'.<para/>
		///		IMPORTENT: Sets primary key if not set already.<para/>
		///</summary>
		[CsDbResolvesRelation("FK_Images_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Images", FkColumn = "ParentPageId")]
		[CsDbResolvesRelation("FK_Pages_PageGroups", PkTable = "PageGroups", PkColumn = "Id", FkTable = "Pages", FkColumn = "PageGroupId")]
		[CsDbResolvesRelation("FK_Texts_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Texts", FkColumn = "ParentPageId")]
		[CsDbResolvesRelation("FK_DoubleTransitions_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "DoubleTransitions", FkColumn = "PageId")]
		[CsDbResolvesRelation("FK_Pages_Pages1", PkTable = "Pages", PkColumn = "Id", FkTable = "Pages", FkColumn = "ParentPageId")]
		[CsDbResolvesRelation("FK_ScheduledPages_Pages", PkTable = "Pages", PkColumn = "Id", FkTable = "PageSchedules", FkColumn = "PageId")]
		[CsDbResolvesRelation("FK_Videos_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Videos", FkColumn = "ParentPageId")]
		public Page[] LoadThenFind_Each(params Guid[] ids)
		{
			if (ids == null || ids.Length == 0)
				return new Page[0];
		
			DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}] WHERE [Id] IN ('{ids.Select(x=>x.ToString()).Join("', '")}')", false);
			
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
		
			return Find_Each(ids);
		}
		
		
		///	<summary>
		///		find items in local data where Id IN '<paramref name="ids"/>'. IMPORTENT: Sets primary key if not set already.<para/>
		///	</summary>
		[CsDbResolvesRelation("FK_Images_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Images", FkColumn = "ParentPageId")]
		[CsDbResolvesRelation("FK_Pages_PageGroups", PkTable = "PageGroups", PkColumn = "Id", FkTable = "Pages", FkColumn = "PageGroupId")]
		[CsDbResolvesRelation("FK_Texts_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Texts", FkColumn = "ParentPageId")]
		[CsDbResolvesRelation("FK_DoubleTransitions_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "DoubleTransitions", FkColumn = "PageId")]
		[CsDbResolvesRelation("FK_Pages_Pages1", PkTable = "Pages", PkColumn = "Id", FkTable = "Pages", FkColumn = "ParentPageId")]
		[CsDbResolvesRelation("FK_ScheduledPages_Pages", PkTable = "Pages", PkColumn = "Id", FkTable = "PageSchedules", FkColumn = "PageId")]
		[CsDbResolvesRelation("FK_Videos_Visuals", PkTable = "Pages", PkColumn = "Id", FkTable = "Videos", FkColumn = "ParentPageId")]
		public Page[] Find_Each(params Guid[] ids)
		{
			if (ids == null || ids.Length == 0)
				return new Page[0];
		
			if (PrimaryKey.Length == 0)
				PrimaryKey = new[] { Columns[IdCol] };
				
			return Select(ids.Select(key=>$"{IdCol} = '{key}'").Join(" OR "));
		}
		#endregion
		
		
		
		
		
		#region FUNC<Foreign Key>
		[field:NonSerialized] private Dictionary<Guid?, CsWeakReference<ContractCollection<Page>>> _byPageGroupId = new Dictionary<Guid?, CsWeakReference<ContractCollection<Page>>>();
		
		///	<summary> 
		///		Query <c>SELECT (DefaultSqlSelector) FROM Pages WHERE [PageGroupId] = '<paramref name="pageGroupId"/>'</c><para/>
		///		[<c>Pages</c>].[<c>PageGroupId</c>] &#62;&#62;&#62;&#62; [<c>PageGroups</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK_Pages_PageGroups", PkTable = "PageGroups", PkColumn = "Id", FkTable = "Pages", FkColumn = "PageGroupId")]
		public ContractCollection<Page> FindOrLoad_By_PageGroupId(Guid? pageGroupId)
		{
			if (pageGroupId == null)
				return null;
			CsWeakReference<ContractCollection<Page>> weak;
			ContractCollection<Page> result;
		
			if (_byPageGroupId.TryGetValue(pageGroupId, out weak) && weak.TryGetTarget(out result))
				return result;
		
			if (HasBeenLoaded == true || weak != null)
				result = CreateContractCollection(@page => Equals(@page.PageGroupId, pageGroupId));
			else 
			{
				DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}] WHERE [{PageGroupIdCol}] = '{pageGroupId}'", false);
				result = CreateContractCollection(@page => Equals(@page.PageGroupId, pageGroupId));
			}
		
			if (weak == null)
				_byPageGroupId.Add(pageGroupId, weak = new CsWeakReference<ContractCollection<Page>>(result));
			else
				weak.SetTarget(result);
		
			return result;
		}
		///	<summary> 
		///		Query <c>SELECT (DefaultSqlSelector) FROM Pages WHERE [PageGroupId] = '<paramref name="pageGroupId"/>'</c><para/>
		///		[<c>Pages</c>].[<c>PageGroupId</c>] &#62;&#62;&#62;&#62; [<c>PageGroups</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK_Pages_PageGroups", PkTable = "PageGroups", PkColumn = "Id", FkTable = "Pages", FkColumn = "PageGroupId")]
		public ContractCollection<Page> LoadThenFind_By_PageGroupId(Guid? pageGroupId)
		{
			if (pageGroupId == null)
				return null;
			CsWeakReference<ContractCollection<Page>> weak;
			ContractCollection<Page> result;
		
			DownloadRows($"SELECT {DefaultSqlSelector} FROM {NativeName} WHERE [{PageGroupIdCol}] = '{pageGroupId}'", false);
		
			if (_byPageGroupId.TryGetValue(pageGroupId, out weak) && weak.TryGetTarget(out result))
				return result;
		
			result = CreateContractCollection(@page => Equals(@page.PageGroupId, pageGroupId));
		
			if (weak == null)
				_byPageGroupId.Add(pageGroupId, weak = new CsWeakReference<ContractCollection<Page>>(result));
			else
				weak.SetTarget(result);
		
			return result;
		}
		///	<summary> 
		///		Query <c>SELECT (DefaultSqlSelector) FROM Pages WHERE [PageGroupId] = '<paramref name="pageGroupId"/>'</c><para/>
		///		[<c>Pages</c>].[<c>PageGroupId</c>] &#62;&#62;&#62;&#62; [<c>PageGroups</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK_Pages_PageGroups", PkTable = "PageGroups", PkColumn = "Id", FkTable = "Pages", FkColumn = "PageGroupId")]
		public ContractCollection<Page> Find_By_PageGroupId(Guid? pageGroupId)
		{
			if (pageGroupId == null)
				return null;
			CsWeakReference<ContractCollection<Page>> weak;
			ContractCollection<Page> result;
		
			if (_byPageGroupId.TryGetValue(pageGroupId, out weak) && weak.TryGetTarget(out result))
				return result;
		
		
			result = CreateContractCollection(@page => Equals(@page.PageGroupId, pageGroupId));
		
		    if (weak == null)
				_byPageGroupId.Add(pageGroupId, weak = new CsWeakReference<ContractCollection<Page>>(result));
			else
				weak.SetTarget(result);
		
			return result;
		}
		[field:NonSerialized] private Dictionary<Guid?, CsWeakReference<ContractCollection<Page>>> _byParentPageId = new Dictionary<Guid?, CsWeakReference<ContractCollection<Page>>>();
		
		///	<summary> 
		///		Query <c>SELECT (DefaultSqlSelector) FROM Pages WHERE [ParentPageId] = '<paramref name="parentPageId"/>'</c><para/>
		///		[<c>Pages</c>].[<c>ParentPageId</c>] &#62;&#62;&#62;&#62; [<c>Pages</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK_Pages_Pages1", PkTable = "Pages", PkColumn = "Id", FkTable = "Pages", FkColumn = "ParentPageId")]
		public ContractCollection<Page> FindOrLoad_By_ParentPageId(Guid? parentPageId)
		{
			if (parentPageId == null)
				return null;
			CsWeakReference<ContractCollection<Page>> weak;
			ContractCollection<Page> result;
		
			if (_byParentPageId.TryGetValue(parentPageId, out weak) && weak.TryGetTarget(out result))
				return result;
		
			if (HasBeenLoaded == true || weak != null)
				result = CreateContractCollection(@page => Equals(@page.ParentPageId, parentPageId));
			else 
			{
				DownloadRows($"SELECT {DefaultSqlSelector} FROM [{NativeName}] WHERE [{ParentPageIdCol}] = '{parentPageId}'", false);
				result = CreateContractCollection(@page => Equals(@page.ParentPageId, parentPageId));
			}
		
			if (weak == null)
				_byParentPageId.Add(parentPageId, weak = new CsWeakReference<ContractCollection<Page>>(result));
			else
				weak.SetTarget(result);
		
			return result;
		}
		///	<summary> 
		///		Query <c>SELECT (DefaultSqlSelector) FROM Pages WHERE [ParentPageId] = '<paramref name="parentPageId"/>'</c><para/>
		///		[<c>Pages</c>].[<c>ParentPageId</c>] &#62;&#62;&#62;&#62; [<c>Pages</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK_Pages_Pages1", PkTable = "Pages", PkColumn = "Id", FkTable = "Pages", FkColumn = "ParentPageId")]
		public ContractCollection<Page> LoadThenFind_By_ParentPageId(Guid? parentPageId)
		{
			if (parentPageId == null)
				return null;
			CsWeakReference<ContractCollection<Page>> weak;
			ContractCollection<Page> result;
		
			DownloadRows($"SELECT {DefaultSqlSelector} FROM {NativeName} WHERE [{ParentPageIdCol}] = '{parentPageId}'", false);
		
			if (_byParentPageId.TryGetValue(parentPageId, out weak) && weak.TryGetTarget(out result))
				return result;
		
			result = CreateContractCollection(@page => Equals(@page.ParentPageId, parentPageId));
		
			if (weak == null)
				_byParentPageId.Add(parentPageId, weak = new CsWeakReference<ContractCollection<Page>>(result));
			else
				weak.SetTarget(result);
		
			return result;
		}
		///	<summary> 
		///		Query <c>SELECT (DefaultSqlSelector) FROM Pages WHERE [ParentPageId] = '<paramref name="parentPageId"/>'</c><para/>
		///		[<c>Pages</c>].[<c>ParentPageId</c>] &#62;&#62;&#62;&#62; [<c>Pages</c>].[<c>Id</c>]
		///	</summary>
		[CsDbResolvesRelation("FK_Pages_Pages1", PkTable = "Pages", PkColumn = "Id", FkTable = "Pages", FkColumn = "ParentPageId")]
		public ContractCollection<Page> Find_By_ParentPageId(Guid? parentPageId)
		{
			if (parentPageId == null)
				return null;
			CsWeakReference<ContractCollection<Page>> weak;
			ContractCollection<Page> result;
		
			if (_byParentPageId.TryGetValue(parentPageId, out weak) && weak.TryGetTarget(out result))
				return result;
		
		
			result = CreateContractCollection(@page => Equals(@page.ParentPageId, parentPageId));
		
		    if (weak == null)
				_byParentPageId.Add(parentPageId, weak = new CsWeakReference<ContractCollection<Page>>(result));
			else
				weak.SetTarget(result);
		
			return result;
		}
		#endregion
		
		
		/// <summary>Creates a row then copy's the data from the <paramref name="item"/> and adds it to the row collection.</summary>
		public Page AddAsNewRow(IPage item)
		{
			var row = NewRow();
			row.Copy_From(item, true);
			Add(row);
			return row;
		}
	}
}