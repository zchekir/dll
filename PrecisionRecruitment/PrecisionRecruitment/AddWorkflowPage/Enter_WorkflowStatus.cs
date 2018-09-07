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

namespace PrecisionRecruitment.AddWorkflowPage
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Enter_WorkflowStatus recording.
    /// </summary>
    [TestModule("2fea4a16-adc5-4a20-b63c-853b13ceed4a", ModuleType.Recording, 1)]
    public partial class Enter_WorkflowStatus : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PrecisionRecruitment.PrecisionRecruitmentRepository repository.
        /// </summary>
        public static PrecisionRecruitment.PrecisionRecruitmentRepository repo = PrecisionRecruitment.PrecisionRecruitmentRepository.Instance;

        static Enter_WorkflowStatus instance = new Enter_WorkflowStatus();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Enter_WorkflowStatus()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Enter_WorkflowStatus Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform.AddWorkflowPage.WorkflowStatusDropdown' at Center.", repo.CogstateSolutionPlatform.AddWorkflowPage.WorkflowStatusDropdownInfo, new RecordItemIndex(0));
            repo.CogstateSolutionPlatform.AddWorkflowPage.WorkflowStatusDropdown.Click(3);
            Delay.Milliseconds(90);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Draft' with focus on 'CogstateSolutionPlatform.AddWorkflowPage.WorkflowStatusDropdown'.", repo.CogstateSolutionPlatform.AddWorkflowPage.WorkflowStatusDropdownInfo, new RecordItemIndex(1));
            repo.CogstateSolutionPlatform.AddWorkflowPage.WorkflowStatusDropdown.PressKeys("Draft", 1);
            Delay.Milliseconds(90);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'CogstateSolutionPlatform.AddWorkflowPage.WorkflowStatusDropdown'.", repo.CogstateSolutionPlatform.AddWorkflowPage.WorkflowStatusDropdownInfo, new RecordItemIndex(2));
            repo.CogstateSolutionPlatform.AddWorkflowPage.WorkflowStatusDropdown.PressKeys("{Return}", 1);
            Delay.Milliseconds(90);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
