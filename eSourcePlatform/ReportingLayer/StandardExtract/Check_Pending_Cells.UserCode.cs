﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using System.Data;
using System.Data.SqlClient;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;
using System.Diagnostics;

namespace ReportingLayer.StandardExtract
{
	public partial class Check_Pending_Cells
	{
		int i;
		Boolean isPending;
		DataTable dt = new DataTable();
		
		private void Init()
		{
			
		}

		
		public void CheckPending(string dbserver, string database, string username, string password, string authentication)
		{
			DataTable dt = new DataTable();
			Stopwatch timer = new Stopwatch();
			timer.Start();
			//Build SQL query and connection string
			string query = @"SELECT * 
							FROM [dbo].[vwStandardExtract]
							WHERE TestIdentifier = @TestIdentifier";
			
			//do while the peeding data appears in DB
			do{
				
				//Reset pending flag to false otherwise it will get stuck in loop even if data continues to flow
				isPending = false;
				
				string sqlConnString = string.Format("Server={0};Database={1};User Id={2};Password={3};Authentication={4};Connection Timeout={5};", dbserver, database, username, password, authentication, "300");
				
				SqlDataAdapter da = new SqlDataAdapter(query,sqlConnString);
				
				//Replaces the Testidentifier variable in query with TestIdentifier obtained during test run
				da.SelectCommand.Parameters.AddWithValue("@TestIdentifier", TestIdentifier);
				//Sets the timeout for the query to 5 minutes
				da.SelectCommand.CommandTimeout = 300;
				
				using (da)
				{
					da.Fill(dt);
				}
				
				//Loop over the entire first row and confirm there are no <Pending> cells
				for (i = 0; i < dt.Columns.Count; i++)
				{
					if (dt.Rows[0][i].ToString() == "<Pending>")
					{
						isPending = true;
						Delay.Seconds(4);
					}
					else
					{
						Report.Success(dt.Columns[i].ColumnName + ": " + dt.Rows[0][i].ToString());

					}
					
				}
				
				if ( timer.Elapsed > TimeSpan.FromMinutes(5)){
					
					for ( i = 0; i < dt.Columns.Count; i++){
						Report.Failure("The following Variable is still pending: " + dt.Columns[i].ColumnName);
					}
					
					break;
				}
				
				
			}while (isPending);
		}

	}
}
