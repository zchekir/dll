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

namespace RedCapCloud.InputModules.LoginPage
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Click_Login_Button recording.
    /// </summary>
    [TestModule("a8e2f938-460b-4a0b-bfb0-e72acab1ecce", ModuleType.Recording, 1)]
    public partial class Click_Login_Button : ITestModule
    {
        /// <summary>
        /// Holds an instance of the RedCapCloud.RedCapCloudRepository repository.
        /// </summary>
        public static RedCapCloud.RedCapCloudRepository repo = RedCapCloud.RedCapCloudRepository.Instance;

        static Click_Login_Button instance = new Click_Login_Button();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Click_Login_Button()
        {
            Password = "913172@RCC{LShiftKey up}{Return}";
            username = "dwood@cogstate.com";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Click_Login_Button Instance
        {
            get { return instance; }
        }

#region Variables

        string _Password;

        /// <summary>
        /// Gets or sets the value of variable Password.
        /// </summary>
        [TestVariable("8b602917-63e3-4ce4-b628-77e249e49ff4")]
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        string _username;

        /// <summary>
        /// Gets or sets the value of variable username.
        /// </summary>
        [TestVariable("25c52c99-a552-4a8e-8fd0-6594ddb75a8c")]
        public string username
        {
            get { return _username; }
            set { _username = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'REDCapCloud.LoginPage.LoginButton' at Center.", repo.REDCapCloud.LoginPage.LoginButtonInfo, new RecordItemIndex(0));
            repo.REDCapCloud.LoginPage.LoginButton.Click(30);
            Delay.Milliseconds(470);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'REDCapCloud.MyStudiesTitle'.", repo.REDCapCloud.MyStudiesTitleInfo, new RecordItemIndex(1));
            Validate.Exists(repo.REDCapCloud.MyStudiesTitleInfo);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
