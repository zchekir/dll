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

namespace PrecisionRecruitment.ValidationModules
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Validate_Min_WorkflowDescription recording.
    /// </summary>
    [TestModule("fa1de2c1-27ec-4204-8909-3ece44c420bc", ModuleType.Recording, 1)]
    public partial class Validate_Min_WorkflowDescription : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PrecisionRecruitment.PrecisionRecruitmentRepository repository.
        /// </summary>
        public static PrecisionRecruitment.PrecisionRecruitmentRepository repo = PrecisionRecruitment.PrecisionRecruitmentRepository.Instance;

        static Validate_Min_WorkflowDescription instance = new Validate_Min_WorkflowDescription();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Validate_Min_WorkflowDescription()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Validate_Min_WorkflowDescription Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CogstateSolutionPlatform.AddWorkflowPage.WorkflowDescriptionMinLength'.", repo.CogstateSolutionPlatform.AddWorkflowPage.WorkflowDescriptionMinLengthInfo, new RecordItemIndex(0));
            Validate.Exists(repo.CogstateSolutionPlatform.AddWorkflowPage.WorkflowDescriptionMinLengthInfo);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
