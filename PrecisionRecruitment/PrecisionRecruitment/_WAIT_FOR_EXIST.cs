/*
 * Created by Ranorex
 * User: DWood
 * Date: 11/01/2018
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

namespace PrecisionRecruitment
{
    /// <summary>
    /// Description of _WAIT_FOR_EXIST.
    /// </summary>
    [TestModule("B6D5672F-723B-4321-9907-4776BE9B5EB2", ModuleType.UserCode, 1)]
    public class _WAIT_FOR_EXIST : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public _WAIT_FOR_EXIST()
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
            
        }
    }
}
