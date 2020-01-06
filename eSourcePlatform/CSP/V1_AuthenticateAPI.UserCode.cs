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

/*
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
	*/
	/// <summary>-------------------------------------------------------------------
	/// Class definition for JSON object which is received after an AuthToken request
	/// </summary>
	public class V1AuthJSONResponse
		
	{
		
		
		public string serverAuthToken { get; set; }
		//public string authorizationScheme { get; set; }
		
		public V1AuthJSONResponse()
		{
			
		}
	}
namespace CSP
{
    public partial class V1_AuthenticateAPI
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void V1AuthenticationAPI(string DOM, string secret, string Key)
        {
        string url ="https://cgst-qc-orr.azurewebsites.net/api/external/AuthenticationToken?key=5767c4d2-be6c-4bdc-ac60-5ba8474f37af&secret=305e95af-bb38-4a00-bf8e-448d06f67f55";
          
        	HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(url);
        	httpRequest.ContentType = "application/json";
        	httpRequest.Method = "POST";
        	httpRequest.ContentLength =0;
        	
        	
        	//Get the response and read into a new object
        	HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();
        	
        	V1AuthJSONResponse responseObject = new V1AuthJSONResponse();
        	
        	using (StreamReader sr = new StreamReader(httpResponse.GetResponseStream()))
        	{
        		string response = sr.ReadToEnd();
        		//Deserialise the JSON in a new object to use later
        		responseObject = new JavaScriptSerializer().Deserialize<V1AuthJSONResponse>(response);
        		
        		var authToken = responseObject.serverAuthToken;
        		
        		Report.Log(ReportLevel.Info, "Authentication Successfull, AuthToken is: " + authToken);
        	}
        }

    }
}
