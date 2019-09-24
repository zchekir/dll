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
    ///The Validate_Sync_Success recording.
    /// </summary>
    [TestModule("ff849467-5c5b-4735-9e50-3e3d77a297b2", ModuleType.Recording, 1)]
    public partial class Validate_Sync_Success : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::CSP.CSPRepository repository.
        /// </summary>
        public static global::CSP.CSPRepository repo = global::CSP.CSPRepository.Instance;

        static Validate_Sync_Success instance = new Validate_Sync_Success();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Validate_Sync_Success()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Validate_Sync_Success Instance
        {
            get { return instance; }
        }

#region Variables

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

            try {
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 45s to exist. Associated repository item: 'CogstateSolutionPlatform.Popups.SynchronizationSuccessful'", repo.CogstateSolutionPlatform.Popups.SynchronizationSuccessfulInfo, new ActionTimeout(45000), new RecordItemIndex(0));
                repo.CogstateSolutionPlatform.Popups.SynchronizationSuccessfulInfo.WaitForExists(45000);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Synchronization Successful') on item 'CogstateSolutionPlatform.Popups.SynchronizationSuccessful'.", repo.CogstateSolutionPlatform.Popups.SynchronizationSuccessfulInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.CogstateSolutionPlatform.Popups.SynchronizationSuccessfulInfo, "InnerText", "Synchronization Successful");
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "Data Successfully Synchronized", repo.CogstateSolutionPlatform.Self, false, new RecordItemIndex(2));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
