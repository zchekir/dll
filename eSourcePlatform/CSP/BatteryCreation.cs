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

namespace CSP
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The BatteryCreation recording.
    /// </summary>
    [TestModule("9c9fbb6a-7049-4ee6-8a05-326298e5321f", ModuleType.Recording, 1)]
    public partial class BatteryCreation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CSPRepository repository.
        /// </summary>
        public static CSPRepository repo = CSPRepository.Instance;

        static BatteryCreation instance = new BatteryCreation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BatteryCreation()
        {
            Token = "";
            Studyid = "";
            BatteryJASON = "";
            CSPDOM = "";
            Studname = "";
            Batteryversion = "";
            batteryID = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BatteryCreation Instance
        {
            get { return instance; }
        }

#region Variables

        string _Token;

        /// <summary>
        /// Gets or sets the value of variable Token.
        /// </summary>
        [TestVariable("21d80088-00f9-4cd2-b431-60d0da0a6b1b")]
        public string Token
        {
            get { return _Token; }
            set { _Token = value; }
        }

        string _Studyid;

        /// <summary>
        /// Gets or sets the value of variable Studyid.
        /// </summary>
        [TestVariable("6382549c-46ec-491a-885a-197718e89e74")]
        public string Studyid
        {
            get { return _Studyid; }
            set { _Studyid = value; }
        }

        string _BatteryJASON;

        /// <summary>
        /// Gets or sets the value of variable BatteryJASON.
        /// </summary>
        [TestVariable("8f519bcc-3e54-4657-b742-d5b665f9d993")]
        public string BatteryJASON
        {
            get { return _BatteryJASON; }
            set { _BatteryJASON = value; }
        }

        string _Studname;

        /// <summary>
        /// Gets or sets the value of variable Studname.
        /// </summary>
        [TestVariable("32124dfc-6a12-4785-b854-8ade4508119a")]
        public string Studname
        {
            get { return _Studname; }
            set { _Studname = value; }
        }

        string _Batteryversion;

        /// <summary>
        /// Gets or sets the value of variable Batteryversion.
        /// </summary>
        [TestVariable("48ad6700-c66f-4b87-b79b-c93002a290dc")]
        public string Batteryversion
        {
            get { return _Batteryversion; }
            set { _Batteryversion = value; }
        }

        string _batteryID;

        /// <summary>
        /// Gets or sets the value of variable batteryID.
        /// </summary>
        [TestVariable("cb21ed8d-50bd-4f06-b6d6-986032c042b9")]
        public string batteryID
        {
            get { return _batteryID; }
            set { _batteryID = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable CSPDOM.
        /// </summary>
        [TestVariable("bb97dc8b-d79d-4e45-b659-b8ff0fd6dcd8")]
        public string CSPDOM
        {
            get { return repo.CSPDOM; }
            set { repo.CSPDOM = value; }
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

            battery_Creation(Token, Studyid, BatteryJASON, CSPDOM, Batteryversion);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
