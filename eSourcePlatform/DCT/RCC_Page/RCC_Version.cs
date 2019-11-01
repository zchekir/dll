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
    ///The RCC_Version recording.
    /// </summary>
    [TestModule("9aa4db57-0c36-48f5-b0e4-034541eb1b12", ModuleType.Recording, 1)]
    public partial class RCC_Version : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::DCT.DCTRepository repository.
        /// </summary>
        public static global::DCT.DCTRepository repo = global::DCT.DCTRepository.Instance;

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

        /// <summary>
        /// Gets or sets the value of variable AzureDOM.
        /// </summary>
        [TestVariable("49e5b85f-1ec2-4934-a251-0656cf1bbe62")]
        public string AzureDOM
        {
            get { return repo.AzureDOM; }
            set { repo.AzureDOM = value; }
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

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'KuduServices.PowerShallConsol' at Center.", repo.KuduServices.PowerShallConsolInfo, new RecordItemIndex(0));
            //repo.KuduServices.PowerShallConsol.Click();
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$RCCVersionQuery_' with focus on 'KuduServices.PowerShallConsol'.", repo.KuduServices.PowerShallConsolInfo, new RecordItemIndex(1));
            //repo.KuduServices.PowerShallConsol.PressKeys(RCCVersionQuery_);
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(2));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'KuduServices.rcc_hubPowerShall' at Center.", repo.KuduServices.rcc_hubPowerShallInfo, new RecordItemIndex(3));
            repo.KuduServices.rcc_hubPowerShall.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$RCCVersionQuery_' with focus on 'KuduServices.rcc_hubPowerShall'.", repo.KuduServices.rcc_hubPowerShallInfo, new RecordItemIndex(4));
            repo.KuduServices.rcc_hubPowerShall.PressKeys(RCCVersionQuery_);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{ENTER}'.", new RecordItemIndex(5));
            Keyboard.Press("{ENTER}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(6));
            Delay.Duration(5000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
