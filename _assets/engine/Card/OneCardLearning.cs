/*
 * Created by Ranorex
 * User: DWood
 * Date: 28/03/2018
 * Time: 9:36 AM
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
    public class OneCardLearning
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        
        /// <summary>
        /// This will pick up from the OCLLearn Instructions screen and
        /// just complete the test
        /// </summary>
        [UserCodeMethod]
        public static void RunOCLLearn(String DOM)
        {
        	//Initialise Variables
            Imaging.FindOptions.Default.Similarity = 0.999;
            List<Bitmap> shownCards = new List<Bitmap>();
            Bitmap cardDisplayed;
            int x = 355, y = 180, width = 350, height = 420;
            int trialNumber = 0;
            int startDelay = 5000;
            bool finished = false;
            bool match = false;
            
			ButtonTag startButton = "/dom[@domain='" + DOM + "']//button[#'instructions_button']";
            
			//Wait for start button to become enabled
			Delay.Duration(startDelay);
			
			startButton.Click();
			
			CanvasTag canvas = "/dom[@domain='" + DOM + "']//div[#displayDiv]/canvas";
			
			//Wait for first card
			Delay.Duration(5500);
			
			//First response is always 'no'
			cardDisplayed = Imaging.Crop(Imaging.CaptureImageAuto(canvas), new Rectangle(x, y, width, height));
			shownCards.Add(cardDisplayed);
			Keyboard.Press("d");
			trialNumber++;
			Delay.Duration(5500);

			while (!finished) {
				cardDisplayed = Imaging.Crop(Imaging.CaptureImageAuto(canvas), new Rectangle(x, y, width, height));
				
				foreach (Bitmap img in shownCards)
				{
					match = Imaging.Contains(img, cardDisplayed);
					if (match) {
						break;
					}
				}
				
				if (match) {
					Keyboard.Press("k");
					match = false;
				}
				else {
					Keyboard.Press("d");
					shownCards.Add(cardDisplayed);
				}
				
				trialNumber++;
				
				//Allow extra delay for card to turn face up during the first few trials of each learning phase while prompts are disaplayed
				if (trialNumber == 12)
					finished = true;
				else if (trialNumber == 1 || trialNumber == 2 || trialNumber == 3 || trialNumber == 6 || trialNumber == 7)
					Delay.Duration(6000);
				else
					Delay.Duration(3000);
			}
        }
        
        
        /// <summary>
        /// This will pick up from the OCLDemo Instructions screen and
        /// just complete the test
        /// </summary>
        [UserCodeMethod]
        public static void RunOCLDemo(String DOM)
        {
        	//Initialise Variables
            Imaging.FindOptions.Default.Similarity = 0.999;
            List<Bitmap> shownCards = new List<Bitmap>();
            Bitmap cardDisplayed;
            int x = 355, y = 180, width = 350, height = 420;
            int trialNumber = 0;
            int startDelay = 5000;
            int feedbackTime = 2000;
            bool finished = false;
            bool match = false;
            
			ButtonTag startButton = "/dom[@domain='" + DOM + "']//button[#'instructions_button']";
            
			//Wait for start button to become enabled
			Delay.Duration(startDelay);
			
			startButton.Click();
			
			CanvasTag canvas = "/dom[@domain='" + DOM + "']//div[#displayDiv]/canvas";
			
			//Wait for first card
			Delay.Duration(feedbackTime);
			
			//First response is always 'no'
			cardDisplayed = Imaging.Crop(Imaging.CaptureImageAuto(canvas), new Rectangle(x, y, width, height));
			shownCards.Add(cardDisplayed);
			Keyboard.Press("d");
			trialNumber++;
			Delay.Duration(feedbackTime);
			
			while (!finished) {
				
				cardDisplayed = Imaging.Crop(Imaging.CaptureImageAuto(canvas), new Rectangle(x, y, width, height));
				
				//Compare card displayed to each card that has been shown prevously
				foreach (Bitmap img in shownCards)
				{
					match = Imaging.Contains(img, cardDisplayed);
					if (match) {
						break;	
					}
				}
				
				if (match) {
					Keyboard.Press("k");
					match = false;
				}
				else {
					Keyboard.Press("d");
					shownCards.Add(cardDisplayed);
				}
				
				trialNumber++;
				
				if (trialNumber == 10)
					finished = true;
				else
					Delay.Duration(feedbackTime);	
			}
        }
        
        
        /// <summary>
        /// This will pick up from the OCLReal Instructions screen and
        /// just complete the test
        /// </summary>
        [UserCodeMethod]
        public static void RunOCLReal(String DOM)
        {
        	//Initialise Variables
            Imaging.FindOptions.Default.Similarity = 0.999;
            List<Bitmap> shownCards = new List<Bitmap>();
            Bitmap cardDisplayed;
            int x = 355, y = 180, width = 350, height = 420;
            int trialNumber = 0;
            int startDelay = 5000;
            int feedbackTime = 2000;
            bool finished = false;
            bool match = false;
            
			ButtonTag startButton = "/dom[@domain='" + DOM + "']//div[#displayDiv]/tag/div/div/?/?/button[@innertext='START']";
            
			//Wait for start button to become enabled
			Delay.Duration(startDelay);
			
			startButton.Click();
			
			CanvasTag canvas = "/dom[@domain='" + DOM + "']//div[#displayDiv]/canvas";
			
			//Wait for first card
			Delay.Duration(feedbackTime);
			
			//First response is always 'no'
			cardDisplayed = Imaging.Crop(Imaging.CaptureImageAuto(canvas), new Rectangle(x, y, width, height));
			shownCards.Add(cardDisplayed);
			Keyboard.Press("d");
			trialNumber++;
			Delay.Duration(feedbackTime);
			
			
			while (!finished) {
				
				//Report.Info("Trial Number: " + trialNumber); //Debugging
				
				cardDisplayed = Imaging.Crop(Imaging.CaptureImageAuto(canvas), new Rectangle(x, y, width, height));
				
				//Compare card displayed to each card that has been shown prevously
				foreach (Bitmap img in shownCards)
				{
					match = Imaging.Contains(img, cardDisplayed);
					if (match) {
						break;	
					}
				}
				
				if (match) {
					Keyboard.Press("k");
					match = false;
				}
				else {
					Keyboard.Press("d");
					shownCards.Add(cardDisplayed);
				}
				
				trialNumber++;
				
				if (trialNumber == 80)
					finished = true;
				else
					Delay.Duration(feedbackTime);	
			}
        }
    }
}
