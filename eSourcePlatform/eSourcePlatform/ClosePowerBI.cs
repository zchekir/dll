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
    ///The ClosePowerBI recording.
    /// </summary>
    [TestModule("d74af8f5-0dda-4472-a322-756e01567e15", ModuleType.Recording, 1)]
    public partial class ClosePowerBI : ITestModule
    {
        /// <summary>
        /// Holds an instance of the eSourcePlatformRepository repository.
        /// </summary>
        public static eSourcePlatformRepository repo = eSourcePlatformRepository.Instance;

        static ClosePowerBI instance = new ClosePowerBI();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ClosePowerBI()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ClosePowerBI Instance
        {
            get { return instance; }
        }

#region Variables

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

            //Report.Log(ReportLevel.Info, "Application", "Killing application containing item 'AcademicExtractJORDANPowerBI.PowerBI'.", repo.AcademicExtractJORDANPowerBI.PowerBIInfo, new RecordItemIndex(0));
            //Host.Current.KillApplication(repo.AcademicExtractJORDANPowerBI.PowerBI);
            //Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
