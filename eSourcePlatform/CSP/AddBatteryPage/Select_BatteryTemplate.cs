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

namespace CSP.AddBatteryPage
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Select_BatteryTemplate recording.
    /// </summary>
    [TestModule("28d48d57-1bf5-4535-b798-78226952b412", ModuleType.Recording, 1)]
    public partial class Select_BatteryTemplate : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::CSP.CSPRepository repository.
        /// </summary>
        public static global::CSP.CSPRepository repo = global::CSP.CSPRepository.Instance;

        static Select_BatteryTemplate instance = new Select_BatteryTemplate();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Select_BatteryTemplate()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Select_BatteryTemplate Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable CSPDOM.
        /// </summary>
        [TestVariable("f54fbb85-c5ac-4f6a-98d6-049472b68327")]
        public string CSPDOM
        {
            get { return repo.CSPDOM; }
            set { repo.CSPDOM = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable BatteryTemplateName.
        /// </summary>
        [TestVariable("a4551ae9-7e82-4cfb-a9d4-a720e5b38b7a")]
        public string BatteryTemplateName
        {
            get { return repo.BatteryTemplateName; }
            set { repo.BatteryTemplateName = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable RandNum.
        /// </summary>
        [TestVariable("88063847-8295-4241-aa12-5e073e7388b1")]
        public string RandNum
        {
            get { return repo.RandNum; }
            set { repo.RandNum = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform.AddBatteryPage.BatteryTemplateDropdown' at Center.", repo.CogstateSolutionPlatform.AddBatteryPage.BatteryTemplateDropdownInfo, new RecordItemIndex(0));
            repo.CogstateSolutionPlatform.AddBatteryPage.BatteryTemplateDropdown.Click(1);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Select() on item 'CogstateSolutionPlatform.AddBatteryPage.BatteryTemplateDropdownOption'.", repo.CogstateSolutionPlatform.AddBatteryPage.BatteryTemplateDropdownOptionInfo, new RecordItemIndex(1));
            repo.CogstateSolutionPlatform.AddBatteryPage.BatteryTemplateDropdownOption.Select();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'CogstateSolutionPlatform.AddBatteryPage.BatteryTemplateDropdown'.", repo.CogstateSolutionPlatform.AddBatteryPage.BatteryTemplateDropdownInfo, new RecordItemIndex(2));
            repo.CogstateSolutionPlatform.AddBatteryPage.BatteryTemplateDropdown.PressKeys("{Return}", 1);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
