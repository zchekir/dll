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
    ///The Check_Duplicate_Study recording.
    /// </summary>
    [TestModule("052f590d-8129-4cde-ac98-6ee337aed7f7", ModuleType.Recording, 1)]
    public partial class Check_Duplicate_Study : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CSPRepository repository.
        /// </summary>
        public static CSPRepository repo = CSPRepository.Instance;

        static Check_Duplicate_Study instance = new Check_Duplicate_Study();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Check_Duplicate_Study()
        {
            DBServer = "";
            Database = "";
            dbUsername = "";
            dbPassword = "";
            Authentication = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Check_Duplicate_Study Instance
        {
            get { return instance; }
        }

#region Variables

        string _DBServer;

        /// <summary>
        /// Gets or sets the value of variable DBServer.
        /// </summary>
        [TestVariable("fbd8c746-8dee-40e2-a25e-7d4650ede54b")]
        public string DBServer
        {
            get { return _DBServer; }
            set { _DBServer = value; }
        }

        string _Database;

        /// <summary>
        /// Gets or sets the value of variable Database.
        /// </summary>
        [TestVariable("a59ffc6d-d062-472f-94aa-c95b29f1f338")]
        public string Database
        {
            get { return _Database; }
            set { _Database = value; }
        }

        string _dbUsername;

        /// <summary>
        /// Gets or sets the value of variable dbUsername.
        /// </summary>
        [TestVariable("886557f5-2eb8-4294-b581-d4f9918c3dc4")]
        public string dbUsername
        {
            get { return _dbUsername; }
            set { _dbUsername = value; }
        }

        string _dbPassword;

        /// <summary>
        /// Gets or sets the value of variable dbPassword.
        /// </summary>
        [TestVariable("f0140580-8190-4863-8035-81d6f1f5202e")]
        public string dbPassword
        {
            get { return _dbPassword; }
            set { _dbPassword = value; }
        }

        string _Authentication;

        /// <summary>
        /// Gets or sets the value of variable Authentication.
        /// </summary>
        [TestVariable("13b38966-593e-4b60-8295-78b60bdc5b56")]
        public string Authentication
        {
            get { return _Authentication; }
            set { _Authentication = value; }
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

            StudyDupplicationTest(DBServer, Database, dbUsername, dbPassword, Authentication);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
