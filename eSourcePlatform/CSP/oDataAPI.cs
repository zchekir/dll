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
    ///The oDataAPI recording.
    /// </summary>
    [TestModule("e5c5155b-1c7b-4dcd-9aad-e16fa12f0735", ModuleType.Recording, 1)]
    public partial class oDataAPI : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CSPRepository repository.
        /// </summary>
        public static CSPRepository repo = CSPRepository.Instance;

        static oDataAPI instance = new oDataAPI();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public oDataAPI()
        {
            CSPDOM = "cgst-qc-orr.azurewebsites.net";
            ProtocolNumber = "";
            token = "bIKSv9W2XerfKckVPMexzEfR42euEhqgZOXehV4gEVsqjR8mVeoy6xuR_XxMj0As";
            RandNum = "";
            Key = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static oDataAPI Instance
        {
            get { return instance; }
        }

#region Variables

        string _ProtocolNumber;

        /// <summary>
        /// Gets or sets the value of variable ProtocolNumber.
        /// </summary>
        [TestVariable("11aa8809-f874-4ac3-be34-3eeb27f4515e")]
        public string ProtocolNumber
        {
            get { return _ProtocolNumber; }
            set { _ProtocolNumber = value; }
        }

        string _token;

        /// <summary>
        /// Gets or sets the value of variable token.
        /// </summary>
        [TestVariable("5eeb1a88-fdcf-4023-abff-5b24c8a887c1")]
        public string token
        {
            get { return _token; }
            set { _token = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable CSPDOM.
        /// </summary>
        [TestVariable("c8b4b7d8-5ec1-44d1-9ce3-70a3bdb9b058")]
        public string CSPDOM
        {
            get { return repo.CSPDOM; }
            set { repo.CSPDOM = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable RandNum.
        /// </summary>
        [TestVariable("71310b93-a35f-46be-9c69-3ee20b568499")]
        public string RandNum
        {
            get { return repo.RandNum; }
            set { repo.RandNum = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Key.
        /// </summary>
        [TestVariable("c876df1e-bfea-4796-a52b-9bb42e3883a7")]
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

            engine.Helpers.WebService.oData(token);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
