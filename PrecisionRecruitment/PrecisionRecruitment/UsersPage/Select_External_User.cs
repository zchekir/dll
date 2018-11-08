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
    ///The Select_External_User recording.
    /// </summary>
    [TestModule("e844cf88-3771-4adb-927e-acb6829f601c", ModuleType.Recording, 1)]
    public partial class Select_External_User : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PrecisionRecruitment.PrecisionRecruitmentRepository repository.
        /// </summary>
        public static PrecisionRecruitment.PrecisionRecruitmentRepository repo = PrecisionRecruitment.PrecisionRecruitmentRepository.Instance;

        static Select_External_User instance = new Select_External_User();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Select_External_User()
        {
            Key = "d7a6d2bb-f854-460f-bf23-c009f9d91619";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Select_External_User Instance
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
        /// Gets or sets the value of variable Key.
        /// </summary>
        [TestVariable("2902f0dc-8c70-46e4-b658-a8dd9ce5f42c")]
        public string Key
        {
            get { return repo.Key; }
            set { repo.Key = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform.MainToolbar.SearchField' at Center.", repo.CogstateSolutionPlatform.MainToolbar.SearchFieldInfo, new RecordItemIndex(0));
            repo.CogstateSolutionPlatform.MainToolbar.SearchField.Click(300);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Key' with focus on 'CogstateSolutionPlatform.MainToolbar.SearchField'.", repo.CogstateSolutionPlatform.MainToolbar.SearchFieldInfo, new RecordItemIndex(1));
            repo.CogstateSolutionPlatform.MainToolbar.SearchField.PressKeys(Key, 1);
            Delay.Milliseconds(90);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform.ExternalUserPage.ExternalUserRow' at Center.", repo.CogstateSolutionPlatform.ExternalUserPage.ExternalUserRowInfo, new RecordItemIndex(2));
            repo.CogstateSolutionPlatform.ExternalUserPage.ExternalUserRow.Click(300);
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
