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
using Newtonsoft.Json;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;

namespace eSourcePlatform
{
	
	
	public class AssemblyVersion
    {
        public string Version;
        public string TenantName;
        public string StudyFilters;
        public string EntryAssembly;
    }
  
public class rowsJSONResponseA
	{
		
		
		
		
		public string rows { get; set; }
		
		
		
		public rowsJSONResponseA()
		{
			
		}
  
	}



	public partial class DCTVHUBV
    {
       //varibles :
            private const string V8HandlerJobs ="Cogstate.Integration.V8HandlerJobs";
            private const string V8AdapterJobs ="Cogstate.Integration.V8AdapterJobs";
            private const string RedCapAdapterJob  ="Cogstate.Integration.RedCapAdapterJobs";
            private const string RedCapHandlerJobs ="Cogstate.Integration.RedCapHandlerJobs";
            private const string AbsorbWebJobs  ="Cogstate.Absorb.WebJobs";
            private const string DataCleaningTool  ="Cogstate.DataCleaningTool.WebJobs";
            string DOM ="https://api.applicationinsights.io/v1/apps/";
       
            private void Init()
        {
            
        }

        public void VersionHUB(string EvKey, string Ahuky, string Query, string TimeStmp)
        {
        	
        	
        	try{
        		
        
		    // sending the API call 		
			var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.Add("x-api-key", Ahuky);

            var response =  httpClient.GetAsync( DOM +   EvKey  +  "/query?timespan="  + TimeStmp + "&query="+ Query).GetAwaiter().GetResult();
            
            var responseString = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            var anonymousTypeObject = new {tables = new[] {new {name = "", rows = new[] { new List<dynamic>() } }}};

            var responseObject =Newtonsoft.Json.JsonConvert.DeserializeAnonymousType(responseString, anonymousTypeObject);
            
            var assemblyVersionString = responseObject.tables.First().rows.First().ElementAt(3);
            
            
          
             //V8Handler
             foreach( var row in  responseObject.tables.First().rows){
             var rowData = row.ElementAt(3);
             AssemblyVersion version = Newtonsoft.Json.JsonConvert.DeserializeObject<AssemblyVersion>(rowData);
             var entryAssembly = version.EntryAssembly.Split(',').First();
             if( entryAssembly ==  V8HandlerJobs  ){
             Validate.AreEqual("V8Handler_Jobs: "+ version.Version ,"V8Handler_Jobs: "+ V8Handler_Jobs);
             break;
              
              
             } 
             }
			 
			  //V8Adapter
			 
             foreach( var row in  responseObject.tables.First().rows){
             var rowData = row.ElementAt(3);
             AssemblyVersion version = Newtonsoft.Json.JsonConvert.DeserializeObject<AssemblyVersion>(rowData);
             var entryAssembly = version.EntryAssembly.Split(',').First();
             if( entryAssembly ==  V8AdapterJobs  ){
             Validate.AreEqual("V8Adapter_Jobs: "+ version.Version ,"V8Adapter_Jobs: "+ V8Adapter_Jobs);
             break;
              
              
             } 
			 }
			 
			  // RedCapAdapterJob 
			 
             foreach( var row in  responseObject.tables.First().rows){
             var rowData = row.ElementAt(3);
             AssemblyVersion version = Newtonsoft.Json.JsonConvert.DeserializeObject<AssemblyVersion>(rowData);
             var entryAssembly = version.EntryAssembly.Split(',').First();
             if( entryAssembly ==  RedCapAdapterJob  ){
             Validate.AreEqual("RedCapAdapter_Job: "+ version.Version ,"RedCapAdapter_Job: "+ RedCapAdapter_Job);
             break;
              
              
             } 
			 }
			 
			 //RedCapHandlerJobs
			 
             foreach( var row in  responseObject.tables.First().rows){
             var rowData = row.ElementAt(3);
             AssemblyVersion version = Newtonsoft.Json.JsonConvert.DeserializeObject<AssemblyVersion>(rowData);
             var entryAssembly = version.EntryAssembly.Split(',').First();
             if( entryAssembly ==  RedCapHandlerJobs  ){
             Validate.AreEqual("RedCapHandler_Jobs: "+ version.Version ,"RedCapHandler_Jobs: "+ RedCapHandler_Jobs);
             break;
              
              
             } 
			 }
			 
			  
            //AbsorbWebJobs
			
             foreach( var row in  responseObject.tables.First().rows){
             var rowData = row.ElementAt(3);
             AssemblyVersion version = Newtonsoft.Json.JsonConvert.DeserializeObject<AssemblyVersion>(rowData);
             var entryAssembly = version.EntryAssembly.Split(',').First();
             if( entryAssembly ==  AbsorbWebJobs  ){
             Validate.AreEqual("Absorb_WebJobs: "+ version.Version ,"Absorb_WebJobs: "+ Absorb_WebJobs);
             break;
              
              
             } 
            }
			  
            
            // DCT Version
			  
			  
             foreach( var row in  responseObject.tables.First().rows){
             var rowData = row.ElementAt(3);
             AssemblyVersion version = Newtonsoft.Json.JsonConvert.DeserializeObject<AssemblyVersion>(rowData);
             var entryAssembly = version.EntryAssembly.Split(',').First();
             if( entryAssembly ==  DataCleaningTool ){
             Validate.AreEqual("Data_CleaningTool: "+ version.Version ,"Data_CleaningTool: "+ Data_CleaningTool);
             break;
              
            }
             } 
			 
			 
			 
	  }catch (Exception e) {
        	
        	Report.Log(ReportLevel.Failure,"Please increase your timestamp, there is NOT data deployed during this time."  );
       
        	
       
        	
        }
        
       
        }
        
        }
	
	
	

    }

