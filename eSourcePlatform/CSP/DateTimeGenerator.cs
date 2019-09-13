/*
 * Created by Ranorex
 * User: DWood
 * Date: 12/09/2019
 * Time: 11:19 AM
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

namespace CSP.UserCodeCollections
{
    /// <summary>
    /// Description of DateTimeGenerator.
    /// </summary>
    [TestModule("CF999998-58C9-4621-AF29-F2668761D042", ModuleType.UserCode, 1)]
    public class DateTimeGenerator : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DateTimeGenerator()
        {
            // Do not delete - a parameterless constructor is required!
        }
        
        
        string _RandNum = "";
        [TestVariable("5f6625fd-29d9-4d66-9ca7-3b41aa87ff77")]
        public string RandNum
        {
        	get { return _RandNum; }
        	set { _RandNum = value; }
        }
        

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            
            System.DateTime utcDate = System.DateTime.UtcNow;
        	RandNum = utcDate.ToString("yyyyMMddHHmm");
        	
        	Report.Info(RandNum);
        }
    }
}
