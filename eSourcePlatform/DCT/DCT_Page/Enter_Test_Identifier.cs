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

namespace DCT.DCT_Page
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Enter_Test_Identifier recording.
    /// </summary>
    [TestModule("d402610e-47e3-451e-84ef-01a160a71297", ModuleType.Recording, 1)]
    public partial class Enter_Test_Identifier : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::DCT.DCTRepository repository.
        /// </summary>
        public static global::DCT.DCTRepository repo = global::DCT.DCTRepository.Instance;

        static Enter_Test_Identifier instance = new Enter_Test_Identifier();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Enter_Test_Identifier()
        {
            TestIdentifier = "1111111111111111111111";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Enter_Test_Identifier Instance
        {
            get { return instance; }
        }

#region Variables

        string _TestIdentifier;

        /// <summary>
        /// Gets or sets the value of variable TestIdentifier.
        /// </summary>
        [TestVariable("cd5709a5-7d80-4f0b-8981-7c29b0cf054c")]
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

            Report.Log(ReportLevel.Info, "User", TestIdentifier, new RecordItemIndex(0));
            
            //TestInd(TestIdentifier);
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$TestIdentifier' with focus on 'DataCleaningTool1.FindByAssessmentId'.", repo.DataCleaningTool1.FindByAssessmentIdInfo, new RecordItemIndex(2));
            repo.DataCleaningTool1.FindByAssessmentId.PressKeys(TestIdentifier);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
