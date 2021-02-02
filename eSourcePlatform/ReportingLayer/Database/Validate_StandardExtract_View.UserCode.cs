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
    public partial class Validate_StandardExtract_View
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
        /// Queries the Standard Extract view for records and stores in the DataTable
        /// </summary>        
        public void GetStandardExtract(string database, string dbserver, string username, string password, string authentication)
        {
            dt.Reset();
        	
        	//Setup SQL Query
        	string query = @"SELECT * FROM extracts.vwStandardExtract
        					WHERE TestIdentifier = @TestIdentifier";
        	
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
        /// Prints the contents of the DataTable to the Report and confirms the Standard Extract view contains the completed assessment
        /// Confirms all expected outcomes are contained in the View
        /// </summary>  
        public void ReportRecords()
        {
            //Array used to store all expected columns in the view
            string[] expectedColumns = new string[] {"ProtocolID", "StudyName", "Locality Code", "PIName", "SiteID", "TestSupervisor", "SubjectID", "IQnumber", "DOB", "Age",
														"Sex", "EventName", "DateOfAssessment", "AssessmentDuration", "TestIdentifier", "AssessmentAttempt", "AssessmentCompletionPass",
													     "AssessmentPerformancePass", "AssessmentIntegrityPass", "ExcludeAssessment", "RCCAssessment", "Test", "TestDuration", "GMLTIndex",
 													      "TestAttempt", "TestVersion", "TestPhase", "TestSubset", "Round", "LanguageCode", "TestCompletionPass", "TestPerformancePass", "TestIntegrityPass",
 													        "PrimaryOutcome", "ReactionTime", "RawReactionTime", "RTVariability", "RawRTVariability", "Accuracy", "RawAccuracy", "TotalTrials",
 													         "TotalResponses", "TotalFalsePositive", "TotalCorrect", "TotalCorrectExclPant", "TotalCorrectFoils", "TotalErrors", "LegalErrors", "RuleBreakErrors",
											                  "PerseverativeErrors","ReturnToHead", "TotalAnticipatory", "TotalPost", "TotalMaxout", "MovesPerSecond", "StandardScoreZ", "StandardScoreT", "ChangeScore", 
											                  "PsyAttChange", "LearnWMStdScr", "LearnWMChange", "AlternateOutcome", "AltStandardScoreZ", "AltStandardScoreT"};
        	int matchedOutcomes = 0;
        	bool resultsFlag = true;
        	
        	//Check only the first row in the Academic Extract. Print stored data and count the number of expected columns found
        	for (int i = 0; i < dt.Columns.Count; i++)
        	{
        		//Here we are getting the current column name and making sure it appears in the expected outcome list
        		if (expectedColumns.Any(dt.Columns[i].ColumnName.Contains))
        		{
        			Report.Log(ReportLevel.Info, dt.Columns[i].ColumnName + ": " + dt.Rows[0][i].ToString());
        			
        			//Counter to keep track of how many expected outcomes we have found in the table
        			matchedOutcomes++;
        		}
        	}

        	
        	//Check to make sure the count of expected outcomes match the number of outcomes found. First we need to divide the number of matched outcomes found by the number of rows
        	//in the DataTable to get the correct number of outcome matches.
        	if (matchedOutcomes == expectedColumns.Length)
        	{
        		Report.Success("Standard Extract View contains all expected outcomes");
        		
        		//Make sure the data returned by the query contains only the Study and TestID we expect
        		foreach (DataRow row in dt.Rows)
        		{
        			if (row["TestIdentifier"].ToString().ToLower() == TestIdentifier && row["ProtocolID"].ToString() == StudyName + RandNum)
        			{
						resultsFlag = true;
        			}
        			else
        			{
        				Report.Failure("Standard Extract view results have not been added/does not appear in the Reporting Database correctly");
        				resultsFlag = false;
        				break;
        			}
        		}
        		
        		//Print result to report if flag is set as true
        		if (resultsFlag) 
        		{
        			Report.Success("Standard Extract view results have been added to the Reporting Database Successfully");
        		}
        	}
        	else
        	{
        		Report.Failure("Expected Number of Outcomes: " + expectedColumns.Length + " Actual Number of Outcomes: " + matchedOutcomes.ToString());
        	}
        }

    }
}
