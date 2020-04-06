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
    ///The DCDBVersion recording.
    /// </summary>
    [TestModule("e7e659e1-4c5a-43bc-9a7e-4bf52cb9cc4a", ModuleType.Recording, 1)]
    public partial class DCDBVersion : ITestModule
    {
        /// <summary>
        /// Holds an instance of the eSourcePlatformRepository repository.
        /// </summary>
        public static eSourcePlatformRepository repo = eSourcePlatformRepository.Instance;

        static DCDBVersion instance = new DCDBVersion();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DCDBVersion()
        {
            dbserver = "";
            database = "";
            username = "";
            password = "";
            authentication = "";
            migrationid = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DCDBVersion Instance
        {
            get { return instance; }
        }

#region Variables

        string _dbserver;

        /// <summary>
        /// Gets or sets the value of variable dbserver.
        /// </summary>
        [TestVariable("bdffafda-04ac-4c92-8c27-b7fcea09a6b2")]
        public string dbserver
        {
            get { return _dbserver; }
            set { _dbserver = value; }
        }

        string _database;

        /// <summary>
        /// Gets or sets the value of variable database.
        /// </summary>
        [TestVariable("29d58262-4218-420a-b550-df56d1d710b5")]
        public string database
        {
            get { return _database; }
            set { _database = value; }
        }

        string _username;

        /// <summary>
        /// Gets or sets the value of variable username.
        /// </summary>
        [TestVariable("c541a5ab-4188-4f68-9ec0-be5a62792c46")]
        public string username
        {
            get { return _username; }
            set { _username = value; }
        }

        string _password;

        /// <summary>
        /// Gets or sets the value of variable password.
        /// </summary>
        [TestVariable("fe2574be-17fa-4c25-b97c-195ef0833ca2")]
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        string _authentication;

        /// <summary>
        /// Gets or sets the value of variable authentication.
        /// </summary>
        [TestVariable("b443a9f5-2316-4510-9dfd-2f72d4e07544")]
        public string authentication
        {
            get { return _authentication; }
            set { _authentication = value; }
        }

        string _migrationid;

        /// <summary>
        /// Gets or sets the value of variable migrationid.
        /// </summary>
        [TestVariable("b8c98ef3-329a-45dd-91f8-bc60c29dda69")]
        public string migrationid
        {
            get { return _migrationid; }
            set { _migrationid = value; }
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

            dc_DBversion(dbserver, database, username, password, authentication, migrationid);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
