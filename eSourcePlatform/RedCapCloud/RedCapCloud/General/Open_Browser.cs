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

namespace RedCapCloud.General
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Open_Browser recording.
    /// </summary>
    [TestModule("00e6b236-1bc8-4276-b907-6919860acfe5", ModuleType.Recording, 1)]
    public partial class Open_Browser : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::RedCapCloud.RedCapCloudRepository repository.
        /// </summary>
        public static global::RedCapCloud.RedCapCloudRepository repo = global::RedCapCloud.RedCapCloudRepository.Instance;

        static Open_Browser instance = new Open_Browser();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Open_Browser()
        {
            RCCURL = "https://cgsqc.redcapcloud.com";
            Browser = "Chrome";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Open_Browser Instance
        {
            get { return instance; }
        }

#region Variables

        string _RCCURL;

        /// <summary>
        /// Gets or sets the value of variable RCCURL.
        /// </summary>
        [TestVariable("6f16e2fe-59f5-4db7-ad65-fc9f98e4843e")]
        public string RCCURL
        {
            get { return _RCCURL; }
            set { _RCCURL = value; }
        }

        string _Browser;

        /// <summary>
        /// Gets or sets the value of variable Browser.
        /// </summary>
        [TestVariable("274716b5-a543-4645-bcdf-0f2be353a9ae")]
        public string Browser
        {
            get { return _Browser; }
            set { _Browser = value; }
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

            Report.Log(ReportLevel.Info, "Website", "Opening web site URL in variable $RCCURL with browser specified by variable $Browser in maximized mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser(RCCURL, Browser, "", false, true, false, false, false, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(1));
            Delay.Duration(5000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
