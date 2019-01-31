﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
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
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace PrecisionRecruitment.StudiesPage
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Select_Study recording.
    /// </summary>
    [TestModule("36e2b5b5-2490-454c-9786-d8f2759ac9c9", ModuleType.Recording, 1)]
    public partial class Select_Study : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PrecisionRecruitment.PrecisionRecruitmentRepository repository.
        /// </summary>
        public static PrecisionRecruitment.PrecisionRecruitmentRepository repo = PrecisionRecruitment.PrecisionRecruitmentRepository.Instance;

        static Select_Study instance = new Select_Study();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Select_Study()
        {
            RandNum = "";
            ProjectName = "Ranorex Project Name";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Select_Study Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable DOM.
        /// </summary>
        [TestVariable("280aff49-d9c4-468c-bece-6c1951b0ef7e")]
        public string DOM
        {
            get { return repo.DOM; }
            set { repo.DOM = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable ProjectName.
        /// </summary>
        [TestVariable("c79bec5d-144b-4142-be36-50ddfe893386")]
        public string ProjectName
        {
            get { return repo.ProjectName; }
            set { repo.ProjectName = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable RandNum.
        /// </summary>
        [TestVariable("d820780f-6115-40b8-8278-c22d3703bd0c")]
        public string RandNum
        {
            get { return repo.RandNum; }
            set { repo.RandNum = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 100;
            Keyboard.DefaultKeyPressTime = 10;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform.Menu.HamburgerMenu' at Center.", repo.CogstateSolutionPlatform.Menu.HamburgerMenuInfo, new RecordItemIndex(0));
            repo.CogstateSolutionPlatform.Menu.HamburgerMenu.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform.Menu.StudiesMenuOption' at Center.", repo.CogstateSolutionPlatform.Menu.StudiesMenuOptionInfo, new RecordItemIndex(1));
            repo.CogstateSolutionPlatform.Menu.StudiesMenuOption.Click();
            Delay.Milliseconds(0);
            
            Try_Enter_StudyName(repo.CogstateSolutionPlatform.MainToolbar.SearchFieldInfo);
            Delay.Milliseconds(0);
            
            // Wait for results to load
            Report.Log(ReportLevel.Info, "Section", "Wait for results to load", new RecordItemIndex(3));
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(4));
            Delay.Duration(2000, false);
            
            // Continue on with Tests
            Report.Log(ReportLevel.Info, "Section", "Continue on with Tests", new RecordItemIndex(5));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform.MainToolbar.CardButton' at Center.", repo.CogstateSolutionPlatform.MainToolbar.CardButtonInfo, new RecordItemIndex(6));
            repo.CogstateSolutionPlatform.MainToolbar.CardButton.Click();
            Delay.Milliseconds(0);
            
            Try_Click_StudyCardTitle(repo.CogstateSolutionPlatform.StudyCards.StudyCardTitleInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>$ProjectName) on item 'CogstateSolutionPlatform.Breadcrumbs.StudyNameBreadcrumb'.", repo.CogstateSolutionPlatform.Breadcrumbs.StudyNameBreadcrumbInfo, new RecordItemIndex(8));
            Validate.AttributeContains(repo.CogstateSolutionPlatform.Breadcrumbs.StudyNameBreadcrumbInfo, "InnerText", ProjectName);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>$RandNum) on item 'CogstateSolutionPlatform.Breadcrumbs.StudyNameBreadcrumb'.", repo.CogstateSolutionPlatform.Breadcrumbs.StudyNameBreadcrumbInfo, new RecordItemIndex(9));
            Validate.AttributeContains(repo.CogstateSolutionPlatform.Breadcrumbs.StudyNameBreadcrumbInfo, "InnerText", RandNum);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
