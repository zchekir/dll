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
        
        /// <summary>
        /// Public variable used to store the Current extract value found
        /// </summary>
        public static string CurrentValue;
        
		
        /// <summary>
        /// This method will loop through the CSV datatable (must be loaded in by using the CSV utility first)
        /// looking for the specified outcome which matches the testcode and round number passed through
        /// </summary>
        /// <param name="testCode">The test code we want to find in the CSV datatable</param>
        /// <param name="round">The round for the current test code we want to find</param>
        /// <param name="outcome">The outcome we want to find for the Test/round specified</param>
        /// <returns>The outcome requested as stored in the CSV datatable</returns>
        [UserCodeMethod]
        private static string GetExtractValue(string testCode, string round, string outcome)
        {
        	int testCodeRowIndex = 0;
        	bool testCodeRowFound = false;
        	
			/*Loop over every row in the CSV Datatable utill the passed in testCode and round is
			 * found in the same row. Once we find the correct row, break from the loop and return the
			 * score for the test and outcome we are interested in. For SAT task, we need to look into the 
			 * TestSubset column instead of the TestCode column
			 * The TestCode and Round columns are being referenced by column name in the if statement below */
        	foreach (DataRow row in engine.Helpers.CSVUtility.dt.Rows)
        	{
        		if(row["TestCode"].ToString() == "SATReal")
        		{
        			if(row["TestSubset"].ToString() == testCode)
        			{
        				testCodeRowFound = true;
        				break;
        			}
        		}
        		else
        		{
        			if (row["TestCode"].ToString() == testCode && row["Round"].ToString() == round)
        			{
        				testCodeRowFound = true;
        				break;
        			}
        		}
        			testCodeRowIndex++;
        	}
        	      	
        	/*Extract the value of the outcome for the current row and store in the class variable which is
 			 * accessible to other methods in this library */	         	
      		if (testCodeRowFound)
      			CurrentValue = engine.Helpers.CSVUtility.dt.Rows[testCodeRowIndex][outcome].ToString();
      		else
      			CurrentValue = "Test Outcome not found in CSV";
        	
			return CurrentValue;        
        }
        
        
        /// <summary>
        /// This method is used internally to compare processed outcomes from the Database and previously
        /// validated outcomes stored in an extract. Certain outcomes require formatting prior to comparison,
        /// and some outcomes are expected to be different for each uplaod (eg, IQNumber). This method will deal with
        /// those instances
        /// </summary>
        /// <param name="outcome">The name of the outcome to compare</param>
        /// <param name="extractValue">The value of the outcome pulled from the locally stored extract</param>
        /// <param name="databaseValue">The value of the outcome pulled directly from the database</param>
        /// <returns>True if the values match, false if there is a mismatch</returns>
        [UserCodeMethod]
        private static bool CheckOutcomesMatch(string outcome, string extractValue, string databaseValue)
        {
        	bool match = false;
        	
        	//Depending on the outcome, we may want to first do some formatting of the two values we are comparing
        	switch (outcome) {
        			
        		/*Extract DateOfBirth format 1/01/1975, Database DateOfBirth Format 1/01/1975 12:00:00 AM
 				 *This will convert each of the dates to the same format and check if they are the same*/
        		case "DateOfBirth":
 					try
 					{
 						System.DateTime extractDate = System.DateTime.Parse(extractValue);
        				System.DateTime databaseDate = System.DateTime.Parse(databaseValue);
        			
        				//Report.Info("Info", "Formatted Extract Date: " + extractDate);
        				//Report.Info("Info", "Formatted Database Date: " + databaseDate);
        			
        				int result = System.DateTime.Compare(extractDate, databaseDate);
        				if (result == 0) 
        					match = true;
        				
 					}
 					catch (Exception e)
 					{
 						Report.Log(ReportLevel.Info, e.Message);
 					}
 					

        			break;
        		
				/*The following Outcomes may contain NULL vlaues, integers or 'Yes'/'No' values
				 *Check for NULL values first before comparing the database and extract values */
				case "SessionIntegrityPass":
 				case "TestCompletionPass":
 				case "TestPerformancePass":
				case "TestIntegrityPass":
				case "Round":
				case "TotalCorrect":
				case "TotalCorrectExclPant":
				case "TotalAnticipatory":
				case "TotalErrors":
				case "TotalPost":
			    case "TotalResponses":
				case "TotalTrials":
				case "TotalMaxOut":
				case "TotalCorrectFoils":
				case "LegalErrors":
				case "RuleBreakErrors":
				case "ReturnToHead":
				case "PerseverativeErrors":
				case "WithinSearchErrors":
				case "GMLTIndex":
				case "TestSubset":

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
 				*Check for NULL values before formatting the scores down to 6 decimal places and comparing*/
 			    case "PrimaryOutcome":
 				case "TestDuration":
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
 				case "SATScore":
 				
 					try
 					{
 						//Check if NULL and compare, otherwise format and then compare
        				if (extractValue == "NULL")
        				{
        					if (databaseValue == "")
        						match = true;
        				}
        				else if (Math.Round(double.Parse(extractValue),5) == Math.Round(double.Parse(databaseValue),5))
        					match = true;
 					} 
 					catch (Exception e)
 					{
 						Report.Log(ReportLevel.Info, e.Message);
 					}
        			
        			
        			break;

				/*The following outcomes will be randomly generated or depend on the date the test is run
 				 *we do not need to compare these values for now other wise we end up with false fails*/         			
 				case "IQNumber":
 			    case "Age":
 				case "SessionID":
 				case "SessionDate":
 				case "SessionTime":
 				case "TestIdentifier":
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
        /// Returns the current Round for the given row index from the database
        /// </summary>
        /// <param name="rowIndex">Row in the datatable where we are currently comparing</param>
        /// <returns>String containing the current round number, null if no round column was found</returns>
        private static string GetCurrentRound(int rowIndex)
        {
        	return engine.Helpers.SQLUtility.dt.Rows[rowIndex]["Round"].ToString();
        }
        
        
		/// <summary>
		/// This method will loop over each row in the Datatable retrieved from the Database, comparing each outcome
		/// to the corresponding outcome from the CSV datatable
		/// </summary>
        [UserCodeMethod]
        public static void Validate_Outcomes_Match()
        {
        	int rowIndex = 0;
        	string extractValue;
        	string databaseValue;
        	string currentOutcome = "";
        	string currentTestCode = "";
        	string currentRound = "";
        	
        	//Loop over each column from the processed data. When the 'Test' column containing the tests completed in the battery is found,
        	//loop over each column in that row, comparing the value from extract to value from database, then move on to the next row
        	foreach (DataRow row in engine.Helpers.SQLUtility.dt.Rows)
        	{
        		//For each row, we want to find the current round associated with the test code
        		currentRound = GetCurrentRound(rowIndex);
        		
        		for (int i = 0; i < engine.Helpers.SQLUtility.dt.Columns.Count; i++)
        		{
        			//Store current outcome and test code we are comparing. For SAT tests, look for the TestSubset column
        			//instead of the TestCode column to differentiate between each subset.
        			currentOutcome = engine.Helpers.SQLUtility.dt.Columns[i].ColumnName;
        			currentTestCode = row["TestCode"].ToString();
        			
        			if (currentTestCode == "SATReal") 
        			{
        				currentTestCode = row["TestSubset"].ToString();
        			}
        			
        			//Get the CSV and Database values using the current TestCode, Round and Outcome as reference
        			extractValue = GetExtractValue(currentTestCode, currentRound, currentOutcome);
        			databaseValue = engine.Helpers.SQLUtility.dt.Rows[rowIndex][currentOutcome].ToString();
        			
        			//Some outcomes may be formatted differently in the extract and database so we need to pass the two values to this method
        			//for some formatting before comparing the two outcomes. Some outcomes are expected not to match. In this case, we just
        			//want to log a message in the report without the Success/Failure log
        			if(CheckOutcomesMatch(currentOutcome, extractValue, databaseValue))
        				if (currentOutcome == "IQNumber" || currentOutcome == "SessionID" || currentOutcome == "SessionDate"
        				    || currentOutcome == "Age" || currentOutcome == "SessionTime" || currentOutcome == "TestIdentifier") {
        				Report.Info("Outcome difference expected, no comparison needed");
        			}
        			else {
        				Report.Success("Processed Score matches the score in the extract");
        			}

        			else
        				Report.Failure("Processed Score does not match the score in the extract");
        			
        			Report.Info("Extract Outcome: " + currentOutcome + " - Extract Value: " + extractValue);
        			Report.Info("Database Outcome: " + currentOutcome + " - Database Value: " + databaseValue);

        		}
        		
        		rowIndex++;
        	}

        	
        }
   
    }
}
