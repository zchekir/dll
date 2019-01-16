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

namespace RedCapCloud.InputModules.AddStudyPage
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Enter_BriefSummary recording.
    /// </summary>
    [TestModule("f8785a4e-ec14-4f14-a878-c63604520e51", ModuleType.Recording, 1)]
    public partial class Enter_BriefSummary : ITestModule
    {
        /// <summary>
        /// Holds an instance of the RedCapCloud.RedCapCloudRepository repository.
        /// </summary>
        public static RedCapCloud.RedCapCloudRepository repo = RedCapCloud.RedCapCloudRepository.Instance;

        static Enter_BriefSummary instance = new Enter_BriefSummary();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Enter_BriefSummary()
        {
            BriefSummary = "Ranorex";
            RandNum = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Enter_BriefSummary Instance
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
        /// Gets or sets the value of variable BriefSummary.
        /// </summary>
        [TestVariable("01efd426-2845-43ed-afa6-6952adeb66c1")]
        public string BriefSummary
        {
            get { return repo.BriefSummary; }
            set { repo.BriefSummary = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable RandNum.
        /// </summary>
        [TestVariable("3c2aee85-fa26-4c15-8b6a-212716f8f4a3")]
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'REDCapCloud.AddStudyPage.BriefSummaryField' at Center.", repo.REDCapCloud.AddStudyPage.BriefSummaryFieldInfo, new RecordItemIndex(0));
            repo.REDCapCloud.AddStudyPage.BriefSummaryField.Click(3);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$BriefSummary' with focus on 'REDCapCloud.AddStudyPage.BriefSummaryField'.", repo.REDCapCloud.AddStudyPage.BriefSummaryFieldInfo, new RecordItemIndex(1));
            repo.REDCapCloud.AddStudyPage.BriefSummaryField.PressKeys(BriefSummary, 1);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$RandNum' with focus on 'REDCapCloud.AddStudyPage.BriefSummaryField'.", repo.REDCapCloud.AddStudyPage.BriefSummaryFieldInfo, new RecordItemIndex(2));
            repo.REDCapCloud.AddStudyPage.BriefSummaryField.PressKeys(RandNum, 1);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (TagValue>$BriefSummary) on item 'REDCapCloud.AddStudyPage.BriefSummaryField'.", repo.REDCapCloud.AddStudyPage.BriefSummaryFieldInfo, new RecordItemIndex(3));
            Validate.AttributeContains(repo.REDCapCloud.AddStudyPage.BriefSummaryFieldInfo, "TagValue", BriefSummary);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (TagValue>$RandNum) on item 'REDCapCloud.AddStudyPage.BriefSummaryField'.", repo.REDCapCloud.AddStudyPage.BriefSummaryFieldInfo, new RecordItemIndex(4));
            Validate.AttributeContains(repo.REDCapCloud.AddStudyPage.BriefSummaryFieldInfo, "TagValue", RandNum);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
