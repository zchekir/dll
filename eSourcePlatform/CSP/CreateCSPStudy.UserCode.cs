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
	//To send in the body 
	public class studyCreation
	{
		
		
	public string id {get;set;}
	public string protocolName {get;set;}
	public string CodeName {get;set;}
	public string sponsor {get;set;}
		
	public	studyCreation(string id,string protocolName,string CodeName, string sponsor)
	{
		this.id=id;
        this.protocolName=protocolName;
        this.CodeName=CodeName;
        this.sponsor=sponsor;
	}
	}
	
	//Object interface
	public class studyCreationR
	{
		
		
	public string id {get;set;}
	
	public string protocolName  {get;set;}
		
	public	studyCreationR()
	{
	
	}
	}
	
	
    public partial class CreateCSPStudy
    {
        //variables:
        string  id="null";
        string protocolName= "APIStudy2";
        string CodeName= "APIStudy2";
        string sponsor= "Cogstate";
       
        private void Init()
        {
            
        }

        public void CSPStudy(string DOM, string AuthToken)
        {
           // generating an rundom number to be used as creation of the study
        	Random r = new Random();
            int  number = r.Next(1,999999);
            string rnumber = number.ToString();
        
            
            // Setting up Get status API call header:
        	string url="https://"+DOM +"/api/studies";
        	HttpWebRequest httpRequest =(HttpWebRequest)WebRequest.Create(url);
        	httpRequest.ContentType = "application/json";
        	httpRequest.Method="POST";
        	httpRequest.Headers.Add("Authorization", AuthToken);
        	
        	
        	//Create JSON object containing for the body study details
        	studyCreation assessmentObject = new studyCreation(id,protocolName+rnumber,CodeName+rnumber,sponsor);
        	using (StreamWriter sw = new StreamWriter(httpRequest.GetRequestStream()))
        	{
        		string json = new JavaScriptSerializer().Serialize(assessmentObject);
        		
        		//Debugging Request
        		Report.Info("Data to send: " + json);
        		
        		sw.Write(json);
        		sw.Flush();
        		sw.Close();
        	}
        	
        	
        	
        	//send the API Call 
        	HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();
        	//CreateObject:
        	studyCreationR responseObject = new studyCreationR();
        	
        	using (StreamReader sr = new StreamReader(httpResponse.GetResponseStream()))
        	
        	{
        		
        		string response= sr.ReadToEnd();
        		responseObject = new JavaScriptSerializer().Deserialize<studyCreationR>(response);
        		string Study_ID= responseObject.id; 
        		string StudyName= responseObject.protocolName;
        		
        		Report.Log(ReportLevel.Info, "StudyID:"+ Study_ID);
        		
        		
        			{
        		}
        	}
        }

    }
}

