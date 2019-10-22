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
    ///The DCT_URL_VALIDATION recording.
    /// </summary>
    [TestModule("ec22c345-3300-424b-92c4-004c30a5141c", ModuleType.Recording, 1)]
    public partial class DCT_URL_VALIDATION : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::DCT.DCTRepository repository.
        /// </summary>
        public static global::DCT.DCTRepository repo = global::DCT.DCTRepository.Instance;

        static DCT_URL_VALIDATION instance = new DCT_URL_VALIDATION();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DCT_URL_VALIDATION()
        {
            DCTURL = "https//:cgst-qc-orr-dct.azurewebsites.net/";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DCT_URL_VALIDATION Instance
        {
            get { return instance; }
        }

#region Variables

        string _DCTURL;

        /// <summary>
        /// Gets or sets the value of variable DCTURL.
        /// </summary>
        [TestVariable("df63d2cc-f9ef-4cc6-8433-d6d5f54102d0")]
        public string DCTURL
        {
            get { return _DCTURL; }
            set { _DCTURL = value; }
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'DataCleaningTool'.", repo.DataCleaningTool.SelfInfo, new RecordItemIndex(0));
            repo.DataCleaningTool.Self.WaitForDocumentLoaded();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeNotContains (PageUrl!>$DCTURL) on item 'DataCleaningTool'.", repo.DataCleaningTool.SelfInfo, new RecordItemIndex(1));
            Validate.AttributeNotContains(repo.DataCleaningTool.SelfInfo, "PageUrl", DCTURL);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'DataCleaningTool'.", repo.DataCleaningTool.SelfInfo, new RecordItemIndex(2));
            Host.Current.CloseApplication(repo.DataCleaningTool.Self, new Duration(0));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(3));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
