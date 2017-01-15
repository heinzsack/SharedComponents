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
//<date>2017-01-15 16:50:35</date>



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
using IRepositoryFile=HsCentralServiceWeb._dbs.hsserver.centralservicedb.rowinterfaces.IRepositoryFile;






namespace HsCentralServiceWeb._dbs.hsserver.centralservicedb.rowinterfaces
{
	///	<summary>Interface for <see cref="RepositoryFile"/> can be used to create POCO object or other models.</summary>
	[CsDbDataRowInterface(Database = "CentralServiceDb", TableName = "RepositoryFiles", Generated = "17.01.15 16:50:35", Hash = "79484A7AFA5D3F1E734CCB30F25BFD56")]
	public interface IRepositoryFile
	{
		///	<summary>[<c>CentralServiceDb</c>].[<c>RepositoryFiles</c>].[<c>Id</c>]</summary>
		Guid Id { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RepositoryFiles</c>].[<c>Hash</c>]</summary>
		String Hash { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RepositoryFiles</c>].[<c>Path</c>]</summary>
		String Path { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RepositoryFiles</c>].[<c>Name</c>]</summary>
		String Name { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RepositoryFiles</c>].[<c>Extension</c>]</summary>
		String Extension { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RepositoryFiles</c>].[<c>Description</c>]</summary>
		String Description { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RepositoryFiles</c>].[<c>Author</c>]</summary>
		String Author { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RepositoryFiles</c>].[<c>Length</c>]</summary>
		Int32 Length { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RepositoryFiles</c>].[<c>Created</c>]</summary>
		DateTime Created { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RepositoryFiles</c>].[<c>Modified</c>]</summary>
		DateTime Modified { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RepositoryFiles</c>].[<c>Group</c>]</summary>
		String Group { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RepositoryFiles</c>].[<c>TimeToLive</c>]</summary>
		DateTime? TimeToLive { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RepositoryFiles</c>].[<c>AccessDate</c>]</summary>
		DateTime? AccessDate { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RepositoryFiles</c>].[<c>AccessCount</c>]</summary>
		Int32? AccessCount { get; set; }
		///	<summary>[<c>CentralServiceDb</c>].[<c>RepositoryFiles</c>].[<c>LastAccessBy</c>]</summary>
		String LastAccessBy { get; set; }
	}
}