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
    ///The Validate_Site_Entry recording.
    /// </summary>
    [TestModule("87af8760-8e28-4032-946e-4d0264c94738", ModuleType.Recording, 1)]
    public partial class Validate_Site_Entry : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::ReportingLayer.ReportingLayerRepository repository.
        /// </summary>
        public static global::ReportingLayer.ReportingLayerRepository repo = global::ReportingLayer.ReportingLayerRepository.Instance;

        static Validate_Site_Entry instance = new Validate_Site_Entry();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Validate_Site_Entry()
        {
            Authentication = "";
            CSPPassword = "";
            CSPUsername = "";
            Database = "";
            DBServer = "";
            StudyName = "";
            RandNum = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Validate_Site_Entry Instance
        {
            get { return instance; }
        }

#region Variables

        string _Authentication;

        /// <summary>
        /// Gets or sets the value of variable Authentication.
        /// </summary>
        [TestVariable("d5184390-1796-4489-b8ff-a50d5ade3971")]
        public string Authentication
        {
            get { return _Authentication; }
            set { _Authentication = value; }
        }

        string _CSPPassword;

        /// <summary>
        /// Gets or sets the value of variable CSPPassword.
        /// </summary>
        [TestVariable("9bb8fe6d-fab5-4f61-b4a6-fdb045ea2fe1")]
        public string CSPPassword
        {
            get { return _CSPPassword; }
            set { _CSPPassword = value; }
        }

        string _Database;

        /// <summary>
        /// Gets or sets the value of variable Database.
        /// </summary>
        [TestVariable("1f9de072-6f06-4344-92f8-4313e2046b66")]
        public string Database
        {
            get { return _Database; }
            set { _Database = value; }
        }

        string _DBServer;

        /// <summary>
        /// Gets or sets the value of variable DBServer.
        /// </summary>
        [TestVariable("917db09d-b3cf-4ba4-beda-a91e2f3171b5")]
        public string DBServer
        {
            get { return _DBServer; }
            set { _DBServer = value; }
        }

        string _StudyName;

        /// <summary>
        /// Gets or sets the value of variable StudyName.
        /// </summary>
        [TestVariable("4b1d6b7b-0bd5-4c5b-8642-03f3236e33dc")]
        public string StudyName
        {
            get { return _StudyName; }
            set { _StudyName = value; }
        }

        string _RandNum;

        /// <summary>
        /// Gets or sets the value of variable RandNum.
        /// </summary>
        [TestVariable("3ff0f739-5b8a-4abe-a4d0-840c5d40ad9e")]
        public string RandNum
        {
            get { return _RandNum; }
            set { _RandNum = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable CSPUsername.
        /// </summary>
        [TestVariable("f44b2169-7fee-4ad7-9fcf-bdd6fb271363")]
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

            GetSite(DBServer, Database, CSPUsername, CSPPassword, Authentication);
            Delay.Milliseconds(0);
            
            ReportRecord();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
