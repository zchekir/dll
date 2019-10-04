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

namespace CSP.LoginPage
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Click_Login_Button recording.
    /// </summary>
    [TestModule("60274d1b-c799-4728-8bf9-1fda6a1fb342", ModuleType.Recording, 1)]
    public partial class Click_Login_Button : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::CSP.CSPRepository repository.
        /// </summary>
        public static global::CSP.CSPRepository repo = global::CSP.CSPRepository.Instance;

        static Click_Login_Button instance = new Click_Login_Button();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Click_Login_Button()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Click_Login_Button Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable CSPDOM.
        /// </summary>
        [TestVariable("f54fbb85-c5ac-4f6a-98d6-049472b68327")]
        public string CSPDOM
        {
            get { return repo.CSPDOM; }
            set { repo.CSPDOM = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s for the attribute 'State' to equal the specified value 'complete'. Associated repository item: 'CogstateSolutionPlatform'", repo.CogstateSolutionPlatform.SelfInfo, new RecordItemIndex(0));
            repo.CogstateSolutionPlatform.SelfInfo.WaitForAttributeEqual(15000, "State", "complete");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform.LoginForm.LoginButton' at Center.", repo.CogstateSolutionPlatform.LoginForm.LoginButtonInfo, new RecordItemIndex(1));
            repo.CogstateSolutionPlatform.LoginForm.LoginButton.Click(1);
            Delay.Milliseconds(90);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
