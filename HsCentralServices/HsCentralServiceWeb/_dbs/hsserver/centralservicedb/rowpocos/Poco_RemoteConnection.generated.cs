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
//<date>2017-01-21 17:31:31</date>



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
using Poco_RemoteConnection=HsCentralServiceWeb._dbs.hsserver.centralservicedb.rowpocos.Poco_RemoteConnection;






namespace HsCentralServiceWeb._dbs.hsserver.centralservicedb.rowpocos
{
	public partial class Poco_RemoteConnection : IRemoteConnection, INotifyPropertyChanged
	{
		private Guid _id;
		private Guid _remoteInstanceId;
		private String _server;
		private DateTime _established;
		private String _events;
	
	
	
		///<summary> 
		///		[<c>CentralServiceDb</c>].[<c>RemoteConnections</c>].[<c>Id</c>] (Type = <c>uniqueidentifier</c>) 
		///</summary>
		public Guid Id 
		{
			get { return _id; }
			set { SetProperty(ref _id, value, nameof(Id)); }
		}
		///<summary> 
		///		[<c>CentralServiceDb</c>].[<c>RemoteConnections</c>].[<c>RemoteInstanceId</c>] (Type = <c>uniqueidentifier</c>) 
		///</summary>
		public Guid RemoteInstanceId 
		{
			get { return _remoteInstanceId; }
			set { SetProperty(ref _remoteInstanceId, value, nameof(RemoteInstanceId)); }
		}
		///<summary> 
		///		[<c>CentralServiceDb</c>].[<c>RemoteConnections</c>].[<c>Server</c>] (Type = <c>nvarchar</c>, MaxLength = <c>500</c>) 
		///</summary>
		public String Server 
		{
			get { return _server; }
			set { SetProperty(ref _server, value, nameof(Server)); }
		}
		///<summary> 
		///		[<c>CentralServiceDb</c>].[<c>RemoteConnections</c>].[<c>Established</c>] (Type = <c>datetime2</c>) 
		///</summary>
		public DateTime Established 
		{
			get { return _established; }
			set { SetProperty(ref _established, value, nameof(Established)); }
		}
		///<summary> 
		///		[<c>CentralServiceDb</c>].[<c>RemoteConnections</c>].[<c>Events</c>] (Type = <c>nvarchar</c>, <c>NULLABLE</c>, MaxLength = <c>-1</c>) 
		///</summary>
		public String Events 
		{
			get { return _events; }
			set { SetProperty(ref _events, value, nameof(Events)); }
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