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

namespace RedCapCloudAndroid.SitesPage
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Enter_SiteID recording.
    /// </summary>
    [TestModule("74441d1d-a532-47f9-a3cd-9386bbb6bdb8", ModuleType.Recording, 1)]
    public partial class Enter_SiteID : ITestModule
    {
        /// <summary>
        /// Holds an instance of the RedCapCloudAndroid.RedCapCloudAndroidRepository repository.
        /// </summary>
        public static RedCapCloudAndroid.RedCapCloudAndroidRepository repo = RedCapCloudAndroid.RedCapCloudAndroidRepository.Instance;

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
        /// Gets or sets the value of variable RandNum.
        /// </summary>
        [TestVariable("ddedbcfe-570f-49d6-9b5d-ebe62856f763")]
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

            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$RandNum' on item 'RanorexBrowser.Dom.SitesPage.StudySiteIdField'.", repo.RanorexBrowser.Dom.SitesPage.StudySiteIdFieldInfo, new RecordItemIndex(0));
            repo.RanorexBrowser.Dom.SitesPage.StudySiteIdField.Element.SetAttributeValue("Value", RandNum);
            Delay.Milliseconds(0);
            
            HelperLibrary.TriggerChange("{SPACE}");
            Delay.Milliseconds(0);
            
            HelperLibrary.TriggerChange("{DEL}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
