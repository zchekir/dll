﻿/*
 * Created by Ranorex
 * User: DWood
 * Date: 24/01/2019
 * Time: 3:32 PM
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

namespace RedCapCloud
{
    /// <summary>
    /// Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class RCCUtility
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        public static RedCapCloudRepository repo = RedCapCloudRepository.Instance;
        /// <summary>
        /// Creates a DataTable containing the Test Outcomes for all the tests in the current CRF
        /// </summary>
        [UserCodeMethod]
        public static void CreateDataTable()
        {
        	var tabs = repo.REDCapCloud.InstrumentsTab.FindChildren<LiTag>();
        	
        	for (int i = 0; i < tabs.Count; i++)
        	{
        		
        		
        	}
        }
    }
}
