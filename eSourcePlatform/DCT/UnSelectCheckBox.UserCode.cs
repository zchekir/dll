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

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace DCT
{
    public partial class UnSelectCheckBox
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }
        
        
        /* 
        The chalange with this one I want to check if the webelemnt is selected the code should unselect it , but since the webelemtn status is always False
        
        and the webelement class doesnt have usefull option in order to handle this situation I tried all situation but with not success if you can help 
         */
        /*
        public void CheckBox()
        {
        	WebElement RadioBox = "//i[#'dataCollectionWidget_checkboxComplete']";
        	String state = RadioBox.Enabled.ToString();
            
            Report.Log(ReportLevel.Info, " The checkbox is sate:" + state);
           
          //  if ( state.CheckNotContainsNull(null)){
            	
            //	RadioBox.Click();
           // }else {
            	
            	//Report.Log(ReportLevel.Info,"CheckBox not selected");
           // }
           
            	
           
        }
        

        public void Validate_DataCollectionWidgetCheckboxComplete(RepoItemInfo itagInfo)
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'itagInfo'.", itagInfo);
             
            
            
            
             Validate.IsTrue(itagInfo));
            	
             	Report.Log(ReportLevel.Info," Dont select it");
             else{
             	
             		WebElement RadioBox = "//i[#'dataCollectionWidget_checkboxComplete']";
             		
             		RadioBox.Click();
             }
             	*/
        }
    }


        

       

    

