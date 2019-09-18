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
    ///The Verify_Version_Client recording.
    /// </summary>
    [TestModule("bbd7de50-f153-4542-b412-b02ff4df214c", ModuleType.Recording, 1)]
    public partial class Verify_Version_Client : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::CSP.CSPRepository repository.
        /// </summary>
        public static global::CSP.CSPRepository repo = global::CSP.CSPRepository.Instance;

        static Verify_Version_Client instance = new Verify_Version_Client();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_Version_Client()
        {
            CSPDOM = "";
            Server = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_Version_Client Instance
        {
            get { return instance; }
        }

#region Variables

        string _Server;

        /// <summary>
        /// Gets or sets the value of variable Server.
        /// </summary>
        [TestVariable("7e058fce-68f4-4858-9c01-983db9e3c891")]
        public string Server
        {
            get { return _Server; }
            set { _Server = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable CSPDOM.
        /// </summary>
        [TestVariable("5573f8ac-d505-42b0-a336-394c8bca477a")]
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

            engine.Helpers.WebService.C_Version(CSPDOM);
            Delay.Milliseconds(0);
            
            ClientValidation();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
