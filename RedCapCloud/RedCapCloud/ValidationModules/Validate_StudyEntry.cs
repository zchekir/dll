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

namespace RedCapCloud.ValidationModules
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Validate_StudyEntry recording.
    /// </summary>
    [TestModule("04a3f2ed-a8f4-4380-ba5a-1b2097e3e934", ModuleType.Recording, 1)]
    public partial class Validate_StudyEntry : ITestModule
    {
        /// <summary>
        /// Holds an instance of the RedCapCloud.RedCapCloudRepository repository.
        /// </summary>
        public static RedCapCloud.RedCapCloudRepository repo = RedCapCloud.RedCapCloudRepository.Instance;

        static Validate_StudyEntry instance = new Validate_StudyEntry();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Validate_StudyEntry()
        {
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
        [TestVariable("6f24cf1a-0e47-4c45-9ce6-3e042db234d2")]
        public string DOM
        {
            get { return repo.DOM; }
            set { repo.DOM = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable StudyName.
        /// </summary>
        [TestVariable("9fb53a7d-2a6f-47b3-8fa5-4d13a07e1b86")]
        public string StudyName
        {
            get { return repo.StudyName; }
            set { repo.StudyName = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable BriefSummary.
        /// </summary>
        [TestVariable("dd613b9d-9d3e-4771-a417-716ec481c2da")]
        public string BriefSummary
        {
            get { return repo.BriefSummary; }
            set { repo.BriefSummary = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable RandNum.
        /// </summary>
        [TestVariable("141d2d08-a488-48d4-921a-cad49dfd869f")]
        public string RandNum
        {
            get { return repo.RandNum; }
            set { repo.RandNum = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'REDCapCloud.StudiesTable.StudyName'.", repo.REDCapCloud.StudiesTable.StudyNameInfo, new RecordItemIndex(0));
            Validate.Exists(repo.REDCapCloud.StudiesTable.StudyNameInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>$RandNum) on item 'REDCapCloud.StudiesTable.StudyName'.", repo.REDCapCloud.StudiesTable.StudyNameInfo, new RecordItemIndex(1));
            Validate.AttributeContains(repo.REDCapCloud.StudiesTable.StudyNameInfo, "InnerText", RandNum);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'REDCapCloud.StudiesTable.StudyCategory'.", repo.REDCapCloud.StudiesTable.StudyCategoryInfo, new RecordItemIndex(2));
            Validate.Exists(repo.REDCapCloud.StudiesTable.StudyCategoryInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'REDCapCloud.StudiesTable.StudySummary'.", repo.REDCapCloud.StudiesTable.StudySummaryInfo, new RecordItemIndex(3));
            Validate.Exists(repo.REDCapCloud.StudiesTable.StudySummaryInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>$RandNum) on item 'REDCapCloud.StudiesTable.StudySummary'.", repo.REDCapCloud.StudiesTable.StudySummaryInfo, new RecordItemIndex(4));
            Validate.AttributeContains(repo.REDCapCloud.StudiesTable.StudySummaryInfo, "InnerText", RandNum);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "Study Added Successfully", repo.REDCapCloud.Self, false, new RecordItemIndex(5));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
