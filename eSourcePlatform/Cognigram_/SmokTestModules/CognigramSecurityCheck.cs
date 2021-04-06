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

namespace Cognigram_.SmokTestModules
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CognigramEmailCheck recording.
    /// </summary>
    [TestModule("36dae8f8-a806-451b-97f6-6e97c29e3ac6", ModuleType.Recording, 1)]
    public partial class CognigramSecurityCheck : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Cognigram_.Cognigram_Repository repository.
        /// </summary>
        public static global::Cognigram_.Cognigram_Repository repo = global::Cognigram_.Cognigram_Repository.Instance;

        static CognigramSecurityCheck instance = new CognigramSecurityCheck();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CognigramSecurityCheck()
        {
            DOM = "cshc-qc.azurewebsites.net";
            Email = "";
            URL = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CognigramSecurityCheck Instance
        {
            get { return instance; }
        }

#region Variables

        string _Email;

        /// <summary>
        /// Gets or sets the value of variable Email.
        /// </summary>
        [TestVariable("3efe305b-a795-4278-bde1-99b6e9e933d9")]
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        string _URL;

        /// <summary>
        /// Gets or sets the value of variable URL.
        /// </summary>
        [TestVariable("48f8fc3c-4cfe-4f80-823b-39c97e2ddee0")]
        public string URL
        {
            get { return _URL; }
            set { _URL = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable DOM.
        /// </summary>
        [TestVariable("f7e40c99-5a25-4ca6-88bb-5dff7a4fdca7")]
        public string DOM
        {
            get { return repo.DOM; }
            set { repo.DOM = value; }
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

            Report.Log(ReportLevel.Info, "Website", "Opening web site URL in variable $URL with browser 'Chrome' in normal mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser(URL, "Chrome", "", false, false, false, true, false, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 900ms.", new RecordItemIndex(1));
            Delay.Duration(900, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'COGNIGRAM.Loginbox.ForgotPassword' at Center.", repo.COGNIGRAM.Loginbox.ForgotPasswordInfo, new RecordItemIndex(2));
            repo.COGNIGRAM.Loginbox.ForgotPassword.MoveTo();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(3));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'COGNIGRAM.Loginbox.ForgotPassword' at Center.", repo.COGNIGRAM.Loginbox.ForgotPasswordInfo, new RecordItemIndex(4));
            repo.COGNIGRAM.Loginbox.ForgotPassword.DoubleClick();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(5));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'COGNIGRAM.Loginbox.EnterEmail' at Center.", repo.COGNIGRAM.Loginbox.EnterEmailInfo, new RecordItemIndex(6));
            repo.COGNIGRAM.Loginbox.EnterEmail.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'COGNIGRAM.Loginbox.EnterEmail'.", repo.COGNIGRAM.Loginbox.EnterEmailInfo, new RecordItemIndex(7));
            Keyboard.PrepareFocus(repo.COGNIGRAM.Loginbox.EnterEmail);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Email' with focus on 'COGNIGRAM.Loginbox.EnterEmail'.", repo.COGNIGRAM.Loginbox.EnterEmailInfo, new RecordItemIndex(8));
            repo.COGNIGRAM.Loginbox.EnterEmail.PressKeys(Email);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'COGNIGRAM.Loginbox.ClickContinueButton' at Center.", repo.COGNIGRAM.Loginbox.ClickContinueButtonInfo, new RecordItemIndex(9));
            repo.COGNIGRAM.Loginbox.ClickContinueButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Application", "Killing application containing item 'COGNIGRAM'.", repo.COGNIGRAM.SelfInfo, new RecordItemIndex(10));
            Host.Current.KillApplication(repo.COGNIGRAM.Self);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1m.", new RecordItemIndex(11));
            Delay.Duration(60000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
