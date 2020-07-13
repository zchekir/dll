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
	
	
	
	
	public class dataJSONResponse
	{
		
		
		public string workflowAuthToken { get; set; }
		
		
		
		public dataJSONResponse()
		{
			
		}
	
	
	
	
	
    
	}

    public partial class UB01
    {
       public string row;
        
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void UpdateBatteryFirstCall(string workflowID, string DOM, string workflowToken, string Batteryid, string rawdata)
        {
            
	      //Setup API call
            string url = "https://" + DOM +  "/api/prsworkflow/" + workflowID + "/UpdateBatteryAssessee";
		    HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(url);
			httpRequest.ContentType = "application/json";
			httpRequest.Method = "POST";
			httpRequest.Headers.Add("Authorization", workflowToken);
			
		 using (StreamWriter sw = new StreamWriter(httpRequest.GetRequestStream()))
			{
				
				
				//Debugging Request
				Report.Info("Data to send: " + rawdata);
				
				sw.Write(rawdata);
				sw.Flush();
				sw.Close();
			}
			
			//Get response and store in new object
			HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();
			
			dataJSONResponse responseObject = new dataJSONResponse();
			
			using (StreamReader sr = new StreamReader(httpResponse.GetResponseStream()))
			{
				string response = sr.ReadToEnd();
				responseObject = new JavaScriptSerializer().Deserialize<dataJSONResponse>(response);
				Report.Log(ReportLevel.Info, "TEST PASSED  " + response );
				
			}
        }

    }

}
