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

namespace Cognigram_
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CognigramPDF recording.
    /// </summary>
    [TestModule("7d01d121-faf5-4983-a444-3b76588ce911", ModuleType.Recording, 1)]
    public partial class CognigramPDF : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Cognigram_Repository repository.
        /// </summary>
        public static Cognigram_Repository repo = Cognigram_Repository.Instance;

        static CognigramPDF instance = new CognigramPDF();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CognigramPDF()
        {
            DOM = "cshc-qc.azurewebsites.net";
            CognigramUserName = "zchekir@cogstate.com";
            CognigramPassword = "Mamine2014@@";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CognigramPDF Instance
        {
            get { return instance; }
        }

#region Variables

        string _CognigramUserName;

        /// <summary>
        /// Gets or sets the value of variable CognigramUserName.
        /// </summary>
        [TestVariable("6682788b-4d50-49d2-ba74-7a5278feb856")]
        public string CognigramUserName
        {
            get { return _CognigramUserName; }
            set { _CognigramUserName = value; }
        }

        string _CognigramPassword;

        /// <summary>
        /// Gets or sets the value of variable CognigramPassword.
        /// </summary>
        [TestVariable("8b60a7da-5b42-40b7-9301-e5ca2fa00385")]
        public string CognigramPassword
        {
            get { return _CognigramPassword; }
            set { _CognigramPassword = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable DOM.
        /// </summary>
        [TestVariable("9da4be33-5d30-4395-8707-2a1fa9e4ac43")]
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

            Report.Log(ReportLevel.Info, "Website", "Opening web site URL in variable $DOM with browser 'Chrome' in normal mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser(DOM, "Chrome", "", false, false, false, false, false, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 800ms.", new RecordItemIndex(1));
            Delay.Duration(800, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'COGNIGRAM.Loginbox.EnterUserName' at Center.", repo.COGNIGRAM.Loginbox.EnterUserNameInfo, new RecordItemIndex(2));
            repo.COGNIGRAM.Loginbox.EnterUserName.DoubleClick();
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'COGNIGRAM.Loginbox.EnterUserName' at Center.", repo.COGNIGRAM.Loginbox.EnterUserNameInfo, new RecordItemIndex(3));
            //repo.COGNIGRAM.Loginbox.EnterUserName.Click();
            //Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'COGNIGRAM.Loginbox.EnterUserName'.", repo.COGNIGRAM.Loginbox.EnterUserNameInfo, new RecordItemIndex(4));
            Keyboard.PrepareFocus(repo.COGNIGRAM.Loginbox.EnterUserName);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CognigramUserName' with focus on 'COGNIGRAM.Loginbox.EnterUserName'.", repo.COGNIGRAM.Loginbox.EnterUserNameInfo, new RecordItemIndex(5));
            repo.COGNIGRAM.Loginbox.EnterUserName.PressKeys(CognigramUserName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'COGNIGRAM.Loginbox.EntertPassword' at Center.", repo.COGNIGRAM.Loginbox.EntertPasswordInfo, new RecordItemIndex(6));
            repo.COGNIGRAM.Loginbox.EntertPassword.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'COGNIGRAM.Loginbox.EntertPassword'.", repo.COGNIGRAM.Loginbox.EntertPasswordInfo, new RecordItemIndex(7));
            Keyboard.PrepareFocus(repo.COGNIGRAM.Loginbox.EntertPassword);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CognigramPassword' with focus on 'COGNIGRAM.Loginbox.EntertPassword'.", repo.COGNIGRAM.Loginbox.EntertPasswordInfo, new RecordItemIndex(8));
            repo.COGNIGRAM.Loginbox.EntertPassword.PressKeys(CognigramPassword);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'COGNIGRAM.Loginbox.ClickSignIn' at Center.", repo.COGNIGRAM.Loginbox.ClickSignInInfo, new RecordItemIndex(9));
            repo.COGNIGRAM.Loginbox.ClickSignIn.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 800ms.", new RecordItemIndex(10));
            Delay.Duration(800, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
