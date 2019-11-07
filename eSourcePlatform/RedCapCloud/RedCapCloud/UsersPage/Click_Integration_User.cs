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

namespace RedCapCloud.UsersPage
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Click_Integration_User recording.
    /// </summary>
    [TestModule("4fdaf16e-b932-4bc1-a7d1-1705281622ba", ModuleType.Recording, 1)]
    public partial class Click_Integration_User : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::RedCapCloud.RedCapCloudRepository repository.
        /// </summary>
        public static global::RedCapCloud.RedCapCloudRepository repo = global::RedCapCloud.RedCapCloudRepository.Instance;

        static Click_Integration_User instance = new Click_Integration_User();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Click_Integration_User()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Click_Integration_User Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable RCCDOM.
        /// </summary>
        [TestVariable("6f24cf1a-0e47-4c45-9ce6-3e042db234d2")]
        public string RCCDOM
        {
            get { return repo.RCCDOM; }
            set { repo.RCCDOM = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'REDCapCloud.UsersPage.IntegrationUserEditButton' at 13;12.", repo.REDCapCloud.UsersPage.IntegrationUserEditButtonInfo, new RecordItemIndex(0));
            repo.REDCapCloud.UsersPage.IntegrationUserEditButton.Click("13;12", 1);
            Delay.Milliseconds(90);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>'IntegrationUser') on item 'REDCapCloud.UsersPage.IntegrationUserEditPanel'.", repo.REDCapCloud.UsersPage.IntegrationUserEditPanelInfo, new RecordItemIndex(1));
            Validate.AttributeContains(repo.REDCapCloud.UsersPage.IntegrationUserEditPanelInfo, "InnerText", "IntegrationUser");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
