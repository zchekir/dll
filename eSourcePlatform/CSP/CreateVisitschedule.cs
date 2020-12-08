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
    ///The CreateVisitschedule recording.
    /// </summary>
    [TestModule("8013edcd-a876-49a7-b495-e779933a8fe2", ModuleType.Recording, 1)]
    public partial class CreateVisitschedule : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CSPRepository repository.
        /// </summary>
        public static CSPRepository repo = CSPRepository.Instance;

        static CreateVisitschedule instance = new CreateVisitschedule();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CreateVisitschedule()
        {
            Token = "";
            Studyid = "";
            CSPDOM = "";
            VisitCode = "";
            VisitSceduleData = "";
            rNumber = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CreateVisitschedule Instance
        {
            get { return instance; }
        }

#region Variables

        string _Token;

        /// <summary>
        /// Gets or sets the value of variable Token.
        /// </summary>
        [TestVariable("d4990ef5-ff60-4162-a061-a9cff9bb6b75")]
        public string Token
        {
            get { return _Token; }
            set { _Token = value; }
        }

        string _Studyid;

        /// <summary>
        /// Gets or sets the value of variable Studyid.
        /// </summary>
        [TestVariable("c0deec5c-cb56-44fb-85fb-8b319345fdd7")]
        public string Studyid
        {
            get { return _Studyid; }
            set { _Studyid = value; }
        }

        string _VisitCode;

        /// <summary>
        /// Gets or sets the value of variable VisitCode.
        /// </summary>
        [TestVariable("a3fa63dd-ce5a-4761-9da3-499cf61c5616")]
        public string VisitCode
        {
            get { return _VisitCode; }
            set { _VisitCode = value; }
        }

        string _VisitSceduleData;

        /// <summary>
        /// Gets or sets the value of variable VisitSceduleData.
        /// </summary>
        [TestVariable("bed4926d-b6fd-44ab-98a4-c52e31f5f26c")]
        public string VisitSceduleData
        {
            get { return _VisitSceduleData; }
            set { _VisitSceduleData = value; }
        }

        string _rNumber;

        /// <summary>
        /// Gets or sets the value of variable rNumber.
        /// </summary>
        [TestVariable("1e19f4b4-049a-47bf-9d6f-a7d36d843826")]
        public string rNumber
        {
            get { return _rNumber; }
            set { _rNumber = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable CSPDOM.
        /// </summary>
        [TestVariable("39991ace-f3d0-4ca1-aebb-999dca1fa0f0")]
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

            Visitschedulecreation(Token, Studyid, VisitCode, CSPDOM, VisitSceduleData);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
