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
    ///The Add_Role_External_User recording.
    /// </summary>
    [TestModule("4886f8c4-1345-48b0-abbd-1a572ffc4d8b", ModuleType.Recording, 1)]
    public partial class Add_Role_External_User : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PrecisionRecruitment.PrecisionRecruitmentRepository repository.
        /// </summary>
        public static PrecisionRecruitment.PrecisionRecruitmentRepository repo = PrecisionRecruitment.PrecisionRecruitmentRepository.Instance;

        static Add_Role_External_User instance = new Add_Role_External_User();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Add_Role_External_User()
        {
            CodeName = "Ranorex Code Name";
            RandNum = "990598";
            DOM = "cgst-qc-duo.cogstate.com";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Add_Role_External_User Instance
        {
            get { return instance; }
        }

#region Variables

        string _CodeName;

        /// <summary>
        /// Gets or sets the value of variable CodeName.
        /// </summary>
        [TestVariable("49cfa874-725e-4141-b715-d2c17ac6eae8")]
        public string CodeName
        {
            get { return _CodeName; }
            set { _CodeName = value; }
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
        [TestVariable("ad914b3d-ce99-4bdb-9e75-5df98d80d2b2")]
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform.ExternalUserPage.AddRoleButton' at Center.", repo.CogstateSolutionPlatform.ExternalUserPage.AddRoleButtonInfo, new RecordItemIndex(0));
            repo.CogstateSolutionPlatform.ExternalUserPage.AddRoleButton.Click(300);
            Delay.Milliseconds(0);
            
            SelectStudyToAdd();
            Delay.Milliseconds(0);
            
            SelectExternalServiceRole();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform.ExternalUserPage.AddRoleActiveCheckbox' at 7;6.", repo.CogstateSolutionPlatform.ExternalUserPage.AddRoleActiveCheckboxInfo, new RecordItemIndex(3));
            repo.CogstateSolutionPlatform.ExternalUserPage.AddRoleActiveCheckbox.Click("7;6", 300);
            Delay.Milliseconds(0);
            
            // Slight Delay waiting for Role to save
            Report.Log(ReportLevel.Info, "Delay", "Slight Delay waiting for Role to save\r\nWaiting for 1m.", new RecordItemIndex(4));
            Delay.Duration(60000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
