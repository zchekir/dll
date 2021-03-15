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
    ///The Validate_ExcludeAssessment_Flag recording.
    /// </summary>
    [TestModule("933cb94d-9a39-48c7-b06b-15f54d10a8b2", ModuleType.Recording, 1)]
    public partial class Validate_ExcludeAssessment_Flag : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::ReportingLayer.ReportingLayerRepository repository.
        /// </summary>
        public static global::ReportingLayer.ReportingLayerRepository repo = global::ReportingLayer.ReportingLayerRepository.Instance;

        static Validate_ExcludeAssessment_Flag instance = new Validate_ExcludeAssessment_Flag();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Validate_ExcludeAssessment_Flag()
        {
            Authentication = "";
            CPAPassword = "";
            CPAUsername = "";
            DBServer = "";
            Database = "";
            TestIdentifier = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Validate_ExcludeAssessment_Flag Instance
        {
            get { return instance; }
        }

#region Variables

        string _Authentication;

        /// <summary>
        /// Gets or sets the value of variable Authentication.
        /// </summary>
        [TestVariable("b64e7cde-bbd4-4376-94e5-8f43579bbed3")]
        public string Authentication
        {
            get { return _Authentication; }
            set { _Authentication = value; }
        }

        string _CPAPassword;

        /// <summary>
        /// Gets or sets the value of variable CPAPassword.
        /// </summary>
        [TestVariable("28b1a968-46db-4075-9fe5-7dab1939c204")]
        public string CPAPassword
        {
            get { return _CPAPassword; }
            set { _CPAPassword = value; }
        }

        string _DBServer;

        /// <summary>
        /// Gets or sets the value of variable DBServer.
        /// </summary>
        [TestVariable("17fd0ab6-8df3-4b97-bcd7-c4a856863dec")]
        public string DBServer
        {
            get { return _DBServer; }
            set { _DBServer = value; }
        }

        string _Database;

        /// <summary>
        /// Gets or sets the value of variable Database.
        /// </summary>
        [TestVariable("8a201856-f512-43e5-8a58-6ee8078673fb")]
        public string Database
        {
            get { return _Database; }
            set { _Database = value; }
        }

        string _TestIdentifier;

        /// <summary>
        /// Gets or sets the value of variable TestIdentifier.
        /// </summary>
        [TestVariable("8fe27a60-0666-4c13-8bc8-1258d62a11a4")]
        public string TestIdentifier
        {
            get { return _TestIdentifier; }
            set { _TestIdentifier = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable CPAUsername.
        /// </summary>
        [TestVariable("8c8cfb72-1ffe-4fee-b048-e08996b148ae")]
        public string CPAUsername
        {
            get { return repo.CPAUsername; }
            set { repo.CPAUsername = value; }
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

            GetFlag(Database, DBServer, CPAUsername, CPAPassword, Authentication);
            Delay.Milliseconds(0);
            
            ReportFlag();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
