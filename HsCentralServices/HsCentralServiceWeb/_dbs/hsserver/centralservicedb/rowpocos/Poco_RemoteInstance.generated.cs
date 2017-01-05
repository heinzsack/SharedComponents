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
//<date>2017-01-04 13:12:46</date>



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
using HsCentralServiceWeb._dbs.hsserver.centralservicedb.rowinterfaces;
using Poco_RemoteInstance=HsCentralServiceWeb._dbs.hsserver.centralservicedb.rowpocos.Poco_RemoteInstance;






namespace HsCentralServiceWeb._dbs.hsserver.centralservicedb.rowpocos
{
	public partial class Poco_RemoteInstance : IRemoteInstance, INotifyPropertyChanged
	{
		private Guid _id;
		private String _processFile;
		private DateTime? _firstExecutionTime;
		private DateTime? _lastExecutionTime;
		private Int32? _unsignedStartupCount;
		private Int64? _ticksUseageTime;
		private String _version;
		private DateTime _created;
		private DateTime _lastSeen;
		private Guid _remoteUserId;
		private Guid _remoteApplicationId;
	
	
	
		///<summary> 
		///		[<c>CentralServiceDb</c>].[<c>RemoteInstances</c>].[<c>Id</c>] (Type = <c>uniqueidentifier</c>, Default = '<c>(newid())</c>') 
		///</summary>
		public Guid Id 
		{
			get { return _id; }
			set { SetProperty(ref _id, value, nameof(Id)); }
		}
		///<summary> 
		///		[<c>CentralServiceDb</c>].[<c>RemoteInstances</c>].[<c>ProcessFile</c>] (Type = <c>nvarchar</c>, <c>NULLABLE</c>, MaxLength = <c>-1</c>) 
		///</summary>
		public String ProcessFile 
		{
			get { return _processFile; }
			set { SetProperty(ref _processFile, value, nameof(ProcessFile)); }
		}
		///<summary> 
		///		[<c>CentralServiceDb</c>].[<c>RemoteInstances</c>].[<c>FirstExecutionTime</c>] (Type = <c>datetime2</c>, <c>NULLABLE</c>) 
		///</summary>
		public DateTime? FirstExecutionTime 
		{
			get { return _firstExecutionTime; }
			set { SetProperty(ref _firstExecutionTime, value, nameof(FirstExecutionTime)); }
		}
		///<summary> 
		///		[<c>CentralServiceDb</c>].[<c>RemoteInstances</c>].[<c>LastExecutionTime</c>] (Type = <c>datetime2</c>, <c>NULLABLE</c>) 
		///</summary>
		public DateTime? LastExecutionTime 
		{
			get { return _lastExecutionTime; }
			set { SetProperty(ref _lastExecutionTime, value, nameof(LastExecutionTime)); }
		}
		///<summary> 
		///		[<c>CentralServiceDb</c>].[<c>RemoteInstances</c>].[<c>Unsigned_StartupCount</c>] (Type = <c>int</c>, <c>NULLABLE</c>) 
		///</summary>
		public Int32? UnsignedStartupCount 
		{
			get { return _unsignedStartupCount; }
			set { SetProperty(ref _unsignedStartupCount, value, nameof(UnsignedStartupCount)); }
		}
		///<summary> 
		///		[<c>CentralServiceDb</c>].[<c>RemoteInstances</c>].[<c>Ticks_UseageTime</c>] (Type = <c>bigint</c>, <c>NULLABLE</c>) 
		///</summary>
		public Int64? TicksUseageTime 
		{
			get { return _ticksUseageTime; }
			set { SetProperty(ref _ticksUseageTime, value, nameof(TicksUseageTime)); }
		}
		///<summary> 
		///		[<c>CentralServiceDb</c>].[<c>RemoteInstances</c>].[<c>Version</c>] (Type = <c>nvarchar</c>, <c>NULLABLE</c>, MaxLength = <c>-1</c>) 
		///</summary>
		public String Version 
		{
			get { return _version; }
			set { SetProperty(ref _version, value, nameof(Version)); }
		}
		///<summary> 
		///		[<c>CentralServiceDb</c>].[<c>RemoteInstances</c>].[<c>Created</c>] (Type = <c>datetime2</c>) 
		///</summary>
		public DateTime Created 
		{
			get { return _created; }
			set { SetProperty(ref _created, value, nameof(Created)); }
		}
		///<summary> 
		///		[<c>CentralServiceDb</c>].[<c>RemoteInstances</c>].[<c>LastSeen</c>] (Type = <c>datetime2</c>) 
		///</summary>
		public DateTime LastSeen 
		{
			get { return _lastSeen; }
			set { SetProperty(ref _lastSeen, value, nameof(LastSeen)); }
		}
		///<summary> 
		///		[<c>CentralServiceDb</c>].[<c>RemoteInstances</c>].[<c>RemoteUserId</c>] (Type = <c>uniqueidentifier</c>) 
		///</summary>
		public Guid RemoteUserId 
		{
			get { return _remoteUserId; }
			set { SetProperty(ref _remoteUserId, value, nameof(RemoteUserId)); }
		}
		///<summary> 
		///		[<c>CentralServiceDb</c>].[<c>RemoteInstances</c>].[<c>RemoteApplicationId</c>] (Type = <c>uniqueidentifier</c>) 
		///</summary>
		public Guid RemoteApplicationId 
		{
			get { return _remoteApplicationId; }
			set { SetProperty(ref _remoteApplicationId, value, nameof(RemoteApplicationId)); }
		}
		///<summary> 
		///		[<c>CentralServiceDb</c>].[<c>RemoteInstances</c>].[<c>Unsigned_StartupCount</c>] (Type = <c>int</c>, <c>NULLABLE</c>) 
		///</summary>
		public UInt32? StartupCount
		{
			get { return (UInt32?) UnsignedStartupCount; }
			set { UnsignedStartupCount = (Int32?) value; }
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