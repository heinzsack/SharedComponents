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
using RingPlayer24._dbs.hsserver.ringplayerdb.rows;
using RingPlayer24._dbs.hsserver.ringplayerdb.tables;
using RingPlayer24._dbs.hsserver;






namespace RingPlayer24._dbs.hsserver.ringplayerdb.dataset
{
	
	
	
	/// <summary>'[<c>HsServerContext</c>].[<c>RingPlayerDb</c>]': a dataset/database inside context [<c>HsServerContext</c>] providing the tables and views inside database [<c>RingPlayerDb</c>].</summary>
	[Serializable]
	[DebuggerDisplay("DB[RingPlayerDb]: Tables[{Tables.Count}]")]
	[CsDbDataSet(Name = "RingPlayerDb", Generated = "17.01.15 00:09:47", Hash = "54EF86EB6E8009A5AD89633AEFDA07D6")]
	public partial class RingPlayerDb : CsDbDataSet
	{
	
	
	#region StaticDefinitions: Table names, Relations, schema description,...
	
		private static DataSet _schemaSet;
		private static CsDbRelation[] _csDbRelations;
		private static Dictionary<Type, CsDbRelation[]> _csDbRelationsPerTableType;
	
	
		/// <summary>The database name for the the database 'RingPlayerDb' </summary>
		public const string NativeName = "RingPlayerDb";
	
	
		///	<summary>Gets a list of the native names of all tables inside the database.</summary>
		public static string[] StaticTableNames = new string[]{"Videos", "Images", "Texts", "sysdiagrams", "DoubleTransitions", "Pages", "Rings", "RingEntries"};
	
	
		///	<summary>Gets a list of the native relations of all tables inside the data set. With this set of relations you can use reflection to dynamically get linked rows.</summary>
		public static CsDbRelation[] StaticCsDbRelations
		{
			get
			{
				if (_csDbRelations != null)
					return _csDbRelations;
				_csDbRelations = new[]{new CsDbRelation(typeof(RingPlayer24._dbs.hsserver.ringplayerdb.tables.PagesTable), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.Page), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.tables.VideosTable), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.Video), "Pages", "Id", "Videos", "PageId", typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.Page).GetProperty("Id"), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.Video).GetProperty("PageId"), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.Video).GetProperty("Page"), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.Page).GetProperty("Videos")),
					new CsDbRelation(typeof(RingPlayer24._dbs.hsserver.ringplayerdb.tables.PagesTable), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.Page), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.tables.ImagesTable), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.Image), "Pages", "Id", "Images", "PageId", typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.Page).GetProperty("Id"), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.Image).GetProperty("PageId"), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.Image).GetProperty("Page"), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.Page).GetProperty("Images")),
					new CsDbRelation(typeof(RingPlayer24._dbs.hsserver.ringplayerdb.tables.PagesTable), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.Page), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.tables.TextsTable), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.Text), "Pages", "Id", "Texts", "PageId", typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.Page).GetProperty("Id"), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.Text).GetProperty("PageId"), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.Text).GetProperty("Page"), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.Page).GetProperty("Texts")),
					new CsDbRelation(typeof(RingPlayer24._dbs.hsserver.ringplayerdb.tables.PagesTable), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.Page), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.tables.DoubleTransitionsTable), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.DoubleTransition), "Pages", "Id", "DoubleTransitions", "PageId", typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.Page).GetProperty("Id"), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.DoubleTransition).GetProperty("PageId"), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.DoubleTransition).GetProperty("Page"), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.Page).GetProperty("DoubleTransitions")),
					new CsDbRelation(typeof(RingPlayer24._dbs.hsserver.ringplayerdb.tables.PagesTable), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.Page), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.tables.PagesTable), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.Page), "Pages", "Id", "Pages", "ParentPageId", typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.Page).GetProperty("Id"), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.Page).GetProperty("ParentPageId"), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.Page).GetProperty("ParentPage"), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.Page).GetProperty("ChildPages")),
					new CsDbRelation(typeof(RingPlayer24._dbs.hsserver.ringplayerdb.tables.PagesTable), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.Page), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.tables.RingEntriesTable), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.RingEntry), "Pages", "Id", "RingEntries", "PageId", typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.Page).GetProperty("Id"), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.RingEntry).GetProperty("PageId"), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.RingEntry).GetProperty("Page"), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.Page).GetProperty("RingEntries")),
					new CsDbRelation(typeof(RingPlayer24._dbs.hsserver.ringplayerdb.tables.RingsTable), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.Ring), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.tables.RingEntriesTable), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.RingEntry), "Rings", "Id", "RingEntries", "RingId", typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.Ring).GetProperty("Id"), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.RingEntry).GetProperty("RingId"), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.RingEntry).GetProperty("Ring"), typeof(RingPlayer24._dbs.hsserver.ringplayerdb.rows.Ring).GetProperty("RingEntries")),			};
				return _csDbRelations;
			}
		}
		
		///	<summary>Gets a list of the native relations of all tables inside the data set. With this set of relations you can use reflection to dynamically get linked rows. Use table type as key.</summary>
		public static Dictionary<Type, CsDbRelation[]> StaticCsDbRelationsPerTableType
		{
			get
			{
				if (_csDbRelationsPerTableType != null)
					return _csDbRelationsPerTableType;
	
					
				var dict = new Dictionary<Type, List<CsDbRelation>>();
				foreach (var relation in StaticCsDbRelations)
				{
					List<CsDbRelation> pkrelations;
					if (!dict.TryGetValue(relation.PkTableType, out pkrelations))
					{
						pkrelations = new List<CsDbRelation>();
						dict.Add(relation.PkTableType, pkrelations);
					}
					if (!pkrelations.Contains(relation))
						pkrelations.Add(relation);
	
	
					List<CsDbRelation> fkrelations;
					if (!dict.TryGetValue(relation.FkTableType, out fkrelations))
					{
						fkrelations = new List<CsDbRelation>();
						dict.Add(relation.FkTableType, fkrelations);
					}
					if (!fkrelations.Contains(relation))
						fkrelations.Add(relation);
				}
				return _csDbRelationsPerTableType = dict.ToDictionary(x => x.Key, x => x.Value.ToArray());
			}
		}
	
	
	
	
		///	<summary>Gets a list of the native relations of all tables inside the data set. With this set of relations you can use reflection to dynamically get linked rows.</summary>
		public override CsDbRelation[] CsDbRelations => StaticCsDbRelations;
	
		///	<summary>Gets a list of the native relations of all tables inside the data set. With this set of relations you can use reflection to dynamically get linked rows.</summary>
		public override Dictionary<Type, CsDbRelation[]> CsDbRelationsPerTableType => StaticCsDbRelationsPerTableType;
		
		///	<summary>Gets a list of the native names of all tables inside the database.</summary>
		public override string[] TableNames => StaticTableNames;
	
	
	
		/// <summary> Used as a database template for the schema.</summary>
		public override DataSet SchemaSet
		{
			get
			{
				if (_schemaSet != null)
					return _schemaSet;
	
				_schemaSet = DbProxy.ExecuteDataSetCommand(TableNames.Select(tableName => $"SELECT TOP(0) * FROM [{tableName}]").Join(";"));
				for (int i = 0; i < TableNames.Length; i++)
				{
					string tableName = TableNames[i];
					_schemaSet.Tables[i].TableName = tableName;
				}
				return _schemaSet;
			}
		}
	#endregion
	
	
	#region WPF Extension
		///<summary>Use this to propagate an instance of the data set trough the logical tree of an WPF control.</summary>
		public static readonly DependencyProperty InstanceProperty = DependencyProperty.RegisterAttached("Instance", typeof (RingPlayerDb), typeof (RingPlayerDb), new FrameworkPropertyMetadata(default(RingPlayerDb), FrameworkPropertyMetadataOptions.Inherits));
		///<summary>Use this to propagate an instance of the data set trough the logical tree of an WPF control.</summary>
		public static void SetInstance(DependencyObject element, RingPlayerDb value)
		{
			element.SetValue(InstanceProperty, value);
		}
		///<summary>Use this to get the propagated instance from a control inside the logical tree. You have to set the property anywhere in upstream to get it with this method.</summary>
		public static RingPlayerDb GetInstance(DependencyObject element)
		{
			return (RingPlayerDb) element.GetValue(InstanceProperty);
		}
	#endregion
	
	
		public RingPlayerDb()
		{
			DataSetName = "RingPlayerDb";
		}
	
		///<summary>Gets the owning data context for this data set. The owning context is the relative addressing method for other databases on the same server.</summary>
		public new RingPlayer24._dbs.hsserver.HsServerContext DataContext
		{
			get { return (RingPlayer24._dbs.hsserver.HsServerContext) base.DataContext; }
			internal set { base.DataContext = value; }
		}
	
		///<summary>Gets the native name of the owning data context or the native name of the database server associated with this.</summary>
		public override string DataContextName => DataContext?.Name ?? "HsServerContext";
	
	
	#region Tables
		///<summary>Get or Create DataTable([<c>RingPlayerDb</c>].[<c>DoubleTransitions</c>]) => If table does not exist in <see cref="Tables"/> collection, it will be created and inserted automatically.</summary>
		public DoubleTransitionsTable DoubleTransitions => GetTable<DoubleTransitionsTable>("DoubleTransitions");
	
		///<summary>Get or Create DataTable([<c>RingPlayerDb</c>].[<c>Images</c>]) => If table does not exist in <see cref="Tables"/> collection, it will be created and inserted automatically.</summary>
		public ImagesTable Images => GetTable<ImagesTable>("Images");
	
		///<summary>Get or Create DataTable([<c>RingPlayerDb</c>].[<c>Pages</c>]) => If table does not exist in <see cref="Tables"/> collection, it will be created and inserted automatically.</summary>
		public PagesTable Pages => GetTable<PagesTable>("Pages");
	
		///<summary>Get or Create DataTable([<c>RingPlayerDb</c>].[<c>RingEntries</c>]) => If table does not exist in <see cref="Tables"/> collection, it will be created and inserted automatically.</summary>
		public RingEntriesTable RingEntries => GetTable<RingEntriesTable>("RingEntries");
	
		///<summary>Get or Create DataTable([<c>RingPlayerDb</c>].[<c>Rings</c>]) => If table does not exist in <see cref="Tables"/> collection, it will be created and inserted automatically.</summary>
		public RingsTable Rings => GetTable<RingsTable>("Rings");
	
		///<summary>Get or Create DataTable([<c>RingPlayerDb</c>].[<c>sysdiagrams</c>]) => If table does not exist in <see cref="Tables"/> collection, it will be created and inserted automatically.</summary>
		public SysdiagramsTable Sysdiagrams => GetTable<SysdiagramsTable>("sysdiagrams");
	
		///<summary>Get or Create DataTable([<c>RingPlayerDb</c>].[<c>Texts</c>]) => If table does not exist in <see cref="Tables"/> collection, it will be created and inserted automatically.</summary>
		public TextsTable Texts => GetTable<TextsTable>("Texts");
	
		///<summary>Get or Create DataTable([<c>RingPlayerDb</c>].[<c>Videos</c>]) => If table does not exist in <see cref="Tables"/> collection, it will be created and inserted automatically.</summary>
		public VideosTable Videos => GetTable<VideosTable>("Videos");
	#endregion
	
	
	
	
	#region Views
		
	#endregion
	
		private bool _constraintsLoaded = false;
	
		///<summary>First it loads the schema then the relations and after that it enforces the constraint's.</summary>
		public override void LoadConstraints()
		{
			if (_constraintsLoaded)
				return;
	
			LoadSchema();
	
			AddRelation("FK_Videos_Visuals", Pages.Columns[PagesTable.IdCol], Videos.Columns[VideosTable.PageIdCol], Rule.Cascade, Rule.Cascade);
			AddRelation("FK_Images_Visuals", Pages.Columns[PagesTable.IdCol], Images.Columns[ImagesTable.PageIdCol], Rule.Cascade, Rule.Cascade);
			AddRelation("FK_Texts_Visuals", Pages.Columns[PagesTable.IdCol], Texts.Columns[TextsTable.PageIdCol], Rule.Cascade, Rule.Cascade);
			AddRelation("FK_DoubleTransitions_Visuals", Pages.Columns[PagesTable.IdCol], DoubleTransitions.Columns[DoubleTransitionsTable.PageIdCol], Rule.Cascade, Rule.Cascade);
			AddRelation("FK_Pages_Pages1", Pages.Columns[PagesTable.IdCol], Pages.Columns[PagesTable.ParentPageIdCol], Rule.None, Rule.None);
			AddRelation("FK_ScheduledPages_Pages", Pages.Columns[PagesTable.IdCol], RingEntries.Columns[RingEntriesTable.PageIdCol], Rule.Cascade, Rule.Cascade);
			AddRelation("FK_RingEntries_Rings", Rings.Columns[RingsTable.IdCol], RingEntries.Columns[RingEntriesTable.RingIdCol], Rule.Cascade, Rule.Cascade);
			
			_constraintsLoaded = true;
		}
		///<summary>Saves the tables in an order which is good for creating new items.</summary>
		public override CsDbDataSet SaveAnabolic(object tag = null)
		{
			RingPlayerDb targetSet = new RingPlayerDb();
	
			if(Tables.Contains("Pages")) AddAnabolicChanges(targetSet, Pages);
			if(Tables.Contains("Rings")) AddAnabolicChanges(targetSet, Rings);
			if(Tables.Contains("sysdiagrams")) AddAnabolicChanges(targetSet, Sysdiagrams);
			if(Tables.Contains("DoubleTransitions")) AddAnabolicChanges(targetSet, DoubleTransitions);
			if(Tables.Contains("Images")) AddAnabolicChanges(targetSet, Images);
			if(Tables.Contains("RingEntries")) AddAnabolicChanges(targetSet, RingEntries);
			if(Tables.Contains("Texts")) AddAnabolicChanges(targetSet, Texts);
			if(Tables.Contains("Videos")) AddAnabolicChanges(targetSet, Videos);
			
			if (targetSet.Tables.Count != 0)
				DbProxy.SaveChanges(targetSet.CloneTo_Native(), tag);
	
			return targetSet;
		}
		///<summary>Saves the tables in an order which is good for deleting items.</summary>
		public override CsDbDataSet SaveKatabolic(object tag = null)
		{
			RingPlayerDb targetSet = new RingPlayerDb();
	
			if(Tables.Contains("DoubleTransitions")) AddKatabolicChanges(targetSet, DoubleTransitions);
			if(Tables.Contains("Images")) AddKatabolicChanges(targetSet, Images);
			if(Tables.Contains("RingEntries")) AddKatabolicChanges(targetSet, RingEntries);
			if(Tables.Contains("Texts")) AddKatabolicChanges(targetSet, Texts);
			if(Tables.Contains("Videos")) AddKatabolicChanges(targetSet, Videos);
			if(Tables.Contains("Pages")) AddKatabolicChanges(targetSet, Pages);
			if(Tables.Contains("Rings")) AddKatabolicChanges(targetSet, Rings);
			if(Tables.Contains("sysdiagrams")) AddKatabolicChanges(targetSet, Sysdiagrams);
			
			if (targetSet.Tables.Count != 0)
				DbProxy.SaveChanges(targetSet.CloneTo_Native(), tag);
				
			return targetSet;
		}
		///<summary>Get the right table by its table name</summary>
		public override CsDbTable GetTableByName(string nativeName)
		{
			switch (nativeName)
			{
				case "Videos":
					return Videos;
				case "Images":
					return Images;
				case "Texts":
					return Texts;
				case "sysdiagrams":
					return Sysdiagrams;
				case "DoubleTransitions":
					return DoubleTransitions;
				case "Pages":
					return Pages;
				case "Rings":
					return Rings;
				case "RingEntries":
					return RingEntries;
				default:
					throw new Exception($"Table with native name [{nativeName}] not found.");
			}
		}
		///<summary>Get the right table by its type</summary>
		public override CsDbTable GetTableByType<TType>()
		{
			switch (typeof(TType).Name)
			{
				case "VideosTable":
					return Videos;
				case "ImagesTable":
					return Images;
				case "TextsTable":
					return Texts;
				case "SysdiagramsTable":
					return Sysdiagrams;
				case "DoubleTransitionsTable":
					return DoubleTransitions;
				case "PagesTable":
					return Pages;
				case "RingsTable":
					return Rings;
				case "RingEntriesTable":
					return RingEntries;
				default:
					throw new Exception($"Table with type [{typeof(TType).Name}] not found.");
			}
		}
	}
	
}