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
	public class generateKey
	{
		
		public string id { get; set; }
		
		public string key { get; set; }
		
		public string genderCode { get; set; }
		public string contactEmail { get; set; }
		public string active { get; set; }
		
		public generateKey(string Id, string key, string contactEmail, string active){
			
			this.id=id;
			this.key=key;
			this.contactEmail=contactEmail;
			this.active=active;
			
		}
	}
		
		public class ExternalKey{
			
			public string id { get; set; }
		
		  public string key { get; set; }
		  
		  public ExternalKey(){
		  	
		  }
			
		}
		
	}

namespace CSP
{
    public partial class GenerateKey
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Generate_Key(string id, string contactEmail, string active, string I_AuthToken, string key)
        {
            
            //Setup API call
        	HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create("https://cgst-qc-jordan.azurewebsites.net/api/externalusers");
        	httpRequest.ContentType = "application/json";
        	httpRequest.Method = "POST";
        	httpRequest.Headers.Add("Authorization", I_AuthToken);
        
        	
        	//Check if external id is empty and generate a random number if true
        
        	
        	//Create JSON object containing demographics and study details
        	
        	generateKey assessmentObject = new generateKey(id, key, contactEmail, active);
        	
        	
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
        	
        	 ExternalKey responseObject = new  ExternalKey();
        	
        	using (StreamReader sr = new StreamReader(httpResponse.GetResponseStream()))
        	{
        		string response = sr.ReadToEnd();
        		responseObject = new JavaScriptSerializer().Deserialize<ExternalKey>(response);
        		
        		
        		var Ex_key = responseObject.key;
        		
        		Report.Log(ReportLevel.Info, "ExternalKey is : " + Ex_key );
        		
        	}
        }

    }
}


