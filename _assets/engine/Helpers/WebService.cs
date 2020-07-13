/*
 * Created by Ranorex
 * User: DWood
 * Date: 28/03/2018
 * Time: 10:35 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
// imported .Net methods--------------------------------
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
	/// <summary>-------------------------------------------------------------
	/// Class definition for JSON object which is sent to retrive an AuthToken
	/// </summary>
	public class AuthJSONRequest
	{
		/// <summary>-------------------------------------------------------
		/// External users key for accessing the API
		/// </summary>
		public string key { get; set; }
		
		/// <summary>------------------------------------------------------
		/// External users secret for accessing the API
		/// </summary>
		public string secret { get; set; }
		
		/// <summary>-----------------------------------------------------
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
	
	/// <summary>-------------------------------------------------------------------
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
	
	/// <summary>---------------------------------------------------------------
	/// Class definition for JSON object sent in order to retrieve a testing URL
	/// </summary>
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
		
		/// <summary>----------------------------------------------------------------------------
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
	
	/// <summary>----------------------------------------------------------------------
	/// Class definition for JSON object which is received after requesting a testing URL
	/// </summary>
	public class AssessmentAttemptJSONResponse
	{
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
		
		public AssessmentAttemptJSONResponse()
		{
			
		}
	}
	
	/// <summary>------------------------------------------------------------------
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
	/// /Secret parsing--------------------------------------------------
	/// </summary>
	public class SaveNewSecretResponse
	{
		
		public string name { get; set; }
		
		
		public string value { get; set; }
		
		
		public SaveNewSecretResponse()
		{
			
		}
		
	}
	//Server version---------------
	public class DevopsRespose
	{
		public string assemblyVersion {get;set;}
		
		public  DevopsRespose()
		{
			
		}
	}
	
	// client version--------------
	public class ClientDevopsRespose
	{
		
		public string version{get;set;}
		
		public ClientDevopsRespose()
		{
			
			
		}
		
		
		
	}
	
	//oData:
	public class odataRespose
	{
		
		public string PersonID {get;set;}
		
		public string AssesseeID {get; set;}
		
		public odataRespose()
		{
			
			
		}
		
		
		
	}
	// InternalUserLogin:
	
	public class InternalLogin
	{
		
		public string username {get;set;}
		public string password {get;set;}
		public string portal {get;set;}
		
		
		public InternalLogin(string username, string password,string portal)
		{
			this.username = username;
			this.password = password;
			this.portal = portal;
		}
		
		
		
	}
	public class loginToken
	{
		public string authToken { get; set; }
		
		
		public loginToken()
		{
			
		}
	}
	
	
	
	
	
	
	/// <summary>--------------------------------------------------------------------------------------------------------------------------
	/// Ranorex user code collection. A collection is used to publish user code methods to the user code library.
	/// </summary>
	[UserCodeCollection]
	public class WebService
	{
		// You can use the "Insert New User Code Method" functionality from the context menu,
		// to add a new method with the attribute [UserCodeMethod].
		
		//*********Global variables list*************
		public static string InternalAuthToken;
		public static string AuthToken;
		public static string AssessmentURL;
		public static string TestIdentifier;
		public static string QualificationStatus;
		public static string Token;
		public static string Sversion;
		public static string ClientVersion;
		public static string oDatainfos;
		public static string InternalToken;
		
		
		
		/// <summary>-------------------------------------------------------------------------------------------------------------------------
		/// This method will retrieve an AuthToken based on the protocol, key and secret provided.
		/// </summary>
		[UserCodeMethod]
		public static void Authenticate(string DOM, string studyProtocolName, string key)
		{
			
			
			HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create("https://" + DOM + "/api/external/V2/" + studyProtocolName  + "/AuthenticationToken");
			httpRequest.ContentType = "application/json";
			httpRequest.Method = "POST";
			
			//Create JSON object containing key and secret which is sent in the body
			AuthJSONRequest jsonObject = new AuthJSONRequest(key, Token);
			
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
		
		
		/// <summary>-------------------------------------------------------------------------------------------------------------------
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
		
		
		
		/// <summary>----------------------------------------------------------------------------------------------------------
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
		
		
		/// <summary>-----------------------------------------------------------------------------------------------------------
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
		/// Launch Chrome using an Assessment Attempt URL-----------------------------------------------------------------
		/// </summary>
		[UserCodeMethod]
		public static void LaunchAssessment(string Browser)
		{
			//URL requires encoding as it may contain spaces when it is retrieved from the API
			//AssessmentURL = Uri.EscapeUriString(AssessmentURL);
			Report.Log(ReportLevel.Info, "Website", "Opening web site " + AssessmentURL + " with browser " + Browser + " in normal mode.");
			Host.Current.OpenBrowser(AssessmentURL, Browser, "", false, false, false, false, false, true);
		}
		
		
		/// <summary>-------------------------------------------------------------------------------------------------
		/// This method its about generating secret key and to use it to authenticate to the server
		/// </summary>
		[UserCodeMethod]
		public static void GenerateSecret(string DOM)
		{
			//creating the API Request
			string SecretAPI = "/api/externalusers/"+ SQLUtility.ResetToken + "/savenewsecret";
			HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create("https://"+DOM+ SecretAPI );
			httpRequest.ContentType = "application/json";
			httpRequest.ContentLength=0;
			httpRequest.Method = "PUT";
			
			
			//Sending the API call:
			
			HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();
			SaveNewSecretResponse responseObject = new SaveNewSecretResponse();
			using (StreamReader sr = new StreamReader(httpResponse.GetResponseStream()))
			{
				string secret = sr.ReadToEnd();
				responseObject = new JavaScriptSerializer().Deserialize<SaveNewSecretResponse>(secret);
				Token = responseObject.value;
				Report.Log(ReportLevel.Info, "Secret: " + Token);
				
			}
			
		}
		
		
		
		/// <summary>-------------------------------------------------------------------------------------------------
		/// This method is for validating the current server version
		/// </summary>
		[UserCodeMethod]
		public static void ServerVersion(string DOM)
		{
			string ServerVersion = "/api/devops";
			HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create("https://"+DOM+ ServerVersion  );
			httpRequest.ContentType = "application/json";
			httpRequest.ContentLength=0;
			httpRequest.Method = "GET";
			
			
			//Sending the API call:
			
			HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();
			DevopsRespose responseObject = new  DevopsRespose();
			using (StreamReader sr = new StreamReader(httpResponse.GetResponseStream()))
			{
				string versionServer = sr.ReadToEnd();
				responseObject = new JavaScriptSerializer().Deserialize<DevopsRespose>(versionServer);
				Sversion = responseObject.assemblyVersion;
				
			}
			// splinting version number
			string splitVersion = Sversion.Split('.')[0];
			//Sversion = splitVersion[0] + "." + splitVersion[1] + "." + splitVersion[2];
			Report.Log(ReportLevel.Info, "Server_Version"+ splitVersion );
			
			
			
		}
		
		
		/// <summary>
		/// This method is for logining in as InternalUser and the token will be used for generating Odata report
		/// </summary>
		[UserCodeMethod]///////---------------------------
		public static void InternalUserLogin(string DOM, string username, string password, string portal)
		{
			//Setup API call
			string LoginAPI = "/api/Account/Login";
			HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create("https://"+ DOM + LoginAPI);
			httpRequest.ContentType = "application/json";
			httpRequest.Method = "POST";
			
			//Create JSON ibject containing key and secret which is sent in the body
			InternalLogin jsonObject = new InternalLogin(username, password,portal);
			
			using (StreamWriter sw = new StreamWriter(httpRequest.GetRequestStream()))
			{
				string json = new JavaScriptSerializer().Serialize(jsonObject);
				
				sw.Write(json);
				sw.Flush();
				sw.Close();
			}
			
			//Get the response and read into a new object
			HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();
			
			loginToken responseObject = new loginToken();
			
			using (StreamReader sr = new StreamReader(httpResponse.GetResponseStream()))
			{
				string response = sr.ReadToEnd();
				//Deserialise the JSON in a new object to use later
				responseObject = new JavaScriptSerializer().Deserialize<loginToken>(response);
				
				InternalAuthToken = responseObject.authToken;
				
				Report.Log(ReportLevel.Info, "InternalUserToken: " + InternalAuthToken);
			}
			
			
			
			
			
		}
		/// <summary>-------------------------------------------------------------------------------------------
		/// This method is for validating the current client version
		/// </summary>
		[UserCodeMethod]
		public static void C_Version(string DOM)
		{
			
			string ClientVersionAPI = "/version.json";
			HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create("https://"+DOM+ ClientVersionAPI   );
			httpRequest.ContentType = "application/json";
			httpRequest.ContentLength=0;
			httpRequest.Method = "GET";
			
			
			//Sending the API call:
			
			HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();
			ClientDevopsRespose responseObject = new  ClientDevopsRespose();
			using (StreamReader sr = new StreamReader(httpResponse.GetResponseStream()))
			{
				string versionClient = sr.ReadToEnd();
				responseObject = new JavaScriptSerializer().Deserialize<ClientDevopsRespose>(versionClient);
				ClientVersion= responseObject.version;
				Report.Log(ReportLevel.Info,ClientVersion);
				
			}
			// splinting version number
			string splitClientVersion = ClientVersion.Split('.')[0];
			//ClientVersion = splitClientVersion[0] + "." + splitClientVersion[1] + "." + splitClientVersion[2];
			Report.Log(ReportLevel.Info, "Client_Version"+ splitClientVersion);
			
			
		}
		/// <summary>
		/// Generating OdataReport
		/// </summary>
		[UserCodeMethod]
		public static void oData(string DOM)
		{
			
			string oDataAPI = "/odata/vwExtractStandardAssessmentDetails?TOP =1";
			HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create("https://"+ DOM + oDataAPI  );
			httpRequest.ContentType = "application/json";
			httpRequest.ContentLength=0;
			httpRequest.Method = "GET";
			httpRequest.Headers.Add("Authorization", InternalAuthToken);
			
			
			//Sending the API call:
			
			HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();
			odataRespose responseObject = new  odataRespose();
			var responseStatus = httpResponse.StatusCode;
			using (StreamReader sr = new StreamReader(httpResponse.GetResponseStream()))
			Report.Log(ReportLevel.Info, "oData API Call is working as Expected" + " : " +   responseStatus.ToString());
			
			
			
			
			
			
			
			
		}
		
	}

}
