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

namespace CSP
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The WAS_DB recording.
    /// </summary>
    [TestModule("55e598c3-2d98-4ad1-bf3e-e5128afbc5d4", ModuleType.Recording, 1)]
    public partial class WAS_DB : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CSPRepository repository.
        /// </summary>
        public static CSPRepository repo = CSPRepository.Instance;

        static WAS_DB instance = new WAS_DB();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public WAS_DB()
        {
            was = " https://633444484876.signin.aws.amazon.com/console";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static WAS_DB Instance
        {
            get { return instance; }
        }

#region Variables

        string _was;

        /// <summary>
        /// Gets or sets the value of variable was.
        /// </summary>
        [TestVariable("4cc61eba-2f9f-4736-9b01-fafcbecdc33e")]
        public string was
        {
            get { return _was; }
            set { _was = value; }
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

            Report.Log(ReportLevel.Info, "Website", "Opening web site URL in variable $was with browser 'Chrome' in normal mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser(was, "Chrome", "", false, false, false, false, false, true);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
