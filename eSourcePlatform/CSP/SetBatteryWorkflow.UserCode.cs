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
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web.Script.Serialization;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;
using Newtonsoft.Json.Linq;

namespace CSP
{
 
public class BatteryWorkflowJSONRequest
	{
		public string JsonData { get; set; }
	
		public string workflowid { get; set; }
		
		public string id { get; set; }
		
	/// Object for creating a new workflow request
		public BatteryWorkflowJSONRequest()
		{
			
		
		}
		
	}


	public partial class SetBatteryWorkflow
    {
        
        private void Init()
        {
            
        }

        public void SetBatteryWorkf(string StudyID, string Token, string WorkflowID, string BatteryID, string CSPDOM, string battryworkflowData, string WorkflowBlockID)
        {
            
        	//variable
		    string url = "https://" + CSPDOM + "/api/workflows/" + WorkflowID + "/workflowBlocks/"+ WorkflowBlockID;
			//Setup API call
			HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(url);
			httpRequest.ContentType = "application/json";
			httpRequest.Method = "PUT";
			httpRequest.Headers.Add("Authorization", Token);
			
			
			// sending the data in the body and replacing the studyid, studyname and version
			using (StreamWriter sw = new StreamWriter(httpRequest.GetRequestStream()))
			{
		 	
		    
               var testData = battryworkflowData.Replace(@"<wkid>", WorkflowID).Replace(@"<studid>", StudyID).Replace(@"<batteryID>", BatteryID).Replace(@"<WorkflowBlockID>", WorkflowBlockID).Replace(@"<desktopConfigurationid>", desktopConfigurationid).Replace(@"<tabletConfigurationid>", tabletConfigurationid);
				Report.Info("Data to send: " + testData);
				
				sw.Write(testData);
				sw.Flush();
				sw.Close();
			}
			
			
			
			//Get response and store in new object
			HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();
			
			BatteryWorkflowJSONRequest responseObject = new BatteryWorkflowJSONRequest();
			
			using (StreamReader sr = new StreamReader(httpResponse.GetResponseStream()))
			{
				string response = sr.ReadToEnd();
				responseObject = new JavaScriptSerializer().Deserialize<BatteryWorkflowJSONRequest>(response);
				
				Report.Log(ReportLevel.Info, "The battery of the workflow  is created as expected " + response );
				
			 }
        	
        	
        	
        	
        }

    }
}
