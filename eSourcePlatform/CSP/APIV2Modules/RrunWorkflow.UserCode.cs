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

namespace CSP.APIV2Modules
{
    public partial class RrunWorkflow
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
       
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void R_runworkflow(string AuthToken, string studyProtocolName, string DOM, string genderCode, string localityCode, string redirectError, string redirect, string visitSessionCode, string supervisorid, string TestIdentifier, string externalid, string mode)
        {
            //variable
    	string url = "https://"+ DOM +"/api/external/V2/AutomationStudy/AssessmentAttempt";
        //Setup API call
        	HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(url);
        	httpRequest.ContentType = "application/json";
        	httpRequest.Method = "POST";
        	httpRequest.Headers.Add("Authorization", AuthToken);
        	
        	 // Varibles section:
             string InvalidDOB ="1978-01-01";   
        		
        	//Create JSON object containing demographics and study details
        	AssessmentAttemptJSONRequest assessmentObject = new AssessmentAttemptJSONRequest(externalid, InvalidDOB, genderCode, localityCode, redirectError, redirect, visitSessionCode, supervisorid,mode);
        
        	
        	using (StreamWriter sw = new StreamWriter(httpRequest.GetRequestStream()))
        	{
        		string json = new JavaScriptSerializer().Serialize(assessmentObject);
        		
        		//Debugging Request
        		Report.Info("Data to send: " + json);
        		
        		sw.Write(json);
        		sw.Flush();
        		sw.Close();
        	}
        	
        	//Get response and store in new object
        	HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();
        	
        	AssessmentAttemptJSONResponse responseObject = new AssessmentAttemptJSONResponse();
        	
        	using (StreamReader sr = new StreamReader(httpResponse.GetResponseStream()))
        	{
        		string response = sr.ReadToEnd();
        		responseObject = new JavaScriptSerializer().Deserialize<AssessmentAttemptJSONResponse>(response);
        		
        		var AssessmentURL = responseObject.url;
        		TestIdentifier = responseObject.testIdentifier;
        		
        		Report.Log(ReportLevel.Info, "Assessment Attempt Created, URL is: " + AssessmentURL);
        		Report.Log(ReportLevel.Info, "Assessment Attempt Created, TestIdentifier is: " + TestIdentifier);
        	}
        }

    }
}
