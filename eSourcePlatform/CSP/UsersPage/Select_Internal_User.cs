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

namespace CSP.UsersPage
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Select_Internal_User recording.
    /// </summary>
    [TestModule("9b3135d5-cdf5-4668-9f80-c3f4c3a33eae", ModuleType.Recording, 1)]
    public partial class Select_Internal_User : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::CSP.CSPRepository repository.
        /// </summary>
        public static global::CSP.CSPRepository repo = global::CSP.CSPRepository.Instance;

        static Select_Internal_User instance = new Select_Internal_User();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Select_Internal_User()
        {
            Username = "";
            RandNum = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Select_Internal_User Instance
        {
            get { return instance; }
        }

#region Variables

        string _Username;

        /// <summary>
        /// Gets or sets the value of variable Username.
        /// </summary>
        [TestVariable("fda9fc1e-50ba-4648-abeb-e523aff13776")]
        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable CSPDOM.
        /// </summary>
        [TestVariable("f54fbb85-c5ac-4f6a-98d6-049472b68327")]
        public string CSPDOM
        {
            get { return repo.CSPDOM; }
            set { repo.CSPDOM = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable RandNum.
        /// </summary>
        [TestVariable("067dd459-6ac9-4db7-b891-9e9e9d6cb41e")]
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform.MainToolbar.SearchField' at 58;16.", repo.CogstateSolutionPlatform.MainToolbar.SearchFieldInfo, new RecordItemIndex(0));
            repo.CogstateSolutionPlatform.MainToolbar.SearchField.Click("58;16", 100);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Username' with focus on 'CogstateSolutionPlatform.MainToolbar.SearchField'.", repo.CogstateSolutionPlatform.MainToolbar.SearchFieldInfo, new RecordItemIndex(1));
            repo.CogstateSolutionPlatform.MainToolbar.SearchField.PressKeys(Username, 1);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '%2B' with focus on 'CogstateSolutionPlatform.MainToolbar.SearchField'.", repo.CogstateSolutionPlatform.MainToolbar.SearchFieldInfo, new RecordItemIndex(2));
            repo.CogstateSolutionPlatform.MainToolbar.SearchField.PressKeys("%2B", 1);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$RandNum' with focus on 'CogstateSolutionPlatform.MainToolbar.SearchField'.", repo.CogstateSolutionPlatform.MainToolbar.SearchFieldInfo, new RecordItemIndex(3));
            repo.CogstateSolutionPlatform.MainToolbar.SearchField.PressKeys(RandNum, 1);
            Delay.Milliseconds(10);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '@gmail.com' with focus on 'CogstateSolutionPlatform.MainToolbar.SearchField'.", repo.CogstateSolutionPlatform.MainToolbar.SearchFieldInfo, new RecordItemIndex(4));
            repo.CogstateSolutionPlatform.MainToolbar.SearchField.PressKeys("@gmail.com", 1);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform.UsersPage.InternalUserRow' at Center.", repo.CogstateSolutionPlatform.UsersPage.InternalUserRowInfo, new RecordItemIndex(5));
            repo.CogstateSolutionPlatform.UsersPage.InternalUserRow.Click(100);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
