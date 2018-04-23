/*
 * Created by Ranorex
 * User: DWood
 * Date: 27/03/2018
 * Time: 4:37 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.IO;
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
    public class Identification
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        
        /// <summary>
        /// This will pick up from the IdentificationLearn Instructions screen and
        /// just complete the test
        /// </summary>
        [UserCodeMethod]
        public static void RunIdentificationLearn(String DOM)
        {
        	//initialise variables
			int trialNumber = 0;
			int x = 355, y = 180, width = 350, height = 420; //Crop entire card
			//int x = 380, y = 210, width = 35, height = 115; //Crop only card number and suit
			int tPos = 0, tNeg = 0;
			int startDelay = 5000;
			int feedbackTime = 4000;
			bool finished = false;
			bool match = false;
			ButtonTag startButton = "/dom[@domain='" + DOM + "']//button[#'instructions_button']";
			CanvasTag canvas;
			Bitmap cardDisplayed;		
			Bitmap redJoker = Imaging.Load(@".\images\RJ.png");
			Imaging.FindOptions.Default.Similarity = 0.99;
			
			
			//Wait for start button to be enabled
			Delay.Duration(startDelay);
			
			startButton.Click();
			
			canvas = "/dom[@domain='" + DOM + "']//div[#displayDiv]/canvas";
			
			//Wait for first card
			Delay.Duration(startDelay);
			
			//Continue to make correct responses until required correct has been met
			while (!finished) {
				
				//Takes roughly 150-200ms to capture and crop
				cardDisplayed = Imaging.Crop(Imaging.CaptureImageAuto(canvas), new Rectangle(x, y, width, height));
				//Report.Log(ReportLevel.Info, "start image compare");
				//50ms for red joker 600ms for black joker
				match = Imaging.Contains(cardDisplayed, redJoker);
				//Report.Log(ReportLevel.Info, "end image compare");
				
				//Report.LogData(ReportLevel.Info, "User", "Card cropped", cardDisplayed);
				
				//Make a response and Increment TPOS/TNEG/Trial Count
				if (match == true) {
					Keyboard.Press("k");
					tPos++;
				}
				else {
					Keyboard.Press("d");	
					tNeg++;
				}
				
				trialNumber++;
				
				if (trialNumber == 5 && tPos >= 1 && tNeg >= 1)
					finished = true;
				else
					Delay.Duration(feedbackTime);
			}
        }
        
        
        
        /// <summary>
        /// This will pick up from the Identification Instructions screen and 
        /// complete the standard configuration which consists of the demo
        /// and real tests
        /// </summary>
        [UserCodeMethod]
        public static void RunIdentificationTest(String DOM)
        {
        	//initialise variables
			int trialNumber = 0;
			int x = 355, y = 180, width = 350, height = 420; //Crop entire card
			//int x = 380, y = 210, width = 35, height = 115; //Crop only card number and suit
			int tPos = 0, tNeg = 0;
			int startDelay = 5000;
			int feedbackTime = 2000;
			bool finished = false;
			bool match = false;
			bool demo = true;
			ButtonTag startButton = "/dom[@domain='" + DOM + "']//button[#'instructions_button']";
			CanvasTag canvas;
			Bitmap cardDisplayed;			
			Bitmap redJoker = Imaging.Load(@".\images\RJ.png");
			Imaging.FindOptions.Default.Similarity = 0.99;
			
			//Wait for start button be become enabled
			Delay.Duration(startDelay);
			
			startButton.Click();
			
			canvas = "/dom[@domain='" + DOM + "']//div[#displayDiv]/canvas";
			
			//Wait for first card
			Delay.Duration(1500);
			
			//Continue to make correct responses until requried correct has been met
			while (!finished) {
				
				cardDisplayed = Imaging.Crop(Imaging.CaptureImageAuto(canvas), new Rectangle(x, y, width, height));
				//Report.Log(ReportLevel.Info, "start image compare");
				match = Imaging.Contains(cardDisplayed, redJoker);
				//Report.Log(ReportLevel.Info, "end image compare");
				
				//Make a response and increment TPOS/TNEG/Trial count
				if (match == true) {
					Keyboard.Press("k");					
					tPos++;
				}
				else {
					Keyboard.Press("d");	
					tNeg++;
				}
				
				trialNumber++;
				
				//Check to see if demo is complete.
				//Reset the counters if we are onto the real task
				if (demo == true && tPos >= 1 && tNeg >= 1 && trialNumber >= 3) {
					demo = false;
					trialNumber = 0;
				}
					
				if (trialNumber == 30)
					finished = true;
				else
					Delay.Duration(feedbackTime);
				
			}
        }
    }
}
