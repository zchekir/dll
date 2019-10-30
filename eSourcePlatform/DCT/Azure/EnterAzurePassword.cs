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

namespace DCT.Azure
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The EnterAzurePassword recording.
    /// </summary>
    [TestModule("ea399d48-376a-48ca-be23-6753d5fe4e10", ModuleType.Recording, 1)]
    public partial class EnterAzurePassword : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::DCT.DCTRepository repository.
        /// </summary>
        public static global::DCT.DCTRepository repo = global::DCT.DCTRepository.Instance;

        static EnterAzurePassword instance = new EnterAzurePassword();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EnterAzurePassword()
        {
            OctopusPassword = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EnterAzurePassword Instance
        {
            get { return instance; }
        }

#region Variables

        string _OctopusPassword;

        /// <summary>
        /// Gets or sets the value of variable OctopusPassword.
        /// </summary>
        [TestVariable("2d566e3b-6a30-4d9c-94f0-3b4848ae1ea3")]
        public string OctopusPassword
        {
            get { return _OctopusPassword; }
            set { _OctopusPassword = value; }
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

            Key_sequence_PasswordInput(repo.SignIn.PasswordInputInfo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
