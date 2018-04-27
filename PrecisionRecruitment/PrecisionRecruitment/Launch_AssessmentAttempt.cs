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

namespace PrecisionRecruitment
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Launch_AssessmentAttempt recording.
    /// </summary>
    [TestModule("4cf38574-50a6-4296-8017-6f3285aac388", ModuleType.Recording, 1)]
    public partial class Launch_AssessmentAttempt : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PrecisionRecruitmentRepository repository.
        /// </summary>
        public static PrecisionRecruitmentRepository repo = PrecisionRecruitmentRepository.Instance;

        static Launch_AssessmentAttempt instance = new Launch_AssessmentAttempt();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Launch_AssessmentAttempt()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Launch_AssessmentAttempt Instance
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
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            engine.Helpers.WebService.LaunchAssessment();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", "Waiting for Assets to load", new RecordItemIndex(1));
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'CogstateSolutionPlatform.BatteryLoadingBar'", repo.CogstateSolutionPlatform.BatteryLoadingBarInfo, new ActionTimeout(30000), new RecordItemIndex(2));
            repo.CogstateSolutionPlatform.BatteryLoadingBarInfo.WaitForNotExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
