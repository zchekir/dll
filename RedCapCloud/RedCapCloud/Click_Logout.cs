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

namespace RedCapCloud
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Click_Logout recording.
    /// </summary>
    [TestModule("82c513c0-bd23-4fbe-a34f-2907c8524d40", ModuleType.Recording, 1)]
    public partial class Click_Logout : ITestModule
    {
        /// <summary>
        /// Holds an instance of the RedCapCloudRepository repository.
        /// </summary>
        public static RedCapCloudRepository repo = RedCapCloudRepository.Instance;

        static Click_Logout instance = new Click_Logout();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Click_Logout()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Click_Logout Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'REDCapCloud.UserSettingsMenu' at Center.", repo.REDCapCloud.UserSettingsMenuInfo, new RecordItemIndex(0));
            repo.REDCapCloud.UserSettingsMenu.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'REDCapCloud.LogoutButton' at Center.", repo.REDCapCloud.LogoutButtonInfo, new RecordItemIndex(1));
            repo.REDCapCloud.LogoutButton.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
