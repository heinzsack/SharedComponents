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
//<date>2017-01-15 16:50:36</date>



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
using Poco_DoubleTransition=RingPlayer24._dbs.hsserver.ringplayerdb.rowpocos.Poco_DoubleTransition;






namespace RingPlayer24._dbs.hsserver.ringplayerdb.rowpocos
{
	public partial class Poco_DoubleTransition : IDoubleTransition, INotifyPropertyChanged
	{
		private Guid _id;
		private Guid _pageId;
		private Double _beginnTimeSeconds;
		private Double _durationSeconds;
		private Double _fromValue;
		private Double _toValue;
		private String _propertyPath;
		private String _transitionType;
		private String _diagnosticText;
	
	
	
		///<summary> 
		///		[<c>RingPlayerDb</c>].[<c>DoubleTransitions</c>].[<c>Id</c>] (Type = <c>uniqueidentifier</c>, Default = '<c>(newid())</c>') 
		///</summary>
		public Guid Id 
		{
			get { return _id; }
			set { SetProperty(ref _id, value, nameof(Id)); }
		}
		///<summary> 
		///		[<c>RingPlayerDb</c>].[<c>DoubleTransitions</c>].[<c>PageId</c>] (Type = <c>uniqueidentifier</c>) 
		///</summary>
		public Guid PageId 
		{
			get { return _pageId; }
			set { SetProperty(ref _pageId, value, nameof(PageId)); }
		}
		///<summary> 
		///		[<c>RingPlayerDb</c>].[<c>DoubleTransitions</c>].[<c>BeginnTimeSeconds</c>] (Type = <c>float</c>) 
		///</summary>
		public Double BeginnTimeSeconds 
		{
			get { return _beginnTimeSeconds; }
			set { SetProperty(ref _beginnTimeSeconds, value, nameof(BeginnTimeSeconds)); }
		}
		///<summary> 
		///		[<c>RingPlayerDb</c>].[<c>DoubleTransitions</c>].[<c>DurationSeconds</c>] (Type = <c>float</c>) 
		///</summary>
		public Double DurationSeconds 
		{
			get { return _durationSeconds; }
			set { SetProperty(ref _durationSeconds, value, nameof(DurationSeconds)); }
		}
		///<summary> 
		///		[<c>RingPlayerDb</c>].[<c>DoubleTransitions</c>].[<c>FromValue</c>] (Type = <c>float</c>) 
		///</summary>
		public Double FromValue 
		{
			get { return _fromValue; }
			set { SetProperty(ref _fromValue, value, nameof(FromValue)); }
		}
		///<summary> 
		///		[<c>RingPlayerDb</c>].[<c>DoubleTransitions</c>].[<c>ToValue</c>] (Type = <c>float</c>) 
		///</summary>
		public Double ToValue 
		{
			get { return _toValue; }
			set { SetProperty(ref _toValue, value, nameof(ToValue)); }
		}
		///<summary> 
		///		[<c>RingPlayerDb</c>].[<c>DoubleTransitions</c>].[<c>PropertyPath</c>] (Type = <c>nvarchar</c>, MaxLength = <c>-1</c>) 
		///</summary>
		public String PropertyPath 
		{
			get { return _propertyPath; }
			set { SetProperty(ref _propertyPath, value, nameof(PropertyPath)); }
		}
		///<summary> 
		///		[<c>RingPlayerDb</c>].[<c>DoubleTransitions</c>].[<c>TransitionType</c>] (Type = <c>nvarchar</c>, Default = '<c>(N'Cubic')</c>', MaxLength = <c>-1</c>) 
		///</summary>
		public String TransitionType 
		{
			get { return _transitionType; }
			set { SetProperty(ref _transitionType, value, nameof(TransitionType)); }
		}
		///<summary> 
		///		[<c>RingPlayerDb</c>].[<c>DoubleTransitions</c>].[<c>DiagnosticText</c>] (Type = <c>nvarchar</c>, <c>NULLABLE</c>, MaxLength = <c>-1</c>) 
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