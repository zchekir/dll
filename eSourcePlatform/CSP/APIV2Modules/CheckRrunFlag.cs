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

namespace CSP.APIV2Modules
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CheckRrunFlag recording.
    /// </summary>
    [TestModule("cf6de81a-ac52-40c4-9fec-7a2e2f9612a7", ModuleType.Recording, 1)]
    public partial class CheckRrunFlag : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::CSP.CSPRepository repository.
        /// </summary>
        public static global::CSP.CSPRepository repo = global::CSP.CSPRepository.Instance;

        static CheckRrunFlag instance = new CheckRrunFlag();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CheckRrunFlag()
        {
            DBServer = "cgst-qc.database.windows.net";
            Database = "";
            dbUsername = "";
            dbPassword = "";
            ExternalID = "";
            Authentication = "Active Directory Password";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CheckRrunFlag Instance
        {
            get { return instance; }
        }

#region Variables

        string _DBServer;

        /// <summary>
        /// Gets or sets the value of variable DBServer.
        /// </summary>
        [TestVariable("0502a8f9-2e49-49a7-a1b5-998c1f0c66cb")]
        public string DBServer
        {
            get { return _DBServer; }
            set { _DBServer = value; }
        }

        string _Database;

        /// <summary>
        /// Gets or sets the value of variable Database.
        /// </summary>
        [TestVariable("212a9155-795a-426f-b0de-503e1dce769f")]
        public string Database
        {
            get { return _Database; }
            set { _Database = value; }
        }

        string _dbUsername;

        /// <summary>
        /// Gets or sets the value of variable dbUsername.
        /// </summary>
        [TestVariable("d36b3ff7-5f95-4501-bfda-c8b5c180e548")]
        public string dbUsername
        {
            get { return _dbUsername; }
            set { _dbUsername = value; }
        }

        string _dbPassword;

        /// <summary>
        /// Gets or sets the value of variable dbPassword.
        /// </summary>
        [TestVariable("7abe048e-cc2d-49e5-8b2e-95594a505c78")]
        public string dbPassword
        {
            get { return _dbPassword; }
            set { _dbPassword = value; }
        }

        string _ExternalID;

        /// <summary>
        /// Gets or sets the value of variable ExternalID.
        /// </summary>
        [TestVariable("006c9617-2a38-4ce9-b149-2f23fbb5c5dd")]
        public string ExternalID
        {
            get { return _ExternalID; }
            set { _ExternalID = value; }
        }

        string _Authentication;

        /// <summary>
        /// Gets or sets the value of variable Authentication.
        /// </summary>
        [TestVariable("24b99672-d4b4-4352-83dc-f0d6f336ecdf")]
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

            RrunFlag(DBServer, Database, dbUsername, dbPassword, Authentication, ExternalID);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
