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
    ///The Select_Study recording.
    /// </summary>
    [TestModule("36e2b5b5-2490-454c-9786-d8f2759ac9c9", ModuleType.Recording, 1)]
    public partial class Select_Study : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PrecisionRecruitmentRepository repository.
        /// </summary>
        public static PrecisionRecruitmentRepository repo = PrecisionRecruitmentRepository.Instance;

        static Select_Study instance = new Select_Study();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Select_Study()
        {
            Studyname = "";
            RandNum = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Select_Study Instance
        {
            get { return instance; }
        }

#region Variables

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
        /// Gets or sets the value of variable Studyname.
        /// </summary>
        [TestVariable("553e355a-3de3-4941-95ce-d6902f51f04c")]
        public string Studyname
        {
            get { return repo.StudyName; }
            set { repo.StudyName = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable RandNum.
        /// </summary>
        [TestVariable("d820780f-6115-40b8-8278-c22d3703bd0c")]
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
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform.SearchField' at 36;15.", repo.CogstateSolutionPlatform.SearchFieldInfo, new RecordItemIndex(0));
            repo.CogstateSolutionPlatform.SearchField.Click("36;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Studyname' with focus on 'CogstateSolutionPlatform.SearchField'.", repo.CogstateSolutionPlatform.SearchFieldInfo, new RecordItemIndex(1));
            repo.CogstateSolutionPlatform.SearchField.PressKeys(Studyname);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$RandNum' with focus on 'CogstateSolutionPlatform.SearchField'.", repo.CogstateSolutionPlatform.SearchFieldInfo, new RecordItemIndex(2));
            repo.CogstateSolutionPlatform.SearchField.PressKeys(RandNum);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(3));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform.Expanded.StudyCard' at Center.", repo.CogstateSolutionPlatform.Expanded.StudyCardInfo, new RecordItemIndex(4));
            repo.CogstateSolutionPlatform.Expanded.StudyCard.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>$Studyname) on item 'CogstateSolutionPlatform.StudyNameBreadcrumb'.", repo.CogstateSolutionPlatform.StudyNameBreadcrumbInfo, new RecordItemIndex(5));
            Validate.AttributeContains(repo.CogstateSolutionPlatform.StudyNameBreadcrumbInfo, "InnerText", Studyname);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>$RandNum) on item 'CogstateSolutionPlatform.StudyNameBreadcrumb'.", repo.CogstateSolutionPlatform.StudyNameBreadcrumbInfo, new RecordItemIndex(6));
            Validate.AttributeContains(repo.CogstateSolutionPlatform.StudyNameBreadcrumbInfo, "InnerText", RandNum);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
