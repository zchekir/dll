/*
 * Created by Ranorex
 * User: DWood
 * Date: 25/10/2018
 * Time: 4:20 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
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
using Ranorex.Core.Testing;

namespace engine.DataProcessor
{
    /// <summary>
    /// Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class CompareOutcomes
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        public static string CurrentValue;
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        private static string GetExtractValue(string testCode, string outcome)
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
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        private static bool CheckOutcomesMatch(string outcome, string extractValue, string databaseValue)
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
 			    case "Age":
 				case "SessionID":
 				case "SessionDate":					
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
        
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void Validate_Outcomes_Match()
        {
        	int colIndex = 1;
        	int rowIndex = 0;
        	string extractValue;
        	string databaseValue;
        	string currentOutcome = "";
        	string currentTestCode = "";
        	
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
           					//Store current outcome and test code we are comparing
           					currentOutcome = engine.Helpers.SQLUtility.dt.Columns[i].ColumnName;
           					currentTestCode = row[colIndex].ToString();
           					
           					//Get the extract value from the imported CSV, using the current TestCode and outcome from the database scores as reference
           					extractValue = GetExtractValue(currentTestCode, currentOutcome);
           					databaseValue = engine.Helpers.SQLUtility.dt.Rows[rowIndex][i].ToString();
           					
           					//Some outcomes may be formatted differently in the extract and database so we need to pass the two values to this method
           					//for some formatting before comparing the two outcomes. Some outcomes are expected not to match. In this case, we just
           					//want to log a message in the report without the Success/Failure log
           					if(CheckOutcomesMatch(engine.Helpers.SQLUtility.dt.Columns[i].ColumnName, extractValue, databaseValue))
           						if (currentOutcome == "IQNumber" || currentOutcome == "SessionID" || currentOutcome == "SessionDate"
           						   || currentOutcome == "Age") {
           							 Report.Info("Outcome difference expected, no comparison needed");
           						}
           						else {
           							 Report.Success("Processed Score matches the score in the extract");
           						}

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
    }
}
