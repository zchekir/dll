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
    ///The Enter_SiteID recording.
    /// </summary>
    [TestModule("9f216037-4a92-4e9e-ac53-cd9ce20eca4e", ModuleType.Recording, 1)]
    public partial class Enter_SiteID : ITestModule
    {
        /// <summary>
        /// Holds an instance of the RedCapCloud.RedCapCloudRepository repository.
        /// </summary>
        public static RedCapCloud.RedCapCloudRepository repo = RedCapCloud.RedCapCloudRepository.Instance;

        static Enter_SiteID instance = new Enter_SiteID();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Enter_SiteID()
        {
            RandNum = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Enter_SiteID Instance
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
        /// Gets or sets the value of variable RandNum.
        /// </summary>
        [TestVariable("07826f20-20b1-4c0b-849d-cea11012c111")]
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'REDCapCloud.AddSitePage.StudySiteSiteId' at Center.", repo.REDCapCloud.AddSitePage.StudySiteSiteIdInfo, new RecordItemIndex(0));
            repo.REDCapCloud.AddSitePage.StudySiteSiteId.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{End}{LShiftKey down}{Home}{LShiftKey up}{Delete}' with focus on 'REDCapCloud.AddSitePage.StudySiteSiteId'.", repo.REDCapCloud.AddSitePage.StudySiteSiteIdInfo, new RecordItemIndex(1));
            repo.REDCapCloud.AddSitePage.StudySiteSiteId.PressKeys("{End}{LShiftKey down}{Home}{LShiftKey up}{Delete}", 100);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$RandNum' with focus on 'REDCapCloud.AddSitePage.StudySiteSiteId'.", repo.REDCapCloud.AddSitePage.StudySiteSiteIdInfo, new RecordItemIndex(2));
            repo.REDCapCloud.AddSitePage.StudySiteSiteId.PressKeys(RandNum, 100);
            Delay.Milliseconds(10);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value=$RandNum) on item 'REDCapCloud.AddSitePage.StudySiteSiteId'.", repo.REDCapCloud.AddSitePage.StudySiteSiteIdInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.REDCapCloud.AddSitePage.StudySiteSiteIdInfo, "Value", RandNum);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
