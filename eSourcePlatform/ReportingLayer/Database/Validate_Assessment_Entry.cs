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
    ///The Validate_Assessment_Entry recording.
    /// </summary>
    [TestModule("6ba7b7e9-f5c9-4c3b-a3f0-4ce9fbf2febb", ModuleType.Recording, 1)]
    public partial class Validate_Assessment_Entry : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::ReportingLayer.ReportingLayerRepository repository.
        /// </summary>
        public static global::ReportingLayer.ReportingLayerRepository repo = global::ReportingLayer.ReportingLayerRepository.Instance;

        static Validate_Assessment_Entry instance = new Validate_Assessment_Entry();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Validate_Assessment_Entry()
        {
            Authentication = "";
            CSPPassword = "";
            CSPUsername = "";
            Database = "";
            DBServer = "";
            RandNum = "";
            StudyName = "";
            TestIdentifier = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Validate_Assessment_Entry Instance
        {
            get { return instance; }
        }

#region Variables

        string _Authentication;

        /// <summary>
        /// Gets or sets the value of variable Authentication.
        /// </summary>
        [TestVariable("78990f30-2961-490b-9ee2-cda439079628")]
        public string Authentication
        {
            get { return _Authentication; }
            set { _Authentication = value; }
        }

        string _CSPPassword;

        /// <summary>
        /// Gets or sets the value of variable CSPPassword.
        /// </summary>
        [TestVariable("d93e385a-42d1-4e04-a8b9-cee77e09c97e")]
        public string CSPPassword
        {
            get { return _CSPPassword; }
            set { _CSPPassword = value; }
        }

        string _Database;

        /// <summary>
        /// Gets or sets the value of variable Database.
        /// </summary>
        [TestVariable("f4c0a38c-f35d-4f61-86b0-492ce37da749")]
        public string Database
        {
            get { return _Database; }
            set { _Database = value; }
        }

        string _DBServer;

        /// <summary>
        /// Gets or sets the value of variable DBServer.
        /// </summary>
        [TestVariable("95db278b-de92-44ac-b5da-f7a75b114193")]
        public string DBServer
        {
            get { return _DBServer; }
            set { _DBServer = value; }
        }

        string _RandNum;

        /// <summary>
        /// Gets or sets the value of variable RandNum.
        /// </summary>
        [TestVariable("50b8ec56-7934-4213-b15a-16c89a88a059")]
        public string RandNum
        {
            get { return _RandNum; }
            set { _RandNum = value; }
        }

        string _StudyName;

        /// <summary>
        /// Gets or sets the value of variable StudyName.
        /// </summary>
        [TestVariable("7584ba58-c242-4473-81e0-4565aebe7ef0")]
        public string StudyName
        {
            get { return _StudyName; }
            set { _StudyName = value; }
        }

        string _TestIdentifier;

        /// <summary>
        /// Gets or sets the value of variable TestIdentifier.
        /// </summary>
        [TestVariable("9ec4f0b1-c59a-439c-8257-ce6707740e8c")]
        public string TestIdentifier
        {
            get { return _TestIdentifier; }
            set { _TestIdentifier = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable CSPUsername.
        /// </summary>
        [TestVariable("56556a77-bafc-435d-8934-f53bb5510593")]
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

            GetAssessment(DBServer, Database, CSPUsername, CSPPassword, Authentication);
            Delay.Milliseconds(0);
            
            ReportRecord();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
