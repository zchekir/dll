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
    ///The DCT_URL recording.
    /// </summary>
    [TestModule("5d2ef5fe-273d-43ea-b4d5-a8d2efc9ca23", ModuleType.Recording, 1)]
    public partial class DCT_URL : ITestModule
    {
        /// <summary>
        /// Holds an instance of the DCTRepository repository.
        /// </summary>
        public static DCTRepository repo = DCTRepository.Instance;

        static DCT_URL instance = new DCT_URL();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DCT_URL()
        {
            DCTURL = "";
            Browser = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DCT_URL Instance
        {
            get { return instance; }
        }

#region Variables

        string _DCTURL;

        /// <summary>
        /// Gets or sets the value of variable DCTURL.
        /// </summary>
        [TestVariable("8463e4a6-eafa-4aa9-b3f9-8c31b5959f9b")]
        public string DCTURL
        {
            get { return _DCTURL; }
            set { _DCTURL = value; }
        }

        string _Browser;

        /// <summary>
        /// Gets or sets the value of variable Browser.
        /// </summary>
        [TestVariable("ea48e640-72d1-4391-844d-f960d0c21bf4")]
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

            //DCTLogin(DCTURL, Browser);
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Website", "Opening web site URL in variable $DCTURL with browser 'Chrome' in normal mode.", new RecordItemIndex(1));
            Host.Current.OpenBrowser(DCTURL, "Chrome", "", false, false, false, true, false, true);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Success, "User", "LoggedIn Successfully", null, false, new RecordItemIndex(2));
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1ms.", new RecordItemIndex(3));
            Delay.Duration(1, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
