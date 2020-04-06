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
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace ReportingLayer.Database
{
	public partial class Validate_AssessmentTestResp_Entry
	{
		public static DataTable dt = new DataTable();
		/// <summary>
		/// This method gets called right after the recording has been started.
		/// It can be used to execute recording specific initialization code.
		/// </summary>
		private void Init()
		{
			// Your recording specific initialization code goes here.
		}

		/// <summary>
		/// Queries the Reporting database for AssessmentTestResponses and stores the resulting records in a Datatable
		/// </summary>
		public void GetAssessment(string database, string dbserver, string username, string password, string authentication)
		{
			dt.Reset();
			
			//Setup SQL Query
			string query = @"SELECT * FROM Assessment.AssessmentTestResponse
        					WHERE TestID = @TestIdentifier";
			
			//Setup Connection String
			string sqlConnString = string.Format("Server={0};Database={1};User Id={2};Password={3};Authentication={4};Connection Timeout={5};", dbserver, database, username, password, authentication, "30");
			
			//Setup sql Client
			SqlDataAdapter da = new SqlDataAdapter(query, sqlConnString);
			da.SelectCommand.Parameters.AddWithValue("@TestIdentifier", TestIdentifier);
			
			//Get query results
			using (da)
			{
				da.Fill(dt);
			}
			
		}
		
		/// <summary>
		/// Prints the contents of the DataTable to the Report and confirms the AssessmentTestResponses have been added to the Reporting Database correctly
		/// </summary>
		public void ReportRecord()
		{
			//Print only the first record as the AssessmentTestResponses could contian more records
			//than which we would like to add to the report
			for (int i = 0; i < dt.Columns.Count; i++)
			{
				Report.Log(ReportLevel.Info, dt.Columns[i].ColumnName + ": " + dt.Rows[0][i].ToString());
			}
			
            //Compare the ProtocolName and TestId and confirm it is saved correctly
            if (dt.Rows[0]["ProtocolName"].ToString() == StudyName + RandNum &&
            	dt.Rows[0]["TestID"].ToString() == TestIdentifier)
            {
            	Report.Success("AssessmentTestResponse has been added to the Reporting Database successfully");
            }
            else
            {
                Report.Failure("AssessmentTestResponse has not been found/added to the Reporting Database");        	
            }
			
		}

	}
}
