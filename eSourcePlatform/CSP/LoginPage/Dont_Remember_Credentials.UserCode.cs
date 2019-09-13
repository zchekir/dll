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

namespace CSP.LoginPage
{
    public partial class Dont_Remember_Credentials
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void ForgetCredentials(RepoItemInfo DontAskCheckbox, RepoItemInfo NoButton)
        {
        	if (DontAskCheckbox.Exists(new Duration(2500)))
        	{
        		Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo' at 9;11.", DontAskCheckbox);
            	DontAskCheckbox.FindAdapter<InputTag>().Click("9;11");
           	 	Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo1' at 51;16.", NoButton);
            	NoButton.FindAdapter<InputTag>().Click("51;16");
        	}
            
        }

    }
}
