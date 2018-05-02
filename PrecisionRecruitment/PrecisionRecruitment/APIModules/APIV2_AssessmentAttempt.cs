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

namespace PrecisionRecruitment.APIModules
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The APIV2_AssessmentAttempt recording.
    /// </summary>
    [TestModule("4a51a55e-772b-4944-828f-24a314e6b0ae", ModuleType.Recording, 1)]
    public partial class APIV2_AssessmentAttempt : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PrecisionRecruitment.PrecisionRecruitmentRepository repository.
        /// </summary>
        public static PrecisionRecruitment.PrecisionRecruitmentRepository repo = PrecisionRecruitment.PrecisionRecruitmentRepository.Instance;

        static APIV2_AssessmentAttempt instance = new APIV2_AssessmentAttempt();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public APIV2_AssessmentAttempt()
        {
            DOM = "";
            RandNum = "";
            VisitSessionCode = "RanVisitCode";
            ProtocolID = "Ranorex Protocol ID";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static APIV2_AssessmentAttempt Instance
        {
            get { return instance; }
        }

#region Variables

        string _VisitSessionCode;

        /// <summary>
        /// Gets or sets the value of variable VisitSessionCode.
        /// </summary>
        [TestVariable("a84760e4-9334-4e65-9802-55c4b29148f5")]
        public string VisitSessionCode
        {
            get { return _VisitSessionCode; }
            set { _VisitSessionCode = value; }
        }

        string _ProtocolID;

        /// <summary>
        /// Gets or sets the value of variable ProtocolID.
        /// </summary>
        [TestVariable("5f0211ea-1362-42e8-901b-6ec4e36f57d1")]
        public string ProtocolID
        {
            get { return _ProtocolID; }
            set { _ProtocolID = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable DOM.
        /// </summary>
        [TestVariable("288f411e-c76f-4619-8bb0-66a24d3754d2")]
        public string DOM
        {
            get { return repo.DOM; }
            set { repo.DOM = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable RandNum.
        /// </summary>
        [TestVariable("3e8cc784-9b0c-4dc8-82ad-e823e9823c2f")]
        public string RandNum
        {
            get { return repo.RandNum; }
            set { repo.RandNum = value; }
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

            engine.Helpers.WebService.CreateAssessmentAttempt(RandNum, DOM, RandNum, "1978-01-01", "M", "en-us", "Error", "Success", VisitSessionCode, ProtocolID);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
