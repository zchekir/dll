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

namespace PrecisionRecruitment.AddVisitSchedulePage
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Select_Workflow recording.
    /// </summary>
    [TestModule("1bf7aabb-931a-4efb-8e05-7a8f93549a40", ModuleType.Recording, 1)]
    public partial class Select_Workflow : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PrecisionRecruitment.PrecisionRecruitmentRepository repository.
        /// </summary>
        public static PrecisionRecruitment.PrecisionRecruitmentRepository repo = PrecisionRecruitment.PrecisionRecruitmentRepository.Instance;

        static Select_Workflow instance = new Select_Workflow();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Select_Workflow()
        {
            WorkflowName = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Select_Workflow Instance
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
        /// Gets or sets the value of variable WorkflowName.
        /// </summary>
        [TestVariable("04b4d8c1-daf9-4eed-a980-91b726b458bf")]
        public string WorkflowName
        {
            get { return repo.WorkflowName; }
            set { repo.WorkflowName = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform.AddVisitSchedulePage.VisitScheduleWorkflowDropdown' at Center.", repo.CogstateSolutionPlatform.AddVisitSchedulePage.VisitScheduleWorkflowDropdownInfo, new RecordItemIndex(0));
            repo.CogstateSolutionPlatform.AddVisitSchedulePage.VisitScheduleWorkflowDropdown.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$WorkflowName' with focus on 'CogstateSolutionPlatform.AddVisitSchedulePage.VisitScheduleWorkflowDropdown'.", repo.CogstateSolutionPlatform.AddVisitSchedulePage.VisitScheduleWorkflowDropdownInfo, new RecordItemIndex(1));
            repo.CogstateSolutionPlatform.AddVisitSchedulePage.VisitScheduleWorkflowDropdown.PressKeys(WorkflowName, 100);
            Delay.Milliseconds(10);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{ENTER}' with focus on 'CogstateSolutionPlatform.AddVisitSchedulePage.VisitScheduleWorkflowDropdown'.", repo.CogstateSolutionPlatform.AddVisitSchedulePage.VisitScheduleWorkflowDropdownInfo, new RecordItemIndex(2));
            repo.CogstateSolutionPlatform.AddVisitSchedulePage.VisitScheduleWorkflowDropdown.PressKeys("{ENTER}", 100);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
