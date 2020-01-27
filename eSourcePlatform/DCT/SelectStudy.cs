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

namespace DCT
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SelectStudy recording.
    /// </summary>
    [TestModule("e9c0ac00-3de7-4009-828c-ea03cc80ff53", ModuleType.Recording, 1)]
    public partial class SelectStudy : ITestModule
    {
        /// <summary>
        /// Holds an instance of the DCTRepository repository.
        /// </summary>
        public static DCTRepository repo = DCTRepository.Instance;

        static SelectStudy instance = new SelectStudy();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectStudy()
        {
            StudyName = "AutomationStudy";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SelectStudy Instance
        {
            get { return instance; }
        }

#region Variables

        string _StudyName;

        /// <summary>
        /// Gets or sets the value of variable StudyName.
        /// </summary>
        [TestVariable("f181992b-5848-45bd-b7b4-c20790faddb3")]
        public string StudyName
        {
            get { return _StudyName; }
            set { _StudyName = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DataCleaningTool1.SelectStudy' at Center.", repo.DataCleaningTool1.SelectStudyInfo, new RecordItemIndex(0));
            repo.DataCleaningTool1.SelectStudy.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$StudyName' with focus on 'DataCleaningTool1.SelectStudy'.", repo.DataCleaningTool1.SelectStudyInfo, new RecordItemIndex(1));
            repo.DataCleaningTool1.SelectStudy.PressKeys(StudyName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(2));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{TAB}'.", new RecordItemIndex(3));
            Keyboard.Press("{TAB}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
