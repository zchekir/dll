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
    ///The GetNextStateWoklowID recording.
    /// </summary>
    [TestModule("860147ff-5413-4ab9-a595-bf35f0534b58", ModuleType.Recording, 1)]
    public partial class GetNextStateWoklowID : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CSPRepository repository.
        /// </summary>
        public static CSPRepository repo = CSPRepository.Instance;

        static GetNextStateWoklowID instance = new GetNextStateWoklowID();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public GetNextStateWoklowID()
        {
            CSPDOM = "";
            Token = "";
            StudyID = "";
            WorkflowID = "";
            BatteryID = "";
            JSONDATA = "";
            NextStateWorflowID = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static GetNextStateWoklowID Instance
        {
            get { return instance; }
        }

#region Variables

        string _Token;

        /// <summary>
        /// Gets or sets the value of variable Token.
        /// </summary>
        [TestVariable("812d8636-2835-40c2-8aee-e0b9acd30f02")]
        public string Token
        {
            get { return _Token; }
            set { _Token = value; }
        }

        string _StudyID;

        /// <summary>
        /// Gets or sets the value of variable StudyID.
        /// </summary>
        [TestVariable("51c6a724-af66-44de-a4b0-eb9f707a54e7")]
        public string StudyID
        {
            get { return _StudyID; }
            set { _StudyID = value; }
        }

        string _WorkflowID;

        /// <summary>
        /// Gets or sets the value of variable WorkflowID.
        /// </summary>
        [TestVariable("49f304bf-c2b2-40d2-80c4-ad15dfebf1d6")]
        public string WorkflowID
        {
            get { return _WorkflowID; }
            set { _WorkflowID = value; }
        }

        string _BatteryID;

        /// <summary>
        /// Gets or sets the value of variable BatteryID.
        /// </summary>
        [TestVariable("f3bf29fb-ab8a-4218-9654-d2e47c937426")]
        public string BatteryID
        {
            get { return _BatteryID; }
            set { _BatteryID = value; }
        }

        string _JSONDATA;

        /// <summary>
        /// Gets or sets the value of variable JSONDATA.
        /// </summary>
        [TestVariable("19e6c627-addb-48e2-b2b7-72473e7f9adf")]
        public string JSONDATA
        {
            get { return _JSONDATA; }
            set { _JSONDATA = value; }
        }

        string _NextStateWorflowID;

        /// <summary>
        /// Gets or sets the value of variable NextStateWorflowID.
        /// </summary>
        [TestVariable("1a72f90a-a63d-46cd-9d60-9c9bbbe23c6a")]
        public string NextStateWorflowID
        {
            get { return _NextStateWorflowID; }
            set { _NextStateWorflowID = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable CSPDOM.
        /// </summary>
        [TestVariable("736f7f70-8741-473d-9dbc-2114f17d0ebf")]
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

            NextStateWorkflowID(Token, StudyID, WorkflowID, BatteryID, JSONDATA, CSPDOM);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
