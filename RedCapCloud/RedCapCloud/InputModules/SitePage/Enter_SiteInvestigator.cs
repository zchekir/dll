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

namespace RedCapCloud.InputModules.SitePage
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Enter_SiteInvestigator recording.
    /// </summary>
    [TestModule("ce122304-990d-4f47-b11b-bc20b49860b7", ModuleType.Recording, 1)]
    public partial class Enter_SiteInvestigator : ITestModule
    {
        /// <summary>
        /// Holds an instance of the RedCapCloud.RedCapCloudRepository repository.
        /// </summary>
        public static RedCapCloud.RedCapCloudRepository repo = RedCapCloud.RedCapCloudRepository.Instance;

        static Enter_SiteInvestigator instance = new Enter_SiteInvestigator();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Enter_SiteInvestigator()
        {
            SiteInvestigator = "Cogstate";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Enter_SiteInvestigator Instance
        {
            get { return instance; }
        }

#region Variables

        string _SiteInvestigator;

        /// <summary>
        /// Gets or sets the value of variable SiteInvestigator.
        /// </summary>
        [TestVariable("d934abc0-32ca-4744-aa04-8c7f1cfa6fb9")]
        public string SiteInvestigator
        {
            get { return _SiteInvestigator; }
            set { _SiteInvestigator = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable DOM.
        /// </summary>
        [TestVariable("6f24cf1a-0e47-4c45-9ce6-3e042db234d2")]
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'REDCapCloud.AddSitePage.StudySiteInvestigator' at 59;11.", repo.REDCapCloud.AddSitePage.StudySiteInvestigatorInfo, new RecordItemIndex(0));
            repo.REDCapCloud.AddSitePage.StudySiteInvestigator.Click("59;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{End}{LShiftKey down}{Home}{LShiftKey up}{Delete}' with focus on 'REDCapCloud.AddSitePage.StudySiteInvestigator'.", repo.REDCapCloud.AddSitePage.StudySiteInvestigatorInfo, new RecordItemIndex(1));
            repo.REDCapCloud.AddSitePage.StudySiteInvestigator.PressKeys("{End}{LShiftKey down}{Home}{LShiftKey up}{Delete}", 100);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$SiteInvestigator' with focus on 'REDCapCloud.AddSitePage.StudySiteInvestigator'.", repo.REDCapCloud.AddSitePage.StudySiteInvestigatorInfo, new RecordItemIndex(2));
            repo.REDCapCloud.AddSitePage.StudySiteInvestigator.PressKeys(SiteInvestigator, 100);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value=$SiteInvestigator) on item 'REDCapCloud.AddSitePage.StudySiteInvestigator'.", repo.REDCapCloud.AddSitePage.StudySiteInvestigatorInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.REDCapCloud.AddSitePage.StudySiteInvestigatorInfo, "Value", SiteInvestigator);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
