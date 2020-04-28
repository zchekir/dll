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
    ///The ValidatinTheDatSCV recording.
    /// </summary>
    [TestModule("fe5e7eea-cac2-48d8-a015-66c734eb7ce5", ModuleType.Recording, 1)]
    public partial class ValidatinTheDatSCV : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CSPRepository repository.
        /// </summary>
        public static CSPRepository repo = CSPRepository.Instance;

        static ValidatinTheDatSCV instance = new ValidatinTheDatSCV();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidatinTheDatSCV()
        {
            TestIdentifier = "3e56ef3d-f702-41d7-b474-73d6524024e5";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidatinTheDatSCV Instance
        {
            get { return instance; }
        }

#region Variables

        string _TestIdentifier;

        /// <summary>
        /// Gets or sets the value of variable TestIdentifier.
        /// </summary>
        [TestVariable("4ce106f9-0bc5-4cdb-a260-6744372a260f")]
        public string TestIdentifier
        {
            get { return _TestIdentifier; }
            set { _TestIdentifier = value; }
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

            csvDataValidation();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
