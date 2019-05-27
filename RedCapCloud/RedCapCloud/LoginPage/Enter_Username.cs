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

namespace RedCapCloud.LoginPage
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Enter_Username recording.
    /// </summary>
    [TestModule("e508381d-293b-4818-ab9c-d4393b14b647", ModuleType.Recording, 1)]
    public partial class Enter_Username : ITestModule
    {
        /// <summary>
        /// Holds an instance of the RedCapCloud.RedCapCloudRepository repository.
        /// </summary>
        public static RedCapCloud.RedCapCloudRepository repo = RedCapCloud.RedCapCloudRepository.Instance;

        static Enter_Username instance = new Enter_Username();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Enter_Username()
        {
            Username = "dwood@cogstate.com";
            DOM = "cgsqc.redcapcloud.com";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Enter_Username Instance
        {
            get { return instance; }
        }

#region Variables

        string _Username;

        /// <summary>
        /// Gets or sets the value of variable Username.
        /// </summary>
        [TestVariable("6f1c465c-9a9b-427e-8e79-df300403992d")]
        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'REDCapCloud.LoginPage.LoginUsername' at Center.", repo.REDCapCloud.LoginPage.LoginUsernameInfo, new RecordItemIndex(0));
            repo.REDCapCloud.LoginPage.LoginUsername.Click(3);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(1));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Home}{LShiftKey down}{End}{LShiftKey up}{Delete}' with focus on 'REDCapCloud.LoginPage.LoginUsername'.", repo.REDCapCloud.LoginPage.LoginUsernameInfo, new RecordItemIndex(2));
            repo.REDCapCloud.LoginPage.LoginUsername.PressKeys("{Home}{LShiftKey down}{End}{LShiftKey up}{Delete}", 1);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Username' with focus on 'REDCapCloud.LoginPage.LoginUsername'.", repo.REDCapCloud.LoginPage.LoginUsernameInfo, new RecordItemIndex(3));
            repo.REDCapCloud.LoginPage.LoginUsername.PressKeys(Username, 1);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value=$Username) on item 'REDCapCloud.LoginPage.LoginUsername'.", repo.REDCapCloud.LoginPage.LoginUsernameInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.REDCapCloud.LoginPage.LoginUsernameInfo, "Value", Username);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'REDCapCloud.LoginPage.LoginUsername'.", repo.REDCapCloud.LoginPage.LoginUsernameInfo, new RecordItemIndex(5));
            repo.REDCapCloud.LoginPage.LoginUsername.PressKeys("{Tab}", 1);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'REDCapCloud.LoginPage.LoginButton' at Center.", repo.REDCapCloud.LoginPage.LoginButtonInfo, new RecordItemIndex(6));
            repo.REDCapCloud.LoginPage.LoginButton.Click(3);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(7));
            Delay.Duration(1000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
