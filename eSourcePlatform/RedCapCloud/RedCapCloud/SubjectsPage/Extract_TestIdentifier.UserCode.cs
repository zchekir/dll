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

namespace RedCapCloud.SubjectsPage
{
    public partial class Extract_TestIdentifier
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Get_value_TestIdentifier(RepoItemInfo inputTagInfo)
        {
        	Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'inputTagInfo' and assigning its value to variable 'TestIdentifier'.", inputTagInfo);
        	
        	//while (!inputTagInfo.Exists(new Duration(10000))) 
        	while (!inputTagInfo.Exists(new Duration(1000))){
        		
        		//If TestIdentifier is not found, we need to go back to the subjects menu, select the subject,
        		//select the visit and select the CRF again. If we simply sit at the DataConfirmationCRF page and refresh it,
        		//the CRF is locked and the TestIdentifier may never come throug
        		Report.Log(ReportLevel.Info, "Click", "Mouse Click on Subjects button", new RecordItemIndex(0));
        		repo.REDCapCloud.SubjectsButton.Click(Location.Center, 500);
        		
        		Report.Log(ReportLevel.Info, "Click", "Mouse click on Subject", new RecordItemIndex(1));
        		repo.REDCapCloud.SubjectsPage.Subject.Click(Location.Center, 500);
        		
        		Report.Log(ReportLevel.Info, "Click", "Mouse click on FirstVisit", new RecordItemIndex(2));
        		repo.REDCapCloud.SubjectsPage.FirstVisit.Click(Location.Center, 500);

        		Report.Log(ReportLevel.Info, "Delay", "Waiting for 1.5m.", new RecordItemIndex(3));
                Delay.Duration(9000, false);
        		
        		Report.Log(ReportLevel.Info, "Click", "Mouse click on DataConfirmationCRF", new RecordItemIndex(4));
        		repo.REDCapCloud.SubjectsPage.DataConfirmationCRF.Click();
        			
        	} 
            
            TestIdentifier = inputTagInfo.FindAdapter<InputTag>().Element.GetAttributeValueText("Value");
            
        }

    }
}
