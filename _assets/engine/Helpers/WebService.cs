/*
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
		public string key { get; set; }
		public string secret { get; set; }
		
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
		public string externalId { get; set; }
		public string dob { get; set; }
		public string genderCode { get; set; }
		public string localityCode { get; set; }
		public string postError { get; set; }
		public string visitSessionCode { get; set; }
		public string post { get; set; }
		
		public AssessmentAttemptJSONRequest(string externalId, string dob, string genderCode, string localityCode,
		                                    string postError, string post, string visitSessionCode)
		{
			this.externalId = externalId;
			this.dob = dob;
			this.genderCode = genderCode;
			this.localityCode = localityCode;
			this.postError = postError;
			this.post = post;
			this.visitSessionCode = visitSessionCode;
		}
	}
	
	/// <summary>
	/// CLass definition for JSON object which is received after requesting a testing URL
	/// </summary>
	public class AssessmentAttemptJSONResponse
	{
		public string workflowAuthToken { get; set; }
		public string localityCode { get; set; }
		public string url { get; set; }
		public string testIdentifier { get; set; }
		
		public AssessmentAttemptJSONResponse()
		{
			
		}
	}
	
	public class QualificationStatusJSONResponse
	{
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
                                                  string postError, string post, string visitSessionCode, string studyProtocolName)
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
        	AssessmentAttemptJSONRequest assessmentObject = new AssessmentAttemptJSONRequest(externalId, dob, genderCode, localityCode, postError, post, visitSessionCode + randNum);
        	
        	
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
