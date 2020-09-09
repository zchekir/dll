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

namespace CSP.APIV1Modules
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The APIV1_ReferralStatus recording.
    /// </summary>
    [TestModule("25e2a597-538e-4553-af69-d582add674b4", ModuleType.Recording, 1)]
    public partial class APIV1_ReferralStatus : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::CSP.CSPRepository repository.
        /// </summary>
        public static global::CSP.CSPRepository repo = global::CSP.CSPRepository.Instance;

        static APIV1_ReferralStatus instance = new APIV1_ReferralStatus();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public APIV1_ReferralStatus()
        {
            visitsession = "110872";
            CSPDOM = "cgst-qc-orr.azurewebsites.net";
            externalId = "7086092750633861";
            AuthToken = "ZAvudGtQyt5MfdxdAVGRCDnLBR0yoUJDdkE0mEpzdYc7OCHXLHfgFRMZXsrOZb-p";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static APIV1_ReferralStatus Instance
        {
            get { return instance; }
        }

#region Variables

        string _visitsession;

        /// <summary>
        /// Gets or sets the value of variable visitsession.
        /// </summary>
        [TestVariable("41388a0a-76aa-43f4-93b1-ce52059feed5")]
        public string visitsession
        {
            get { return _visitsession; }
            set { _visitsession = value; }
        }

        string _externalId;

        /// <summary>
        /// Gets or sets the value of variable externalId.
        /// </summary>
        [TestVariable("8236c42e-b21a-468c-8b20-d1cebbe63072")]
        public string externalId
        {
            get { return _externalId; }
            set { _externalId = value; }
        }

        string _AuthToken;

        /// <summary>
        /// Gets or sets the value of variable AuthToken.
        /// </summary>
        [TestVariable("91b9db8e-9e88-4c2f-a39b-01b65efe4a14")]
        public string AuthToken
        {
            get { return _AuthToken; }
            set { _AuthToken = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable CSPDOM.
        /// </summary>
        [TestVariable("3f1a37b1-0a7c-4ea0-8f2f-bae9b206051a")]
        public string CSPDOM
        {
            get { return repo.CSPDOM; }
            set { repo.CSPDOM = value; }
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

            StatusReferral(visitsession, CSPDOM, externalId, AuthToken);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
