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

namespace ReportingLayer.StandardExtract
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Set_TestIdentifier_Filter recording.
    /// </summary>
    [TestModule("478d647e-d7d3-47c9-bc73-483c7f81df1f", ModuleType.Recording, 1)]
    public partial class Set_TestIdentifier_Filter : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::ReportingLayer.ReportingLayerRepository repository.
        /// </summary>
        public static global::ReportingLayer.ReportingLayerRepository repo = global::ReportingLayer.ReportingLayerRepository.Instance;

        static Set_TestIdentifier_Filter instance = new Set_TestIdentifier_Filter();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Set_TestIdentifier_Filter()
        {
            TestIdentifier = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Set_TestIdentifier_Filter Instance
        {
            get { return instance; }
        }

#region Variables

        string _TestIdentifier;

        /// <summary>
        /// Gets or sets the value of variable TestIdentifier.
        /// </summary>
        [TestVariable("8aa89dac-1cd3-46e4-8810-9ee134597bdc")]
        public string TestIdentifier
        {
            get { return _TestIdentifier; }
            set { _TestIdentifier = value; }
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1m.", new RecordItemIndex(0));
            Delay.Duration(60000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'PowerBI' at Center.", repo.PowerBI.SelfInfo, new RecordItemIndex(1));
            repo.PowerBI.Self.MoveTo();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PowerBI.FilterButton' at Center.", repo.PowerBI.FilterButtonInfo, new RecordItemIndex(2));
            repo.PowerBI.FilterButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Escape} '.", new RecordItemIndex(3));
            Keyboard.Press("{Escape} ");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PowerBI.SearchFilterBox' at Center.", repo.PowerBI.SearchFilterBoxInfo, new RecordItemIndex(4));
            repo.PowerBI.SearchFilterBox.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(5));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'TestIdentifier' with focus on 'PowerBI.SearchFilterBox'.", repo.PowerBI.SearchFilterBoxInfo, new RecordItemIndex(6));
            repo.PowerBI.SearchFilterBox.PressKeys("TestIdentifier", 10);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(7));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PowerBI.FilterOptions.TestIdentifierFilter.ExpandFilter' at Center.", repo.PowerBI.FilterOptions.TestIdentifierFilter.ExpandFilterInfo, new RecordItemIndex(8));
            repo.PowerBI.FilterOptions.TestIdentifierFilter.ExpandFilter.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$TestIdentifier' with focus on 'PowerBI.FilterOptions.TestIdentifierFilter.SearchFilter'.", repo.PowerBI.FilterOptions.TestIdentifierFilter.SearchFilterInfo, new RecordItemIndex(9));
            repo.PowerBI.FilterOptions.TestIdentifierFilter.SearchFilter.PressKeys(TestIdentifier);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(10));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PowerBI.FilterOptions.TestIdentifierFilter.CheckboxOption' at Center.", repo.PowerBI.FilterOptions.TestIdentifierFilter.CheckboxOptionInfo, new RecordItemIndex(11));
            repo.PowerBI.FilterOptions.TestIdentifierFilter.CheckboxOption.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(12));
            Delay.Duration(500, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
