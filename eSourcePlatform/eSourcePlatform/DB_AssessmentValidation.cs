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

namespace eSourcePlatform
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The DB_AssessmentValidation recording.
    /// </summary>
    [TestModule("74edc47d-2b4b-418c-8ffc-996ba7474b59", ModuleType.Recording, 1)]
    public partial class DB_AssessmentValidation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the eSourcePlatformRepository repository.
        /// </summary>
        public static eSourcePlatformRepository repo = eSourcePlatformRepository.Instance;

        static DB_AssessmentValidation instance = new DB_AssessmentValidation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DB_AssessmentValidation()
        {
            dbserver = "cgst-qc.database.windows.net";
            database = "cgst-bear-api";
            username = "zchekir@cogstate.com";
            password = "Cogstate2016";
            authentication = "Active Directory Password";
            TestIdentifier = "E00C148B-3D73-44E0-8AC9-024C50AB397B";
            PrimaryOutcome = "0.970444658471641";
            StandardScoreZ = "-2.9910644585573";
            StandardScoreT = "70.089355414427";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DB_AssessmentValidation Instance
        {
            get { return instance; }
        }

#region Variables

        string _dbserver;

        /// <summary>
        /// Gets or sets the value of variable dbserver.
        /// </summary>
        [TestVariable("dee25264-d606-41ca-bf0f-9efe134b8991")]
        public string dbserver
        {
            get { return _dbserver; }
            set { _dbserver = value; }
        }

        string _database;

        /// <summary>
        /// Gets or sets the value of variable database.
        /// </summary>
        [TestVariable("501de4e3-4fde-45a1-8e39-f50da8cccb6a")]
        public string database
        {
            get { return _database; }
            set { _database = value; }
        }

        string _username;

        /// <summary>
        /// Gets or sets the value of variable username.
        /// </summary>
        [TestVariable("c842c4af-9cbc-4c54-8fbe-f573a02dbdb8")]
        public string username
        {
            get { return _username; }
            set { _username = value; }
        }

        string _password;

        /// <summary>
        /// Gets or sets the value of variable password.
        /// </summary>
        [TestVariable("d6df326c-c955-4056-82a3-583d328b2603")]
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        string _authentication;

        /// <summary>
        /// Gets or sets the value of variable authentication.
        /// </summary>
        [TestVariable("ec3dc429-d49f-4980-9287-23711c36c87d")]
        public string authentication
        {
            get { return _authentication; }
            set { _authentication = value; }
        }

        string _TestIdentifier;

        /// <summary>
        /// Gets or sets the value of variable TestIdentifier.
        /// </summary>
        [TestVariable("9fae6d08-a73d-4b7a-be99-a84a17d24ddc")]
        public string TestIdentifier
        {
            get { return _TestIdentifier; }
            set { _TestIdentifier = value; }
        }

        string _PrimaryOutcome;

        /// <summary>
        /// Gets or sets the value of variable PrimaryOutcome.
        /// </summary>
        [TestVariable("7cd6ee47-6bb8-4f3c-bbf7-0129f1e13b30")]
        public string PrimaryOutcome
        {
            get { return _PrimaryOutcome; }
            set { _PrimaryOutcome = value; }
        }

        string _StandardScoreZ;

        /// <summary>
        /// Gets or sets the value of variable StandardScoreZ.
        /// </summary>
        [TestVariable("a1676bb6-ae1a-4144-97e1-da672931fe75")]
        public string StandardScoreZ
        {
            get { return _StandardScoreZ; }
            set { _StandardScoreZ = value; }
        }

        string _StandardScoreT;

        /// <summary>
        /// Gets or sets the value of variable StandardScoreT.
        /// </summary>
        [TestVariable("50071bb3-4103-42e8-b898-bde82c740bc4")]
        public string StandardScoreT
        {
            get { return _StandardScoreT; }
            set { _StandardScoreT = value; }
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

            AssessmentValidation(dbserver, database, username, password, authentication, TestIdentifier, StandardScoreT, StandardScoreZ, PrimaryOutcome);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
