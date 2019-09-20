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

namespace CSP.APIModules
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The APIV2_QualificationStatus recording.
    /// </summary>
    [TestModule("8080cd65-37d3-431e-8bd9-4ff840801312", ModuleType.Recording, 1)]
    public partial class APIV2_QualificationStatus : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::CSP.CSPRepository repository.
        /// </summary>
        public static global::CSP.CSPRepository repo = global::CSP.CSPRepository.Instance;

        static APIV2_QualificationStatus instance = new APIV2_QualificationStatus();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public APIV2_QualificationStatus()
        {
            DOM = "cgst-qc-duo.cogstate.com";
            RandNum = "";
            ProtocolNumber = "Ranorex Protocol Number";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static APIV2_QualificationStatus Instance
        {
            get { return instance; }
        }

#region Variables

        string _DOM;

        /// <summary>
        /// Gets or sets the value of variable DOM.
        /// </summary>
        [TestVariable("f6062ed9-9482-48a1-ac41-081363e7698e")]
        public string DOM
        {
            get { return _DOM; }
            set { _DOM = value; }
        }

        string _ProtocolNumber;

        /// <summary>
        /// Gets or sets the value of variable ProtocolNumber.
        /// </summary>
        [TestVariable("6017c17a-abf9-48f7-926e-a1d1d8419954")]
        public string ProtocolNumber
        {
            get { return _ProtocolNumber; }
            set { _ProtocolNumber = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable RandNum.
        /// </summary>
        [TestVariable("ce244600-855c-465a-97fa-6250038a91dd")]
        public string RandNum
        {
            get { return repo.RandNum; }
            set { repo.RandNum = value; }
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

            engine.Helpers.WebService.GetQualificationStatus(RandNum, DOM, ProtocolNumber);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
