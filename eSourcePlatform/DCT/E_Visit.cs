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

namespace DCT
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The E_Visit recording.
    /// </summary>
    [TestModule("d0095689-a29f-4e12-b935-b16779cc190b", ModuleType.Recording, 1)]
    public partial class E_Visit : ITestModule
    {
        /// <summary>
        /// Holds an instance of the DCTRepository repository.
        /// </summary>
        public static DCTRepository repo = DCTRepository.Instance;

        static E_Visit instance = new E_Visit();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public E_Visit()
        {
            DCTVisit = "vit";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static E_Visit Instance
        {
            get { return instance; }
        }

#region Variables

        string _DCTVisit;

        /// <summary>
        /// Gets or sets the value of variable DCTVisit.
        /// </summary>
        [TestVariable("761f832e-6cc2-4e00-a143-1d08ebd31d37")]
        public string DCTVisit
        {
            get { return _DCTVisit; }
            set { _DCTVisit = value; }
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

            //Visit(DCTVisit);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DataCleaningTool.EnterVisit_' at Center.", repo.DataCleaningTool.EnterVisit_Info, new RecordItemIndex(1));
            //repo.DataCleaningTool.EnterVisit_.Click();
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DCTVisit' with focus on 'DataCleaningTool.EnterVisit_'.", repo.DataCleaningTool.EnterVisit_Info, new RecordItemIndex(2));
            //repo.DataCleaningTool.EnterVisit_.PressKeys(DCTVisit);
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DataCleaningTool.EnterVisit_' at Center.", repo.DataCleaningTool.EnterVisit_Info, new RecordItemIndex(3));
            repo.DataCleaningTool.EnterVisit_.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DCTVisit' with focus on 'DataCleaningTool.EnterVisit_'.", repo.DataCleaningTool.EnterVisit_Info, new RecordItemIndex(4));
            repo.DataCleaningTool.EnterVisit_.PressKeys(DCTVisit);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{TAB}'.", new RecordItemIndex(5));
            Keyboard.Press("{TAB}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
