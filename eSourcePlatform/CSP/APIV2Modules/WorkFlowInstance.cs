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
    ///The WorkFlowInstance recording.
    /// </summary>
    [TestModule("9a2b9fff-5819-4334-8d9a-6b84b58d99f8", ModuleType.Recording, 1)]
    public partial class WorkFlowInstance : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::CSP.CSPRepository repository.
        /// </summary>
        public static global::CSP.CSPRepository repo = global::CSP.CSPRepository.Instance;

        static WorkFlowInstance instance = new WorkFlowInstance();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public WorkFlowInstance()
        {
            AuthToken = "IgOgdLNEAzGEjvyONsrg1tgK2SSCu-8axAr8WOF52erGxL9SEyBZ7krKrwub3Wyp";
            studyProtocolName = "AutomationStudy";
            DOM = "cgst-qc-orr.azurewebsites.net";
            dob = "2000-01-01";
            genderCode = "m";
            localityCode = "en_US";
            postError = "WWW.GOOGLE.COM";
            post = "www.facebook.com";
            visitSessionCode = "visit1";
            supervisorId = "1";
            TestIdentifier = "";
            externalId = "";
            AssessmentURL = "";
            mode = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static WorkFlowInstance Instance
        {
            get { return instance; }
        }

#region Variables

        string _AuthToken;

        /// <summary>
        /// Gets or sets the value of variable AuthToken.
        /// </summary>
        [TestVariable("640023f9-9c6a-4a88-8722-9526acc509cc")]
        public string AuthToken
        {
            get { return _AuthToken; }
            set { _AuthToken = value; }
        }

        string _studyProtocolName;

        /// <summary>
        /// Gets or sets the value of variable studyProtocolName.
        /// </summary>
        [TestVariable("4b0a9c84-d41d-4d3c-b3c7-03dee9ee893c")]
        public string studyProtocolName
        {
            get { return _studyProtocolName; }
            set { _studyProtocolName = value; }
        }

        string _DOM;

        /// <summary>
        /// Gets or sets the value of variable DOM.
        /// </summary>
        [TestVariable("1d05b902-cc15-48e1-99d9-dfc534871d94")]
        public string DOM
        {
            get { return _DOM; }
            set { _DOM = value; }
        }

        string _dob;

        /// <summary>
        /// Gets or sets the value of variable dob.
        /// </summary>
        [TestVariable("baaaad91-5ccd-4dd6-9cbd-d4523f1da5cb")]
        public string dob
        {
            get { return _dob; }
            set { _dob = value; }
        }

        string _genderCode;

        /// <summary>
        /// Gets or sets the value of variable genderCode.
        /// </summary>
        [TestVariable("2e1366ad-da48-4246-816e-fa44895ddd07")]
        public string genderCode
        {
            get { return _genderCode; }
            set { _genderCode = value; }
        }

        string _localityCode;

        /// <summary>
        /// Gets or sets the value of variable localityCode.
        /// </summary>
        [TestVariable("8dd6b8c2-2a52-4502-8866-9304c3644c52")]
        public string localityCode
        {
            get { return _localityCode; }
            set { _localityCode = value; }
        }

        string _postError;

        /// <summary>
        /// Gets or sets the value of variable postError.
        /// </summary>
        [TestVariable("74e43bb7-921d-45b5-ba71-a320656a11fc")]
        public string postError
        {
            get { return _postError; }
            set { _postError = value; }
        }

        string _post;

        /// <summary>
        /// Gets or sets the value of variable post.
        /// </summary>
        [TestVariable("0844a293-2dc9-4219-9cb3-cafcd0f168bd")]
        public string post
        {
            get { return _post; }
            set { _post = value; }
        }

        string _visitSessionCode;

        /// <summary>
        /// Gets or sets the value of variable visitSessionCode.
        /// </summary>
        [TestVariable("5cf91dfd-49d7-4276-8188-104b3707a7e7")]
        public string visitSessionCode
        {
            get { return _visitSessionCode; }
            set { _visitSessionCode = value; }
        }

        string _supervisorId;

        /// <summary>
        /// Gets or sets the value of variable supervisorId.
        /// </summary>
        [TestVariable("fd2e40a7-d9e4-422c-b1d3-6c9247b2458e")]
        public string supervisorId
        {
            get { return _supervisorId; }
            set { _supervisorId = value; }
        }

        string _TestIdentifier;

        /// <summary>
        /// Gets or sets the value of variable TestIdentifier.
        /// </summary>
        [TestVariable("54bb55db-35b3-4db2-90ca-cb42cec494b3")]
        public string TestIdentifier
        {
            get { return _TestIdentifier; }
            set { _TestIdentifier = value; }
        }

        string _externalId;

        /// <summary>
        /// Gets or sets the value of variable externalId.
        /// </summary>
        [TestVariable("0e972c7a-57eb-4293-a7cc-32e75ea62d02")]
        public string externalId
        {
            get { return _externalId; }
            set { _externalId = value; }
        }

        string _AssessmentURL;

        /// <summary>
        /// Gets or sets the value of variable AssessmentURL.
        /// </summary>
        [TestVariable("72f9fd39-079c-4f76-a947-2a49e9350a9d")]
        public string AssessmentURL
        {
            get { return _AssessmentURL; }
            set { _AssessmentURL = value; }
        }

        string _mode;

        /// <summary>
        /// Gets or sets the value of variable mode.
        /// </summary>
        [TestVariable("f4f9ca38-7f8c-45a9-aabe-272a2438d295")]
        public string mode
        {
            get { return _mode; }
            set { _mode = value; }
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

            Workflow(AuthToken, studyProtocolName, DOM, dob, genderCode, localityCode, postError, post, mode);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
