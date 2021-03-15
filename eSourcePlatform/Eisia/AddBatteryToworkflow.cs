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

namespace Eisia
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AddBatteryToworkflow recording.
    /// </summary>
    [TestModule("a2f72593-f076-4ff7-acd1-3a311fbcbb22", ModuleType.Recording, 1)]
    public partial class AddBatteryToworkflow : ITestModule
    {
        /// <summary>
        /// Holds an instance of the EisiaRepository repository.
        /// </summary>
        public static EisiaRepository repo = EisiaRepository.Instance;

        static AddBatteryToworkflow instance = new AddBatteryToworkflow();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddBatteryToworkflow()
        {
            StudyID = "";
            Token = "";
            WorkflowID = "";
            BatteryID = "";
            battryworkflowData = "";
            WorkflowBlockID = "";
            tabletConfigurationid = "";
            desktopConfigurationid = "";
            CPADOM = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddBatteryToworkflow Instance
        {
            get { return instance; }
        }

#region Variables

        string _StudyID;

        /// <summary>
        /// Gets or sets the value of variable StudyID.
        /// </summary>
        [TestVariable("54e7362d-f7ae-4b37-87d6-c9b04c646a8c")]
        public string StudyID
        {
            get { return _StudyID; }
            set { _StudyID = value; }
        }

        string _Token;

        /// <summary>
        /// Gets or sets the value of variable Token.
        /// </summary>
        [TestVariable("5cc232d4-f8b0-4831-b0db-09adcfada21e")]
        public string Token
        {
            get { return _Token; }
            set { _Token = value; }
        }

        string _WorkflowID;

        /// <summary>
        /// Gets or sets the value of variable WorkflowID.
        /// </summary>
        [TestVariable("d6916ec0-a981-4a2d-9e9c-d960b867bb18")]
        public string WorkflowID
        {
            get { return _WorkflowID; }
            set { _WorkflowID = value; }
        }

        string _BatteryID;

        /// <summary>
        /// Gets or sets the value of variable BatteryID.
        /// </summary>
        [TestVariable("f2a9c7a9-9eef-400f-bb69-94e39e07ebd1")]
        public string BatteryID
        {
            get { return _BatteryID; }
            set { _BatteryID = value; }
        }

        string _battryworkflowData;

        /// <summary>
        /// Gets or sets the value of variable battryworkflowData.
        /// </summary>
        [TestVariable("d6821b3a-dc57-48f5-843b-ae5b05532ab3")]
        public string battryworkflowData
        {
            get { return _battryworkflowData; }
            set { _battryworkflowData = value; }
        }

        string _WorkflowBlockID;

        /// <summary>
        /// Gets or sets the value of variable WorkflowBlockID.
        /// </summary>
        [TestVariable("4f11f28a-19e9-41a2-bfa1-6ae876883f32")]
        public string WorkflowBlockID
        {
            get { return _WorkflowBlockID; }
            set { _WorkflowBlockID = value; }
        }

        string _tabletConfigurationid;

        /// <summary>
        /// Gets or sets the value of variable tabletConfigurationid.
        /// </summary>
        [TestVariable("016609bc-a8e9-441f-8605-40fc7c7ee9e7")]
        public string tabletConfigurationid
        {
            get { return _tabletConfigurationid; }
            set { _tabletConfigurationid = value; }
        }

        string _desktopConfigurationid;

        /// <summary>
        /// Gets or sets the value of variable desktopConfigurationid.
        /// </summary>
        [TestVariable("4f392ac8-de08-4491-aa3c-747acfffb01f")]
        public string desktopConfigurationid
        {
            get { return _desktopConfigurationid; }
            set { _desktopConfigurationid = value; }
        }

        string _CPADOM;

        /// <summary>
        /// Gets or sets the value of variable CPADOM.
        /// </summary>
        [TestVariable("e43f1de6-b235-4bc5-9a5f-0db403946a32")]
        public string CPADOM
        {
            get { return _CPADOM; }
            set { _CPADOM = value; }
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

            AddBatterytoWoekflow(StudyID, Token, WorkflowID, BatteryID, battryworkflowData, WorkflowBlockID, tabletConfigurationid, desktopConfigurationid);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
