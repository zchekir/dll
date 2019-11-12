/*
 * Created by Ranorex
 * User: DWood
 * Date: 9/07/2018
 * Time: 3:50 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using System.IO;
using System.Data;
using CsvHelper;
using Microsoft.VisualBasic.FileIO;
using WinForms = System.Windows.Forms;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace engine.Helpers
{
    /// <summary>
    /// Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class CSVUtility
    {     
		/// <summary>
		/// DataTable used to store contents of CSV file after being read
		/// </summary>
    	public static DataTable dt = new DataTable();
    	

        /// <summary>
        /// Reads the CSV file passed in and stores it into a new DataTable
        /// </summary>
        [UserCodeMethod]
        public static void ReadCSVIntoDataTable(string fileName)
        {
        	//Clear datatable to make sure we are starting fresh
        	dt.Reset();
        	
        	var dIndex = new Dictionary<string, int>();
        	using (TextFieldParser csvReader = new TextFieldParser(@".\csv\" + fileName + ".csv"))
        	{
        		csvReader.Delimiters = new string[] { "," };
        		var cols = csvReader.ReadFields();
        		
        		//Loop over each column which was read in from the CSV file
        		for (int i = 0; i < cols.Length; i++)
        		{
        			//Store the current column name
        			string colHeading = cols[i];
        			
        			//Add the column heading ot dictionary if it contains text
        			if (colHeading != string.Empty)
        			{
        				dIndex.Add(colHeading, i);
        				
        				//Only add the column to the data table if it does not already exist
        				if (!dt.Columns.Contains(colHeading))
        					dt.Columns.Add(colHeading);
        			}
        		}
        		
        		//Read the rest of the CSV file
        		while (!csvReader.EndOfData)
        		{
        			//Reads each field on the current line and stores in the data table
        			string[] field = csvReader.ReadFields();
        			
        			if (field.Length > 0)
        			{
        				//Creates a new row and adds it to the data table
        				DataRow dr = dt.NewRow();
        				
        				//Adds each field to a row
        				foreach (var keyValue in dIndex)
        				{
        					int iVal = keyValue.Value;
        					
        					if (iVal < field.Length)
        						dr[keyValue.Key] = field[iVal];
        				}
        			
        				//Adds the data row to the data table
        				dt.Rows.Add(dr);
        			}
        		}
        	}
        }    	
    	
    	/// <summary>
    	/// Reads a DataTable and writes the contents to a CSV file
    	/// </summary>
    	[UserCodeMethod]
    	public static void WriteToCSV(string fileName)
    	{
    		using (StreamWriter sw = new StreamWriter(@".\csv\" + fileName + ".csv"))
    		{
    			var csv = new CsvWriter(sw);
    			foreach (DataColumn column in dt.Columns)
    			{
    				csv.WriteField(column.ColumnName);
    			}
    			csv.NextRecord();
    			
    			foreach (DataRow row in dt.Rows)
    			{
    				for(int i = 0; i < dt.Columns.Count; i++)
    				{
    					csv.WriteField(row[i]);
    				}
    				csv.NextRecord();
    			}
    		}
    		
    	}
    	
        
        /// <summary>
        /// Adds study visit specific settings into a DataTable
        /// </summary>
        [UserCodeMethod]
        public static void AddVisitSettings(string URL, string key)
        {
        	bool found = false;
        	int colIndex = 0;
        	
        	//Loop over each Column in the DataTable
        	foreach (DataColumn column in dt.Columns)
        	{
        		//Find the column which contains the Visit Settings
        		if (column.ColumnName == "\"Custom Info\"")
        		{
        			found = true;
        			
       				int rowIndex = 0;
        			//Loop over each row in the current column and modify the cell contents using the settings required
        			foreach (DataRow row in dt.Rows)
        			{
        				
        				//First we need to find the row which contains the visit settings
        				if (row[colIndex].ToString().Contains("Begin Assessment"))
        				{
        					Report.Log(ReportLevel.Info, "Cell Found! Current settings are: " + row[column].ToString());
        					
        					dt.Rows[rowIndex][colIndex] = "{\"label\":\"Begin Assessment\", \"url\":\"" + URL + "api/external/v2" + "\", \"key\":\"" + key + "\", \"secret\":\"" + WebService.Token + "\",\"execStatusVariable\":\"ExecutionStatus\", \"dob_variable\":\"dob\", \"sex_variable\":\"gender\", \"lang_variable\":\"language\", \"fieldHide\":\"N\"}";
        				
        					Report.Log(ReportLevel.Info, "Cell Updated! New settings are: " + row[column].ToString());
        				}
        				rowIndex++; 
        			}
       				
        		}
        		colIndex++;
        	}
        	
        	if (!found)
        		Report.Log(ReportLevel.Info, "Could not find required column");
        	
        }
        
    }
}
