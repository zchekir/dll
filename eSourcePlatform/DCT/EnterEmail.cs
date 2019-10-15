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

namespace DCT
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The EnterEmail recording.
    /// </summary>
    [TestModule("53807fba-9413-4799-85c8-de7828cb5bd1", ModuleType.Recording, 1)]
    public partial class EnterEmail : ITestModule
    {
        /// <summary>
        /// Holds an instance of the DCTRepository repository.
        /// </summary>
        public static DCTRepository repo = DCTRepository.Instance;

        static EnterEmail instance = new EnterEmail();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EnterEmail()
        {
            DCT_USERNAME = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EnterEmail Instance
        {
            get { return instance; }
        }

#region Variables

        string _DCT_USERNAME;

        /// <summary>
        /// Gets or sets the value of variable DCT_USERNAME.
        /// </summary>
        [TestVariable("d0e07d16-6eb8-40a3-aa90-8b3a394a6391")]
        public string DCT_USERNAME
        {
            get { return _DCT_USERNAME; }
            set { _DCT_USERNAME = value; }
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

            //UserNameInput(DCT_USERNAME);
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DCT_USERNAME' with focus on 'SignInToYourAccount.EnterUseName'.", repo.SignInToYourAccount.EnterUseNameInfo, new RecordItemIndex(1));
            repo.SignInToYourAccount.EnterUseName.PressKeys(DCT_USERNAME);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
