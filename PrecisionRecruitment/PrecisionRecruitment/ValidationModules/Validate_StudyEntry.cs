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
    ///The Validate_StudyEntry recording.
    /// </summary>
    [TestModule("dcd3c857-708a-4094-9656-57f93b949ee6", ModuleType.Recording, 1)]
    public partial class Validate_StudyEntry : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PrecisionRecruitment.PrecisionRecruitmentRepository repository.
        /// </summary>
        public static PrecisionRecruitment.PrecisionRecruitmentRepository repo = PrecisionRecruitment.PrecisionRecruitmentRepository.Instance;

        static Validate_StudyEntry instance = new Validate_StudyEntry();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Validate_StudyEntry()
        {
            StudyName = "StudyName";
            RandNum = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Validate_StudyEntry Instance
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
        /// Gets or sets the value of variable StudyName.
        /// </summary>
        [TestVariable("038e5fe8-a13d-4e73-93f5-79db93c5397f")]
        public string StudyName
        {
            get { return repo.StudyName; }
            set { repo.StudyName = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable RandNum.
        /// </summary>
        [TestVariable("43bc76cc-bebe-4259-8d4a-b16ffcb116ed")]
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
            Mouse.DefaultMoveTime = 100;
            Keyboard.DefaultKeyPressTime = 10;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'CogstateSolutionPlatform.StudyNameBreadcrumb'", repo.CogstateSolutionPlatform.StudyNameBreadcrumbInfo, new ActionTimeout(10000), new RecordItemIndex(0));
            repo.CogstateSolutionPlatform.StudyNameBreadcrumbInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>$StudyName) on item 'CogstateSolutionPlatform.StudyNameBreadcrumb'.", repo.CogstateSolutionPlatform.StudyNameBreadcrumbInfo, new RecordItemIndex(1));
            Validate.AttributeContains(repo.CogstateSolutionPlatform.StudyNameBreadcrumbInfo, "InnerText", StudyName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>$RandNum) on item 'CogstateSolutionPlatform.StudyNameBreadcrumb'.", repo.CogstateSolutionPlatform.StudyNameBreadcrumbInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.CogstateSolutionPlatform.StudyNameBreadcrumbInfo, "InnerText", RandNum);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
