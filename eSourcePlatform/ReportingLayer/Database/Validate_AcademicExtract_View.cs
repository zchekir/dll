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
    ///The Validate_AcademicExtract_View recording.
    /// </summary>
    [TestModule("9b031b36-2991-45e5-9920-2937eb519049", ModuleType.Recording, 1)]
    public partial class Validate_AcademicExtract_View : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::ReportingLayer.ReportingLayerRepository repository.
        /// </summary>
        public static global::ReportingLayer.ReportingLayerRepository repo = global::ReportingLayer.ReportingLayerRepository.Instance;

        static Validate_AcademicExtract_View instance = new Validate_AcademicExtract_View();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Validate_AcademicExtract_View()
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
        public static Validate_AcademicExtract_View Instance
        {
            get { return instance; }
        }

#region Variables

        string _Authentication;

        /// <summary>
        /// Gets or sets the value of variable Authentication.
        /// </summary>
        [TestVariable("3ddd30d0-b3b6-427b-bb7a-dc97fa1d5d5d")]
        public string Authentication
        {
            get { return _Authentication; }
            set { _Authentication = value; }
        }

        string _CSPPassword;

        /// <summary>
        /// Gets or sets the value of variable CSPPassword.
        /// </summary>
        [TestVariable("29062611-e2e2-401e-8762-b601727ca4f3")]
        public string CSPPassword
        {
            get { return _CSPPassword; }
            set { _CSPPassword = value; }
        }

        string _CSPUsername;

        /// <summary>
        /// Gets or sets the value of variable CSPUsername.
        /// </summary>
        [TestVariable("6bfefd8c-e52b-4b8f-887d-3ec70abdc8f5")]
        public string CSPUsername
        {
            get { return _CSPUsername; }
            set { _CSPUsername = value; }
        }

        string _DBServer;

        /// <summary>
        /// Gets or sets the value of variable DBServer.
        /// </summary>
        [TestVariable("daf3b434-1fd5-46ba-9485-3e7353e11113")]
        public string DBServer
        {
            get { return _DBServer; }
            set { _DBServer = value; }
        }

        string _Database;

        /// <summary>
        /// Gets or sets the value of variable Database.
        /// </summary>
        [TestVariable("e9237707-036b-42a6-bc80-48752a2b9e3c")]
        public string Database
        {
            get { return _Database; }
            set { _Database = value; }
        }

        string _StudyName;

        /// <summary>
        /// Gets or sets the value of variable StudyName.
        /// </summary>
        [TestVariable("5d524974-8a9f-4413-b997-491a099682ad")]
        public string StudyName
        {
            get { return _StudyName; }
            set { _StudyName = value; }
        }

        string _RandNum;

        /// <summary>
        /// Gets or sets the value of variable RandNum.
        /// </summary>
        [TestVariable("d0f3bd5a-0ba0-43ca-a678-8bb81580dbe9")]
        public string RandNum
        {
            get { return _RandNum; }
            set { _RandNum = value; }
        }

        string _TestIdentifier;

        /// <summary>
        /// Gets or sets the value of variable TestIdentifier.
        /// </summary>
        [TestVariable("d19b978f-ae5f-4a46-923f-b2b2d54cc8e6")]
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

            GetAcademicExtract(Database, DBServer, CSPUsername, CSPPassword, Authentication);
            Delay.Milliseconds(0);
            
            ReportRecords();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
