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
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace CSP
{
    public partial class ClickExportFolder
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Get_value_OpenExportFolder(RepoItemInfo atagInfo)
        {
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'atagInfo' and assigning its value to variable 'date'.", atagInfo);
            date = atagInfo.FindAdapter<ATag>().Element.GetAttributeValueText("InnerText");
            
            
             string toDayDate = System.DateTime.Now.ToString("yyyyMMdd");
             string reportDate = date.Substring(8, 8);
             
             Validate.AreEqual(toDayDate, reportDate);
            
        }

    }
}
