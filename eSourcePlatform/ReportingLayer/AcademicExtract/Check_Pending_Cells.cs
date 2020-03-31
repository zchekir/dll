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

namespace ReportingLayer.AcademicExtract
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Check_Pending_Cells recording.
    /// </summary>
    [TestModule("7060530d-d9d5-4bd3-a649-8ea6b2c9991e", ModuleType.Recording, 1)]
    public partial class Check_Pending_Cells : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::ReportingLayer.ReportingLayerRepository repository.
        /// </summary>
        public static global::ReportingLayer.ReportingLayerRepository repo = global::ReportingLayer.ReportingLayerRepository.Instance;

        static Check_Pending_Cells instance = new Check_Pending_Cells();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Check_Pending_Cells()
        {
            TestIdentifier = "05DE4D94-E0CC-459F-9CBA-27BBB73928BA";
            DBServer = "cgst-qc.database.windows.net";
            RptDatabase = "cgst-bear-rpt";
            CSPUsername = "zchekir@cogstate.com";
            CSPPassword = "Cogstate2016";
            Authentication = "Active Directory Password";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Check_Pending_Cells Instance
        {
            get { return instance; }
        }

#region Variables

        string _TestIdentifier;

        /// <summary>
        /// Gets or sets the value of variable TestIdentifier.
        /// </summary>
        [TestVariable("b2dc96c4-f70a-419b-b408-823dc38808d1")]
        public string TestIdentifier
        {
            get { return _TestIdentifier; }
            set { _TestIdentifier = value; }
        }

        string _DBServer;

        /// <summary>
        /// Gets or sets the value of variable DBServer.
        /// </summary>
        [TestVariable("00c37608-7147-4234-b38a-a3de330366bf")]
        public string DBServer
        {
            get { return _DBServer; }
            set { _DBServer = value; }
        }

        string _RptDatabase;

        /// <summary>
        /// Gets or sets the value of variable RptDatabase.
        /// </summary>
        [TestVariable("e681316c-42cb-4c83-8246-0ff801cabffa")]
        public string RptDatabase
        {
            get { return _RptDatabase; }
            set { _RptDatabase = value; }
        }

        string _CSPPassword;

        /// <summary>
        /// Gets or sets the value of variable CSPPassword.
        /// </summary>
        [TestVariable("e97c2288-b590-45f3-917f-8d5240416341")]
        public string CSPPassword
        {
            get { return _CSPPassword; }
            set { _CSPPassword = value; }
        }

        string _Authentication;

        /// <summary>
        /// Gets or sets the value of variable Authentication.
        /// </summary>
        [TestVariable("592d9682-c36b-48f4-9a7f-bfe539527b8b")]
        public string Authentication
        {
            get { return _Authentication; }
            set { _Authentication = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable CSPUsername.
        /// </summary>
        [TestVariable("daf603e2-eb88-46f1-8eca-e2b4bce773ea")]
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

            CheckPending(DBServer, RptDatabase, CSPUsername, CSPPassword, Authentication);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
