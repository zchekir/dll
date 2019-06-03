﻿/*
 * Created by Ranorex
 * User: DWood
 * Date: 28/03/2018
 * Time: 10:35 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.IO;
using System.Net;
using System.Web.Script.Serialization;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace engine.Helpers
{
	/// <summary>
	/// Class definition for JSON object which is sent to retrive an AuthToken
	/// </summary>
	public class AuthJSONRequest
	{
		/// <summary>
		/// External users key for accessing the API
		/// </summary>
		public string key { get; set; }
		
		/// <summary>
		/// External users secret for accessing the API
		/// </summary>
		public string secret { get; set; }
		
		/// <summary>
		/// Creates a new autentication request object
		/// </summary>
		/// <param name="key"></param>
		/// <param name="secret"></param>
		public AuthJSONRequest(string key, string secret)
		{
			this.key = key;
			this.secret = secret;
		}
			
	}
	
	/// <summary>
	/// Class definition for JSON object which is received after an AuthToken request
	/// </summary>
	public class AuthJSONResponse
	{
		public string authorizationValue { get; set; }
		public string authorizationScheme { get; set; }
		
		public AuthJSONResponse()
		{
			
		}
	}
	
	/// <summary>
	/// Class definition for JSON object sent in order to retrieve a testing URL
	/// </summary>
	public class AssessmentAttemptJSONRequest
	{
		/// <summary>
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
		public string postError { get; set; }
		
		/// <summary>
		/// Code for the visit we want to run
		/// </summary>
		public string visitSessionCode { get; set; }
		
		/// <summary>
		/// Message to post upon completion
		/// </summary>
		public string post { get; set; }
		
		/// <summary>
		/// The id of the supervisor condicting the test
		/// </summary>
		public string supervisorId { get; set; }
		
		/// <summary>
		/// Object for creating a new workflow request
		/// </summary>
		/// <param name="externalId"></param>
		/// <param name="dob"></param>
		/// <param name="genderCode"></param>
		/// <param name="localityCode"></param>
		/// <param name="postError"></param>
		/// <param name="post"></param>
		/// <param name="visitSessionCode"></param>
		/// <param name="supervisorId"></param>
		public AssessmentAttemptJSONRequest(string externalId, string dob, string genderCode, string localityCode,
		                                    string postError, string post, string visitSessionCode, string supervisorId)
		{
			this.externalId = externalId;
			this.dob = dob;
			this.genderCode = genderCode;
			this.localityCode = localityCode;
			this.postError = postError;
			this.post = post;
			this.visitSessionCode = visitSessionCode;
			this.supervisorId = supervisorId;
		}
	}
	
	/// <summary>
	/// Class definition for JSON object which is received after requesting a testing URL
	/// </summary>
	public class AssessmentAttemptJSONResponse
	{
		/// <summary>
		/// Returned authtoken from API following a workflow instance request
		/// </summary>
		public string workflowAuthToken { get; set; }
		
		/// <summary>
		/// The returend locality code
		/// </summary>
		public string localityCode { get; set; }
		
		/// <summary>
		/// Returned URL for running the battery
		/// </summary>
		public string url { get; set; }
		
		/// <summary>
		/// Unique ideitifer to the test
		/// </summary>
		public string testIdentifier { get; set; }
		
		public AssessmentAttemptJSONResponse()
		{
			
		}
	}
	
	/// <summary>
	/// Response object for the test qualification status
	/// </summary>
	public class QualificationStatusJSONResponse
	{
		/// <summary>
		/// Returned qualificaiton status
		/// </summary>
		public string assessmentAttemptQualificationStatus { get; set; }
		
		public QualificationStatusJSONResponse()
		{
			
		}
	}
	
	
    /// <summary>
    /// Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class WebService
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        public static string AuthToken;
        public static string AssessmentURL;
        public static string TestIdentifier;
        public static string QualificationStatus;
        
        
        /// <summary>
        /// This method will retrieve an AuthToken based on the protocl, key and secret provided
        /// </summary>
        [UserCodeMethod]
        public static void Authenticate(string randNum, string DOM, string studyProtocolName, string key, string secret)
        {
        	//Setup API call
        	HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create("https://" + DOM + "/api/external/V2/" + studyProtocolName + randNum + "/AuthenticationToken");
        	httpRequest.ContentType = "application/json";
        	httpRequest.Method = "POST";
        	
        	//Create JSON ibject containing key and secret which is sent in the body
        	AuthJSONRequest jsonObject = new AuthJSONRequest(key, secret);
        	
        	using (StreamWriter sw = new StreamWriter(httpRequest.GetRequestStream()))
        	{
        		string json = new JavaScriptSerializer().Serialize(jsonObject);
        		
        		sw.Write(json);
        		sw.Flush();
        		sw.Close();
        	}
        	
        	//Get the response and read into a new object
        	HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();
        	
        	AuthJSONResponse responseObject = new AuthJSONResponse();
        	
        	using (StreamReader sr = new StreamReader(httpResponse.GetResponseStream()))
        	{
        		string response = sr.ReadToEnd();
        		//Deserialise the JSON in a new object to use later
        		responseObject = new JavaScriptSerializer().Deserialize<AuthJSONResponse>(response);
        		
        		AuthToken = responseObject.authorizationValue;
        		
        		Report.Log(ReportLevel.Info, "Authentication Successfull, AuthToken is: " + AuthToken);
        	}
        	
        }
        
        
        /// <summary>
        /// This method will retrieve an assessment URL using the provided demographic information, study details
		/// and AuthToken
        /// </summary>
        [UserCodeMethod]
        public static void CreateAssessmentAttempt(string randNum, string DOM, string externalId, string dob, string genderCode, string localityCode,
                                                  string postError, string post, string visitSessionCode, string studyProtocolName, string supervisorId)
        {
        	//Setup API call
        	HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create("https://" + DOM + "/api/external/V2/" + studyProtocolName + randNum + "/AssessmentAttempt");
        	httpRequest.ContentType = "application/json";
        	httpRequest.Method = "POST";
        	httpRequest.Headers.Add("Authorization", AuthToken);
        	
        	//Check if external id is empty and generate a random number if true
        	if (externalId == "")
        	{
        		Report.Info("No External id passed through, generating external id...");
        		Random r = new Random();
        	
        		int number = r.Next(1,999999);
        		externalId = number.ToString();
        	}
        	
        	//Create JSON object containing demographics and study details
        	AssessmentAttemptJSONRequest assessmentObject = new AssessmentAttemptJSONRequest(externalId, dob, genderCode, localityCode, postError, post, visitSessionCode + randNum, supervisorId);
        	
        	
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
        		
        		Report.Log(ReportLevel.Info, "Assessment Attempt Created, URL is: " + AssessmentURL);
        		Report.Log(ReportLevel.Info, "Assessment Attempt Created, TestIdentifier is: " + TestIdentifier);
        	}
        }
        
        
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void GetQualificationStatus(string randNum, string DOM, string studyProtocolName)
        {
        	//Setup API call
        	HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create("https://" + DOM + "/api/external/V2/" + studyProtocolName + randNum + "/assessmentattempt/" + TestIdentifier + "/qualificationstatus");
        	httpRequest.ContentType = "application/json";
        	httpRequest.Method = "GET";
        	httpRequest.Headers.Add("Authorization", AuthToken);
        	
        	HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();
        	
        	QualificationStatusJSONResponse responseObject = new QualificationStatusJSONResponse();
        	
        	using (StreamReader sr = new StreamReader(httpResponse.GetResponseStream()))
        	{
        		string response = sr.ReadToEnd();
        		responseObject = new JavaScriptSerializer().Deserialize<QualificationStatusJSONResponse>(response);
        		
        		QualificationStatus = responseObject.assessmentAttemptQualificationStatus;
        		
        		Report.Log(ReportLevel.Info, "Status", "Qualification Status: " + QualificationStatus);
        	}
        	
        }
        
        
        /// <summary>
        /// This method will use the AssessmentAttempt API call to update the date of birth of a particular participant
		/// and AuthToken
        /// </summary>
        [UserCodeMethod]
        public static void UpdateDOBDemographic(string randNum, string DOM, string externalId, string dob, string genderCode, string localityCode,
                                                  string postError, string post, string visitSessionCode, string studyProtocolName, string supervisorId)
        {
        	//Exit with fail if external id is empty as we don't know which subject to update
        	if (externalId == "")
        	{
        		Report.Failure("No External id passed through, exiting...");
				return;
        	}
        	
        	//Using the participants original DOB, extract the Year, subtract a random number of years from the DOB and recreate the DOB string
        	int yearIndex = 2;
        	int newYear;

        	string[] oldYear = dob.Split('/');
        	
        	Random r = new Random();
        	newYear = r.Next(1900, int.Parse(oldYear[yearIndex]));
        	
        	Report.Info("Old Date of Birth: " + dob);
        	dob = dob.Replace(oldYear[yearIndex], newYear.ToString());
        	Report.Info("New Date of Birth: " + dob);
        	
        	//Setup API call
        	HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create("https://" + DOM + "/api/external/V2/" + studyProtocolName + randNum + "/AssessmentAttempt");
        	httpRequest.ContentType = "application/json";
        	httpRequest.Method = "POST";
        	httpRequest.Headers.Add("Authorization", AuthToken);
        	
        	//Create JSON object containing demographics and study details
        	AssessmentAttemptJSONRequest assessmentObject = new AssessmentAttemptJSONRequest(externalId, dob, genderCode, localityCode, postError, post, visitSessionCode + randNum, supervisorId);
        	
        	
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
        		
        		Report.Log(ReportLevel.Info, "Assessment Attempt Created, URL is: " + AssessmentURL);
        		Report.Log(ReportLevel.Info, "Assessment Attempt Created, TestIdentifier is: " + TestIdentifier);
        	}
        }
        
        
        /// <summary>
        /// Launch Chrome using an Assessment Attempt URL
        /// </summary>
        [UserCodeMethod]
        public static void LaunchAssessment()
        {
        	//URL requires encoding as it may contain spaces when it is retrieved from the API
        	AssessmentURL = Uri.EscapeUriString(AssessmentURL);
        	Report.Log(ReportLevel.Info, "Website", "Opening web site " + AssessmentURL + " with browser 'Chrome' in normal mode.");
        	Host.Current.OpenBrowser(AssessmentURL, "Chrome", "", false, false, false, false, false);
        }
        
    }
}
