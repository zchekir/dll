/*
 * Created by Ranorex
 * User: DWood
 * Date: 27/03/2018
 * Time: 4:28 PM
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
    public class YesNoLearn
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        
        
        /// <summary>
 		/// This will pick up from the Yes No Learn Instructions screen
        /// and continue to press the "d" and "k" keys untill the test ends
        /// </summary>
        [UserCodeMethod]
        public static void RunYesNoLearn(String DOM)
        {
        	//initialise variables
			int taskTime = 20000;
			int startDelay = 5000;
			Stopwatch sw = new Stopwatch();
			ButtonTag startButton = "/dom[@domain='" + DOM + "']//button[#'instructions_button']";
			
			//Wait for start button to be enabled
			Delay.Duration(startDelay);

			startButton.Click();
			
			//start timer, yes no learn task will end after 20 seconds
			sw.Start();
			
			Delay.Duration(5000);
			
			//Press both the yes and no keys instead of dealing with image comparisons to workout which key to press
			//We only care about getting through the task at this stage
			while (sw.ElapsedMilliseconds < taskTime) {
				Keyboard.Press("k");
				Keyboard.Press("d");
				Delay.Duration(2500);
			}
        }
    }
}
