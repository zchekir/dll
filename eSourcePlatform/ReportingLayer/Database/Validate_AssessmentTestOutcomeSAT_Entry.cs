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
    ///The Validate_AssessmentTestOutcomeSAT_Entry recording.
    /// </summary>
    [TestModule("4246b633-1d3d-47cf-9ae7-4fb2f592534f", ModuleType.Recording, 1)]
    public partial class Validate_AssessmentTestOutcomeSAT_Entry : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::ReportingLayer.ReportingLayerRepository repository.
        /// </summary>
        public static global::ReportingLayer.ReportingLayerRepository repo = global::ReportingLayer.ReportingLayerRepository.Instance;

        static Validate_AssessmentTestOutcomeSAT_Entry instance = new Validate_AssessmentTestOutcomeSAT_Entry();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Validate_AssessmentTestOutcomeSAT_Entry()
        {
            Authentication = "";
            CSPPassword = "";
            CSPUsername = "";
            DBServer = "";
            Database = "";
            StudyName = "";
            RandNum = "";
            TestIdentifier = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Validate_AssessmentTestOutcomeSAT_Entry Instance
        {
            get { return instance; }
        }

#region Variables

        string _Authentication;

        /// <summary>
        /// Gets or sets the value of variable Authentication.
        /// </summary>
        [TestVariable("91989417-cf19-4d83-aae2-e8e4ffec225f")]
        public string Authentication
        {
            get { return _Authentication; }
            set { _Authentication = value; }
        }

        string _CSPPassword;

        /// <summary>
        /// Gets or sets the value of variable CSPPassword.
        /// </summary>
        [TestVariable("fb76f8f0-f99e-4df1-b623-a0d5a7372ddc")]
        public string CSPPassword
        {
            get { return _CSPPassword; }
            set { _CSPPassword = value; }
        }

        string _DBServer;

        /// <summary>
        /// Gets or sets the value of variable DBServer.
        /// </summary>
        [TestVariable("1ba72492-2490-40ec-81a7-943edd0784fc")]
        public string DBServer
        {
            get { return _DBServer; }
            set { _DBServer = value; }
        }

        string _Database;

        /// <summary>
        /// Gets or sets the value of variable Database.
        /// </summary>
        [TestVariable("15c79fff-2cd5-453e-9fce-a9d10849596d")]
        public string Database
        {
            get { return _Database; }
            set { _Database = value; }
        }

        string _StudyName;

        /// <summary>
        /// Gets or sets the value of variable StudyName.
        /// </summary>
        [TestVariable("c9eb6ed4-63ff-4264-a364-a499634f0ca3")]
        public string StudyName
        {
            get { return _StudyName; }
            set { _StudyName = value; }
        }

        string _RandNum;

        /// <summary>
        /// Gets or sets the value of variable RandNum.
        /// </summary>
        [TestVariable("beaf8f20-9978-4c0f-84bb-375aa81ecc5f")]
        public string RandNum
        {
            get { return _RandNum; }
            set { _RandNum = value; }
        }

        string _TestIdentifier;

        /// <summary>
        /// Gets or sets the value of variable TestIdentifier.
        /// </summary>
        [TestVariable("dc84b8f2-5109-479a-9f7a-cf24097d39bb")]
        public string TestIdentifier
        {
            get { return _TestIdentifier; }
            set { _TestIdentifier = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable CSPUsername.
        /// </summary>
        [TestVariable("4091a148-f736-42c7-b6b1-d2dffc0159b2")]
        public string CSPUsername
        {
            get { return repo.CSPUsername; }
            set { repo.CSPUsername = value; }
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

            GetAssessmentTestOutcomesSAT(Database, DBServer, CSPUsername, CSPPassword, Authentication);
            Delay.Milliseconds(0);
            
            ReportRecords();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
