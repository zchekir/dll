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

//Battery Configuration Report
namespace CSP.InternalAPIModules
{
	
	
	//To send in the body 
	public class batteryReport
	{
		
		
	public string id {get;set;}
	public string reportType {get;set;}
	public string requestDate {get;set;}
	public string jsonData {get;set;}
		
	public	batteryReport(string id,string reportType,string requestDate , string jsonData)
	{
		this.id=id;
        this.reportType=reportType;
        this.requestDate =requestDate ;
        this.jsonData=jsonData;
	}
	}
	
	//Object interface
	public class batteryReportR
	{
		
		
	public string id {get;set;}
	public string reportType {get;set;}
	public string requestDate {get;set;}
	public string jsonData {get;set;}
		
	public	batteryReportR()
	{
	
	}
	
	}
	
    public partial class BatteryConfiguration_Report
    {
    
      
        private void Init()
        {
            
        }

        public void BatteryConfigurationReport(string DOM, string AuthToken)
        {
        	
       //variables:
       string reportid= "520";
       string id ="";
       string reportType= "";
       string requestDate= "";
       string jsonData="";
       string url="https://"+DOM+"/api/studies/163777/BatteryConfigurationReports/" + reportid;
        
        
    
            // Setting up Get status API call header:
        	
        	HttpWebRequest httpRequest =(HttpWebRequest)WebRequest.Create(url);
        	httpRequest.ContentType = "application/json";
        	httpRequest.Method="GET";
        	httpRequest.Headers.Add("Authorization", AuthToken);
        	
        	
        	//Create JSON object containing for the body study details
        	batteryReport assessmentObject = new batteryReport(id,reportType,requestDate,jsonData);
        	
        	//send the API Call 
        	HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();
        	//CreateObject:
        	batteryReportR responseObject = new batteryReportR();
        	
        	using (StreamReader sr = new StreamReader(httpResponse.GetResponseStream()))
        	
        	{
        		
        		string response= sr.ReadToEnd();
        		responseObject = new JavaScriptSerializer().Deserialize<batteryReportR>(response);
        		string ID= responseObject.id; 
        		string ReportType = responseObject.reportType;
        		string RequestDate= responseObject.requestDate;
        		string JsonData= responseObject.jsonData;
        		Report.Log(ReportLevel.Info, "ReportType :"+ ReportType );
        		Report.Log(ReportLevel.Info, "RequestDate:"+ RequestDate);
        		Report.Log(ReportLevel.Info, "JsonData:"+ JsonData);
        		Report.Log(ReportLevel.Info, "ID:"+ ID);
        		
        		
        			{
        		}
        	
          
        }

    }
    }
}
    
