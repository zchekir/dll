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

namespace PrecisionRecruitment.InputModules
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Enter_BatteryDescription recording.
    /// </summary>
    [TestModule("2d955e0d-66b6-44f7-997e-8b5e6d4de1a2", ModuleType.Recording, 1)]
    public partial class Enter_BatteryDescription : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PrecisionRecruitment.PrecisionRecruitmentRepository repository.
        /// </summary>
        public static PrecisionRecruitment.PrecisionRecruitmentRepository repo = PrecisionRecruitment.PrecisionRecruitmentRepository.Instance;

        static Enter_BatteryDescription instance = new Enter_BatteryDescription();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Enter_BatteryDescription()
        {
            BatteryDescription = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Enter_BatteryDescription Instance
        {
            get { return instance; }
        }

#region Variables

        string _BatteryDescription;

        /// <summary>
        /// Gets or sets the value of variable BatteryDescription.
        /// </summary>
        [TestVariable("409b2d92-92f5-4b9b-898e-d2d04aaba500")]
        public string BatteryDescription
        {
            get { return _BatteryDescription; }
            set { _BatteryDescription = value; }
        }

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform.AddBatteryPage.BatteryDescriptionField' at Center.", repo.CogstateSolutionPlatform.AddBatteryPage.BatteryDescriptionFieldInfo, new RecordItemIndex(0));
            repo.CogstateSolutionPlatform.AddBatteryPage.BatteryDescriptionField.Click(300);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{End}{LShiftKey down}{Home}{LShiftKey up}{Delete}' with focus on 'CogstateSolutionPlatform.AddBatteryPage.BatteryDescriptionField'.", repo.CogstateSolutionPlatform.AddBatteryPage.BatteryDescriptionFieldInfo, new RecordItemIndex(1));
            repo.CogstateSolutionPlatform.AddBatteryPage.BatteryDescriptionField.PressKeys("{End}{LShiftKey down}{Home}{LShiftKey up}{Delete}");
            Delay.Milliseconds(50);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$BatteryDescription' with focus on 'CogstateSolutionPlatform.AddBatteryPage.BatteryDescriptionField'.", repo.CogstateSolutionPlatform.AddBatteryPage.BatteryDescriptionFieldInfo, new RecordItemIndex(2));
            repo.CogstateSolutionPlatform.AddBatteryPage.BatteryDescriptionField.PressKeys(BatteryDescription);
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$BatteryDescription) on item 'CogstateSolutionPlatform.AddBatteryPage.BatteryDescriptionField'.", repo.CogstateSolutionPlatform.AddBatteryPage.BatteryDescriptionFieldInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.CogstateSolutionPlatform.AddBatteryPage.BatteryDescriptionFieldInfo, "TagValue", BatteryDescription);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
