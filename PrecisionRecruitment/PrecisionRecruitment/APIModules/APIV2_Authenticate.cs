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

namespace PrecisionRecruitment.APIModules
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The APIV2_Authenticate recording.
    /// </summary>
    [TestModule("03a98aac-9699-4331-a3fa-00536dfad33f", ModuleType.Recording, 1)]
    public partial class APIV2_Authenticate : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PrecisionRecruitment.PrecisionRecruitmentRepository repository.
        /// </summary>
        public static PrecisionRecruitment.PrecisionRecruitmentRepository repo = PrecisionRecruitment.PrecisionRecruitmentRepository.Instance;

        static APIV2_Authenticate instance = new APIV2_Authenticate();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public APIV2_Authenticate()
        {
            DOM = "";
            ProtocolID = "Ran123";
            RandNum = "";
            Key = "d7a6d2bb-f854-460f-bf23-c009f9d91619";
            Secret = "28566e30-ffff-4f45-8ea5-e8c286df10fc";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static APIV2_Authenticate Instance
        {
            get { return instance; }
        }

#region Variables

        string _ProtocolID;

        /// <summary>
        /// Gets or sets the value of variable ProtocolID.
        /// </summary>
        [TestVariable("3b244791-8adf-4420-ba52-5c63812fac17")]
        public string ProtocolID
        {
            get { return _ProtocolID; }
            set { _ProtocolID = value; }
        }

        string _Secret;

        /// <summary>
        /// Gets or sets the value of variable Secret.
        /// </summary>
        [TestVariable("a702b301-700e-48a4-bc0b-f7361f7a8fb9")]
        public string Secret
        {
            get { return _Secret; }
            set { _Secret = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable DOM.
        /// </summary>
        [TestVariable("a6eaa971-72cb-4cb1-8dc8-9c7cbf3bfb65")]
        public string DOM
        {
            get { return repo.DOM; }
            set { repo.DOM = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable RandNum.
        /// </summary>
        [TestVariable("f596d89d-2a08-4a15-bfcb-1856ad2829bb")]
        public string RandNum
        {
            get { return repo.RandNum; }
            set { repo.RandNum = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Key.
        /// </summary>
        [TestVariable("35d6bff4-468a-4307-8386-b46e7e547dc9")]
        public string Key
        {
            get { return repo.Key; }
            set { repo.Key = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            engine.Helpers.WebService.Authenticate(RandNum, DOM, ProtocolID, Key, Secret);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
