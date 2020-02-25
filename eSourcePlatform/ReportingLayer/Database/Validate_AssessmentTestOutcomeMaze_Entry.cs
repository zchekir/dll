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

namespace ReportingLayer.Database
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Validate_AssessmentTestOutcomeMaze_Entry recording.
    /// </summary>
    [TestModule("35780fd6-fc1a-4d3d-b321-0e9e471f1d66", ModuleType.Recording, 1)]
    public partial class Validate_AssessmentTestOutcomeMaze_Entry : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::ReportingLayer.ReportingLayerRepository repository.
        /// </summary>
        public static global::ReportingLayer.ReportingLayerRepository repo = global::ReportingLayer.ReportingLayerRepository.Instance;

        static Validate_AssessmentTestOutcomeMaze_Entry instance = new Validate_AssessmentTestOutcomeMaze_Entry();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Validate_AssessmentTestOutcomeMaze_Entry()
        {
            Database = "";
            DBServer = "";
            CSPUsername = "";
            CSPPassword = "";
            Authentication = "";
            StudyName = "";
            RandNum = "";
            TestIdentifier = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Validate_AssessmentTestOutcomeMaze_Entry Instance
        {
            get { return instance; }
        }

#region Variables

        string _Database;

        /// <summary>
        /// Gets or sets the value of variable Database.
        /// </summary>
        [TestVariable("5f886da9-afeb-46dc-98b2-57095e0c53f7")]
        public string Database
        {
            get { return _Database; }
            set { _Database = value; }
        }

        string _DBServer;

        /// <summary>
        /// Gets or sets the value of variable DBServer.
        /// </summary>
        [TestVariable("7801bf74-aa6e-4442-b239-cda135e32918")]
        public string DBServer
        {
            get { return _DBServer; }
            set { _DBServer = value; }
        }

        string _CSPUsername;

        /// <summary>
        /// Gets or sets the value of variable CSPUsername.
        /// </summary>
        [TestVariable("0bb5bb57-00f3-4291-bcb0-a0b6bd2f573b")]
        public string CSPUsername
        {
            get { return _CSPUsername; }
            set { _CSPUsername = value; }
        }

        string _CSPPassword;

        /// <summary>
        /// Gets or sets the value of variable CSPPassword.
        /// </summary>
        [TestVariable("dda126a4-6c33-464e-a218-a18d10083152")]
        public string CSPPassword
        {
            get { return _CSPPassword; }
            set { _CSPPassword = value; }
        }

        string _Authentication;

        /// <summary>
        /// Gets or sets the value of variable Authentication.
        /// </summary>
        [TestVariable("cce9af2f-dfef-4d83-8c47-c027a81897c7")]
        public string Authentication
        {
            get { return _Authentication; }
            set { _Authentication = value; }
        }

        string _StudyName;

        /// <summary>
        /// Gets or sets the value of variable StudyName.
        /// </summary>
        [TestVariable("c0ffe793-4ae5-4647-b6a3-425477fc7181")]
        public string StudyName
        {
            get { return _StudyName; }
            set { _StudyName = value; }
        }

        string _RandNum;

        /// <summary>
        /// Gets or sets the value of variable RandNum.
        /// </summary>
        [TestVariable("6e6c722c-ff51-42bd-9b60-ed2c16083dd6")]
        public string RandNum
        {
            get { return _RandNum; }
            set { _RandNum = value; }
        }

        string _TestIdentifier;

        /// <summary>
        /// Gets or sets the value of variable TestIdentifier.
        /// </summary>
        [TestVariable("e9435d2b-5eb4-41c7-b80f-b568f06a1e44")]
        public string TestIdentifier
        {
            get { return _TestIdentifier; }
            set { _TestIdentifier = value; }
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

            GetAssessmentTestOutcomeMaze(Database, DBServer, CSPUsername, CSPPassword, Authentication);
            Delay.Milliseconds(0);
            
            ReportRecords();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
