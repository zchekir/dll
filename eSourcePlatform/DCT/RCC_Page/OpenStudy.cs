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

namespace DCT.RCC_Page
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The OpenStudy recording.
    /// </summary>
    [TestModule("83773ca8-ef21-4bac-bf66-4fa324b1b30b", ModuleType.Recording, 1)]
    public partial class OpenStudy : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::DCT.DCTRepository repository.
        /// </summary>
        public static global::DCT.DCTRepository repo = global::DCT.DCTRepository.Instance;

        static OpenStudy instance = new OpenStudy();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OpenStudy()
        {
            RCC_Study_Name = "zktest 0001";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static OpenStudy Instance
        {
            get { return instance; }
        }

#region Variables

        string _RCC_Study_Name;

        /// <summary>
        /// Gets or sets the value of variable RCC_Study_Name.
        /// </summary>
        [TestVariable("7e849208-d2d3-4d04-9470-753f5d81f297")]
        public string RCC_Study_Name
        {
            get { return _RCC_Study_Name; }
            set { _RCC_Study_Name = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable RCCDOM.
        /// </summary>
        [TestVariable("5a760c9f-9fed-4f01-8c4c-f1cd491cbeda")]
        public string RCCDOM
        {
            get { return repo.RCCDOM; }
            set { repo.RCCDOM = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable RandNum.
        /// </summary>
        [TestVariable("0a1f4511-792f-4cbf-818c-dcbe6257b7c8")]
        public string RandNum
        {
            get { return repo.RandNum; }
            set { repo.RandNum = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'REDCapCloud.OpenRCCStudy' at Center.", repo.REDCapCloud.OpenRCCStudyInfo, new RecordItemIndex(0));
            repo.REDCapCloud.OpenRCCStudy.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
