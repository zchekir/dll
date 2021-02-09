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
    ///The Clear_Test_Slicer recording.
    /// </summary>
    [TestModule("c54f947a-0235-4689-b126-7e7629c48e9b", ModuleType.Recording, 1)]
    public partial class Clear_Test_Slicer : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::ReportingLayer.ReportingLayerRepository repository.
        /// </summary>
        public static global::ReportingLayer.ReportingLayerRepository repo = global::ReportingLayer.ReportingLayerRepository.Instance;

        static Clear_Test_Slicer instance = new Clear_Test_Slicer();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Clear_Test_Slicer()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Clear_Test_Slicer Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PowerBI.Slicers.SerchTestIdentifier' at Center.", repo.PowerBI.Slicers.SerchTestIdentifierInfo, new RecordItemIndex(0));
            repo.PowerBI.Slicers.SerchTestIdentifier.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$TestIdentifier' with focus on 'PowerBI.Slicers.SerchTestIdentifier'.", repo.PowerBI.Slicers.SerchTestIdentifierInfo, new RecordItemIndex(1));
            repo.PowerBI.Slicers.SerchTestIdentifier.PressKeys(TestIdentifier);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'PowerBI.ClearTestSelections' at Center.", repo.PowerBI.ClearTestSelectionsInfo, new RecordItemIndex(2));
            repo.PowerBI.ClearTestSelections.MoveTo();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'PowerBI.ClearTestSelections' at Center.", repo.PowerBI.ClearTestSelectionsInfo, new RecordItemIndex(3));
            repo.PowerBI.ClearTestSelections.DoubleClick(3);
            Delay.Milliseconds(490);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'PowerBI.Slicers.SelectCheckBox' at Center.", repo.PowerBI.Slicers.SelectCheckBoxInfo, new RecordItemIndex(4));
            repo.PowerBI.Slicers.SelectCheckBox.MoveTo();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PowerBI.Slicers.SelectCheckBox' at Center.", repo.PowerBI.Slicers.SelectCheckBoxInfo, new RecordItemIndex(5));
            repo.PowerBI.Slicers.SelectCheckBox.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1m.", new RecordItemIndex(6));
            Delay.Duration(60000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
