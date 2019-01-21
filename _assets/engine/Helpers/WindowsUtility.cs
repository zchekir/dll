/*
 * Created by Ranorex
 * User: DWood
 * Date: 17/01/2019
 * Time: 12:14 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using System.Management;
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
    public class WindowsUtility
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        
        /// <summary>
        /// This will use WMI (Windows Management Instrumentation) to find and disable the current Network Connection
        /// </summary>
        [UserCodeMethod]
        public static void Disable_Network_Connection()
        {
        	Report.Info("Building Query");
        	SelectQuery wmiQuery = new SelectQuery("SELECT * FROM Win32_NetworkAdapter WHERE NetConnectionId != NULL");
        	
        	Report.Info("Running Search");
        	ManagementObjectSearcher search = new ManagementObjectSearcher(wmiQuery);
        	
        	Report.Info("Form Loop outer");
        	foreach (ManagementObject item in search.Get())
        	{
        		Report.Info("Form Loop Inner");
        		Report.Info("Item: " + (string)item["NetConnectionId"]);
        		if (((string)item["NetConnectionId"]) == "Ethernet")
        		{
        			item.InvokeMethod("Disable", null);
        			break;
        		}
        	}
        	Report.Info("Done");
        }
        
        /// <summary>
        /// This will use WMI (Windows Management Instrumentation) to find and enable the current Network Connection
        /// </summary>
        [UserCodeMethod]
        public static void Enable_Network_Connection()
        {
        	SelectQuery wmiQuery = new SelectQuery("SELECT * FROM Win32_NetworkAdapter WHERE NetConnectionId != NULL");
        	
        	ManagementObjectSearcher search = new ManagementObjectSearcher(wmiQuery);
        	
        	foreach (ManagementObject item in search.Get())
        	{
        		if (((string)item["NetConnectionId"]) == "Ethernet")
        		{
        			item.InvokeMethod("Enable", null);
        		}
        	}
        }
    }
}
