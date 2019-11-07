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

namespace DCT.RCC_Page
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The RCC_Password recording.
    /// </summary>
    [TestModule("f5564136-5579-4875-9ecc-f178163e418b", ModuleType.Recording, 1)]
    public partial class RCC_Password : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::DCT.DCTRepository repository.
        /// </summary>
        public static global::DCT.DCTRepository repo = global::DCT.DCTRepository.Instance;

        static RCC_Password instance = new RCC_Password();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RCC_Password()
        {
            RCCPassword = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RCC_Password Instance
        {
            get { return instance; }
        }

#region Variables

        string _RCCPassword;

        /// <summary>
        /// Gets or sets the value of variable RCCPassword.
        /// </summary>
        [TestVariable("26a6626b-d09c-44c8-8946-95e7238e575b")]
        public string RCCPassword
        {
            get { return _RCCPassword; }
            set { _RCCPassword = value; }
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1.5s.", new RecordItemIndex(0));
            Delay.Duration(1500, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{END}{SHIFT DOWN}{HOME}{SHIFT UP}{DELETE}' with focus on 'REDCapCloud.LoginPassword'.", repo.REDCapCloud.LoginPasswordInfo, new RecordItemIndex(1));
            repo.REDCapCloud.LoginPassword.PressKeys("{END}{SHIFT DOWN}{HOME}{SHIFT UP}{DELETE}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$RCCPassword' with focus on 'REDCapCloud.LoginPassword'.", repo.REDCapCloud.LoginPasswordInfo, new RecordItemIndex(2));
            repo.REDCapCloud.LoginPassword.PressKeys(RCCPassword);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{TAB}'.", new RecordItemIndex(3));
            Keyboard.Press("{TAB}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
