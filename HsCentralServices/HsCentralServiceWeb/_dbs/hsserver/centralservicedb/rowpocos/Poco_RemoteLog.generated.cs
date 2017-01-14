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
//<date>2017-01-14 15:59:26</date>



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
using Poco_RemoteLog=HsCentralServiceWeb._dbs.hsserver.centralservicedb.rowpocos.Poco_RemoteLog;






namespace HsCentralServiceWeb._dbs.hsserver.centralservicedb.rowpocos
{
	public partial class Poco_RemoteLog : IRemoteLog, INotifyPropertyChanged
	{
		private Guid _id;
		private DateTime _created;
		private Int32 _severityNumber;
		private String _title;
		private String _message;
		private String _codeFile;
		private String _codeMethod;
		private Int32? _codeLine;
		private Guid _remoteInstanceId;
	
	
	
		///<summary> 
		///		[<c>CentralServiceDb</c>].[<c>RemoteLogs</c>].[<c>Id</c>] (Type = <c>uniqueidentifier</c>, Default = '<c>(newid())</c>') 
		///</summary>
		public Guid Id 
		{
			get { return _id; }
			set { SetProperty(ref _id, value, nameof(Id)); }
		}
		///<summary> 
		///		[<c>CentralServiceDb</c>].[<c>RemoteLogs</c>].[<c>Created</c>] (Type = <c>datetime2</c>) 
		///</summary>
		public DateTime Created 
		{
			get { return _created; }
			set { SetProperty(ref _created, value, nameof(Created)); }
		}
		///<summary> 
		///		[<c>CentralServiceDb</c>].[<c>RemoteLogs</c>].[<c>SeverityNumber</c>] (Type = <c>int</c>) 
		///</summary>
		public Int32 SeverityNumber 
		{
			get { return _severityNumber; }
			set { SetProperty(ref _severityNumber, value, nameof(SeverityNumber)); }
		}
		///<summary> 
		///		[<c>CentralServiceDb</c>].[<c>RemoteLogs</c>].[<c>Title</c>] (Type = <c>nvarchar</c>, MaxLength = <c>-1</c>) 
		///</summary>
		public String Title 
		{
			get { return _title; }
			set { SetProperty(ref _title, value, nameof(Title)); }
		}
		///<summary> 
		///		[<c>CentralServiceDb</c>].[<c>RemoteLogs</c>].[<c>Message</c>] (Type = <c>nvarchar</c>, MaxLength = <c>-1</c>) 
		///</summary>
		public String Message 
		{
			get { return _message; }
			set { SetProperty(ref _message, value, nameof(Message)); }
		}
		///<summary> 
		///		[<c>CentralServiceDb</c>].[<c>RemoteLogs</c>].[<c>CodeFile</c>] (Type = <c>nvarchar</c>, <c>NULLABLE</c>, MaxLength = <c>-1</c>) 
		///</summary>
		public String CodeFile 
		{
			get { return _codeFile; }
			set { SetProperty(ref _codeFile, value, nameof(CodeFile)); }
		}
		///<summary> 
		///		[<c>CentralServiceDb</c>].[<c>RemoteLogs</c>].[<c>CodeMethod</c>] (Type = <c>nvarchar</c>, <c>NULLABLE</c>, MaxLength = <c>-1</c>) 
		///</summary>
		public String CodeMethod 
		{
			get { return _codeMethod; }
			set { SetProperty(ref _codeMethod, value, nameof(CodeMethod)); }
		}
		///<summary> 
		///		[<c>CentralServiceDb</c>].[<c>RemoteLogs</c>].[<c>CodeLine</c>] (Type = <c>int</c>, <c>NULLABLE</c>) 
		///</summary>
		public Int32? CodeLine 
		{
			get { return _codeLine; }
			set { SetProperty(ref _codeLine, value, nameof(CodeLine)); }
		}
		///<summary> 
		///		[<c>CentralServiceDb</c>].[<c>RemoteLogs</c>].[<c>RemoteInstanceId</c>] (Type = <c>uniqueidentifier</c>) 
		///</summary>
		public Guid RemoteInstanceId 
		{
			get { return _remoteInstanceId; }
			set { SetProperty(ref _remoteInstanceId, value, nameof(RemoteInstanceId)); }
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