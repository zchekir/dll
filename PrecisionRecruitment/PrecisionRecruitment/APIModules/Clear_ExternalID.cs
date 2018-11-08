/*
 * Created by Ranorex
 * User: DWood
 * Date: 29/10/2018
 * Time: 2:33 PM
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

namespace PrecisionRecruitment.APIModules
{
    /// <summary>
    /// Description of Clear_ExternalID.
    /// </summary>
    [TestModule("3545ADD0-8748-4F6C-BC8A-59649B6E754E", ModuleType.UserCode, 1)]
    public class Clear_ExternalID : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Clear_ExternalID()
        {
            // Do not delete - a parameterless constructor is required!
        }
        
        
        string _externalID = "";
        [TestVariable("57037071-6036-4a24-8145-c9dbf508e396")]
        public string externalID
        {
        	get { return _externalID; }
        	set { _externalID = value; }
        }
        
        
        string _Datafile = "";
        [TestVariable("b024ef00-d4e1-48a9-b7e5-4304183e124a")]
        public string Datafile
        {
        	get { return _Datafile; }
        	set { _Datafile = value; }
        }
        
        

        /// <summary>
        /// Use this module to reset the Global external ID parameter. This is useful for when you want to complete and check the outcomes
        /// of an assessment multiple times in the same test run.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            //Clears the external id string if it has been set by a previous test module
            if (externalID != "" && Datafile != "FollowUp") {
            	Report.Info("Info", "External ID has been set to " + externalID + " previously, resetting external id now...");
            	externalID = "";
            }
        }
    }
}
