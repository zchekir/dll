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
using System.Timers;
using System.Diagnostics;

namespace ReportingLayer.AcademicExtract
{
	public partial class Check_Pending_Cells
		
	{
		int i;
		Boolean isPending;
		DataTable dt = new DataTable();
		
		//Timer.Equals(2)
		
		
		private void Init()
		{
			
		}

	
		public void CheckPending(string dbserver, string database, string username, string password, string authentication)
		{
			Stopwatch timer = new Stopwatch();
			timer.Start();
			
			string query;
			
			//Build SQL query and connection string
			//Adding an if statement in here so we can query a different view for the Cricket.1 hotfix
			if (database == "cgst-cricket-rpt")
			{
				query = @"SELECT * 
						FROM [dbo].[vwAcademicExtract]
						WHERE TestIdentifier = @TestIdentifier";
			}
			else
			{
				query = @"SELECT * 
						FROM [extracts].[vwAcademicExtract]
						WHERE TestIdentifier = @TestIdentifier";
			}
			
			//do while pending data appears in DB
			do{
				
				//Reset pending flag to false otherwise it will get stuck in loop even if data continues to flow
				isPending = false;
				
				do{
					string sqlConnString = string.Format("Server={0};Database={1};User Id={2};Password={3};Authentication={4};Connection Timeout={5};", dbserver, database, username, password, authentication, "30");
					
					SqlDataAdapter da = new SqlDataAdapter(query,sqlConnString);
					
					//Replaces the Testidentifier variable in query with TestIdentifier obtained during test run
					da.SelectCommand.Parameters.AddWithValue("@TestIdentifier", TestIdentifier);
					
					using (da)
					{
						da.Fill(dt);
					}
					
				} while ( dt.Rows.Count < 1);
				
				//Loop over the entire first row and confirm there are no <Pending> cells
				for ( i = 0; i < dt.Columns.Count; i++)
				{
					
					if(dt.Rows[0][i].ToString() == "<Pending>")
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
				
			} while (isPending);
	
		}
	
	}
	
}






