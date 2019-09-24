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
    ///The Launch_AssessmentAttempt recording.
    /// </summary>
    [TestModule("4cf38574-50a6-4296-8017-6f3285aac388", ModuleType.Recording, 1)]
    public partial class Launch_AssessmentAttempt : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::CSP.CSPRepository repository.
        /// </summary>
        public static global::CSP.CSPRepository repo = global::CSP.CSPRepository.Instance;

        static Launch_AssessmentAttempt instance = new Launch_AssessmentAttempt();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Launch_AssessmentAttempt()
        {
            Browser = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Launch_AssessmentAttempt Instance
        {
            get { return instance; }
        }

#region Variables

        string _Browser;

        /// <summary>
        /// Gets or sets the value of variable Browser.
        /// </summary>
        [TestVariable("81704e14-17b3-497c-918b-6ed0d27d5881")]
        public string Browser
        {
            get { return _Browser; }
            set { _Browser = value; }
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

            engine.Helpers.WebService.LaunchAssessment(Browser);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", "Waiting for Assets to load", new RecordItemIndex(1));
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'CogstateSolutionPlatform.WorkflowRunner.StartInstructions'", repo.CogstateSolutionPlatform.WorkflowRunner.StartInstructionsInfo, new ActionTimeout(30000), new RecordItemIndex(2));
            repo.CogstateSolutionPlatform.WorkflowRunner.StartInstructionsInfo.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
