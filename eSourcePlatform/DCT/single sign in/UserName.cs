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

namespace DCT.single_sign_in
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The UserName recording.
    /// </summary>
    [TestModule("133e5a1c-f5f6-4b01-a455-fc038cc1133d", ModuleType.Recording, 1)]
    public partial class UserName : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::DCT.DCTRepository repository.
        /// </summary>
        public static global::DCT.DCTRepository repo = global::DCT.DCTRepository.Instance;

        static UserName instance = new UserName();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UserName()
        {
            RCCUsername = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UserName Instance
        {
            get { return instance; }
        }

#region Variables

        string _RCCUsername;

        /// <summary>
        /// Gets or sets the value of variable RCCUsername.
        /// </summary>
        [TestVariable("7aae9b89-6ea3-4934-9b7b-2481c9851e50")]
        public string RCCUsername
        {
            get { return _RCCUsername; }
            set { _RCCUsername = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable RCCDOM.
        /// </summary>
        [TestVariable("5a760c9f-9fed-4f01-8c4c-f1cd491cbeda")]
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(0));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{END}{SHIFT DOWN}{HOME}{SHIFT UP}{DELETE}' with focus on 'REDCapCloud.LoginUsername'.", repo.REDCapCloud.LoginUsernameInfo, new RecordItemIndex(1));
            repo.REDCapCloud.LoginUsername.PressKeys("{END}{SHIFT DOWN}{HOME}{SHIFT UP}{DELETE}");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$RCCUsername' with focus on 'REDCapCloudGoogleChrome.RCC_Username'.", repo.REDCapCloudGoogleChrome.RCC_UsernameInfo, new RecordItemIndex(2));
            //repo.REDCapCloudGoogleChrome.RCC_Username.PressKeys(RCCUsername);
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$RCCUsername' with focus on 'REDCapCloud.LoginUsername'.", repo.REDCapCloud.LoginUsernameInfo, new RecordItemIndex(3));
            repo.REDCapCloud.LoginUsername.PressKeys(RCCUsername);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
