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
    ///The Clear_Gmail_Inbox recording.
    /// </summary>
    [TestModule("46fd72b9-76a1-4e0f-a312-530d1c4995bb", ModuleType.Recording, 1)]
    public partial class Clear_Gmail_Inbox : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PrecisionRecruitment.PrecisionRecruitmentRepository repository.
        /// </summary>
        public static PrecisionRecruitment.PrecisionRecruitmentRepository repo = PrecisionRecruitment.PrecisionRecruitmentRepository.Instance;

        static Clear_Gmail_Inbox instance = new Clear_Gmail_Inbox();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Clear_Gmail_Inbox()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Clear_Gmail_Inbox Instance
        {
            get { return instance; }
        }

#region Variables

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

            //Ranorex.AutomationHelpers.UserCodeCollections.PopupWatcherLibrary.StartPopupWatcher(null, null);
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GmailInbox.BackToInbox' at Center.", repo.GmailInbox.BackToInboxInfo, new RecordItemIndex(1));
            repo.GmailInbox.BackToInbox.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 250ms.", new RecordItemIndex(2));
            Delay.Duration(250, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GmailInbox.SelectAllMessagesCheckbox' at Center.", repo.GmailInbox.SelectAllMessagesCheckboxInfo, new RecordItemIndex(3));
            repo.GmailInbox.SelectAllMessagesCheckbox.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 100ms.", new RecordItemIndex(4));
            Delay.Duration(100, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GmailInbox.DeleteButton' at Center.", repo.GmailInbox.DeleteButtonInfo, new RecordItemIndex(5));
            repo.GmailInbox.DeleteButton.Click("Center");
            Delay.Milliseconds(0);
            
            //Ranorex.AutomationHelpers.UserCodeCollections.PopupWatcherLibrary.StopPopupWatcher(null, null);
            //Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
