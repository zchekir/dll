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

namespace CSP.AddWorkflowPage
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Enter_WorkflowTemplate recording.
    /// </summary>
    [TestModule("038f892a-56da-4728-bb1c-ad7a56abce64", ModuleType.Recording, 1)]
    public partial class Enter_WorkflowTemplate : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::CSP.CSPRepository repository.
        /// </summary>
        public static global::CSP.CSPRepository repo = global::CSP.CSPRepository.Instance;

        static Enter_WorkflowTemplate instance = new Enter_WorkflowTemplate();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Enter_WorkflowTemplate()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Enter_WorkflowTemplate Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable CSPDOM.
        /// </summary>
        [TestVariable("f54fbb85-c5ac-4f6a-98d6-049472b68327")]
        public string CSPDOM
        {
            get { return repo.CSPDOM; }
            set { repo.CSPDOM = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable WorkflowTemplate.
        /// </summary>
        [TestVariable("87005baf-9d21-4fd0-8599-d463aad52dc9")]
        public string WorkflowTemplate
        {
            get { return repo.WorkflowTemplate; }
            set { repo.WorkflowTemplate = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform.AddWorkflowPage.WorkflowTemplateDropdown' at Center.", repo.CogstateSolutionPlatform.AddWorkflowPage.WorkflowTemplateDropdownInfo, new RecordItemIndex(0));
            repo.CogstateSolutionPlatform.AddWorkflowPage.WorkflowTemplateDropdown.Click(1);
            Delay.Milliseconds(490);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Select() on item 'CogstateSolutionPlatform.AddWorkflowPage.WorkflowTemplateOption'.", repo.CogstateSolutionPlatform.AddWorkflowPage.WorkflowTemplateOptionInfo, new RecordItemIndex(1));
            repo.CogstateSolutionPlatform.AddWorkflowPage.WorkflowTemplateOption.Select();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CogstateSolutionPlatform.AddWorkflowPage.WorkflowTemplateDropdown' at Center.", repo.CogstateSolutionPlatform.AddWorkflowPage.WorkflowTemplateDropdownInfo, new RecordItemIndex(2));
            repo.CogstateSolutionPlatform.AddWorkflowPage.WorkflowTemplateDropdown.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
