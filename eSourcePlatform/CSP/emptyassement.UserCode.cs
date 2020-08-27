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
	
		public class emptyAssJSONResponse
	{
		/// <summary>
		/// Returned qualificaiton status
		/// </summary>
		/// need change this
		public string name { get; set; }
		public string code { get; set; }
		public string data { get; set; }
		
		public emptyAssJSONResponse()
		{
			
		}
	
	
   

   

		}

    public partial class emptyassement
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void E_mptyAssment(string workflowID, string DOM, string workflowToken, string Batteryid)
        {
           //Setup API call
			HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create("https://" + DOM + "/api/prsworkflow/" + workflowID  + "/InsertEmptyAssessment?batteryConfigurationId="+ B_id);
			httpRequest.ContentType = "application/json";
			httpRequest.Method = "POST";
			httpRequest.Headers.Add("Authorization", workflowToken);
			httpRequest.ContentLength=0;
			HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();
			emptyAssJSONResponse responseObject = new emptyAssJSONResponse();
			
			using (StreamReader sr = new StreamReader(httpResponse.GetResponseStream()))
			{
				string response = sr.ReadToEnd();
				responseObject = new JavaScriptSerializer().Deserialize<emptyAssJSONResponse>(response);
				
				
					// slpit
			char[] mych = { '&', ',','?','=',':' };
            string assID = response;
            string[] Assmentid = assID.Split(mych);
            assessmentID = Assmentid[1];
				
				
		
				//need change this
				string  dataID = responseObject.data;
				
				Report.Log(ReportLevel.Info, response);
				Report.Log(ReportLevel.Info,   assessmentID);
			}
        }

    }
}

