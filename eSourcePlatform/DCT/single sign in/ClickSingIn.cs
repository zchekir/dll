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
    ///The ClickSingIn recording.
    /// </summary>
    [TestModule("13255c7b-53f1-48b6-ba90-de7e89b3af9d", ModuleType.Recording, 1)]
    public partial class ClickSingIn : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::DCT.DCTRepository repository.
        /// </summary>
        public static global::DCT.DCTRepository repo = global::DCT.DCTRepository.Instance;

        static ClickSingIn instance = new ClickSingIn();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ClickSingIn()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ClickSingIn Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'REDCapCloud.LoginApplyButton' at Center.", repo.REDCapCloud.LoginApplyButtonInfo, new RecordItemIndex(0));
            repo.REDCapCloud.LoginApplyButton.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
