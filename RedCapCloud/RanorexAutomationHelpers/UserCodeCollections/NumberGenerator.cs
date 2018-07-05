/*
 * Created by Ranorex
 * User: DWood
 * Date: 10/01/2018
 * Time: 11:48 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
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

namespace Ranorex_Automation_Helpers.UserCodeCollections
{
    /// <summary>
    /// Description of NumberGenerator.
    /// </summary>
    [TestModule("FF756843-3CD0-4C4C-8F54-BB0085FEF353", ModuleType.UserCode, 1)]
    public class NumberGenerator : ITestModule
    {
    	
    	
    	string _Output = "";
    	[TestVariable("57c1f925-f31b-40a1-bccd-58269808e361")]
    	public string Output
    	{
    		get { return _Output; }
    		set { _Output = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public NumberGenerator()
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
        	Random r = new Random();
        	
        	int number = r.Next(1,999999);
        	Output = number.ToString();
        }
    }
}
