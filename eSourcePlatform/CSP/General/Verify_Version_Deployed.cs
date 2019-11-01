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

namespace CSP.General
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Verify_Version_Deployed recording.
    /// </summary>
    [TestModule("c718511d-4281-405c-9160-251f311d2703", ModuleType.Recording, 1)]
    public partial class Verify_Version_Deployed : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::CSP.CSPRepository repository.
        /// </summary>
        public static global::CSP.CSPRepository repo = global::CSP.CSPRepository.Instance;

        static Verify_Version_Deployed instance = new Verify_Version_Deployed();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_Version_Deployed()
        {
            ServerVersion = "1.10.0.7526";
            CSPDOM = "cgst-qc-orr.azurewebsites.net";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_Version_Deployed Instance
        {
            get { return instance; }
        }

#region Variables

        string _ServerVersion;

        /// <summary>
        /// Gets or sets the value of variable ServerVersion.
        /// </summary>
        [TestVariable("3405ba1d-b660-45c9-ae63-2a2a96b1364e")]
        public string ServerVersion
        {
            get { return _ServerVersion; }
            set { _ServerVersion = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable CSPDOM.
        /// </summary>
        [TestVariable("f54fbb85-c5ac-4f6a-98d6-049472b68327")]
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

            engine.Helpers.WebService.ServerVersion(CSPDOM);
            Delay.Milliseconds(0);
            
            VersionValidation();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
