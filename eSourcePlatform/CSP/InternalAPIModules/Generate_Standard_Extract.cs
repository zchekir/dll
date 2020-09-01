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
    ///The Generate_Standard_Extract recording.
    /// </summary>
    [TestModule("8203643e-31dc-4a6f-9d4e-39d89aad76a6", ModuleType.Recording, 1)]
    public partial class Generate_Standard_Extract : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::CSP.CSPRepository repository.
        /// </summary>
        public static global::CSP.CSPRepository repo = global::CSP.CSPRepository.Instance;

        static Generate_Standard_Extract instance = new Generate_Standard_Extract();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Generate_Standard_Extract()
        {
            DOM = "";
            AuthToken = "";
            studid = "";
            BatteryConfigurationReports = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Generate_Standard_Extract Instance
        {
            get { return instance; }
        }

#region Variables

        string _DOM;

        /// <summary>
        /// Gets or sets the value of variable DOM.
        /// </summary>
        [TestVariable("2b5eb1c3-c095-4852-9694-912db827a0aa")]
        public string DOM
        {
            get { return _DOM; }
            set { _DOM = value; }
        }

        string _AuthToken;

        /// <summary>
        /// Gets or sets the value of variable AuthToken.
        /// </summary>
        [TestVariable("31e22614-3918-4963-8e74-185109b5c01e")]
        public string AuthToken
        {
            get { return _AuthToken; }
            set { _AuthToken = value; }
        }

        string _studid;

        /// <summary>
        /// Gets or sets the value of variable studid.
        /// </summary>
        [TestVariable("953bedaa-c4ee-4948-abeb-1f377d6a2b44")]
        public string studid
        {
            get { return _studid; }
            set { _studid = value; }
        }

        string _BatteryConfigurationReports;

        /// <summary>
        /// Gets or sets the value of variable BatteryConfigurationReports.
        /// </summary>
        [TestVariable("ecea577f-7024-4f55-8e11-1f49f457ca2d")]
        public string BatteryConfigurationReports
        {
            get { return _BatteryConfigurationReports; }
            set { _BatteryConfigurationReports = value; }
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

            Generate_StandardExtract(DOM, AuthToken);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
