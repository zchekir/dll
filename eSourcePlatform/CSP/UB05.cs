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

namespace CSP
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The UB05 recording.
    /// </summary>
    [TestModule("f9ab5a2f-0c8e-4cca-afa0-85f28bbf302a", ModuleType.Recording, 1)]
    public partial class UB05 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CSPRepository repository.
        /// </summary>
        public static CSPRepository repo = CSPRepository.Instance;

        static UB05 instance = new UB05();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UB05()
        {
            workflowID = "";
            DOM = "";
            workflowToken = "";
            Batteryid = "";
            rawdata = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UB05 Instance
        {
            get { return instance; }
        }

#region Variables

        string _workflowID;

        /// <summary>
        /// Gets or sets the value of variable workflowID.
        /// </summary>
        [TestVariable("ce09eeae-d878-4d48-a6d5-868e359132ef")]
        public string workflowID
        {
            get { return _workflowID; }
            set { _workflowID = value; }
        }

        string _DOM;

        /// <summary>
        /// Gets or sets the value of variable DOM.
        /// </summary>
        [TestVariable("d9f68ea1-4307-4ed8-8dcf-7a30276c7060")]
        public string DOM
        {
            get { return _DOM; }
            set { _DOM = value; }
        }

        string _workflowToken;

        /// <summary>
        /// Gets or sets the value of variable workflowToken.
        /// </summary>
        [TestVariable("6ff42131-c711-4337-94ac-32eb367575ab")]
        public string workflowToken
        {
            get { return _workflowToken; }
            set { _workflowToken = value; }
        }

        string _Batteryid;

        /// <summary>
        /// Gets or sets the value of variable Batteryid.
        /// </summary>
        [TestVariable("ae4ddde1-6c8b-4e91-96ac-69f24ea5e1ab")]
        public string Batteryid
        {
            get { return _Batteryid; }
            set { _Batteryid = value; }
        }

        string _rawdata;

        /// <summary>
        /// Gets or sets the value of variable rawdata.
        /// </summary>
        [TestVariable("f9068fca-50d3-4393-bf07-83d793b4b3c0")]
        public string rawdata
        {
            get { return _rawdata; }
            set { _rawdata = value; }
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

            UpdateBatteryFive(workflowID, DOM, workflowToken, Batteryid, rawdata);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
