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

namespace eSourcePlatform
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Username recording.
    /// </summary>
    [TestModule("4770ec4d-ff94-4fca-a4dd-391039e85292", ModuleType.Recording, 1)]
    public partial class Username : ITestModule
    {
        /// <summary>
        /// Holds an instance of the eSourcePlatformRepository repository.
        /// </summary>
        public static eSourcePlatformRepository repo = eSourcePlatformRepository.Instance;

        static Username instance = new Username();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Username()
        {
            CSPUsername = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Username Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable CSPUsername.
        /// </summary>
        [TestVariable("183e9531-6771-4da6-b401-fd43895a2255")]
        public string CSPUsername
        {
            get { return repo.CSPUsername; }
            set { repo.CSPUsername = value; }
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(0));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform1.LoginEmail' at Center.", repo.CogstateSolutionPlatform1.LoginEmailInfo, new RecordItemIndex(1));
            repo.CogstateSolutionPlatform1.LoginEmail.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{END}{SHIFT DOWN}{HOME}{SHIFT UP}{DELETE}'.", new RecordItemIndex(2));
            Keyboard.Press("{END}{SHIFT DOWN}{HOME}{SHIFT UP}{DELETE}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(3));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CSPUsername' with focus on 'CogstateSolutionPlatform1.LoginEmail'.", repo.CogstateSolutionPlatform1.LoginEmailInfo, new RecordItemIndex(4));
            repo.CogstateSolutionPlatform1.LoginEmail.PressKeys(CSPUsername);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CSPUsername' with focus on 'CogstateSolutionPlatform1.LoginEmail'.", repo.CogstateSolutionPlatform1.LoginEmailInfo, new RecordItemIndex(5));
            //repo.CogstateSolutionPlatform1.LoginEmail.PressKeys(CSPUsername);
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{ENTER}'.", new RecordItemIndex(6));
            Keyboard.Press("{ENTER}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
