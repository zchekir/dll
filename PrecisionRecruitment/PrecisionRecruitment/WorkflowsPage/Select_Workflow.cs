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

namespace PrecisionRecruitment.WorkflowsPage
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Select_Workflow recording.
    /// </summary>
    [TestModule("702570ca-23d6-40c2-8455-86a1f42e9870", ModuleType.Recording, 1)]
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
            RandNum = "";
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
        [TestVariable("482e915d-6fd1-48cc-a4dd-8c5f1fd9aa65")]
        public string WorkflowName
        {
            get { return repo.WorkflowName; }
            set { repo.WorkflowName = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable RandNum.
        /// </summary>
        [TestVariable("3d3b911e-6d5b-45de-9b57-b7519eb28a0a")]
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform.WorkflowsTab' at Center.", repo.CogstateSolutionPlatform.WorkflowsTabInfo, new RecordItemIndex(0));
            repo.CogstateSolutionPlatform.WorkflowsTab.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$WorkflowName' with focus on 'CogstateSolutionPlatform.SearchField'.", repo.CogstateSolutionPlatform.SearchFieldInfo, new RecordItemIndex(1));
            repo.CogstateSolutionPlatform.SearchField.PressKeys(WorkflowName, 100);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$RandNum' with focus on 'CogstateSolutionPlatform.SearchField'.", repo.CogstateSolutionPlatform.SearchFieldInfo, new RecordItemIndex(2));
            repo.CogstateSolutionPlatform.SearchField.PressKeys(RandNum, 100);
            Delay.Milliseconds(0);
            
            // Wait for list to load
            Report.Log(ReportLevel.Info, "Section", "Wait for list to load", new RecordItemIndex(3));
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(4));
            Delay.Duration(1000, false);
            
            // Continue with test
            Report.Log(ReportLevel.Info, "Section", "Continue with test", new RecordItemIndex(5));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform.WorkflowsViewMenu.CardButton' at Center.", repo.CogstateSolutionPlatform.WorkflowsViewMenu.CardButtonInfo, new RecordItemIndex(6));
            repo.CogstateSolutionPlatform.WorkflowsViewMenu.CardButton.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform.WorkflowsViewMenu.WorkflowCard' at 76;11.", repo.CogstateSolutionPlatform.WorkflowsViewMenu.WorkflowCardInfo, new RecordItemIndex(7));
            repo.CogstateSolutionPlatform.WorkflowsViewMenu.WorkflowCard.Click("76;11");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
