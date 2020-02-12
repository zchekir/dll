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
    public partial class ReportingDBVersion
    {
    	//variables:
    	public static DataTable dt = new DataTable();
        
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void ReportingDB_Version()
        {
            //Validating the Reporting DB Version :
			
			dt.Reset();
			
			
			// QueryDB
			         string query = @"SELECT top 1
                                    MigrationId
                                    FROM  [dbo].[__MigrationHistory]
                                    order by 1 desc";
			
	
		
				
				Report.Info( " Validating  Reporting DB version....  ");
				
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
				 string[] dbvID = DBVersion.Split();
			     //Pringting the resutls:
			     Report.Log(ReportLevel.Info,  "Reporting DB version: " + "  " + dbvID[0]  );
			     
			     // validating the DB version
			     Validate.AreEqual(dbvID[0]  ,migrationid);
			       
				}catch (Exception e){
					
				  Report.Log(ReportLevel.Info,  "Error: " + e.Message );	
				}
        }

    }
}
