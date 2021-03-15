/*
 * Created by Ranorex
 * User: DWood
 * Date: 19/09/2018
 * Time: 11:15 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
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

namespace CPA.StudiesPage
{
    /// <summary>
    /// Description of Validate_Previous_Page.
    /// </summary>
    [TestModule("0D12C760-1F82-421E-B529-CDA277D518A2", ModuleType.UserCode, 1)]
    public class Validate_Previous_Page : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Validate_Previous_Page()
        {
            // Do not delete - a parameterless constructor is required!
        }
        
        public static CPA.CPARepository repo = CPA.CPARepository.Instance;

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 0;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            List<String> originalList = new List<String>();
            List<String> newList = new List<String>();
            bool flag = true;
            
            //Log screenshot of Studies list before attempt to change page
            Report.Log(ReportLevel.Info,"User", "Studies list before changing page");
            Report.Screenshot(repo.CogstateSolutionPlatform.Self);
            
            //Find the Project name for each row in the table and store in list
            foreach (TrTag row in repo.CogstateSolutionPlatform.StudyTableHeaders.TableBody.Find("./tr"))
            {
            	IList<ATag> cells = row.Find<ATag>("./td/a");
            	originalList.Add(cells[0].InnerText);
            }
            
            //Click the previous page button to view more studies
            Report.Log(ReportLevel.Info, "User", "Mouse click on Previous button");
            repo.CogstateSolutionPlatform.PreviousPageButton.Click();
            Delay.Duration(1000);
            
            //Find the Project names for each row in the table for the new page            	
            foreach (TrTag row in repo.CogstateSolutionPlatform.StudyTableHeaders.TableBody.Find("./tr"))
            {
            	IList<ATag> cells = row.Find<ATag>("./td/a");
            	newList.Add(cells[0].InnerText);
            }
            
            for (int i = 0; i < originalList.Count; i++)
            {
            	if (originalList[i] == newList[i]) {
            		flag = false;
            		break;
            	}
            }
            
            //Log result in report
            if (flag) 
            	Report.Success("Info", "Previous studies page list has been loaded");
            else
            	Report.Failure("info", "Previous studies page list has failed to laod");
            
            Report.Screenshot(repo.CogstateSolutionPlatform.Self);
            
        }
    }
}
