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
    ///The InnalidMethode recording.
    /// </summary>
    [TestModule("8f0a81f9-8c93-4991-a51a-72922622081c", ModuleType.Recording, 1)]
    public partial class InnalidMethode : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CSPRepository repository.
        /// </summary>
        public static CSPRepository repo = CSPRepository.Instance;

        static InnalidMethode instance = new InnalidMethode();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InnalidMethode()
        {
            secret = "";
            StudyProtocol = "";
            DOM = "";
            invalidSecret = "";
            key = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InnalidMethode Instance
        {
            get { return instance; }
        }

#region Variables

        string _secret;

        /// <summary>
        /// Gets or sets the value of variable secret.
        /// </summary>
        [TestVariable("314adaf8-554a-45e9-bd83-b3bd6da59f8e")]
        public string secret
        {
            get { return _secret; }
            set { _secret = value; }
        }

        string _StudyProtocol;

        /// <summary>
        /// Gets or sets the value of variable StudyProtocol.
        /// </summary>
        [TestVariable("dc80104d-340b-414f-b4b4-e62613ed86bd")]
        public string StudyProtocol
        {
            get { return _StudyProtocol; }
            set { _StudyProtocol = value; }
        }

        string _DOM;

        /// <summary>
        /// Gets or sets the value of variable DOM.
        /// </summary>
        [TestVariable("a5ff7d3a-f594-4f8e-88e5-71a78c8aec95")]
        public string DOM
        {
            get { return _DOM; }
            set { _DOM = value; }
        }

        string _invalidSecret;

        /// <summary>
        /// Gets or sets the value of variable invalidSecret.
        /// </summary>
        [TestVariable("3def5a72-4bb2-4d6f-bf23-80f1516a952f")]
        public string invalidSecret
        {
            get { return _invalidSecret; }
            set { _invalidSecret = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable key.
        /// </summary>
        [TestVariable("6c9dce3d-d56e-4e52-92cc-97ef54372e33")]
        public string key
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

            Invalid_Methode();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
