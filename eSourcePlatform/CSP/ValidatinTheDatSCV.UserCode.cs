﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel; 
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;
using System.Data;
using System.IO;

namespace CSP
{
    public partial class ValidatinTheDatSCV
    {
    	 
    	    String fileName = "export_";
    	    String toDayDate;
    	    String ProtocolID ="AutomationStudy2";


   
        private void Init()
        {
            
        }

        public void csvDataValidation()
        {
        
         toDayDate = System.DateTime.Now.ToString("MM/dd/yy");
         

    	 
    	
        	string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
        	var listofFiles = Directory.GetFiles(path,fileName+"*"+".csv");
        	
            Ranorex.Core.Data.CsvDataConnector csvConnector = new
           	Ranorex.Core.Data.CsvDataConnector("myCSVConnector", listofFiles[0]  ,true);
           
          
        	
           
             Ranorex.Core.Data.ColumnCollection col;
             Ranorex.Core.Data.RowCollection row;
             csvConnector.LoadData(out col, out row);
             
             foreach(Ranorex.Core.Data.Row dataRow in row)
              {
                 
                 Report.Info(""+dataRow["ProtocolID"].ToString());
                 Validate.AreEqual(dataRow["ProtocolID"].ToString(),ProtocolID);
                
                 Report.Info(""+dataRow["SessionDate"].ToString());
                 Validate.AreEqual(dataRow["SessionDate"].ToString(),toDayDate);
			  }
             
     
              
        	
      

            
        
          
            
        
}
}
}
