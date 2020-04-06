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

namespace CSP.InternalAPIModules
{
	public class _GenerateStandardExtract
	{
		
		
	public string url {get;set;}
		
	public	_GenerateStandardExtract()
	{
			
	}
	}
    public partial class Generate_Standard_Extract
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Generate_StandardExtract(string DOM, string AuthToken)
        {
            //{{website}}/api/External/referralStatus/{{iqnumber}}/{{visitsessionid}} 
            
            // Setting up Get status API call header:
                                             //STUDID
            string extractAPI ="/api/studies/163629/extract/2";
        	string url="https://"+ DOM + extractAPI;
        	
        	HttpWebRequest httpRequest =(HttpWebRequest)WebRequest.Create(url);
        	httpRequest.ContentType = "application/json";
        	httpRequest.Method="POST";
        	httpRequest.Headers.Add("Authorization", AuthToken);
        	httpRequest.ContentLength=0;
        	
        	HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();
        	
        	//CreateObject:
        	_GenerateStandardExtract responseObject = new _GenerateStandardExtract();
        	
        	using (StreamReader sr = new StreamReader(httpResponse.GetResponseStream()))
        	
        	{
        		
        		string response= sr.ReadToEnd();
        		responseObject = new JavaScriptSerializer().Deserialize<_GenerateStandardExtract>(response);
        		string StandardExtract = responseObject.url; 
        		
        			Report.Log(ReportLevel.Info, "StandardExtract generated successfully  is:"+ StandardExtract);
        		}
        			
        		
        	
        }

    }
}
