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

namespace PrecisionRecruitment.General
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Generate_Secret recording.
    /// </summary>
    [TestModule("69cc12f0-25dd-4495-a0bc-9eef9bdec8bb", ModuleType.Recording, 1)]
    public partial class Generate_Secret : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PrecisionRecruitment.PrecisionRecruitmentRepository repository.
        /// </summary>
        public static PrecisionRecruitment.PrecisionRecruitmentRepository repo = PrecisionRecruitment.PrecisionRecruitmentRepository.Instance;

        static Generate_Secret instance = new Generate_Secret();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Generate_Secret()
        {
            Key = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Generate_Secret Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Key.
        /// </summary>
        [TestVariable("e93ffd8c-d2ca-4815-8691-5adf41aa0dbd")]
        public string Key
        {
            get { return repo.Key; }
            set { repo.Key = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable DOM.
        /// </summary>
        [TestVariable("280aff49-d9c4-468c-bece-6c1951b0ef7e")]
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'GmailInbox.SecretLink'", repo.GmailInbox.SecretLinkInfo, new ActionTimeout(30000), new RecordItemIndex(0));
            repo.GmailInbox.SecretLinkInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GmailInbox.SecretLink' at UpperLeft.", repo.GmailInbox.SecretLinkInfo, new RecordItemIndex(1));
            repo.GmailInbox.SecretLink.Click(Location.UpperLeft, 1);
            Delay.Milliseconds(90);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>$Key) on item 'CogstateSolutionPlatform.GenerateSecretPage.APIKey'.", repo.CogstateSolutionPlatform.GenerateSecretPage.APIKeyInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.CogstateSolutionPlatform.GenerateSecretPage.APIKeyInfo, "InnerText", Key);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform.GenerateSecretPage.GenerateSecretButton' at 142;18.", repo.CogstateSolutionPlatform.GenerateSecretPage.GenerateSecretButtonInfo, new RecordItemIndex(3));
            repo.CogstateSolutionPlatform.GenerateSecretPage.GenerateSecretButton.Click("142;18");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>'Your API Secret') on item 'CogstateSolutionPlatform.GenerateSecretPage.APISecret'.", repo.CogstateSolutionPlatform.GenerateSecretPage.APISecretInfo, new RecordItemIndex(4));
            Validate.AttributeContains(repo.CogstateSolutionPlatform.GenerateSecretPage.APISecretInfo, "InnerText", "Your API Secret");
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "API Secret Generated", repo.CogstateSolutionPlatform.Self, false, new RecordItemIndex(5));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
