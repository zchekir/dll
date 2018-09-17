﻿/*
 * Created by Ranorex
 * User: DWood
 * Date: 12/09/2018
 * Time: 2:45 PM
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

namespace PrecisionRecruitment.StudiesPage
{
    /// <summary>
    /// Description of Validate_ProjectName_Descending.
    /// </summary>
    [TestModule("A4A77A72-421C-4582-9E3D-6E55D47E1893", ModuleType.UserCode, 1)]
    public class Validate_ProjectName_Descending : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Validate_ProjectName_Descending()
        {
            // Do not delete - a parameterless constructor is required!
        }
        
        public static PrecisionRecruitment.PrecisionRecruitmentRepository repo = PrecisionRecruitment.PrecisionRecruitmentRepository.Instance;

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            List<String> originalList = new List<String>();
            List<String> sortedList = new List<String>();
            bool flag = true;
            
            //Find the first /td/a cell in each table row. This is the project name. Store them in two lists
            foreach (TrTag row in repo.CogstateSolutionPlatform.TableHeaders.TableBody.Find("./tr"))
            {
            	IList<ATag> cells = row.Find<ATag>("./td/a");
            	originalList.Add(cells[0].InnerText);
            	sortedList.Add(cells[0].InnerText);
            	
            }
            
            //Sort one of the lists
            sortedList.Sort();
            sortedList.Reverse();
                       
            //Compare the original list and the ordered list, set flag to false if a mismatch is found
            for (int i = 0; i < sortedList.Count; i++)
            {
            	if (sortedList[i] != originalList[i]) {
            		flag = false;
            		break;
            	}
            
            }
            
            //Log Results in the Report
            if (flag)
            	Report.Success("Info", "Table has been sorted correctly");
            else
            	Report.Failure("Info", "Table has not been sorted correctly");
            
            Report.Screenshot(repo.CogstateSolutionPlatform.Self);
        }
    }
}
