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
    ///The V1_AuthenticateAPI recording.
    /// </summary>
    [TestModule("6c267ae0-eccc-42f7-bcf7-7d5dc0866964", ModuleType.Recording, 1)]
    public partial class V1_AuthenticateAPI : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CSPRepository repository.
        /// </summary>
        public static CSPRepository repo = CSPRepository.Instance;

        static V1_AuthenticateAPI instance = new V1_AuthenticateAPI();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public V1_AuthenticateAPI()
        {
            DOM = "cgst-qc-orr.azurewebsites.net";
            Key = "5767c4d2-be6c-4bdc-ac60-5ba8474f37af";
            secret = "305e95af-bb38-4a00-bf8e-448d06f67f55";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static V1_AuthenticateAPI Instance
        {
            get { return instance; }
        }

#region Variables

        string _DOM;

        /// <summary>
        /// Gets or sets the value of variable DOM.
        /// </summary>
        [TestVariable("b7e113f5-d292-4949-afa8-81cac921e840")]
        public string DOM
        {
            get { return _DOM; }
            set { _DOM = value; }
        }

        string _secret;

        /// <summary>
        /// Gets or sets the value of variable secret.
        /// </summary>
        [TestVariable("05c56c37-01a1-4ad9-92c6-3294df178117")]
        public string secret
        {
            get { return _secret; }
            set { _secret = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Key.
        /// </summary>
        [TestVariable("62f54ed9-1a1e-4d81-8545-c144147955a9")]
        public string Key
        {
            get { return repo.Key; }
            set { repo.Key = value; }
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

            V1AuthenticationAPI(DOM, secret, Key);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
