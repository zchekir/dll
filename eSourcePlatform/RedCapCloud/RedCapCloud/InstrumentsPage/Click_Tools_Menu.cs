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

namespace RedCapCloud.InstrumentsPage
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Click_Tools_Menu recording.
    /// </summary>
    [TestModule("13871cb9-c76a-400f-bd8b-8d53ae8c2114", ModuleType.Recording, 1)]
    public partial class Click_Tools_Menu : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::RedCapCloud.RedCapCloudRepository repository.
        /// </summary>
        public static global::RedCapCloud.RedCapCloudRepository repo = global::RedCapCloud.RedCapCloudRepository.Instance;

        static Click_Tools_Menu instance = new Click_Tools_Menu();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Click_Tools_Menu()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Click_Tools_Menu Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable RCCDOM.
        /// </summary>
        [TestVariable("6f24cf1a-0e47-4c45-9ce6-3e042db234d2")]
        public string RCCDOM
        {
            get { return repo.RCCDOM; }
            set { repo.RCCDOM = value; }
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(0));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'REDCapCloud.InstrumentsPage.ToolsMenu'", repo.REDCapCloud.InstrumentsPage.ToolsMenuInfo, new ActionTimeout(30000), new RecordItemIndex(1));
            repo.REDCapCloud.InstrumentsPage.ToolsMenuInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'REDCapCloud.InstrumentsPage.ToolsMenu' at Center.", repo.REDCapCloud.InstrumentsPage.ToolsMenuInfo, new RecordItemIndex(2));
            repo.REDCapCloud.InstrumentsPage.ToolsMenu.Click(100);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
