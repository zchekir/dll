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

namespace PrecisionRecruitment.InputModules
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Enter_ProtocolID recording.
    /// </summary>
    [TestModule("1e9af83f-3d93-4310-9092-e79dbbc2daa5", ModuleType.Recording, 1)]
    public partial class Enter_ProtocolID : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PrecisionRecruitment.PrecisionRecruitmentRepository repository.
        /// </summary>
        public static PrecisionRecruitment.PrecisionRecruitmentRepository repo = PrecisionRecruitment.PrecisionRecruitmentRepository.Instance;

        static Enter_ProtocolID instance = new Enter_ProtocolID();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Enter_ProtocolID()
        {
            ProtocolID = "ProtocolID";
            RandNum = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Enter_ProtocolID Instance
        {
            get { return instance; }
        }

#region Variables

        string _ProtocolID;

        /// <summary>
        /// Gets or sets the value of variable ProtocolID.
        /// </summary>
        [TestVariable("8b9b0c96-a982-4583-bb77-e3c13ed6136e")]
        public string ProtocolID
        {
            get { return _ProtocolID; }
            set { _ProtocolID = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable DOM.
        /// </summary>
        [TestVariable("280aff49-d9c4-468c-bece-6c1951b0ef7e")]
        public string DOM
        {
            get { return repo.DOM; }
            set { repo.DOM = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable RandNum.
        /// </summary>
        [TestVariable("c068b996-7ba9-46f8-835a-c4d786f724f8")]
        public string RandNum
        {
            get { return repo.RandNum; }
            set { repo.RandNum = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform.AddStudyPage.ProtocolIDField' at Center.", repo.CogstateSolutionPlatform.AddStudyPage.ProtocolIDFieldInfo, new RecordItemIndex(0));
            repo.CogstateSolutionPlatform.AddStudyPage.ProtocolIDField.Click(300);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{End}{LShiftKey down}{Home}{LShiftKey up}{Delete}' with focus on 'CogstateSolutionPlatform.AddStudyPage.ProtocolIDField'.", repo.CogstateSolutionPlatform.AddStudyPage.ProtocolIDFieldInfo, new RecordItemIndex(1));
            repo.CogstateSolutionPlatform.AddStudyPage.ProtocolIDField.PressKeys("{End}{LShiftKey down}{Home}{LShiftKey up}{Delete}");
            Delay.Milliseconds(50);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ProtocolID' with focus on 'CogstateSolutionPlatform.AddStudyPage.ProtocolIDField'.", repo.CogstateSolutionPlatform.AddStudyPage.ProtocolIDFieldInfo, new RecordItemIndex(2));
            repo.CogstateSolutionPlatform.AddStudyPage.ProtocolIDField.PressKeys(ProtocolID);
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$RandNum' with focus on 'CogstateSolutionPlatform.AddStudyPage.ProtocolIDField'.", repo.CogstateSolutionPlatform.AddStudyPage.ProtocolIDFieldInfo, new RecordItemIndex(3));
            repo.CogstateSolutionPlatform.AddStudyPage.ProtocolIDField.PressKeys(RandNum);
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Value>$ProtocolID) on item 'CogstateSolutionPlatform.AddStudyPage.ProtocolIDField'.", repo.CogstateSolutionPlatform.AddStudyPage.ProtocolIDFieldInfo, new RecordItemIndex(4));
            Validate.AttributeContains(repo.CogstateSolutionPlatform.AddStudyPage.ProtocolIDFieldInfo, "Value", ProtocolID);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Value>$RandNum) on item 'CogstateSolutionPlatform.AddStudyPage.ProtocolIDField'.", repo.CogstateSolutionPlatform.AddStudyPage.ProtocolIDFieldInfo, new RecordItemIndex(5));
            Validate.AttributeContains(repo.CogstateSolutionPlatform.AddStudyPage.ProtocolIDFieldInfo, "Value", RandNum);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
