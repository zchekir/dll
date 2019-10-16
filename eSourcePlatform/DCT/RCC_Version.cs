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

namespace DCT
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The RCC_Version recording.
    /// </summary>
    [TestModule("9aa4db57-0c36-48f5-b0e4-034541eb1b12", ModuleType.Recording, 1)]
    public partial class RCC_Version : ITestModule
    {
        /// <summary>
        /// Holds an instance of the DCTRepository repository.
        /// </summary>
        public static DCTRepository repo = DCTRepository.Instance;

        static RCC_Version instance = new RCC_Version();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RCC_Version()
        {
            RCCVersionQuery_ = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RCC_Version Instance
        {
            get { return instance; }
        }

#region Variables

        string _RCCVersionQuery_;

        /// <summary>
        /// Gets or sets the value of variable RCCVersionQuery_.
        /// </summary>
        [TestVariable("b1c7a023-5abd-4a21-8861-19c0f0ab012c")]
        public string RCCVersionQuery_
        {
            get { return _RCCVersionQuery_; }
            set { _RCCVersionQuery_ = value; }
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 4s.", new RecordItemIndex(0));
            Delay.Duration(4000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'KuduServices.PowerShallConsol' at Center.", repo.KuduServices.PowerShallConsolInfo, new RecordItemIndex(1));
            repo.KuduServices.PowerShallConsol.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$RCCVersionQuery_' with focus on 'KuduServices.PowerShallConsol'.", repo.KuduServices.PowerShallConsolInfo, new RecordItemIndex(2));
            repo.KuduServices.PowerShallConsol.PressKeys(RCCVersionQuery_);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{ENTER}'.", new RecordItemIndex(3));
            Keyboard.Press("{ENTER}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(4));
            Delay.Duration(500, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
