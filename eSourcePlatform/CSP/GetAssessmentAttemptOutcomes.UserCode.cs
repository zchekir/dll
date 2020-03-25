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

namespace CSP
{
	
	public class AssessmentAttemptOutcomes
	{
		/// <summary>
		/// Returned qualificaiton status
		/// </summary>
		public string compositeOutcomes { get; set; }
		public string tests { get; set; }
		
		public AssessmentAttemptOutcomes()
		{
			
		}
	}
    public partial class GetAssessmentAttemptOutcomes
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void AssessmentAttemptOutcomes(string DOM, string TestIdentifier, string AutoToken, string StudyProtocolName)
        {
           //Setup API call
			HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create("https://" + DOM + "/api/external/V2/" + StudyProtocolName  + "/assessmentattempt/" + TestIdentifier + "/outcomes");
			httpRequest.ContentType = "application/json";
			httpRequest.Method = "GET";
			httpRequest.ContentLength= 0; 
			
			httpRequest.Headers.Add("Authorization", AutoToken);
			
			HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();
			AssessmentAttemptOutcomes responseObject = new AssessmentAttemptOutcomes();
			
			using (StreamReader sr = new StreamReader(httpResponse.GetResponseStream()))
			{
				string response = sr.ReadToEnd();
				responseObject = new JavaScriptSerializer().Deserialize<AssessmentAttemptOutcomes>(response);
				
				string  Outcomes = responseObject.compositeOutcomes;
				string  Test = responseObject.compositeOutcomes;
				
				Report.Log(ReportLevel.Info, "Test Outcomes:" + response );
				
				
			}
        }

    }
}
