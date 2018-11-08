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
    ///The Enter_Username recording.
    /// </summary>
    [TestModule("e8baed63-acfc-4c88-981f-7e62ff4efa50", ModuleType.Recording, 1)]
    public partial class Enter_Username : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PrecisionRecruitment.PrecisionRecruitmentRepository repository.
        /// </summary>
        public static PrecisionRecruitment.PrecisionRecruitmentRepository repo = PrecisionRecruitment.PrecisionRecruitmentRepository.Instance;

        static Enter_Username instance = new Enter_Username();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Enter_Username()
        {
            Username = "";
            RandNum = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Enter_Username Instance
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
        /// Gets or sets the value of variable Username.
        /// </summary>
        [TestVariable("2b48007a-3e7e-407b-a25b-545d93908445")]
        public string Username
        {
            get { return repo.Username; }
            set { repo.Username = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable RandNum.
        /// </summary>
        [TestVariable("4c5e514d-358a-4119-949c-e61c9aea6e9b")]
        public string RandNum
        {
            get { return repo.RandNum; }
            set { repo.RandNum = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform.AddInternalUserPage.UsernameField' at Center.", repo.CogstateSolutionPlatform.AddInternalUserPage.UsernameFieldInfo, new RecordItemIndex(0));
            repo.CogstateSolutionPlatform.AddInternalUserPage.UsernameField.Click(1);
            Delay.Milliseconds(90);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Username' with focus on 'CogstateSolutionPlatform.AddInternalUserPage.UsernameField'.", repo.CogstateSolutionPlatform.AddInternalUserPage.UsernameFieldInfo, new RecordItemIndex(1));
            repo.CogstateSolutionPlatform.AddInternalUserPage.UsernameField.PressKeys(Username, 1);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '+' with focus on 'CogstateSolutionPlatform.AddInternalUserPage.UsernameField'.", repo.CogstateSolutionPlatform.AddInternalUserPage.UsernameFieldInfo, new RecordItemIndex(2));
            repo.CogstateSolutionPlatform.AddInternalUserPage.UsernameField.PressKeys("+", 1);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$RandNum' with focus on 'CogstateSolutionPlatform.AddInternalUserPage.UsernameField'.", repo.CogstateSolutionPlatform.AddInternalUserPage.UsernameFieldInfo, new RecordItemIndex(3));
            repo.CogstateSolutionPlatform.AddInternalUserPage.UsernameField.PressKeys(RandNum, 1);
            Delay.Milliseconds(10);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '@gmail.com' with focus on 'CogstateSolutionPlatform.AddInternalUserPage.UsernameField'.", repo.CogstateSolutionPlatform.AddInternalUserPage.UsernameFieldInfo, new RecordItemIndex(4));
            repo.CogstateSolutionPlatform.AddInternalUserPage.UsernameField.PressKeys("@gmail.com", 1);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
