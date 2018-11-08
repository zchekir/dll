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
    ///The Assign_Battery_to_Workflow recording.
    /// </summary>
    [TestModule("5e586929-3ac2-4201-84c3-6071a72f25c8", ModuleType.Recording, 1)]
    public partial class Assign_Battery_to_Workflow : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PrecisionRecruitment.PrecisionRecruitmentRepository repository.
        /// </summary>
        public static PrecisionRecruitment.PrecisionRecruitmentRepository repo = PrecisionRecruitment.PrecisionRecruitmentRepository.Instance;

        static Assign_Battery_to_Workflow instance = new Assign_Battery_to_Workflow();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Assign_Battery_to_Workflow()
        {
            BatteryName = "Ranorex Battery";
            RandNum = "270695";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Assign_Battery_to_Workflow Instance
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
        /// Gets or sets the value of variable BatteryName.
        /// </summary>
        [TestVariable("610df901-efa9-4374-8683-6129711e6537")]
        public string BatteryName
        {
            get { return repo.BatteryName; }
            set { repo.BatteryName = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable RandNum.
        /// </summary>
        [TestVariable("e6530ed0-f488-4aa8-8afe-85836dd0927f")]
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform.AddWorkflowPage.SimpleBatteryStep' at Center.", repo.CogstateSolutionPlatform.AddWorkflowPage.SimpleBatteryStepInfo, new RecordItemIndex(0));
            repo.CogstateSolutionPlatform.AddWorkflowPage.SimpleBatteryStep.Click(3);
            Delay.Milliseconds(90);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform.AddWorkflowPage.PropertiesTab' at Center.", repo.CogstateSolutionPlatform.AddWorkflowPage.PropertiesTabInfo, new RecordItemIndex(1));
            repo.CogstateSolutionPlatform.AddWorkflowPage.PropertiesTab.Click(3);
            Delay.Milliseconds(90);
            
            SelectBatteryOption();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform.AddWorkflowPage.WorkflowBlockPropertiesSaveButton' at 28;16.", repo.CogstateSolutionPlatform.AddWorkflowPage.WorkflowBlockPropertiesSaveButtonInfo, new RecordItemIndex(3));
            repo.CogstateSolutionPlatform.AddWorkflowPage.WorkflowBlockPropertiesSaveButton.Click("28;16", 3);
            Delay.Milliseconds(90);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1.5s.", new RecordItemIndex(4));
            Delay.Duration(1500, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
