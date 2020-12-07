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
	
	public class WorkflowJSONRequest
	{
		public string JsonData { get; set; }
	
		public string workflowid { get; set; }
		
		public string id { get; set; }
		
	/// Object for creating a new workflow request
		public WorkflowJSONRequest()
		{
			
		
		}
		
	}

    public partial class WorkflowCreation
    {
        
        private void Init()
        {
           
        }

        public void createWorkflow(string Token, string Studyid, string workflowData, string Studname, string CSPDOM)
        {
        	
        //variable
		    string url = "https://" + CSPDOM + "/api/studies/" + Studyid + "/workflows";
			//Setup API call
			HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(url);
			httpRequest.ContentType = "application/json";
			httpRequest.Method = "POST";
			httpRequest.Headers.Add("Authorization", Token);
			
			
			// sending the data in the body and replacing the studyid, studyname and version
			using (StreamWriter sw = new StreamWriter(httpRequest.GetRequestStream()))
			{
		 	
		    
               var testData = workflowData.Replace(@"<id>", Studyid);
				Report.Info("Data to send: " + testData);
				
				sw.Write(testData);
				sw.Flush();
				sw.Close();
			}
           
			
			
			//Get response and store in new object
			HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();
			
			WorkflowJSONRequest responseObject = new WorkflowJSONRequest();
			
			using (StreamReader sr = new StreamReader(httpResponse.GetResponseStream()))
			{
				string response = sr.ReadToEnd();
				responseObject = new JavaScriptSerializer().Deserialize<WorkflowJSONRequest>(response);
				
				
				
					// slpit
			char[] mych = { '&', ',','?','=' };
            string blockid = response;
            string[] block_id = blockid.Split(mych);
             workflowbatteryBlockID  = block_id[7];
            
				
				
				
				
				
				
				
				workflow_id =responseObject.id; 
				Report.Log(ReportLevel.Info, "The work is created as expected " + response );
				Report.Log(ReportLevel.Info, "workflowID " + workflow_id);
				
				Report.Log(ReportLevel.Info, "workflowbatteryBlockID" + workflowbatteryBlockID);
			 }
   }
    
  }
}
