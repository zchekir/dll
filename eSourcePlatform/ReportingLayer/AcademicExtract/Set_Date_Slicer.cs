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

namespace ReportingLayer.AcademicExtract
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Set_Date_Slicer recording.
    /// </summary>
    [TestModule("b456cb46-8166-4fa6-822b-4dc5f55b97b5", ModuleType.Recording, 1)]
    public partial class Set_Date_Slicer : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::ReportingLayer.ReportingLayerRepository repository.
        /// </summary>
        public static global::ReportingLayer.ReportingLayerRepository repo = global::ReportingLayer.ReportingLayerRepository.Instance;

        static Set_Date_Slicer instance = new Set_Date_Slicer();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Set_Date_Slicer()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Set_Date_Slicer Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PowerBI.DateSlicerToRange' at Center.", repo.PowerBI.DateSlicerToRangeInfo, new RecordItemIndex(0));
            repo.PowerBI.DateSlicerToRange.Click();
            Delay.Milliseconds(200);
            
            EnterToDate(repo.PowerBI.DateSlicerToRangeInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PowerBI.DateSlicerFromRange' at Center.", repo.PowerBI.DateSlicerFromRangeInfo, new RecordItemIndex(2));
            repo.PowerBI.DateSlicerFromRange.Click();
            Delay.Milliseconds(200);
            
            EnterFromDate(repo.PowerBI.DateSlicerFromRangeInfo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
