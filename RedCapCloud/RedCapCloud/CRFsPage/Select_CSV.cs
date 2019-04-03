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

namespace RedCapCloud.CRFsPage
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Select_CSV recording.
    /// </summary>
    [TestModule("26f5ca72-1f84-4986-a06c-f51a8360a311", ModuleType.Recording, 1)]
    public partial class Select_CSV : ITestModule
    {
        /// <summary>
        /// Holds an instance of the RedCapCloud.RedCapCloudRepository repository.
        /// </summary>
        public static RedCapCloud.RedCapCloudRepository repo = RedCapCloud.RedCapCloudRepository.Instance;

        static Select_CSV instance = new Select_CSV();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Select_CSV()
        {
            FileName = "RedCapConfig";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Select_CSV Instance
        {
            get { return instance; }
        }

#region Variables

        string _FileName;

        /// <summary>
        /// Gets or sets the value of variable FileName.
        /// </summary>
        [TestVariable("1243b561-7617-4cbc-8f6d-123972442ec9")]
        public string FileName
        {
            get { return _FileName; }
            set { _FileName = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable DOM.
        /// </summary>
        [TestVariable("6f24cf1a-0e47-4c45-9ce6-3e042db234d2")]
        public string DOM
        {
            get { return repo.DOM; }
            set { repo.DOM = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 100;
            Keyboard.DefaultKeyPressTime = 10;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'REDCapCloud.CRFsPage.ChooseFileButton' at Center.", repo.REDCapCloud.CRFsPage.ChooseFileButtonInfo, new RecordItemIndex(0));
            repo.REDCapCloud.CRFsPage.ChooseFileButton.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OpenFileDialog.FilenameField' at Center.", repo.OpenFileDialog.FilenameFieldInfo, new RecordItemIndex(1));
            repo.OpenFileDialog.FilenameField.Click();
            Delay.Milliseconds(0);
            
            NavigateToDirectory(repo.OpenFileDialog.FilenameFieldInfo);
            Delay.Milliseconds(10);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$FileName' with focus on 'OpenFileDialog.FilenameField'.", repo.OpenFileDialog.FilenameFieldInfo, new RecordItemIndex(3));
            repo.OpenFileDialog.FilenameField.PressKeys(FileName);
            Delay.Milliseconds(10);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '.csv' with focus on 'OpenFileDialog.FilenameField'.", repo.OpenFileDialog.FilenameFieldInfo, new RecordItemIndex(4));
            repo.OpenFileDialog.FilenameField.PressKeys(".csv", 1);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OpenFileDialog.ButtonOpen' at Center.", repo.OpenFileDialog.ButtonOpenInfo, new RecordItemIndex(5));
            repo.OpenFileDialog.ButtonOpen.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(6));
            Delay.Duration(1000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
