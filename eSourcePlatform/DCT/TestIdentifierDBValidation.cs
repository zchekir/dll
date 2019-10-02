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

namespace DCT
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The TestIdentifierDBValidation recording.
    /// </summary>
    [TestModule("1e474587-a2e6-4c33-b39d-7673a9867909", ModuleType.Recording, 1)]
    public partial class TestIdentifierDBValidation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the DCTRepository repository.
        /// </summary>
        public static DCTRepository repo = DCTRepository.Instance;

        static TestIdentifierDBValidation instance = new TestIdentifierDBValidation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TestIdentifierDBValidation()
        {
            DBserver = "cgst-qc.database.windows.net";
            Database = "";
            Authentication = "Active Directory Password";
            dbUsername = "zchekir@cogstate.com";
            dbPassword = "Cogstate2014";
            TestIdentifier = "696e7adf-994a-4f10-920f-caa8cf97e4dc";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static TestIdentifierDBValidation Instance
        {
            get { return instance; }
        }

#region Variables

        string _DBserver;

        /// <summary>
        /// Gets or sets the value of variable DBserver.
        /// </summary>
        [TestVariable("fdfe063d-6783-4369-9629-5a145c369190")]
        public string DBserver
        {
            get { return _DBserver; }
            set { _DBserver = value; }
        }

        string _Database;

        /// <summary>
        /// Gets or sets the value of variable Database.
        /// </summary>
        [TestVariable("014421c8-99a8-4638-a1b8-329b6244fb96")]
        public string Database
        {
            get { return _Database; }
            set { _Database = value; }
        }

        string _Authentication;

        /// <summary>
        /// Gets or sets the value of variable Authentication.
        /// </summary>
        [TestVariable("eb61540a-fb4d-4dc9-a31b-da7d8e0c2955")]
        public string Authentication
        {
            get { return _Authentication; }
            set { _Authentication = value; }
        }

        string _dbUsername;

        /// <summary>
        /// Gets or sets the value of variable dbUsername.
        /// </summary>
        [TestVariable("b0163e3a-504f-4f93-9cf1-0d2f321053c9")]
        public string dbUsername
        {
            get { return _dbUsername; }
            set { _dbUsername = value; }
        }

        string _dbPassword;

        /// <summary>
        /// Gets or sets the value of variable dbPassword.
        /// </summary>
        [TestVariable("99ec8a5f-831b-4bc1-99c8-da84479e2528")]
        public string dbPassword
        {
            get { return _dbPassword; }
            set { _dbPassword = value; }
        }

        string _TestIdentifier;

        /// <summary>
        /// Gets or sets the value of variable TestIdentifier.
        /// </summary>
        [TestVariable("6564ccb3-9f1f-49b3-bf17-fc9f45477b9e")]
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

            engine.Helpers.SQLUtility.ValidateDCTMoved(DBserver, Database, dbUsername, dbPassword, Authentication, TestIdentifier);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
