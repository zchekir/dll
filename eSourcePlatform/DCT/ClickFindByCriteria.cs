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
    ///The ClickFindByCriteria recording.
    /// </summary>
    [TestModule("4bd6b653-9d23-4171-8284-dabedc95e86b", ModuleType.Recording, 1)]
    public partial class ClickFindByCriteria : ITestModule
    {
        /// <summary>
        /// Holds an instance of the DCTRepository repository.
        /// </summary>
        public static DCTRepository repo = DCTRepository.Instance;

        static ClickFindByCriteria instance = new ClickFindByCriteria();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ClickFindByCriteria()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ClickFindByCriteria Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable DCTDOM.
        /// </summary>
        [TestVariable("b4062045-8a57-448e-b3d6-6bd8f25d8dad")]
        public string DCTDOM
        {
            get { return repo.DCTDOM; }
            set { repo.DCTDOM = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DataCleaningTool.FindByCriteria' at Center.", repo.DataCleaningTool.FindByCriteriaInfo, new RecordItemIndex(0));
            repo.DataCleaningTool.FindByCriteria.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
