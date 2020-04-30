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

namespace CSP
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ClickExportFolder recording.
    /// </summary>
    [TestModule("a33a0850-a2d3-4443-ab02-ac3fd559b9ec", ModuleType.Recording, 1)]
    public partial class ClickExportFolder : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CSPRepository repository.
        /// </summary>
        public static CSPRepository repo = CSPRepository.Instance;

        static ClickExportFolder instance = new ClickExportFolder();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ClickExportFolder()
        {
            date = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ClickExportFolder Instance
        {
            get { return instance; }
        }

#region Variables

        string _date;

        /// <summary>
        /// Gets or sets the value of variable date.
        /// </summary>
        [TestVariable("4e5e9b25-334b-4434-9a6a-165198f5d800")]
        public string date
        {
            get { return _date; }
            set { _date = value; }
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

            //Mouse_Click_ClickLastModifier(repo.S3ManagementConsole.ClickLastModifierInfo);
            //Delay.Milliseconds(0);
            
            //DoDelay();
            //Delay.Milliseconds(0);
            
            Get_value_OpenExportFolder(repo.S3ManagementConsole.OpenExportFolderInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'S3ManagementConsole.OpenExportFolder' at Center.", repo.S3ManagementConsole.OpenExportFolderInfo, new RecordItemIndex(3));
            repo.S3ManagementConsole.OpenExportFolder.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(4));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'S3ManagementConsole.ClickDownload' at Center.", repo.S3ManagementConsole.ClickDownloadInfo, new RecordItemIndex(5));
            repo.S3ManagementConsole.ClickDownload.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 6s.", new RecordItemIndex(6));
            Delay.Duration(6000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(7));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
