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

namespace CSP.General
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Upload_RawData recording.
    /// </summary>
    [TestModule("366bcb1e-0676-491a-b683-f0b0918c5c82", ModuleType.Recording, 1)]
    public partial class Upload_RawData : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::CSP.CSPRepository repository.
        /// </summary>
        public static global::CSP.CSPRepository repo = global::CSP.CSPRepository.Instance;

        static Upload_RawData instance = new Upload_RawData();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Upload_RawData()
        {
            Filename = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Upload_RawData Instance
        {
            get { return instance; }
        }

#region Variables

        string _Filename;

        /// <summary>
        /// Gets or sets the value of variable Filename.
        /// </summary>
        [TestVariable("4b1cbab1-5c0f-4d05-9229-9a0d99841ed4")]
        public string Filename
        {
            get { return _Filename; }
            set { _Filename = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable CSPDOM.
        /// </summary>
        [TestVariable("f54fbb85-c5ac-4f6a-98d6-049472b68327")]
        public string CSPDOM
        {
            get { return repo.CSPDOM; }
            set { repo.CSPDOM = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'CogstateSolutionPlatform.WorkflowRunner.CanvasSpinner'", repo.CogstateSolutionPlatform.WorkflowRunner.CanvasSpinnerInfo, new ActionTimeout(30000), new RecordItemIndex(0));
            repo.CogstateSolutionPlatform.WorkflowRunner.CanvasSpinnerInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2m.", new RecordItemIndex(1));
            Delay.Duration(120000, false);
            
            AddRawData(Filename);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1m.", new RecordItemIndex(3));
            Delay.Duration(60000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform.WorkflowRunner.BatterySkipButton' at Center.", repo.CogstateSolutionPlatform.WorkflowRunner.BatterySkipButtonInfo, new RecordItemIndex(4));
            repo.CogstateSolutionPlatform.WorkflowRunner.BatterySkipButton.Click(100);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(5));
            Delay.Duration(500, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "Data Uploaded", repo.CogstateSolutionPlatform.Self, false, new RecordItemIndex(6));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
