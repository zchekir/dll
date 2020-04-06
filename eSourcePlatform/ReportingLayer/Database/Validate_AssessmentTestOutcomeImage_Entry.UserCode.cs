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
using System.Linq;
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
    public partial class Validate_AssessmentTestOutcomeImage_Entry
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
		/// Queries the Reporting database for AssessmentTestOutcome records and stores the resulting records in a Datatable
		/// </summary>         
        public void GetAssessmentTestOutcomesImage(string database, string dbserver, string username, string password, string authentication)
        {
            dt.Reset();
        	
        	//Setup SQL Query
        	string query = @"SELECT * FROM Assessment.AssessmentTestOutcomeImage
        					WHERE TestID = @TestIdentifier";
        	
        	//Setup Connection String
        	string sqlConnString = string.Format("Server={0};Database={1};User Id={2};Password={3};Authentication={4};Connection Timeout={5};", dbserver, database, username, password, authentication, "30");
        	
        	//Setup SQL Client
        	SqlDataAdapter da = new SqlDataAdapter(query, sqlConnString);
        	da.SelectCommand.Parameters.AddWithValue("@TestIdentifier", TestIdentifier);
        	
        	//Get query results
        	using (da) 
        	{
        		da.Fill(dt);
        	}
        }

        
        /// <summary>
        /// Prints the contents of the DataTable to the Report and confirms the AssessmentTestOutcome has been added to the Reporting Database correctly
        /// Confirms all expected outcomes are contained in the Table
        /// </summary>           
        public void ReportRecords()
        {
            //Arry used to store all expected Card outcomes in the Table        	
        	string[] expectedOutcomes = new string[] {"ProtocolName", "IQNumber", "TestId", "AssessmentTestId", "TestCompletion", "ReactionTime", "RawReactionTime",
        		"RTVariability", "RawRTVariability", "Accuracy", "RawAccuracy", "TotalTrials", "TotalResponses", "TotalCorrect", "TotalErrors", "LegalErrors", "RuleBreakErrors", "TotalAnticipatory",
        		"TotalMaxOut", "TestDuration", "PrimaryOutcome"};
        	
        	int matchedOutcomes = 0;
        	
        	//Loop over each row and print the Outcome and Value if the current column is contained in the expected outcomes array
        	//Comparing the columns to the expected outcomes array will avoid printing unnecessary data to the report
			foreach (DataRow row in dt.Rows)
			{
				//Here we are getting the current column name and making sure it appears in the expected outcome list
				for (int i = 0; i < dt.Columns.Count; i++)
				{
					if (expectedOutcomes.Any(dt.Columns[i].ColumnName.Contains))
					{
						Report.Log(ReportLevel.Info, dt.Columns[i].ColumnName + ": " + row[i].ToString());
        				
        				//Counter to keep track of how many expected outcomes we have found in the table 
        				matchedOutcomes++;
					}
				}
			}
			
			//Check to make sure the count of expected outcomes match the number of outcomes found. First we need to divide the number of matched outcomes found by the number of rows
        	//in the DataTable to get the correct number of outcome matches.
        	if ((matchedOutcomes / dt.Rows.Count) == expectedOutcomes.Length)
        	{
        		Report.Success("AssessmentTestOutcomeImage Table contains all expected outcomes");
        		
        		//Make sure the data returned by the query contains only the Study and TestID we expect
        		foreach (DataRow row in dt.Rows)
        		{
        			if (row["TestID"].ToString() == TestIdentifier && 
        				row["ProtocolName"].ToString() == StudyName + RandNum)
        			{
        				Report.Success("AssessmentTestOutcomeImage results have been added to the Reporting Database successfully");        				
        			}
        			else
        			{
        				Report.Failure("AssessmentTestOutcomeImage have not been added/does not appear in the Reporting Database");        				
        			}
        		}
        	}
        	else
        	{
        		Report.Failure("Expected Number of Outcomes: " + expectedOutcomes.Length + " Actual Number of Outcomes: " + (matchedOutcomes / dt.Rows.Count).ToString());        		
        	}
        }

    }
}
