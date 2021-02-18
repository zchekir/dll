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
    ///The NewComletetionSteps recording.
    /// </summary>
    [TestModule("f33785c3-0125-4630-b0d0-c87fd89a5705", ModuleType.Recording, 1)]
    public partial class NewComletetionSteps : ITestModule
    {
        /// <summary>
        /// Holds an instance of the EisiaRepository repository.
        /// </summary>
        public static EisiaRepository repo = EisiaRepository.Instance;

        static NewComletetionSteps instance = new NewComletetionSteps();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public NewComletetionSteps()
        {
            Token = "";
            BlockID = "";
            WorkflowID = "";
            JSONData = "";
            studid = "";
            NextBlockid = "";
            batteryID = "";
            DeskTopID = "";
            TabConfigID = "";
            studyName = "";
            CSPDOM = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static NewComletetionSteps Instance
        {
            get { return instance; }
        }

#region Variables

        string _Token;

        /// <summary>
        /// Gets or sets the value of variable Token.
        /// </summary>
        [TestVariable("7e7b78fd-b145-4fd0-a9a3-48b95da6bb31")]
        public string Token
        {
            get { return _Token; }
            set { _Token = value; }
        }

        string _BlockID;

        /// <summary>
        /// Gets or sets the value of variable BlockID.
        /// </summary>
        [TestVariable("82c1d92f-8ae9-401b-9ed2-122ac5dfac81")]
        public string BlockID
        {
            get { return _BlockID; }
            set { _BlockID = value; }
        }

        string _WorkflowID;

        /// <summary>
        /// Gets or sets the value of variable WorkflowID.
        /// </summary>
        [TestVariable("74464690-2c5c-4b64-97b0-5b011522e8b5")]
        public string WorkflowID
        {
            get { return _WorkflowID; }
            set { _WorkflowID = value; }
        }

        string _JSONData;

        /// <summary>
        /// Gets or sets the value of variable JSONData.
        /// </summary>
        [TestVariable("c8fddc69-3392-40eb-b567-05b2f79077d5")]
        public string JSONData
        {
            get { return _JSONData; }
            set { _JSONData = value; }
        }

        string _studid;

        /// <summary>
        /// Gets or sets the value of variable studid.
        /// </summary>
        [TestVariable("0f152a62-ddf5-41f1-a929-351574c57121")]
        public string studid
        {
            get { return _studid; }
            set { _studid = value; }
        }

        string _NextBlockid;

        /// <summary>
        /// Gets or sets the value of variable NextBlockid.
        /// </summary>
        [TestVariable("0412f7ae-4fbe-4852-b550-7c24762cf55e")]
        public string NextBlockid
        {
            get { return _NextBlockid; }
            set { _NextBlockid = value; }
        }

        string _batteryID;

        /// <summary>
        /// Gets or sets the value of variable batteryID.
        /// </summary>
        [TestVariable("012a4383-c1d9-470f-a8e4-8154dce1c350")]
        public string batteryID
        {
            get { return _batteryID; }
            set { _batteryID = value; }
        }

        string _DeskTopID;

        /// <summary>
        /// Gets or sets the value of variable DeskTopID.
        /// </summary>
        [TestVariable("6455a5c5-84fe-497a-bf82-50a093646c3a")]
        public string DeskTopID
        {
            get { return _DeskTopID; }
            set { _DeskTopID = value; }
        }

        string _TabConfigID;

        /// <summary>
        /// Gets or sets the value of variable TabConfigID.
        /// </summary>
        [TestVariable("1f0eb932-2762-4d78-bb30-9947774ab2df")]
        public string TabConfigID
        {
            get { return _TabConfigID; }
            set { _TabConfigID = value; }
        }

        string _studyName;

        /// <summary>
        /// Gets or sets the value of variable studyName.
        /// </summary>
        [TestVariable("b921938b-c714-42e1-a694-58fa80ed2349")]
        public string studyName
        {
            get { return _studyName; }
            set { _studyName = value; }
        }

        string _CSPDOM;

        /// <summary>
        /// Gets or sets the value of variable CSPDOM.
        /// </summary>
        [TestVariable("007a8ca0-a156-47f0-b00c-1d4a09a5f547")]
        public string CSPDOM
        {
            get { return _CSPDOM; }
            set { _CSPDOM = value; }
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

            Stepcompletation(Token, BlockID, WorkflowID, JSONData, studid, NextBlockid, batteryID, DeskTopID);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
