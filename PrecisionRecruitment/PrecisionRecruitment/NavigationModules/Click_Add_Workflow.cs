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

namespace PrecisionRecruitment.NavigationModules
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Click_Add_Workflow recording.
    /// </summary>
    [TestModule("12c5de0a-0a0d-4bef-bbcd-831ee3ec3abb", ModuleType.Recording, 1)]
    public partial class Click_Add_Workflow : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PrecisionRecruitment.PrecisionRecruitmentRepository repository.
        /// </summary>
        public static PrecisionRecruitment.PrecisionRecruitmentRepository repo = PrecisionRecruitment.PrecisionRecruitmentRepository.Instance;

        static Click_Add_Workflow instance = new Click_Add_Workflow();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Click_Add_Workflow()
        {
            WorkflowName = "";
            DOM = "cgst-qc-2-7-0.cogstate.com";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Click_Add_Workflow Instance
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
        [TestVariable("15565e34-ca60-4a40-82ac-21ae6a8305c3")]
        public string WorkflowName
        {
            get { return repo.WorkflowName; }
            set { repo.WorkflowName = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 100;
            Keyboard.DefaultKeyPressTime = 10;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform.WorkflowsTab' at Center.", repo.CogstateSolutionPlatform.WorkflowsTabInfo, new RecordItemIndex(0));
            repo.CogstateSolutionPlatform.WorkflowsTab.Click(300);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform.WorkflowsViewMenu.AddButton' at Center.", repo.CogstateSolutionPlatform.WorkflowsViewMenu.AddButtonInfo, new RecordItemIndex(1));
            repo.CogstateSolutionPlatform.WorkflowsViewMenu.AddButton.Click(300);
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
