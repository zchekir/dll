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

namespace Cognigram_.SmokTestModules
{
    public partial class CognigramEmailValidation
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Get_value_Capture_the_email_(RepoItemInfo spantagInfo)
        { 
        	try{
        		
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagName' from item 'spantagInfo' and assigning its value to variable 'expectedEmail'.", spantagInfo);
            expectedEmail = spantagInfo.FindAdapter<SpanTag>().Element.GetAttributeValueText("InnerText");
            Validate.AreEqual(currentemail,expectedEmail);
        	
        	}catch(Exception e){
        		
        		
        		 Report.Log(ReportLevel.Error,  " Forget Email link is not appering as expected");
        	}
        }

    }
}
