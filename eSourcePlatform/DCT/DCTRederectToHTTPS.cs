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
    ///The DCTRederectToHTTPS recording.
    /// </summary>
    [TestModule("12fde51f-6680-4824-91b6-f1e17bc3e95a", ModuleType.Recording, 1)]
    public partial class DCTRederectToHTTPS : ITestModule
    {
        /// <summary>
        /// Holds an instance of the DCTRepository repository.
        /// </summary>
        public static DCTRepository repo = DCTRepository.Instance;

        static DCTRederectToHTTPS instance = new DCTRederectToHTTPS();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DCTRederectToHTTPS()
        {
            URL = "https://cgst-qc-orr-dct.azurewebsites.net";
            Browser = "Chrome";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DCTRederectToHTTPS Instance
        {
            get { return instance; }
        }

#region Variables

        string _URL;

        /// <summary>
        /// Gets or sets the value of variable URL.
        /// </summary>
        [TestVariable("558517cb-7077-4490-b81e-859cf85ecae5")]
        public string URL
        {
            get { return _URL; }
            set { _URL = value; }
        }

        string _Browser;

        /// <summary>
        /// Gets or sets the value of variable Browser.
        /// </summary>
        [TestVariable("3fffc709-39ea-40a0-929a-c52c4bca5215")]
        public string Browser
        {
            get { return _Browser; }
            set { _Browser = value; }
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

            //HTTPS(URL, Browser);
            //Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
