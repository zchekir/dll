/*
 * Created by Ranorex
 * User: DWood
 * Date: 25/01/2019
 * Time: 1:46 PM
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

namespace PrecisionRecruitment.UserCodeCollections
{
    /// <summary>
    /// Description of DateTimeGenerator.
    /// </summary>
    [TestModule("F5BF8785-98A5-4C1C-B828-BDB03993284B", ModuleType.UserCode, 1)]
    public class DateTimeGenerator : ITestModule
    {
    	
    	string _Output = "";
    	[TestVariable("f82c872f-1d24-4a83-bf3a-5d3bdfab1b96")]
    	public string Output
    	{
    		get { return _Output; }
    		set { _Output = value; }
    	}
    	
    	
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DateTimeGenerator()
        {
            // Do not delete - a parameterless constructor is required!
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
        	Output = utcDate.ToString("yyyyddMMHHmm");
        	
        	Report.Info(Output);

        }
    }
}
