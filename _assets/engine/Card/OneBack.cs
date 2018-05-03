/*
 * Created by Ranorex
 * User: DWood
 * Date: 28/03/2018
 * Time: 9:53 AM
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

namespace engine.Card
{
    /// <summary>
    /// Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class OneBack
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        
        
        /// <summary>
        /// This will pick up from the OneBackLearn Instructions screen and
        /// just complete the test
        /// </summary>
        [UserCodeMethod]
        public static void RunOneBackLearn(String DOM)
        {
        	//Initialise Variables
            Imaging.FindOptions.Default.Similarity = 0.999;
            Bitmap previousCard;
            Bitmap cardDisplayed;
            int x = 355, y = 180, width = 350, height = 420;
            int tPos = 0, tNeg = 0;
            int trialNumber = 0;
            int startDelay = 5000;
            bool finished = false;
            bool match = false;
            
			ButtonTag startButton = "/dom[@domain='" + DOM + "']//button[#'instructions_button']";
            
			//Wait for start button to be displayed
			Delay.Duration(startDelay);
			
			startButton.Click();
			
			CanvasTag canvas = "/dom[@domain='" + DOM + "']//div[#displayDiv]/canvas";
			
			//Wait for first card
			Delay.Duration(5500);
			
			//Store first card displayed in previousCard as there is no card to compare to yet, saves us having to move it later
			previousCard = Imaging.Crop(Imaging.CaptureImageAuto(canvas), new Rectangle(x, y, width, height));
			Keyboard.Press("d");
			trialNumber++;
			Delay.Duration(5500);
			
			while (!finished) {
				
				cardDisplayed = Imaging.Crop(Imaging.CaptureImageAuto(canvas), new Rectangle(x, y, width, height));
				
				match = Imaging.Contains(previousCard, cardDisplayed);
				if (match) {
					Keyboard.Press("k");
					match = false;
					tPos++;
				}
				else {
					Keyboard.Press("d");
					previousCard = cardDisplayed;
					tNeg++;
				}
				
				trialNumber++;
				
				if (trialNumber == 10 && tPos >= 1 && tNeg >= 1)  //Terminate the task if the required conditions are met
					finished = true;
				else if (trialNumber == 2 || trialNumber == 6) //Allow extra delay for these trials, prompts are shown on the screen
					Delay.Duration(6000);
				else if (trialNumber == 5) //Learn phase 2 starts here, reset the tPos and tNeg counters
				{ 
					tPos = 0;
					tNeg = 0;
					Delay.Duration(6000);
				}
				else
					Delay.Duration(3000);
			}
        }
        
        
        /// <summary>
        /// This will pick up from the OneBackTest Instructions screen and
        /// just complete the test
        /// </summary>
        [UserCodeMethod]
        public static void RunOneBackTest(String DOM)
        {
        	//Initialise Variables
            Imaging.FindOptions.Default.Similarity = 0.999;
            Bitmap previousCard;
            Bitmap cardDisplayed;
            int x = 355, y = 180, width = 350, height = 420;
            int tPos = 0, tNeg = 0;
            int trialNumber = 0;
            int startDelay = 5000;
            bool finished = false;
            bool match = false;
            bool demo = true;
            
			ButtonTag startButton = "/dom[@domain='" + DOM + "']//button[#'instructions_button']";
            
			//Wait for enabled button to be enabled
			Delay.Duration(startDelay);
			
			startButton.Click();
			
			CanvasTag canvas = "/dom[@domain='" + DOM + "']//div[#displayDiv]/canvas";
			
			//Wait for first card
			Delay.Duration(2000);
			
			//Store first card displayed in previousCard as there is no card to compare to yet, saves us having to move it later
			previousCard = Imaging.Crop(Imaging.CaptureImageAuto(canvas), new Rectangle(x, y, width, height));
			Keyboard.Press("d");
			trialNumber++;
			Delay.Duration(2000);
			
			//continue to make correct responses untill required correct has been met
			while (!finished) {
				
				//Report.Info("Trial Number: " + trialNumber + "True Positive: " + tPos + " True Negative: " + tNeg); //Debugging
				
				cardDisplayed = Imaging.Crop(Imaging.CaptureImageAuto(canvas), new Rectangle(x, y, width, height));
				
				match = Imaging.Contains(previousCard, cardDisplayed);
				if (match) {
					Keyboard.Press("k");
					tPos++;
					match = false;
				}
				else {
					Keyboard.Press("d");
					tNeg++;
					previousCard = cardDisplayed;
				}
				
				trialNumber++;
				
				//Check to see if demo is complete
				//Reset the trial counter once onto the real task
				if (demo == true && tPos >= 1 && tNeg >= 1 && trialNumber >= 3) {
					demo = false;
					trialNumber = 0;
				}
				
				if (trialNumber == 31)
					finished = true;
				else
					Delay.Duration(2000);
			}
        }
    }
}
