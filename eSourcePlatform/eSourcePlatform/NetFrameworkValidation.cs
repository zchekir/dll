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

namespace eSourcePlatform
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The NetFrameworkValidation recording.
    /// </summary>
    [TestModule("fb326cbf-1e96-4635-a5ac-840af6cdb390", ModuleType.Recording, 1)]
    public partial class NetFrameworkValidation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the eSourcePlatformRepository repository.
        /// </summary>
        public static eSourcePlatformRepository repo = eSourcePlatformRepository.Instance;

        static NetFrameworkValidation instance = new NetFrameworkValidation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public NetFrameworkValidation()
        {
            NetFrameVersion = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static NetFrameworkValidation Instance
        {
            get { return instance; }
        }

#region Variables

        string _NetFrameVersion;

        /// <summary>
        /// Gets or sets the value of variable NetFrameVersion.
        /// </summary>
        [TestVariable("6336c0ec-26c4-42d6-bce2-af2883c0673a")]
        public string NetFrameVersion
        {
            get { return _NetFrameVersion; }
            set { _NetFrameVersion = value; }
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

            Get_value_NetFramework(repo.DiagnosticConsole.NetFrameworkInfo, NetFrameVersion);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2m.", new RecordItemIndex(1));
            Delay.Duration(120000, false);
            
            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'DiagnosticConsole.NetFramework'.", repo.DiagnosticConsole.NetFrameworkInfo, new RecordItemIndex(2));
            Host.Current.CloseApplication(repo.DiagnosticConsole.NetFramework, new Duration(0));
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
