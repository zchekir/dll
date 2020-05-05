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
	public class AssessmentAttemptJSONRequest
	{
		/// <summary>---------------------------------------------------------
		/// External ID for the participant we want to send through the API
		/// </summary>
		public string externalId { get; set; }
		
		/// <summary>
		/// Date of Birth for the participant we want to send through the API
		/// </summary>
		public string dob { get; set; }
		
		/// <summary>
		/// Gender code for the participant we want to send through the API
		/// </summary>
		public string genderCode { get; set; }
		
		/// <summary>
		/// Language which should be displayed
		/// </summary>
		public string localityCode { get; set; }
		
		/// <summary>
		/// Message to post if an error occurs
		/// </summary>
		public string redirectError { get; set; }
		
		/// <summary>
		/// Code for the visit we want to run
		/// </summary>
		public string visitSessionCode { get; set; }
		
		/// <summary>
		/// Message to post upon completion
		/// </summary>
		public string redirect { get; set; }
		
		/// <summary>
		/// The id of the supervisor condicting the test
		/// </summary>
		public string supervisorId { get; set; }
		
		/// <summary>----------------------------------------------------------------------------
		/// Object for creating a new workflow request
		public AssessmentAttemptJSONRequest(string externalId, string dob, string genderCode, string localityCode,
		                                    string redirectError, string redirect, string visitSessionCode, string supervisorId, string mode)
		{
			this.externalId = externalId;
			this.dob = dob;
			this.genderCode = genderCode;
			this.localityCode = localityCode;
			this.redirectError = redirectError;
			this.redirect = redirect;
			this.visitSessionCode = visitSessionCode;
			this.supervisorId = supervisorId;
		}
	}
	
	/// <summary>----------------------------------------------------------------------
	/// Class definition for JSON object which is received after requesting a testing URL
	/// </summary>
	public class AssessmentAttemptJSONResponse
	{
		
		//string AssessmentURL;
		/// <summary>
		/// Returned authtoken from API following a workflow instance request
		/// </summary>
		public string workflowAuthToken { get; set; }
		
		/// <summary>----------------------------------------------------------------
		/// The returend locality code
		/// </summary>
		public string localityCode { get; set; }
		
		/// <summary>---------------------------------------------------------------
		/// Returned URL for running the battery
		/// </summary>
		public string url { get; set; }
		
		/// <summary>---------------------------------------------------------------
		/// Unique ideitifer to the test
		/// </summary>
		public string testIdentifier { get; set; }
		
		public string externalId { get; set; }
		
		public AssessmentAttemptJSONResponse()
		{
			
		}
	}
	public partial class WorkFlowInstance
	{
		
		
		private void Init()
		{
			// Your recording specific initialization code goes here.
		}
		
		//Generating workflowinstance ULR with using an existing study
		public void Workflow(string AuthToken, string studyProtocolName, string DOM, string dob, string genderCode, string localityCode, string redirectError, string redirect, string mode)
		{
			Report.Log(ReportLevel.Info, studyProtocolName);
			//variable
			string url = "https://"+ DOM +"/api/external/V2/"+studyProtocolName+"/AssessmentAttempt";
			//Setup API call
			HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(url);
			httpRequest.ContentType = "application/json";
			httpRequest.Method = "POST";
			httpRequest.Headers.Add("Authorization", AuthToken);
			
			// generating an rundom number to be used as externalid
			Random r = new Random();
			int number = r.Next(1,999999);
			externalId = number.ToString();
			
			
			//Create JSON object containing demographics and study details
			AssessmentAttemptJSONRequest assessmentObject = new AssessmentAttemptJSONRequest(externalId, dob, genderCode, localityCode, redirectError, redirect, visitSessionCode, supervisorId,mode);
			
			
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
				
				AssessmentURL = responseObject.url;
				TestIdentifier = responseObject.testIdentifier;
				
				
				
				
				Report.Log(ReportLevel.Info, "zAK Assessment Attempt Created, URL is: " + AssessmentURL);
				Report.Log(ReportLevel.Info, "Assessment Attempt Created, TestIdentifier is: " + TestIdentifier);
				
			}
		}

	}
}
