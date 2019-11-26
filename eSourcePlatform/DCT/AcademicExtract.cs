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
    ///The AcademicExtract recording.
    /// </summary>
    [TestModule("72c0a13b-d5e0-4ed7-916c-6c440cfaecab", ModuleType.Recording, 1)]
    public partial class AcademicExtract : ITestModule
    {
        /// <summary>
        /// Holds an instance of the DCTRepository repository.
        /// </summary>
        public static DCTRepository repo = DCTRepository.Instance;

        static AcademicExtract instance = new AcademicExtract();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AcademicExtract()
        {
            ProtocolID = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AcademicExtract Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable CSPDOM.
        /// </summary>
        [TestVariable("4868fd53-f0cc-4bcc-ad64-84d67b341b4d")]
        public string CSPDOM
        {
            get { return repo.CSPDOM; }
            set { repo.CSPDOM = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable ProtocolID.
        /// </summary>
        [TestVariable("30032ee3-af73-4534-811f-e59adee47d65")]
        public string ProtocolID
        {
            get { return repo.ProtocolID; }
            set { repo.ProtocolID = value; }
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 8s.", new RecordItemIndex(0));
            Delay.Duration(8000, false);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'CogstateSolutionPlatform.ProtocolNumberField' and assigning its value to variable 'ProtocolID'.", repo.CogstateSolutionPlatform.ProtocolNumberFieldInfo, new RecordItemIndex(1));
            ProtocolID = repo.CogstateSolutionPlatform.ProtocolNumberField.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform.AcademicExtract' at Center.", repo.CogstateSolutionPlatform.AcademicExtractInfo, new RecordItemIndex(2));
            repo.CogstateSolutionPlatform.AcademicExtract.Click();
            Delay.Milliseconds(200);
            
            ValidateAcademicExtract(repo.AcademicExtractPowerBI.ProtocolIDCellInfo);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "PowerBI Report Generated Successfully", repo.AcademicExtractPowerBI.Self, false, new RecordItemIndex(4));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
