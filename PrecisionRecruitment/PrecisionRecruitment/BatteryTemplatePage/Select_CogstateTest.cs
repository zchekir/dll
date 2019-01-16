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

namespace PrecisionRecruitment.BatteryTemplatePage
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Select_CogstateTest recording.
    /// </summary>
    [TestModule("e231f99c-c036-461b-93e8-b4324c40315e", ModuleType.Recording, 1)]
    public partial class Select_CogstateTest : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PrecisionRecruitment.PrecisionRecruitmentRepository repository.
        /// </summary>
        public static PrecisionRecruitment.PrecisionRecruitmentRepository repo = PrecisionRecruitment.PrecisionRecruitmentRepository.Instance;

        static Select_CogstateTest instance = new Select_CogstateTest();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Select_CogstateTest()
        {
            BatteryBlockName = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Select_CogstateTest Instance
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
        /// Gets or sets the value of variable BatteryBlockName.
        /// </summary>
        [TestVariable("4b35f5bf-972d-4852-b19e-14c27e2391a6")]
        public string BatteryBlockName
        {
            get { return repo.BatteryBlockName; }
            set { repo.BatteryBlockName = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'CogstateSolutionPlatform.AddBatteryPage.CogstateTestDropdown'", repo.CogstateSolutionPlatform.AddBatteryPage.CogstateTestDropdownInfo, new ActionTimeout(10000), new RecordItemIndex(0));
            repo.CogstateSolutionPlatform.AddBatteryPage.CogstateTestDropdownInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform.AddBatteryPage.CogstateTestDropdown' at Center.", repo.CogstateSolutionPlatform.AddBatteryPage.CogstateTestDropdownInfo, new RecordItemIndex(1));
            repo.CogstateSolutionPlatform.AddBatteryPage.CogstateTestDropdown.Click(1);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$BatteryBlockName' with focus on 'CogstateSolutionPlatform.AddBatteryTemplatePage.CogstateTestDropdown'.", repo.CogstateSolutionPlatform.AddBatteryTemplatePage.CogstateTestDropdownInfo, new RecordItemIndex(2));
            repo.CogstateSolutionPlatform.AddBatteryTemplatePage.CogstateTestDropdown.PressKeys(BatteryBlockName, 1);
            Delay.Milliseconds(10);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'CogstateSolutionPlatform.AddBatteryTemplatePage.CogstateTestDropdown'.", repo.CogstateSolutionPlatform.AddBatteryTemplatePage.CogstateTestDropdownInfo, new RecordItemIndex(3));
            repo.CogstateSolutionPlatform.AddBatteryTemplatePage.CogstateTestDropdown.PressKeys("{Return}", 1);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
