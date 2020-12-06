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
    ///The CSPStoreProcedure recording.
    /// </summary>
    [TestModule("efab97cb-f4ab-4d41-965b-4e9ea0dd4cdb", ModuleType.Recording, 1)]
    public partial class CSPStoreProcedure : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CSPRepository repository.
        /// </summary>
        public static CSPRepository repo = CSPRepository.Instance;

        static CSPStoreProcedure instance = new CSPStoreProcedure();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CSPStoreProcedure()
        {
            DBServer = "cgst-qc.database.windows.net";
            Database = "";
            dbUsername = "";
            dbPassword = "";
            Authentication = "Active Directory Password";
            studID = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CSPStoreProcedure Instance
        {
            get { return instance; }
        }

#region Variables

        string _DBServer;

        /// <summary>
        /// Gets or sets the value of variable DBServer.
        /// </summary>
        [TestVariable("ddf1e171-395e-4f71-8308-a919557e5f5e")]
        public string DBServer
        {
            get { return _DBServer; }
            set { _DBServer = value; }
        }

        string _Database;

        /// <summary>
        /// Gets or sets the value of variable Database.
        /// </summary>
        [TestVariable("ffe50506-848f-40a7-ad13-7b8f98eeed30")]
        public string Database
        {
            get { return _Database; }
            set { _Database = value; }
        }

        string _dbUsername;

        /// <summary>
        /// Gets or sets the value of variable dbUsername.
        /// </summary>
        [TestVariable("bc1e8c3b-5918-4d4f-b724-fe2d4bb61fb0")]
        public string dbUsername
        {
            get { return _dbUsername; }
            set { _dbUsername = value; }
        }

        string _dbPassword;

        /// <summary>
        /// Gets or sets the value of variable dbPassword.
        /// </summary>
        [TestVariable("7de9827c-49e0-4c26-b8b1-911edc706074")]
        public string dbPassword
        {
            get { return _dbPassword; }
            set { _dbPassword = value; }
        }

        string _Authentication;

        /// <summary>
        /// Gets or sets the value of variable Authentication.
        /// </summary>
        [TestVariable("3e968851-9891-4442-80c2-acae5c1276e3")]
        public string Authentication
        {
            get { return _Authentication; }
            set { _Authentication = value; }
        }

        string _studID;

        /// <summary>
        /// Gets or sets the value of variable studID.
        /// </summary>
        [TestVariable("b6d45e16-ac93-42ce-8faf-eb0a9367d469")]
        public string studID
        {
            get { return _studID; }
            set { _studID = value; }
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

            ExecuteStoreProcedure(DBServer, Database, dbUsername, dbPassword, Authentication, studID);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 900ms.", new RecordItemIndex(1));
            Delay.Duration(900, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
