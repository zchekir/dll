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
	public class Participant_Qualification
	   {
		/// <summary>
		/// Returned qualificaiton status
		/// </summary>
		public string assessmentAttemptQualificationStatus { get; set; }
		
		public Participant_Qualification()
		{
			
		}
	}
    public partial class ParticipantQualification_Status
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Participant_QualificationStatus()
        {
            //Setup API call
        	HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create("https://" + DOM + "/api/external/V2/" + studyProtocolName  + "/participant/" + externalid + "/qualificationstatus");
        	httpRequest.ContentType = "application/json";
        	httpRequest.Method = "GET";
        	httpRequest.Headers.Add("Authorization", AuthToken);
        	
        	HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();
        	Participant_Qualification responseObject = new Participant_Qualification();
        	
        	using (StreamReader sr = new StreamReader(httpResponse.GetResponseStream()))
        	{
        		string response = sr.ReadToEnd();
        		responseObject = new JavaScriptSerializer().Deserialize<Participant_Qualification>(response);
        		
        		string  ParticipantQualificationStatus = responseObject.assessmentAttemptQualificationStatus;
        		
        		Report.Log(ReportLevel.Info, response);
        	}
        }

    }
}
