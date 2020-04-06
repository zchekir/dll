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
    ///The APIV2_ParticipantQualification_Status recording.
    /// </summary>
    [TestModule("7564efa3-5dfb-429a-8be6-2697f96acf66", ModuleType.Recording, 1)]
    public partial class APIV2_ParticipantQualification_Status : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::CSP.CSPRepository repository.
        /// </summary>
        public static global::CSP.CSPRepository repo = global::CSP.CSPRepository.Instance;

        static APIV2_ParticipantQualification_Status instance = new APIV2_ParticipantQualification_Status();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public APIV2_ParticipantQualification_Status()
        {
            DOM = "";
            studyProtocolName = "";
            externalid = "";
            AuthToken = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static APIV2_ParticipantQualification_Status Instance
        {
            get { return instance; }
        }

#region Variables

        string _DOM;

        /// <summary>
        /// Gets or sets the value of variable DOM.
        /// </summary>
        [TestVariable("ce0eb756-9ae4-4102-bcb9-4fee480f39b6")]
        public string DOM
        {
            get { return _DOM; }
            set { _DOM = value; }
        }

        string _studyProtocolName;

        /// <summary>
        /// Gets or sets the value of variable studyProtocolName.
        /// </summary>
        [TestVariable("2436bc6b-b437-4437-a127-e86e3edb27e2")]
        public string studyProtocolName
        {
            get { return _studyProtocolName; }
            set { _studyProtocolName = value; }
        }

        string _externalid;

        /// <summary>
        /// Gets or sets the value of variable externalid.
        /// </summary>
        [TestVariable("c57c4bea-20ef-4adb-b5a7-49effd8a2370")]
        public string externalid
        {
            get { return _externalid; }
            set { _externalid = value; }
        }

        string _AuthToken;

        /// <summary>
        /// Gets or sets the value of variable AuthToken.
        /// </summary>
        [TestVariable("b2ac9a86-54f6-4d71-a1de-3222a4de05f2")]
        public string AuthToken
        {
            get { return _AuthToken; }
            set { _AuthToken = value; }
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

            Participant_QualificationStatus();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
