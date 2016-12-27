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
//<date>2016-12-20 15:09:57</date>



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
using HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.rowinterfaces;
using Poco_PageSchedule=HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.rowpocos.Poco_PageSchedule;






namespace HsCentralServiceWebInterfacesServer._dbs.hsserver.ringplayerdb.rowpocos
{
	public partial class Poco_PageSchedule : IPageSchedule, INotifyPropertyChanged
	{
		private Guid _id;
		private String _diagnosticText;
		private Int32 _ringMetaDataId;
		private Guid _pageId;
		private Guid _pageGroupScheduleId;
		private Guid _slotId;
		private DateTime _startTime;
	
	
	
		///<summary> 
		///		[<c>RingPlayerDb</c>].[<c>PageSchedules</c>].[<c>Id</c>] (Type = <c>uniqueidentifier</c>, Default = '<c>(newid())</c>') 
		///</summary>
		public Guid Id 
		{
			get { return _id; }
			set { SetProperty(ref _id, value, nameof(Id)); }
		}
		///<summary> 
		///		[<c>RingPlayerDb</c>].[<c>PageSchedules</c>].[<c>DiagnosticText</c>] (Type = <c>nvarchar</c>, <c>NULLABLE</c>, MaxLength = <c>-1</c>) 
		///</summary>
		public String DiagnosticText 
		{
			get { return _diagnosticText; }
			set { SetProperty(ref _diagnosticText, value, nameof(DiagnosticText)); }
		}
		///<summary> 
		///		[<c>RingPlayerDb</c>].[<c>PageSchedules</c>].[<c>RingMetaDataId</c>] (Type = <c>int</c>) 
		///</summary>
		public Int32 RingMetaDataId 
		{
			get { return _ringMetaDataId; }
			set { SetProperty(ref _ringMetaDataId, value, nameof(RingMetaDataId)); }
		}
		///<summary> 
		///		[<c>RingPlayerDb</c>].[<c>PageSchedules</c>].[<c>PageId</c>] (Type = <c>uniqueidentifier</c>) 
		///</summary>
		public Guid PageId 
		{
			get { return _pageId; }
			set { SetProperty(ref _pageId, value, nameof(PageId)); }
		}
		///<summary> 
		///		[<c>RingPlayerDb</c>].[<c>PageSchedules</c>].[<c>PageGroupScheduleId</c>] (Type = <c>uniqueidentifier</c>) 
		///</summary>
		public Guid PageGroupScheduleId 
		{
			get { return _pageGroupScheduleId; }
			set { SetProperty(ref _pageGroupScheduleId, value, nameof(PageGroupScheduleId)); }
		}
		///<summary> 
		///		[<c>RingPlayerDb</c>].[<c>PageSchedules</c>].[<c>SlotId</c>] (Type = <c>uniqueidentifier</c>) 
		///</summary>
		public Guid SlotId 
		{
			get { return _slotId; }
			set { SetProperty(ref _slotId, value, nameof(SlotId)); }
		}
		///<summary> 
		///		[<c>RingPlayerDb</c>].[<c>PageSchedules</c>].[<c>StartTime</c>] (Type = <c>datetime2</c>) 
		///</summary>
		public DateTime StartTime 
		{
			get { return _startTime; }
			set { SetProperty(ref _startTime, value, nameof(StartTime)); }
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