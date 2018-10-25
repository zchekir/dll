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
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace PrecisionRecruitment.ExtractsPage
{
    public partial class Validate_Extract_Outcomes
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }
        
        /// <summary>
        /// Stores the current value found in the extract
        /// </summary>
        public string CurrentValue;

               
        /// <summary>
        /// This will search the stored datatable (after importing form file) for a value using specified options
        /// </summary>
        /// <param name="testCode">The test code to earch for i.e Detection</param>
        /// <param name="outcome">The outcome (column) to search for i.e Accuracy</param>
        /// <returns></returns>
        private string GetExtractValue(string testCode, string outcome)
        {
        	int outcomeIndex = 0;
        	int testCodeRowIndex = 0;
        	int testCodeColIndex = 0;
        	bool testCodeColFound = false;
        	bool testCodeRowFound = false;
        	bool outcomeIndexFound = false;
        	
        	/*Loop over each column in the CSV file. We want to find the column which contains the TestCodes so
        	 * we can then search each row to find which one contains the outcomes for the current test we are
        	 * interested in. 
        	 * */
        	foreach (DataColumn col in engine.Helpers.CSVUtility.dt.Columns)
        	{
  				if (col.ColumnName == "Test")
  				{
  					testCodeColFound = true;
  					//We have now found the column containing the TestCodes, we want to loop over each row and find the
  					//row containing the current test data we are interested in
  					foreach (DataRow row in engine.Helpers.CSVUtility.dt.Rows)
  					{
  						if (row[col].ToString() == testCode)
  						{
  							testCodeRowFound = true;
  							break;
  						}
  						else
  						{
  							testCodeRowIndex++;
  						}
  					}	
  				}
  				
  				//Set flag to true once we have found the column containing the outcome we want
  				if (col.ColumnName == outcome)
  					outcomeIndexFound = true;

  				//Check if we have found the columns and increment counters if we are still searching
  				if (!testCodeColFound)
  				    testCodeColIndex++;

  				if (!outcomeIndexFound) 
  					outcomeIndex++;
  				
  				//Exit the loop if we have found the correct row and column
  				if (outcomeIndexFound && testCodeRowFound)
  					break;
  				  				
        	}
        	
        	//Store result from search
      		if (outcomeIndexFound)
      			CurrentValue = engine.Helpers.CSVUtility.dt.Rows[testCodeRowIndex][outcomeIndex].ToString();
      		else
      			CurrentValue = "Test Outcome not found in CSV";
        	
			return CurrentValue;        	
        }
		
        /// <summary>
        /// Compares values in the database with values from the stored extract after importing the CSV data into a datatable
        /// and running an SQL script to extract the processed scores from the database, also storing them in a datatable
        /// Note; CSV must be imported into Datatable and SQL script must be run and stored in Datatable first
        /// </summary>
        public void CompareOutcomes()
        {
        	int colIndex = 1;
        	int rowIndex = 0;
        	string extractValue;
        	string databaseValue;
        	
           //Loop over each column from the processed data. When the 'Test' column containing the tests completed in the battery is found,
		   //loop over each column in that row, comparing the value from extract to value from database, then move on to the next row           
           foreach (DataColumn col in engine.Helpers.SQLUtility.dt.Columns)
           {
           		if (col.ColumnName == "Test")
           		{
           			foreach (DataRow row in engine.Helpers.SQLUtility.dt.Rows)
           			{
           				for (int i = 0; i < engine.Helpers.SQLUtility.dt.Columns.Count; i++)
           				{
           					//Get the extract value from the imported CSV, using the current TestCode and outcome from the database scores as reference
           					extractValue = GetExtractValue(row[colIndex].ToString(), engine.Helpers.SQLUtility.dt.Columns[i].ColumnName);
           					databaseValue = engine.Helpers.SQLUtility.dt.Rows[rowIndex][i].ToString();
           					
           					//Some outcomes may be formatted differently in the extract and database so we need to pass the two values to this method
           					//for some formatting before comparing the two outcomes
           					if(CheckOutcomesMatch(engine.Helpers.SQLUtility.dt.Columns[i].ColumnName, extractValue, databaseValue))
           						Report.Success("Processed Score matches the score in the extract");
           					else
           						Report.Failure("Processed Score does not match the score in the extract");
           					
           					Report.Info("Extract Outcome: " + engine.Helpers.SQLUtility.dt.Columns[i].ColumnName + " - Extract Value: " + extractValue);
           					Report.Info("Database Outcome: " + engine.Helpers.SQLUtility.dt.Columns[i].ColumnName + " - Database Value: " + databaseValue);

           					//Report.LogHtml(ReportLevel.Info, "Extract - Outcome: " + engine.Helpers.SQLUtility.dt.Columns[i].ColumnName + " - Value: " + GetExtractValue(row[colIndex].ToString(), engine.Helpers.SQLUtility.dt.Columns[i].ColumnName) +
           					          //"<br />" + " Database - Outcome: " + engine.Helpers.SQLUtility.dt.Columns[i].ColumnName + " - Value: " + engine.Helpers.SQLUtility.dt.Rows[rowIndex][i].ToString());
           				}
           				rowIndex++;
           			}
           		}
           		else
           		{
           			colIndex++;
           		}
           }
				
        }
        
        /// <summary>
        /// Compares the extract and database values passed in to determine if they match.
        /// </summary>
        /// <param name="outcome">The name of the outcome to compare</param>
        /// <param name="extractValue">The outcome value from the extract</param>
        /// <param name="databaseValue">The outcome value from the database</param>
        /// <returns></returns>
        private bool CheckOutcomesMatch(string outcome, string extractValue, string databaseValue)
        {
        	bool match = false;
        	
        	//Depending on the outcome, we may want to first do some formatting of the two values we are comparing
        	switch (outcome) {
        			
        		/*Extract DateOfBirth format 1/01/1975, Database DateOfBirth Format 1/01/1975 12:00:00 AM
 				 *This will convert each of the dates to the same format and check if they are the same*/
        		case "DateOfBirth":
        			System.DateTime extractDate = System.DateTime.Parse(extractValue);
        			System.DateTime databaseDate = System.DateTime.Parse(databaseValue);
        			
        			//Report.Info("Info", "Formatted Extract Date: " + extractDate);
        			//Report.Info("Info", "Formatted Database Date: " + databaseDate);
        			
        			int result = System.DateTime.Compare(extractDate, databaseDate);
        			if (result == 0) 
        				match = true;
        			
        			break;
        		
				/*The following Outcomes may contain NULL vlaues, integers or 'Yes'/'No' values
				 *Check for NULL values first before comparing the database and extract values */
				case "TestIntegrityPass":
				case "TotalMaxOut":
				case "TotalCorrectFoils":
				case "LegalErrors":
				case "ReturnToHead":
				case "PerseverativeErrors":
				case "WithinSearchErrors":
				case "GMLTIndex":

					//First check if the extract value is NULL, if so, compare to the database value. Otherwise, check to see if
					//both values are the same i.e TestIntegrity Pass for Detection
        			if (extractValue == "NULL")
        			{
        				if (databaseValue == "")
        					match = true;
        			}
        			else if (extractValue == databaseValue)
        				match = true;
        			
        			break;
        		
				/*The following Outcomes may contain NULL or a digit with decimal places
 				*Check for NULL values before formatting the scores down to 7 decimal places and comparing*/
        		case "PrimaryOutcome":
        		case "ReactionTime":
        		case "RawReactionTime":
        		case "RTVariability":
        		case "RawRTVariability":
        		case "Accuracy":
        		case "RawAccuracy":
        		case "MovesPerSecond":
        		case "StandardScoreZ":
        		case "StandardScoreT":
        		case "PsyAttStdScr":
        		case "LearnWMStdScr":
        		case "AltLearnWMStdScr": 				
        		case "ChangeScore":
				case "PsyAttChange":
				case "LearnWMChange":	
        		case "AltStandardScoreZ":
				case "AltStandardScoreT":
				case "AlternateOutcome":
        			//Check if NULL and compare, otherwise format and then compare
        			if (extractValue == "NULL")
        			{
        				if (databaseValue == "")
        					match = true;
        			}
        			else if (Math.Round(double.Parse(extractValue),7) == Math.Round(double.Parse(databaseValue),7))
        				match = true;
        			
        			break;

				/*The following outcomes will be randomly generated or depend on the date the test is run
 				 *we do not need to compare these values for now*/         			
 				case "IQNumber":
 				case "SessionID":
 				case "SessionDate":
 					Report.Info("Info", "IQNumber, SessionID and SessionDate are expected to be different to the knows scores");
 					
 					match = true;
 					
 					break;
 			

        			
        		/*Compare all other outcomes directly, no formatting needed*/       			
        		default:
        			if (extractValue == databaseValue) 
        				match = true;
        			
        			break;
        	}
        	
        	return match;
        	
        }

    }
}
