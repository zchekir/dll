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

namespace RedCapCloud.PermissionsPage
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Enter_Admin_RoleName recording.
    /// </summary>
    [TestModule("c1dd6568-0e79-41e3-8707-7e61513e716d", ModuleType.Recording, 1)]
    public partial class Enter_Admin_RoleName : ITestModule
    {
        /// <summary>
        /// Holds an instance of the RedCapCloud.RedCapCloudRepository repository.
        /// </summary>
        public static RedCapCloud.RedCapCloudRepository repo = RedCapCloud.RedCapCloudRepository.Instance;

        static Enter_Admin_RoleName instance = new Enter_Admin_RoleName();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Enter_Admin_RoleName()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Enter_Admin_RoleName Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'REDCapCloud.PermissionsPage.StudyPermissionsRoleName' at Center.", repo.REDCapCloud.PermissionsPage.StudyPermissionsRoleNameInfo, new RecordItemIndex(0));
            repo.REDCapCloud.PermissionsPage.StudyPermissionsRoleName.Click(1);
            Delay.Milliseconds(90);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Admin' with focus on 'REDCapCloud.PermissionsPage.StudyPermissionsRoleName'.", repo.REDCapCloud.PermissionsPage.StudyPermissionsRoleNameInfo, new RecordItemIndex(1));
            repo.REDCapCloud.PermissionsPage.StudyPermissionsRoleName.PressKeys("Admin", 1);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
