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
    ///The APIV2_Update_Demographic recording.
    /// </summary>
    [TestModule("70ee2cb7-7981-4f16-9f4b-d4fbea372124", ModuleType.Recording, 1)]
    public partial class APIV2_Update_Demographic : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PrecisionRecruitment.PrecisionRecruitmentRepository repository.
        /// </summary>
        public static PrecisionRecruitment.PrecisionRecruitmentRepository repo = PrecisionRecruitment.PrecisionRecruitmentRepository.Instance;

        static APIV2_Update_Demographic instance = new APIV2_Update_Demographic();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public APIV2_Update_Demographic()
        {
            RandNum = "";
            DOM = "";
            DOB = "";
            externalID = "";
            LocalityCode = "";
            VisitSessionCode = "";
            ProtocolNumber = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static APIV2_Update_Demographic Instance
        {
            get { return instance; }
        }

#region Variables

        string _DOB;

        /// <summary>
        /// Gets or sets the value of variable DOB.
        /// </summary>
        [TestVariable("4e182298-f3e7-41d5-b823-f8d5b3d5c643")]
        public string DOB
        {
            get { return _DOB; }
            set { _DOB = value; }
        }

        string _externalID;

        /// <summary>
        /// Gets or sets the value of variable externalID.
        /// </summary>
        [TestVariable("82273179-811e-4f33-b25f-be2fb914e2c4")]
        public string externalID
        {
            get { return _externalID; }
            set { _externalID = value; }
        }

        string _LocalityCode;

        /// <summary>
        /// Gets or sets the value of variable LocalityCode.
        /// </summary>
        [TestVariable("aaf710fd-f257-4acd-bdce-5e0aeb6d58ae")]
        public string LocalityCode
        {
            get { return _LocalityCode; }
            set { _LocalityCode = value; }
        }

        string _VisitSessionCode;

        /// <summary>
        /// Gets or sets the value of variable VisitSessionCode.
        /// </summary>
        [TestVariable("347a301f-7778-4a89-bef4-031dc3079d49")]
        public string VisitSessionCode
        {
            get { return _VisitSessionCode; }
            set { _VisitSessionCode = value; }
        }

        string _ProtocolNumber;

        /// <summary>
        /// Gets or sets the value of variable ProtocolNumber.
        /// </summary>
        [TestVariable("4dc5e703-084f-4924-a1cb-85750e5f0144")]
        public string ProtocolNumber
        {
            get { return _ProtocolNumber; }
            set { _ProtocolNumber = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable RandNum.
        /// </summary>
        [TestVariable("77ce2ef3-1227-4b17-bda3-bfb0694d2825")]
        public string RandNum
        {
            get { return repo.RandNum; }
            set { repo.RandNum = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable DOM.
        /// </summary>
        [TestVariable("3647ecd2-7316-42dc-a218-b48504becc0d")]
        public string DOM
        {
            get { return repo.DOM; }
            set { repo.DOM = value; }
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

            engine.Helpers.WebService.UpdateDOBDemographic(RandNum, DOM, externalID, DOB, "M", LocalityCode, "Error", "Success", VisitSessionCode, ProtocolNumber);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
