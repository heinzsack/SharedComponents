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
//<date>2017-01-15 00:09:48</date>



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
using Poco_Sysdiagram=RingPlayer24._dbs.hsserver.ringplayerdb.rowpocos.Poco_Sysdiagram;






namespace RingPlayer24._dbs.hsserver.ringplayerdb.rowpocos
{
	public partial class Poco_Sysdiagram : ISysdiagram, INotifyPropertyChanged
	{
		private String _name;
		private Int32 _principalId;
		private Int32 _diagramId;
		private Int32? _version;
		private Byte[] _definition;
	
	
	
		///<summary> 
		///		[<c>RingPlayerDb</c>].[<c>sysdiagrams</c>].[<c>name</c>] (Type = <c>nvarchar</c>, MaxLength = <c>128</c>) 
		///</summary>
		public String Name 
		{
			get { return _name; }
			set { SetProperty(ref _name, value, nameof(Name)); }
		}
		///<summary> 
		///		[<c>RingPlayerDb</c>].[<c>sysdiagrams</c>].[<c>principal_id</c>] (Type = <c>int</c>) 
		///</summary>
		public Int32 PrincipalId 
		{
			get { return _principalId; }
			set { SetProperty(ref _principalId, value, nameof(PrincipalId)); }
		}
		///<summary> 
		///		[<c>RingPlayerDb</c>].[<c>sysdiagrams</c>].[<c>diagram_id</c>] (Type = <c>int</c>) 
		///</summary>
		public Int32 DiagramId 
		{
			get { return _diagramId; }
			set { SetProperty(ref _diagramId, value, nameof(DiagramId)); }
		}
		///<summary> 
		///		[<c>RingPlayerDb</c>].[<c>sysdiagrams</c>].[<c>version</c>] (Type = <c>int</c>, <c>NULLABLE</c>) 
		///</summary>
		public Int32? Version 
		{
			get { return _version; }
			set { SetProperty(ref _version, value, nameof(Version)); }
		}
		///<summary> 
		///		[<c>RingPlayerDb</c>].[<c>sysdiagrams</c>].[<c>definition</c>] (Type = <c>varbinary</c>, <c>NULLABLE</c>, MaxLength = <c>-1</c>) 
		///</summary>
		public Byte[] Definition 
		{
			get { return _definition; }
			set { SetProperty(ref _definition, value, nameof(Definition)); }
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