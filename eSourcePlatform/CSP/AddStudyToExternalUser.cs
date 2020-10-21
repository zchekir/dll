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
    ///The AddStudyToExternalUser recording.
    /// </summary>
    [TestModule("9ef10880-fa3b-4ee3-a5b6-b1d8728f9a11", ModuleType.Recording, 1)]
    public partial class AddStudyToExternalUser : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CSPRepository repository.
        /// </summary>
        public static CSPRepository repo = CSPRepository.Instance;

        static AddStudyToExternalUser instance = new AddStudyToExternalUser();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddStudyToExternalUser()
        {
            Token = "";
            CSPDOM = "";
            RolID = "";
            Key = "";
            JSONData = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddStudyToExternalUser Instance
        {
            get { return instance; }
        }

#region Variables

        string _Token;

        /// <summary>
        /// Gets or sets the value of variable Token.
        /// </summary>
        [TestVariable("1a2cf6ac-1c7f-46ff-8400-5c75a29f06d9")]
        public string Token
        {
            get { return _Token; }
            set { _Token = value; }
        }

        string _RolID;

        /// <summary>
        /// Gets or sets the value of variable RolID.
        /// </summary>
        [TestVariable("ff107b70-fac4-4a78-a6c6-c74f53bb761d")]
        public string RolID
        {
            get { return _RolID; }
            set { _RolID = value; }
        }

        string _JSONData;

        /// <summary>
        /// Gets or sets the value of variable JSONData.
        /// </summary>
        [TestVariable("eb30db56-d622-4fa5-9e9a-5ee3896d248b")]
        public string JSONData
        {
            get { return _JSONData; }
            set { _JSONData = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable CSPDOM.
        /// </summary>
        [TestVariable("60e2bac1-b18c-401e-9273-7a962b5c1c96")]
        public string CSPDOM
        {
            get { return repo.CSPDOM; }
            set { repo.CSPDOM = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Key.
        /// </summary>
        [TestVariable("c4d28067-e2d7-4473-8dff-e025201ec2c0")]
        public string Key
        {
            get { return repo.Key; }
            set { repo.Key = value; }
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

            StudyToExternalUser(Token, RolID, JSONData, CSPDOM, Key);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
