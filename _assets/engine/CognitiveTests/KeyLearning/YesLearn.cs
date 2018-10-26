/*
 * Created by Ranorex
 * User: DWood
 * Date: 27/03/2018
 * Time: 4:13 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Diagnostics;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace engine.CognitiveTests.KeyLearning
{
    /// <summary>
    /// Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class YesLearn
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        
        /// <summary>
        /// This will pick up from the Yes Learn Instructions screen
        /// and continue to press the "k" key untill the test ends
        /// </summary>
        [UserCodeMethod]
        public static void RunYesLearn(String DOM)
        {
        	//initialise variables
            int taskTime = 10000;
            int startDelay = 5000;
            int feedbackTime = 1500;
            
            ButtonTag startButton = "/dom[@domain='" + DOM + "']//button[#'instructions_button']";
            Stopwatch sw = new Stopwatch();
            
			//Wait for start button to be enabled
			Delay.Duration(startDelay);
			
			startButton.Click();
			
			//start timer, yes learn task will end after 10 seconds
			sw.Start();
			
			while (sw.ElapsedMilliseconds < taskTime) {
				Keyboard.Press("k");
				
				Delay.Duration(feedbackTime);
			}
        }
        
    }
}
