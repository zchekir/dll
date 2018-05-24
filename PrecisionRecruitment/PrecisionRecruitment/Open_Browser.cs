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

namespace PrecisionRecruitment
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Open_Browser recording.
    /// </summary>
    [TestModule("6fe4ad3f-c7f8-4d36-8e5a-06d2dfe66a53", ModuleType.Recording, 1)]
    public partial class Open_Browser : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PrecisionRecruitmentRepository repository.
        /// </summary>
        public static PrecisionRecruitmentRepository repo = PrecisionRecruitmentRepository.Instance;

        static Open_Browser instance = new Open_Browser();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Open_Browser()
        {
            URL = "https://cgst-qc-2-7-0.cogstate.com/template.html#/Login";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Open_Browser Instance
        {
            get { return instance; }
        }

#region Variables

        string _URL;

        /// <summary>
        /// Gets or sets the value of variable URL.
        /// </summary>
        [TestVariable("301881c3-bcf1-4345-825a-bdb454120bc4")]
        public string URL
        {
            get { return _URL; }
            set { _URL = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 100;
            Keyboard.DefaultKeyPressTime = 10;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Website", "Opening web site URL in variable $URL with browser 'Chrome' in normal mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser(URL, "Chrome", "", false, false, false, false, false);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
