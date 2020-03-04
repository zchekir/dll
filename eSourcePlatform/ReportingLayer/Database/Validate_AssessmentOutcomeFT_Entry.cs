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
    ///The Validate_AssessmentOutcomeFT_Entry recording.
    /// </summary>
    [TestModule("da9f2a2f-35b0-4d03-b071-1584799912f5", ModuleType.Recording, 1)]
    public partial class Validate_AssessmentOutcomeFT_Entry : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::ReportingLayer.ReportingLayerRepository repository.
        /// </summary>
        public static global::ReportingLayer.ReportingLayerRepository repo = global::ReportingLayer.ReportingLayerRepository.Instance;

        static Validate_AssessmentOutcomeFT_Entry instance = new Validate_AssessmentOutcomeFT_Entry();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Validate_AssessmentOutcomeFT_Entry()
        {
            Authentication = "";
            CSPPassword = "";
            CSPUsername = "";
            DBServer = "";
            Database = "";
            StudyName = "";
            TestIdentifier = "";
            RandNum = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Validate_AssessmentOutcomeFT_Entry Instance
        {
            get { return instance; }
        }

#region Variables

        string _Authentication;

        /// <summary>
        /// Gets or sets the value of variable Authentication.
        /// </summary>
        [TestVariable("c765e2d5-4006-471b-990e-b11f3ac0ff96")]
        public string Authentication
        {
            get { return _Authentication; }
            set { _Authentication = value; }
        }

        string _CSPPassword;

        /// <summary>
        /// Gets or sets the value of variable CSPPassword.
        /// </summary>
        [TestVariable("4beaaa67-2a35-4bda-b348-3f9e447a553e")]
        public string CSPPassword
        {
            get { return _CSPPassword; }
            set { _CSPPassword = value; }
        }

        string _CSPUsername;

        /// <summary>
        /// Gets or sets the value of variable CSPUsername.
        /// </summary>
        [TestVariable("ed3b008b-809e-4eff-b570-f47c9a9fe3c3")]
        public string CSPUsername
        {
            get { return _CSPUsername; }
            set { _CSPUsername = value; }
        }

        string _DBServer;

        /// <summary>
        /// Gets or sets the value of variable DBServer.
        /// </summary>
        [TestVariable("3adf47ce-7455-43e4-b461-7dce35e4c106")]
        public string DBServer
        {
            get { return _DBServer; }
            set { _DBServer = value; }
        }

        string _Database;

        /// <summary>
        /// Gets or sets the value of variable Database.
        /// </summary>
        [TestVariable("220605ff-2f0b-48b6-8c0e-43ec3d920c46")]
        public string Database
        {
            get { return _Database; }
            set { _Database = value; }
        }

        string _StudyName;

        /// <summary>
        /// Gets or sets the value of variable StudyName.
        /// </summary>
        [TestVariable("ec4063a2-0441-471b-a8e2-5bd96917373f")]
        public string StudyName
        {
            get { return _StudyName; }
            set { _StudyName = value; }
        }

        string _TestIdentifier;

        /// <summary>
        /// Gets or sets the value of variable TestIdentifier.
        /// </summary>
        [TestVariable("9b717f4a-8f92-4127-9452-a1445abaaa1c")]
        public string TestIdentifier
        {
            get { return _TestIdentifier; }
            set { _TestIdentifier = value; }
        }

        string _RandNum;

        /// <summary>
        /// Gets or sets the value of variable RandNum.
        /// </summary>
        [TestVariable("748f3444-3fbe-46d7-8f94-d643162a13c1")]
        public string RandNum
        {
            get { return _RandNum; }
            set { _RandNum = value; }
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

            GetAssessmentTestOutcomeFT(Database, DBServer, CSPUsername, CSPPassword, Authentication);
            Delay.Milliseconds(0);
            
            ReportRecords();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
