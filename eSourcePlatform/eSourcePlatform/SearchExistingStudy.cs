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

namespace eSourcePlatform
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SearchExistingStudy recording.
    /// </summary>
    [TestModule("870a9c84-7d0b-4177-ba5d-fcddb759fe95", ModuleType.Recording, 1)]
    public partial class SearchExistingStudy : ITestModule
    {
        /// <summary>
        /// Holds an instance of the eSourcePlatformRepository repository.
        /// </summary>
        public static eSourcePlatformRepository repo = eSourcePlatformRepository.Instance;

        static SearchExistingStudy instance = new SearchExistingStudy();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SearchExistingStudy()
        {
            RCC_Study_Name = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SearchExistingStudy Instance
        {
            get { return instance; }
        }

#region Variables

        string _RCC_Study_Name;

        /// <summary>
        /// Gets or sets the value of variable RCC_Study_Name.
        /// </summary>
        [TestVariable("e3986ab1-206f-432b-8d22-4e356239e182")]
        public string RCC_Study_Name
        {
            get { return _RCC_Study_Name; }
            set { _RCC_Study_Name = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform.SearchStudy' at Center.", repo.CogstateSolutionPlatform.SearchStudyInfo, new RecordItemIndex(0));
            repo.CogstateSolutionPlatform.SearchStudy.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$RCC_Study_Name' with focus on 'CogstateSolutionPlatform.SearchStudy'.", repo.CogstateSolutionPlatform.SearchStudyInfo, new RecordItemIndex(1));
            repo.CogstateSolutionPlatform.SearchStudy.PressKeys(RCC_Study_Name);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
