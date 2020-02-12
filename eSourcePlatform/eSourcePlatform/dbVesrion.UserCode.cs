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
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace eSourcePlatform
{
    public partial class dbVesrion
    {
    	//variables:
    	public static DataTable dt = new DataTable();
       
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void CSPDBVersion()
        {
        	
        		
        	
        }

        public void CSPDB_Version(string dbserver, string database, string username, string password, string authentication, string migrationid)
        {
            
			//Validating the CSP DB Version :
			
			dt.Reset();
			
			
			// QueryDB
			         string query = @"SELECT top 1 
                                    [MigrationId]
                                   ,[TemporalValidFrom]
                                    FROM [dbo].[__MigrationHistory]
                                    order by 1 desc";
			         
			     Report.Info( " Validating  DB version..........  ");
				
				//Connecting to SQL DB:
				string sqlConnString = string.Format("Server={0};Database={1};User Id={2};Password={3};Authentication={4};Connection Timeout={5};", dbserver, database, username, password, authentication, "30");
				//CreateObject:
				SqlDataAdapter da = new SqlDataAdapter(query, sqlConnString);
				da.SelectCommand.Parameters.AddWithValue("@migrationid", migrationid);
				
				// Get the data from DB
				
				try{
					
				  using (da)
				  da.Fill(dt);
				  
				 string DBVersion = dt.Rows[0][0].ToString();
				 string[] dbvID= DBVersion.Split();
				 
			     //Pringting the Current CSP DB version:
			     Report.Log(ReportLevel.Info,  "CSP DB version: " + "  " + dbvID[0]  );
			     
			     //Validating the current with the expected results
			     Validate.AreEqual(dbvID[0] ,migrationid);
				
				}catch (Exception e){
					
				    Report.Log(ReportLevel.Info,  "Error: " + e.Message );	
				}
			
        }

        

    }
}

