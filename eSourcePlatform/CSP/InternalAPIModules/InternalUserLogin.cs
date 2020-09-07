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

namespace CSP.InternalAPIModules
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The InternalUserLogin recording.
    /// </summary>
    [TestModule("e4973cbd-dfaf-437f-8fc4-144e686549f9", ModuleType.Recording, 1)]
    public partial class InternalUserLogin : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::CSP.CSPRepository repository.
        /// </summary>
        public static global::CSP.CSPRepository repo = global::CSP.CSPRepository.Instance;

        static InternalUserLogin instance = new InternalUserLogin();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InternalUserLogin()
        {
            CSPDOM = "";
            username = "";
            password = "";
            portal = "";
            I_AuthToken = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InternalUserLogin Instance
        {
            get { return instance; }
        }

#region Variables

        string _username;

        /// <summary>
        /// Gets or sets the value of variable username.
        /// </summary>
        [TestVariable("b88c9ec6-962a-444e-bac4-93815b46ba02")]
        public string username
        {
            get { return _username; }
            set { _username = value; }
        }

        string _password;

        /// <summary>
        /// Gets or sets the value of variable password.
        /// </summary>
        [TestVariable("4ef44368-44b5-44b2-9dce-c461e383f730")]
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        string _portal;

        /// <summary>
        /// Gets or sets the value of variable portal.
        /// </summary>
        [TestVariable("7fd94859-698e-4303-9a50-498db567abb5")]
        public string portal
        {
            get { return _portal; }
            set { _portal = value; }
        }

        string _I_AuthToken;

        /// <summary>
        /// Gets or sets the value of variable I_AuthToken.
        /// </summary>
        [TestVariable("2a039670-f597-4146-af80-1d37403d4686")]
        public string I_AuthToken
        {
            get { return _I_AuthToken; }
            set { _I_AuthToken = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable CSPDOM.
        /// </summary>
        [TestVariable("3ae820f3-cb8f-4e51-af3b-138594b47045")]
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

            Internal_UserLogin();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
