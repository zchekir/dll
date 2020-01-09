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
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using System.IO;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace CSP.General
{
    public partial class Upload_RawData
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }
        
        public void AddRawData(string fileName)
        {
        	string data;
        	using (StreamReader sr = File.OpenText(@".\rawData\" + fileName + ".txt"))
			{
        		data = sr.ReadToEnd();
			}
        	
        	//Add raw data into the textbox on the battery runner page
        	Report.Log(ReportLevel.Info, "Searching for raw data text field");
        	repo.CogstateSolutionPlatform.WorkflowRunner.BatteryDataField.Element.SetAttributeValue("TagValue", data);
        }

    }
}
