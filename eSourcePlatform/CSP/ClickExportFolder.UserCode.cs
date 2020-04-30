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
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Timers;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace CSP
{
    public partial class ClickExportFolder
    { 
      
       //varibles section
       string toDayDate;
       string reportDate;
        
        
             private void Init()
        {
           
        }

        public void Get_value_OpenExportFolder(RepoItemInfo atagInfo)
        { 
        	
        	Stopwatch timer = new Stopwatch();
			timer.Start();
        	
        	
            

        	do {
        		
        	Delay.Seconds(5);
        	          
        	         // Name sort-icon xpath
                     WebElement xpath = "/dom[@domain='s3.console.aws.amazon.com']//div[#'sidebarNavDiv']/div[2]/div[1]/tag[@tagname='awsui-tabs']/div/div//tag[@tagname='ng-include']/div[1]/div[2]/table/thead/tr/th[2]//tag[@tagname='table-sort-icon']/span";
                     xpath.Click();
        	
        	               // getting the current date
        	               Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'atagInfo' and assigning its value to variable 'date'.", atagInfo);
                            date = atagInfo.FindAdapter<ATag>().Element.GetAttributeValueText("InnerText");
            
             
                                   //generating today date 
                                      toDayDate = System.DateTime.Now.ToString("yyyyMMdd");
                                      
                                    //gettting th substring of the page date
                                    reportDate = date.Substring(8, 8);
                                     
                                    if ( timer.Elapsed > TimeSpan.FromMinutes(3)){
					
						                     Report.Failure("The Report is NOT appearing as expetec " );
						                     break;
					                }
				                    	
             
         }                               while (toDayDate != reportDate);
                                                 // validate if today date is = the the report date 
        	                                     Validate.AreEqual(toDayDate, reportDate);
        
        }

        public void DoDelay()
        {
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2m In order the Data to get to the report .");
            Delay.Duration(120000, false);
        }
        
        /*
        public void Mouse_Click_ClickLastModifier(RepoItemInfo spantagInfo)
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'spantagInfo' at Center.", spantagInfo);
            spantagInfo.FindAdapter<SpanTag>().Click();
        }
        
       */
    
}
}

