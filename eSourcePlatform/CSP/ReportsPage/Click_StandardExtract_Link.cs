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

namespace CSP.ReportsPage
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Click_StandardExtract_Link recording.
    /// </summary>
    [TestModule("4f089712-c239-4883-8bcf-6c722e725e24", ModuleType.Recording, 1)]
    public partial class Click_StandardExtract_Link : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::CSP.CSPRepository repository.
        /// </summary>
        public static global::CSP.CSPRepository repo = global::CSP.CSPRepository.Instance;

        static Click_StandardExtract_Link instance = new Click_StandardExtract_Link();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Click_StandardExtract_Link()
        {
            ProtocolID = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Click_StandardExtract_Link Instance
        {
            get { return instance; }
        }

#region Variables

        string _ProtocolID;

        /// <summary>
        /// Gets or sets the value of variable ProtocolID.
        /// </summary>
        [TestVariable("a50eea40-21b0-482c-be26-86f7f1251a4b")]
        public string ProtocolID
        {
            get { return _ProtocolID; }
            set { _ProtocolID = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable CSPDOM.
        /// </summary>
        [TestVariable("f54fbb85-c5ac-4f6a-98d6-049472b68327")]
        public string CSPDOM
        {
            get { return repo.CSPDOM; }
            set { repo.CSPDOM = value; }
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(0));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'CogstateSolutionPlatform.AddStudyPage.ProtocolNumberField' and assigning its value to variable 'ProtocolID'.", repo.CogstateSolutionPlatform.AddStudyPage.ProtocolNumberFieldInfo, new RecordItemIndex(1));
            ProtocolID = repo.CogstateSolutionPlatform.AddStudyPage.ProtocolNumberField.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform.ReportsPage.StandardExtractLink' at Center.", repo.CogstateSolutionPlatform.ReportsPage.StandardExtractLinkInfo, new RecordItemIndex(2));
            repo.CogstateSolutionPlatform.ReportsPage.StandardExtractLink.Click(3);
            Delay.Milliseconds(490);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(3));
            Delay.Duration(3000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
