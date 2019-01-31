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

namespace PrecisionRecruitment.StudiesPage
{
    public partial class Select_Study
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        //Make sure the full Study name has been entered into the search field before attempting to select the study
        public void Try_Enter_StudyName(RepoItemInfo SearchField)
        {
        	do {
        		Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform.MainToolbar.SearchField' at 36;15.", SearchField);
            	repo.CogstateSolutionPlatform.MainToolbar.SearchField.Click();
        		Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ProjectName' with focus on 'SearchField'.", SearchField);
            	SearchField.FindAdapter<InputTag>().PressKeys(ProjectName, 1);
            	Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$RandNum' with focus on 'SearchField'.", SearchField);
            	SearchField.FindAdapter<InputTag>().PressKeys(RandNum, 1);
            	Delay.Duration(500);
        	}
        	while (!SearchField.FindAdapter<InputTag>().Value.Contains(RandNum)); 	
        }

        //If the study has been added recently through RCC, it may not yet be populated. This will continue to search for the study
        //and click the study card title once it has been pushed to the CSP Database from the Hub
        public void Try_Click_StudyCardTitle(RepoItemInfo StudyCardTitle)
        {
        	while (!StudyCardTitle.Exists(new Duration(5000)))
        	{
        		Report.Log(ReportLevel.Info, "Study does not exist yet, waiting 60 seconds before looking again");
        		Delay.Duration(60000);
        		repo.CogstateSolutionPlatform.MainToolbar.SearchField.PressKeys("{End}{LShiftKey down}{Home}{LShiftKey up}{Delete}");
        		Try_Enter_StudyName(repo.CogstateSolutionPlatform.MainToolbar.SearchFieldInfo);
        	}
        	
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ptagInfo' at Center.", StudyCardTitle);
            StudyCardTitle.FindAdapter<PTag>().Click(3);
        }

    }
}
