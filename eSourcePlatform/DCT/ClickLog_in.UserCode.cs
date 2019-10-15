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

namespace DCT
{
    public partial class ClickLog_in
    {
    	WebElement ClickSubmit= null;
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Mouse_Click_ClickLogin(RepoItemInfo divtagInfo)
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'divtagInfo' at Center.", divtagInfo);
            divtagInfo.FindAdapter<DivTag>().Click();
        }

        public void Click_Submit()
        {
            if (Host.Local.TryFindSingle<WebElement>("//div[@innertext='Sign in with Microsoft']", new Duration(1500), out ClickSubmit)){
               
                ClickSubmit.Click();
            }else{
              
                Report.Log(ReportLevel.Info ,"ClickSubmit is  Not required");
            }
        }

    }
}
