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

namespace PrecisionRecruitment.UsersPage
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Click_External_Users_Menu recording.
    /// </summary>
    [TestModule("87fa94c0-fd9a-48b5-b2d8-c6c921ec6b9a", ModuleType.Recording, 1)]
    public partial class Click_External_Users_Menu : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PrecisionRecruitment.PrecisionRecruitmentRepository repository.
        /// </summary>
        public static PrecisionRecruitment.PrecisionRecruitmentRepository repo = PrecisionRecruitment.PrecisionRecruitmentRepository.Instance;

        static Click_External_Users_Menu instance = new Click_External_Users_Menu();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Click_External_Users_Menu()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Click_External_Users_Menu Instance
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(0));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'CogstateSolutionPlatform.Menu.HamburgerMenu'", repo.CogstateSolutionPlatform.Menu.HamburgerMenuInfo, new ActionTimeout(30000), new RecordItemIndex(1));
            repo.CogstateSolutionPlatform.Menu.HamburgerMenuInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform.Menu.HamburgerMenu' at Center.", repo.CogstateSolutionPlatform.Menu.HamburgerMenuInfo, new RecordItemIndex(2));
            repo.CogstateSolutionPlatform.Menu.HamburgerMenu.Click();
            Delay.Milliseconds(400);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 100ms.", new RecordItemIndex(3));
            Delay.Duration(100, false);
            
            Click_ExternalUsers(repo.CogstateSolutionPlatform.Menu.AdministrationMenuOptionInfo, repo.CogstateSolutionPlatform.Menu.ExternalUsersMenuOptionInfo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
