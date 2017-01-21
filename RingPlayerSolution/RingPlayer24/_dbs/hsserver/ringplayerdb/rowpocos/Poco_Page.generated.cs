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
using RingPlayer24._dbs.hsserver.ringplayerdb.rowinterfaces;
using Poco_Page=RingPlayer24._dbs.hsserver.ringplayerdb.rowpocos.Poco_Page;






namespace RingPlayer24._dbs.hsserver.ringplayerdb.rowpocos
{
	public partial class Poco_Page : IPage, INotifyPropertyChanged
	{
		private Guid _id;
		private Guid? _parentPageId;
		private Int32 _sortOrder;
		private String _marginThickness;
		private String _borderThickness;
		private String _background;
		private String _borderColor;
		private Double _rotation;
		private Boolean _hasFixedRatio;
		private Double _ratioX;
		private Double _ratioY;
		private String _diagnosticText;
	
	
	
		///<summary> 
		///		[<c>RingPlayerDb</c>].[<c>Pages</c>].[<c>Id</c>] (Type = <c>uniqueidentifier</c>, Default = '<c>(newid())</c>') 
		///</summary>
		public Guid Id 
		{
			get { return _id; }
			set { SetProperty(ref _id, value, nameof(Id)); }
		}
		///<summary> 
		///		[<c>RingPlayerDb</c>].[<c>Pages</c>].[<c>ParentPageId</c>] (Type = <c>uniqueidentifier</c>, <c>NULLABLE</c>) 
		///</summary>
		public Guid? ParentPageId 
		{
			get { return _parentPageId; }
			set { SetProperty(ref _parentPageId, value, nameof(ParentPageId)); }
		}
		///<summary> 
		///		[<c>RingPlayerDb</c>].[<c>Pages</c>].[<c>SortOrder</c>] (Type = <c>int</c>, Default = '<c>((0))</c>') 
		///</summary>
		public Int32 SortOrder 
		{
			get { return _sortOrder; }
			set { SetProperty(ref _sortOrder, value, nameof(SortOrder)); }
		}
		///<summary> 
		///		[<c>RingPlayerDb</c>].[<c>Pages</c>].[<c>MarginThickness</c>] (Type = <c>nvarchar</c>, <c>NULLABLE</c>, MaxLength = <c>256</c>) 
		///</summary>
		public String MarginThickness 
		{
			get { return _marginThickness; }
			set { SetProperty(ref _marginThickness, value, nameof(MarginThickness)); }
		}
		///<summary> 
		///		[<c>RingPlayerDb</c>].[<c>Pages</c>].[<c>BorderThickness</c>] (Type = <c>nvarchar</c>, <c>NULLABLE</c>, MaxLength = <c>256</c>) 
		///</summary>
		public String BorderThickness 
		{
			get { return _borderThickness; }
			set { SetProperty(ref _borderThickness, value, nameof(BorderThickness)); }
		}
		///<summary> 
		///		[<c>RingPlayerDb</c>].[<c>Pages</c>].[<c>Background</c>] (Type = <c>nvarchar</c>, <c>NULLABLE</c>, MaxLength = <c>255</c>) 
		///</summary>
		public String Background 
		{
			get { return _background; }
			set { SetProperty(ref _background, value, nameof(Background)); }
		}
		///<summary> 
		///		[<c>RingPlayerDb</c>].[<c>Pages</c>].[<c>BorderColor</c>] (Type = <c>nvarchar</c>, <c>NULLABLE</c>, MaxLength = <c>255</c>) 
		///</summary>
		public String BorderColor 
		{
			get { return _borderColor; }
			set { SetProperty(ref _borderColor, value, nameof(BorderColor)); }
		}
		///<summary> 
		///		[<c>RingPlayerDb</c>].[<c>Pages</c>].[<c>Rotation</c>] (Type = <c>float</c>, Default = '<c>((0))</c>') 
		///</summary>
		public Double Rotation 
		{
			get { return _rotation; }
			set { SetProperty(ref _rotation, value, nameof(Rotation)); }
		}
		///<summary> 
		///		[<c>RingPlayerDb</c>].[<c>Pages</c>].[<c>HasFixedRatio</c>] (Type = <c>bit</c>, Default = '<c>((0))</c>') 
		///</summary>
		public Boolean HasFixedRatio 
		{
			get { return _hasFixedRatio; }
			set { SetProperty(ref _hasFixedRatio, value, nameof(HasFixedRatio)); }
		}
		///<summary> 
		///		[<c>RingPlayerDb</c>].[<c>Pages</c>].[<c>RatioX</c>] (Type = <c>float</c>, Default = '<c>((0))</c>') 
		///</summary>
		public Double RatioX 
		{
			get { return _ratioX; }
			set { SetProperty(ref _ratioX, value, nameof(RatioX)); }
		}
		///<summary> 
		///		[<c>RingPlayerDb</c>].[<c>Pages</c>].[<c>RatioY</c>] (Type = <c>float</c>, Default = '<c>((0))</c>') 
		///</summary>
		public Double RatioY 
		{
			get { return _ratioY; }
			set { SetProperty(ref _ratioY, value, nameof(RatioY)); }
		}
		///<summary> 
		///		[<c>RingPlayerDb</c>].[<c>Pages</c>].[<c>DiagnosticText</c>] (Type = <c>nvarchar</c>, <c>NULLABLE</c>, MaxLength = <c>-1</c>) 
		///</summary>
		public String DiagnosticText 
		{
			get { return _diagnosticText; }
			set { SetProperty(ref _diagnosticText, value, nameof(DiagnosticText)); }
		}
		
	
	
	
	
	
	
	#region INotifyPropertyChanged
		public event PropertyChangedEventHandler PropertyChanged;
		/// <summary>
		///     Implementation of the <see cref="INotifyPropertyChanged" /> interface. Checks whether the backing field
		///     already provides this reference or value. If backing field provides the same value, no notification is sent, if you
		///     want to force a notification use <see cref="OnPropertyChanged" />
		/// </summary>
		/// <typeparam name="T">the generic controller, used to provide intellisense feature.</typeparam>
		/// <param name="backingField">The backing field where the property stores the reference</param>
		/// <param name="value">The new value.</param>
		/// <param name="propertyName">Name of the property.</param>
		/// <returns></returns>
		protected virtual bool SetProperty<T>(ref T backingField, T value, string propertyName)
		{
			if (Equals(backingField, value))
				return false;
	
			backingField = value;
			OnPropertyChanged(propertyName);
			return true;
		}
		/// <summary>Sends a notification to <see cref="PropertyChanged" /> subscriber.</summary>
		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler onPropertyChanged = PropertyChanged;
			if (onPropertyChanged != null)
			{
				onPropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	#endregion
	}
}