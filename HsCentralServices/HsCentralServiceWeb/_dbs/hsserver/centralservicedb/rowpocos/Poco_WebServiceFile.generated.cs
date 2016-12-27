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
//<date>2016-12-20 15:09:56</date>



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
using Poco_WebServiceFile=HsCentralServiceWeb._dbs.hsserver.centralservicedb.rowpocos.Poco_WebServiceFile;






namespace HsCentralServiceWeb._dbs.hsserver.centralservicedb.rowpocos
{
	public partial class Poco_WebServiceFile : IWebServiceFile, INotifyPropertyChanged
	{
		private Guid _id;
		private DateTime _created;
		private DateTime _modified;
		private DateTime _accessed;
		private Int32 _accessCount;
		private String _name;
		private String _extension;
		private String _description;
		private String _fullFilePath;
	
	
	
		///<summary> 
		///		[<c>CentralServiceDb</c>].[<c>WebServiceFiles</c>].[<c>Id</c>] (Type = <c>uniqueidentifier</c>, Default = '<c>(newid())</c>') 
		///</summary>
		public Guid Id 
		{
			get { return _id; }
			set { SetProperty(ref _id, value, nameof(Id)); }
		}
		///<summary> 
		///		[<c>CentralServiceDb</c>].[<c>WebServiceFiles</c>].[<c>Created</c>] (Type = <c>datetime2</c>) 
		///</summary>
		public DateTime Created 
		{
			get { return _created; }
			set { SetProperty(ref _created, value, nameof(Created)); }
		}
		///<summary> 
		///		[<c>CentralServiceDb</c>].[<c>WebServiceFiles</c>].[<c>Modified</c>] (Type = <c>datetime2</c>) 
		///</summary>
		public DateTime Modified 
		{
			get { return _modified; }
			set { SetProperty(ref _modified, value, nameof(Modified)); }
		}
		///<summary> 
		///		[<c>CentralServiceDb</c>].[<c>WebServiceFiles</c>].[<c>Accessed</c>] (Type = <c>datetime2</c>) 
		///</summary>
		public DateTime Accessed 
		{
			get { return _accessed; }
			set { SetProperty(ref _accessed, value, nameof(Accessed)); }
		}
		///<summary> 
		///		[<c>CentralServiceDb</c>].[<c>WebServiceFiles</c>].[<c>AccessCount</c>] (Type = <c>int</c>) 
		///</summary>
		public Int32 AccessCount 
		{
			get { return _accessCount; }
			set { SetProperty(ref _accessCount, value, nameof(AccessCount)); }
		}
		///<summary> 
		///		[<c>CentralServiceDb</c>].[<c>WebServiceFiles</c>].[<c>Name</c>] (Type = <c>nvarchar</c>, MaxLength = <c>2000</c>) 
		///</summary>
		public String Name 
		{
			get { return _name; }
			set { SetProperty(ref _name, value, nameof(Name)); }
		}
		///<summary> 
		///		[<c>CentralServiceDb</c>].[<c>WebServiceFiles</c>].[<c>Extension</c>] (Type = <c>nvarchar</c>, MaxLength = <c>255</c>) 
		///</summary>
		public String Extension 
		{
			get { return _extension; }
			set { SetProperty(ref _extension, value, nameof(Extension)); }
		}
		///<summary> 
		///		[<c>CentralServiceDb</c>].[<c>WebServiceFiles</c>].[<c>Description</c>] (Type = <c>nvarchar</c>, <c>NULLABLE</c>, MaxLength = <c>-1</c>) 
		///</summary>
		public String Description 
		{
			get { return _description; }
			set { SetProperty(ref _description, value, nameof(Description)); }
		}
		///<summary> 
		///		[<c>CentralServiceDb</c>].[<c>WebServiceFiles</c>].[<c>FullFilePath</c>] (Type = <c>nvarchar</c>, MaxLength = <c>4000</c>) 
		///</summary>
		public String FullFilePath 
		{
			get { return _fullFilePath; }
			set { SetProperty(ref _fullFilePath, value, nameof(FullFilePath)); }
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