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

namespace engine.CognitiveTests.Card
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
        /// just complete the learn test
        /// </summary>
        [UserCodeMethod]
        public static void RunOneBackLearn(String DOM)
        {
        	//Initialise Variables
            Imaging.FindOptions.Default.Similarity = 0.999;
            Bitmap previousCard;
            Bitmap cardDisplayed = null;
            Bitmap cardCorner;
            //int x = 355, y = 180, width = 350, height = 420;
            int xCrop = 380, yCrop = 210, widthCrop = 35, heightCrop = 115; //Crop only card number and suit
            int tPos = 0, tNeg = 0;
            int trialNumber = 0;
            int startDelay = 5000;
            bool finished = false;
            bool match = false;
            bool facedown = true;
            
			ButtonTag startButton = "/dom[@domain='" + DOM + "']//button[#'instructions_button']";
            
			//Wait for start button to be displayed
			Delay.Duration(startDelay);
			
			startButton.Click();
			
			CanvasTag canvas = "/dom[@domain='" + DOM + "']//div[#displayDiv]/canvas";
			
			//Capture the corner of the card while face down to determine when the card turns face up
			cardCorner = Imaging.Crop(Imaging.CaptureImageAuto(canvas), new Rectangle(xCrop, yCrop, widthCrop, heightCrop));
			
			//Wait for first card
			Delay.Duration(startDelay);
			
			//Store first card displayed in previousCard as there is no card to compare to yet, saves us having to move it later
			previousCard = Imaging.Crop(Imaging.CaptureImageAuto(canvas), new Rectangle(xCrop, yCrop, widthCrop, heightCrop));
			Keyboard.Press("d");
			trialNumber++;
			
			//Continue to make responses until required correct has been met
			while (!finished) {
				while (facedown) {
					cardDisplayed = Imaging.Crop(Imaging.CaptureImageAuto(canvas), new Rectangle(xCrop, yCrop, widthCrop, heightCrop));
					facedown = Imaging.Contains(cardCorner, cardDisplayed);
					
					Report.Info("Trial No: " + (trialNumber + 1) + ", Is card facedown? " + facedown);
				}
				
				match = Imaging.Contains(previousCard, cardDisplayed);
				
				if (match) {
					Report.Info("Pressing K Key");
					Keyboard.Press("k");
					match = false;
					tPos++;
				}
				else {
					Report.Info("Pressing D Key");
					Keyboard.Press("d");
					previousCard = cardDisplayed;
					tNeg++;
				}
				
				trialNumber++;
				facedown = true;
				Delay.Duration(100);
				
				if (trialNumber == 10 && tPos >= 1 && tNeg >= 1)  //Terminate the task if the required conditions are met
					finished = true;
			}
        }
        
        
        /// <summary>
        /// This will pick up from the OneBackTest Instructions screen and
        /// just complete the Demo and Real test (seamless)
        /// </summary>
        [UserCodeMethod]
        public static void RunOneBackTest(String DOM)
        {
        	//Initialise Variables
            Imaging.FindOptions.Default.Similarity = 0.999;
            Bitmap previousCard;
            Bitmap cardDisplayed = null;
            Bitmap cardCorner;
            //int x = 355, y = 180, width = 350, height = 420;
            int xCrop = 380, yCrop = 210, widthCrop = 35, heightCrop = 115; //Crop only card number and suit
            int tPos = 0, tNeg = 0;
            int trialNumber = 0;
            int startDelay = 5000;
            bool finished = false;
            bool match = false;
            bool demo = true;
            bool facedown = true;
            
			ButtonTag startButton = "/dom[@domain='" + DOM + "']//button[#'instructions_button']";
            
			//Wait for enabled button to be enabled
			Delay.Duration(startDelay);
			
			startButton.Click();
			
			CanvasTag canvas = "/dom[@domain='" + DOM + "']//div[#displayDiv]/canvas";
			
			//Capture the corner of the card while face down to determine when the card turns face up
			cardCorner = Imaging.Crop(Imaging.CaptureImageAuto(canvas), new Rectangle(xCrop, yCrop, widthCrop, heightCrop));
			
			//Wait for first card
			Delay.Duration(2000);
			
			//Store first card displayed in previousCard as there is no card to compare to yet, saves us having to move it later
			previousCard = Imaging.Crop(Imaging.CaptureImageAuto(canvas), new Rectangle(xCrop, yCrop, widthCrop, heightCrop));
			Keyboard.Press("d");
			trialNumber++;
			
			//continue to make correct responses untill required correct has been met
			while (!finished) {
				//Constantly check for card turning face up
				while (facedown) {
					cardDisplayed = Imaging.Crop(Imaging.CaptureImageAuto(canvas), new Rectangle(xCrop, yCrop, widthCrop, heightCrop));
					facedown = Imaging.Contains(cardCorner, cardDisplayed);
					
					Report.Info("Trial No: " + (trialNumber + 1) + ", Is card facedown? " + facedown);
				}
				
				match = Imaging.Contains(previousCard, cardDisplayed);
				
				//Make a response and Increment TPos/TNeg/Trial count
				if (match) {
					Report.Info("Pressing K Key");
					Keyboard.Press("k");
					tPos++;
					match = false;
				}
				else {
					Report.Info("Pressing D Key");
					Keyboard.Press("d");
					tNeg++;
					previousCard = cardDisplayed;
				}
				
				trialNumber++;
				facedown = true;
				Delay.Duration(100);
				
				//Check to see if demo is complete
				//Reset the trial counter once onto the real task
				if (demo == true && tPos >= 1 && tNeg >= 1 && trialNumber >= 3) {
					demo = false;
					trialNumber = 0;
				}
				
				if (trialNumber == 31)
					finished = true;
			}
        }
    }
}
