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
    ///The Enter_WorkflowName recording.
    /// </summary>
    [TestModule("94f6a855-301c-4931-b97a-68e17d5b6b05", ModuleType.Recording, 1)]
    public partial class Enter_WorkflowName : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PrecisionRecruitment.PrecisionRecruitmentRepository repository.
        /// </summary>
        public static PrecisionRecruitment.PrecisionRecruitmentRepository repo = PrecisionRecruitment.PrecisionRecruitmentRepository.Instance;

        static Enter_WorkflowName instance = new Enter_WorkflowName();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Enter_WorkflowName()
        {
            WorkflowName = "";
            RandNum = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Enter_WorkflowName Instance
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
        [TestVariable("385a6332-d56f-441b-bb40-0cdfb6832740")]
        public string WorkflowName
        {
            get { return repo.WorkflowName; }
            set { repo.WorkflowName = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable RandNum.
        /// </summary>
        [TestVariable("cc41debb-a551-411e-9921-5b6e4f6e2dbf")]
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform.AddWorkflowPage.WorkflowNameField' at Center.", repo.CogstateSolutionPlatform.AddWorkflowPage.WorkflowNameFieldInfo, new RecordItemIndex(0));
            repo.CogstateSolutionPlatform.AddWorkflowPage.WorkflowNameField.Click(3);
            Delay.Milliseconds(90);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{End}{LShiftKey down}{Home}{LShiftKey up}{Delete}' with focus on 'CogstateSolutionPlatform.AddWorkflowPage.WorkflowNameField'.", repo.CogstateSolutionPlatform.AddWorkflowPage.WorkflowNameFieldInfo, new RecordItemIndex(1));
            repo.CogstateSolutionPlatform.AddWorkflowPage.WorkflowNameField.PressKeys("{End}{LShiftKey down}{Home}{LShiftKey up}{Delete}", 1);
            Delay.Milliseconds(90);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$WorkflowName' with focus on 'CogstateSolutionPlatform.AddWorkflowPage.WorkflowNameField'.", repo.CogstateSolutionPlatform.AddWorkflowPage.WorkflowNameFieldInfo, new RecordItemIndex(2));
            repo.CogstateSolutionPlatform.AddWorkflowPage.WorkflowNameField.PressKeys(WorkflowName, 1);
            Delay.Milliseconds(90);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$RandNum' with focus on 'CogstateSolutionPlatform.AddWorkflowPage.WorkflowNameField'.", repo.CogstateSolutionPlatform.AddWorkflowPage.WorkflowNameFieldInfo, new RecordItemIndex(3));
            repo.CogstateSolutionPlatform.AddWorkflowPage.WorkflowNameField.PressKeys(RandNum, 1);
            Delay.Milliseconds(90);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Value>$WorkflowName) on item 'CogstateSolutionPlatform.AddWorkflowPage.WorkflowNameField'.", repo.CogstateSolutionPlatform.AddWorkflowPage.WorkflowNameFieldInfo, new RecordItemIndex(4));
            Validate.AttributeContains(repo.CogstateSolutionPlatform.AddWorkflowPage.WorkflowNameFieldInfo, "Value", WorkflowName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Value>$RandNum) on item 'CogstateSolutionPlatform.AddWorkflowPage.WorkflowNameField'.", repo.CogstateSolutionPlatform.AddWorkflowPage.WorkflowNameFieldInfo, new RecordItemIndex(5));
            Validate.AttributeContains(repo.CogstateSolutionPlatform.AddWorkflowPage.WorkflowNameFieldInfo, "Value", RandNum);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
