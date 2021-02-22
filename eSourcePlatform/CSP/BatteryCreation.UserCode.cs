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
	public class BaterytJSONRequest
	{
		public string JsonData { get; set; }
		public string id { get; set; }
		
	
	/// Object for creating a new workflow request
		public BaterytJSONRequest()
		{
			
		
		}
		
	}
    public partial class BatteryCreation
    {
        
        private void Init()
        {
           
        }

        public void battery_Creation(string Token, string Studyid, string JsonData, string CSPDOM, string Batteryversion)
        {
        	
        
        	
			//variable
		    string url = "https://" + CSPDOM + "/api/studies/" + Studyid + "/batteries";
			//Setup API call
			HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(url);
			httpRequest.ContentType = "application/json";
			httpRequest.Method = "POST";
			httpRequest.Headers.Add("Authorization", Token);
			
			
			
			// sending the data in the body and replacing the studyid, studyname and version
			using (StreamWriter sw = new StreamWriter(httpRequest.GetRequestStream()))
			{
		 	
		    
               var testData = JsonData.Replace(@"<id>", Studyid).Replace(@"<name>",Studname).Replace(@"<ver>",Batteryversion); 
				Report.Info("Data to send: " + testData);
				
				sw.Write(testData);
				sw.Flush();
				sw.Close();
			}
			
			
			//Get response and store in new object
			HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();
			
			BaterytJSONRequest responseObject = new BaterytJSONRequest();
			
			using (StreamReader sr = new StreamReader(httpResponse.GetResponseStream()))
			{
				string response = sr.ReadToEnd();
				responseObject = new JavaScriptSerializer().Deserialize<BaterytJSONRequest>(response);
				batteryID =responseObject.id;
				Report.Log(ReportLevel.Info, "The Battery is created as expected- BatteryID is  " + batteryID );
				
			}
            
        }

    }
}
