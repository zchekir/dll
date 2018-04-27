/*
 * Created by Ranorex
 * User: DWood
 * Date: 26/04/2018
 * Time: 11:13 AM
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

namespace engine.Helpers
{
    /// <summary>
    /// Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class DropdownSelect
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        
        /// <summary>
        /// This method will try to select an item from a dropdown list given a dropdown name and item name
        /// </summary>
        [UserCodeMethod]
        public static int SelectItem(string DOM, string DropdownName, string DropownItem)
        {
        	Ranorex.WebDocument webDocument = "/dom[@domain='" + DOM + "']";
        	Ranorex.SelectTag DropdownBox;
        	
        	//Search for the DropdownBox on the page
        	try
        	{
        		webDocument.EnsureVisible();
        		DropdownBox = webDocument.FindSingle(".//select[@name='" + DropdownName + "']");
        	} 
        	
        	catch (RanorexException e)
        	{
        		Report.Error("Unable to find DropdownBox: " + DropdownName);
        		Console.WriteLine(e.ToString());
        		Report.Screenshot();
        		return -1;
        	}
        	
        	//Click on Item in the Dropdown
        	try 
        	{
        		Report.Info("Selecting item: " + DropownItem + " in DropdownBox: " + DropdownName);
        		//DropdownBox.EnsureVisible();
        		DropdownBox.Focus();
        		Thread.Sleep(500);
        		DropdownBox.Click(Location.CenterRight);
        		Thread.Sleep(500);
        		OptionTag option = DropdownBox.FindSingle<OptionTag>(".//option[@innertext='" + DropownItem + "']");
        		option.Click(Location.Center);
        		Report.Debug("Selected item: " + DropownItem + " in DropdownBox: " + DropdownBox);
        	}

        	catch (RanorexException e) 
        	{
        		Report.Error(e.ToString());
        		Report.Screenshot();
        		return -1;
        	}
        	
        	return 0;        	
        }
    }
}
