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
//using System.Web.Script.Serialization;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;


public class AuthJSONRequest1
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
		public AuthJSONRequest1(string key, string secret)
		{
			this.key = key;
			this.secret = secret;
		}
			
	}
	
		public class AuthJSONResponse1
		
	{
		
		
		public string message { get; set; }
		public string authorizationScheme { get; set; }
		
		public AuthJSONResponse1()
		{
			
		}
	}




namespace CSP.APIV2Modules
{
    public partial class InvalidCredentialsError
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Invalid_Credtials(string secret, string key, string StudyProtocol, string DOM)
        {
        	
        	try{
            HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create("https://" + DOM + "/api/external/V2/" + StudyProtocol  + "/AuthenticationToken");
        	httpRequest.ContentType = "application/json";
        	httpRequest.Method = "POST";
        	
        	//Create JSON ibject containing key and secret which is sent in the body
        	AuthJSONRequest1 jsonObject = new AuthJSONRequest1(key,secret);
        	
        	using (StreamWriter sw = new StreamWriter(httpRequest.GetRequestStream()))
        	{
        		string json = new JavaScriptSerializer().Serialize(jsonObject);
        		
        		sw.Write(json);
        		sw.Flush();
        		sw.Close();
        	}
       
        	//Get the response and read into a new object
        	HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();
        	
        	AuthJSONResponse1 responseObject = new AuthJSONResponse1();
        	
        	using (StreamReader sr = new StreamReader(httpResponse.GetResponseStream()))
        	{
        		string response = sr.ReadToEnd();
        		//Deserialise the JSON in a new object to use later
        		responseObject = new JavaScriptSerializer().Deserialize<AuthJSONResponse1>(response);
        		
        		
        		String messageError = responseObject.message;
        		
        		Report.Log(ReportLevel.Info, "LoggedIn Successfull, AuthToken is: " + messageError);
        		
        		 }
        	}
        	catch (Exception e)
             {
             
        	 String Error401 = "The remote server returned an error: (401) Unauthorized.";	
             Validate.AreEqual(Error401 , e.Message);
            
             }
        			
        			
        		
        	}
        }

    }

