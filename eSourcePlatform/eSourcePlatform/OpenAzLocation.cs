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

namespace eSourcePlatform
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The OpenAzLocation recording.
    /// </summary>
    [TestModule("d82ce541-c07b-4458-8378-0fcaefdb1f51", ModuleType.Recording, 1)]
    public partial class OpenAzLocation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the eSourcePlatformRepository repository.
        /// </summary>
        public static eSourcePlatformRepository repo = eSourcePlatformRepository.Instance;

        static OpenAzLocation instance = new OpenAzLocation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OpenAzLocation()
        {
            URL = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static OpenAzLocation Instance
        {
            get { return instance; }
        }

#region Variables

        string _URL;

        /// <summary>
        /// Gets or sets the value of variable URL.
        /// </summary>
        [TestVariable("9b546544-466e-46b9-bd75-1142b2bbe916")]
        public string URL
        {
            get { return _URL; }
            set { _URL = value; }
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

            Report.Log(ReportLevel.Info, "Website", "Opening web site URL in variable $URL with browser 'Chrome' in normal mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser(URL, "Chrome", "", false, false, false, false, false, true);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
