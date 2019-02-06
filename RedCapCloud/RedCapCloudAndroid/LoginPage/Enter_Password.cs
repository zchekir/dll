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

namespace RedCapCloudAndroid.LoginPage
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Enter_Password recording.
    /// </summary>
    [TestModule("35045a3b-4fe9-4bad-b9d7-56409a30a6fd", ModuleType.Recording, 1)]
    public partial class Enter_Password : ITestModule
    {
        /// <summary>
        /// Holds an instance of the RedCapCloudAndroid.RedCapCloudAndroidRepository repository.
        /// </summary>
        public static RedCapCloudAndroid.RedCapCloudAndroidRepository repo = RedCapCloudAndroid.RedCapCloudAndroidRepository.Instance;

        static Enter_Password instance = new Enter_Password();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Enter_Password()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Enter_Password Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Touch", "Touch item 'RanorexBrowser.Dom.LoginPage.LoginPass' at Center", repo.RanorexBrowser.Dom.LoginPage.LoginPassInfo, new RecordItemIndex(0));
            repo.RanorexBrowser.Dom.LoginPage.LoginPass.Touch();
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '913172RCC!' on item 'RanorexBrowser.Dom.LoginPage.LoginPass'.", repo.RanorexBrowser.Dom.LoginPage.LoginPassInfo, new RecordItemIndex(1));
            repo.RanorexBrowser.Dom.LoginPage.LoginPass.Element.SetAttributeValue("Value", "913172RCC!");
            Delay.Milliseconds(0);
            
            HelperLibrary.TriggerChange("{SPACE}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
