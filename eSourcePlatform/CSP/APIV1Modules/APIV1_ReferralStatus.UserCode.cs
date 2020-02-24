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
namespace CSP.APIV1Modules
{
	// creating constructure
	
	public class ReferralStatusObject
	{
		
		public string referralStatusCode {get;set;}
		
		public	ReferralStatusObject()
		{
			
		}
	}
	
	public partial class APIV1_ReferralStatus
	{
		
		int number;
		/// <summary>
		/// This method gets called right after the recording has been started.
		/// It can be used to execute recording specific initialization code.
		/// </summary>
		private void Init()
		{
			// Your recording specific initialization code goes here.
		}

		public void StatusReferral(string visitsession, string DOM, string externalId, string AuthToken)
		{
			if (externalId==""){
				// generating an rundom number to be used as externalid
				Random r = new Random();
				number = r.Next(1,999999);
				externalId = number.ToString();
				
				
			}else{
				
				Report.Log(ReportLevel.Info, "The externalid is generated from workflowinstance call" );
			}
			
			// Setting up Get status API call header:
			string url="https://"+DOM +"/api/External/referralStatus/"+externalId+"/"+visitsession;
			HttpWebRequest httpRequest =(HttpWebRequest)WebRequest.Create(url);
			httpRequest.ContentType = "application/json";
			httpRequest.Method="Get";
			httpRequest.Headers.Add("Authorization", AuthToken);
			
			HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();
			
			//CreateObject:
			ReferralStatusObject responseObject = new ReferralStatusObject();
			
			using (StreamReader sr = new StreamReader(httpResponse.GetResponseStream()))
				
			{
				
				string response = sr.ReadToEnd();
				responseObject = new JavaScriptSerializer().Deserialize<ReferralStatusObject>(response);
				string ReferralStatus = responseObject.referralStatusCode;
				Report.Log(ReportLevel.Info,  response);
				
				{
				}
			}
		}

	}
}
