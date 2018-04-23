/*
 * Created by Ranorex
 * User: DWood
 * Date: 27/03/2018
 * Time: 2:49 PM
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

namespace engine
{
    /// <summary>
    /// Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class Detection
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        
        /// <summary>
        /// This will pick up from the DetectionLearn Instructions screen and
        /// just complete the test
        /// </summary>
        [UserCodeMethod]
        public static void RunDetectionLearn(String DOM)
        {
        	//initialise variables
			int trialNumber = 0;
			bool finished = false;
			int startDelay = 5000;
            ButtonTag startButton = "/dom[@domain='" + DOM + "']//button[#'instructions_button']";
	
            //wait for start button to become active
			Delay.Duration(startDelay);
			
			startButton.Click();
			
			//Make yes responses until task ends
			//The first couple of trials require longer delay
			while (!finished)
			{
				if (trialNumber == 0) {
					Delay.Duration(6000);
				}
				else if (trialNumber == 1) {
					Delay.Duration(4500);
				}
				else {
					Delay.Duration(2000);
				}
				
				Keyboard.Press("k");
				
				trialNumber++;
				
				if (trialNumber == 5)
					finished = true;
			}
        }
        
        
        
        /// <summary>
        /// This will pick up from the Detection Instructions screen and 
        /// complete the standard configuration which consists of the demo
        /// and real tests
        /// </summary>
        [UserCodeMethod]
        public static void RunDetectionTest(String DOM)
        {
        	//initialise variables
            int trialNumber = 0;
            int feedbackTime = 2000;
            int maxTrials = 38;
            bool finished = false;
            int startDelay = 5000;
            ButtonTag startButton = "/dom[@domain='" + DOM + "']//button[#'instructions_button']";
            
            //wait for start button to become active
			Delay.Duration(startDelay);
			
			startButton.Click();
			
			//Continue to make responses for 38 trials (35 for real task and 3 for demo task)
			while (!finished) {
				Delay.Duration(feedbackTime);
				
				Keyboard.Press("k");
				
				trialNumber++;
				
				if (trialNumber == maxTrials)
					finished = true;
			}
        }
    }
}
