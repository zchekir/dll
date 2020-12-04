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

namespace RedCapCloud.UsersPage
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Add_IntegrationUser_API_Key recording.
    /// </summary>
    [TestModule("99e3a789-7644-424b-a824-b5f2b74280fa", ModuleType.Recording, 1)]
    public partial class Add_IntegrationUser_API_Key : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::RedCapCloud.RedCapCloudRepository repository.
        /// </summary>
        public static global::RedCapCloud.RedCapCloudRepository repo = global::RedCapCloud.RedCapCloudRepository.Instance;

        static Add_IntegrationUser_API_Key instance = new Add_IntegrationUser_API_Key();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Add_IntegrationUser_API_Key()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Add_IntegrationUser_API_Key Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable RCCDOM.
        /// </summary>
        [TestVariable("6f24cf1a-0e47-4c45-9ce6-3e042db234d2")]
        public string RCCDOM
        {
            get { return repo.RCCDOM; }
            set { repo.RCCDOM = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'REDCapCloud.UsersPage.AddAPIKeyButton' at Center.", repo.REDCapCloud.UsersPage.AddAPIKeyButtonInfo, new RecordItemIndex(0));
            repo.REDCapCloud.UsersPage.AddAPIKeyButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'REDCapCloud.UsersPage.APIExportCheckbox' at Center.", repo.REDCapCloud.UsersPage.APIExportCheckboxInfo, new RecordItemIndex(1));
            repo.REDCapCloud.UsersPage.APIExportCheckbox.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'REDCapCloud.UsersPage.APIImportCheckbox' at Center.", repo.REDCapCloud.UsersPage.APIImportCheckboxInfo, new RecordItemIndex(2));
            repo.REDCapCloud.UsersPage.APIImportCheckbox.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'REDCapCloud.UsersPage.APISaveAndExit' at Center.", repo.REDCapCloud.UsersPage.APISaveAndExitInfo, new RecordItemIndex(3));
            repo.REDCapCloud.UsersPage.APISaveAndExit.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
