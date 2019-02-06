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

namespace PrecisionRecruitment.AddVisitSchedulePage
{
    public partial class Select_First_Visit
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        //Make sure first visit exists, if not, reload the visit schedule and try again.
        //Sometimes there is a delay between setting the visit in RCC and the visit appearing in CSP
        public void Mouse_Click_Visit1(RepoItemInfo VisitOne)
        {
        	while (!VisitOne.Exists(new Duration(500))) {
        		Report.Info("Visit does not exist, reloading page");
        		repo.CogstateSolutionPlatform.Breadcrumbs.VisitScheduleNameBreadcrumb.Click();
        		Delay.Duration(new Duration(30000));
        	}
        	
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VisitOne' at Center.", VisitOne);
            VisitOne.FindAdapter<H4Tag>().Click();
        }

    }
}
