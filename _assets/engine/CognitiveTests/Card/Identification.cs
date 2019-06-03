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

namespace engine.CognitiveTests.Card
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
        /// just complete the learn test
        /// </summary>
        [UserCodeMethod]
        public static void RunIdentificationLearn(String DOM)
        {
        	//initialise variables
			int trialNumber = 0;
			//int x = 355, y = 180, width = 350, height = 420; //Crop entire card
			int xCrop = 380, yCrop = 210, widthCrop = 35, heightCrop = 115; //Crop only card number and suit
			int tPos = 0, tNeg = 0;
			int startDelay = 5000;
			bool finished = false;
			bool match = false;
			bool facedown = true;
			ButtonTag startButton = "/dom[@domain='" + DOM + "']//button[#'instructions_button']";
			CanvasTag canvas;
			Bitmap cardDisplayed = null;
			Bitmap cardCorner;			
			Bitmap redJoker = Imaging.Load(@".\images\RJ.png");
			Imaging.FindOptions.Default.Similarity = 0.999;
			
			//Wait for start button to be enabled
			Delay.Duration(startDelay);
			
			startButton.Click();
			
			canvas = "/dom[@domain='" + DOM + "']//div[#displayDiv]/canvas";
			
			//Capture the corner of the card while face down to determine when the card turns face up
			cardCorner = Imaging.Crop(Imaging.CaptureImageAuto(canvas), new Rectangle(xCrop, yCrop, widthCrop, heightCrop));
			
			//Wait for first card
			Delay.Duration(startDelay);
			
			//Continue to make correct responses until required correct has been met
			while (!finished) {
				//Constantly check for card turning face up
				while (facedown) {
					cardDisplayed = Imaging.Crop(Imaging.CaptureImageAuto(canvas), new Rectangle(xCrop, yCrop, widthCrop, heightCrop));
					facedown = Imaging.Contains(cardCorner, cardDisplayed);

					Report.Info("Trial No: " + (trialNumber + 1) + ", Is card facedown? " + facedown);
				}
				
				match = Imaging.Contains(redJoker, cardDisplayed);
				//Report.Log(ReportLevel.Info, "end image compare");
				
				//Make a response and Increment TPOS/TNEG/Trial Count
				if (match == true) {
					Report.Info("Pressing K Key");
					Keyboard.Press("k");
					tPos++;
				}
				else {
					Report.Info("Pressing D Key");
					Keyboard.Press("d");	
					tNeg++;
				}
				
				trialNumber++;
				facedown = true;
				Delay.Duration(100);
				
				if (trialNumber == 5 && tPos >= 1 && tNeg >= 1)
					finished = true;

			}
        }
        
        
        
        /// <summary>
        /// This will pick up from the Identification Instructions screen and 
        /// complete the standard configuration which consists of the demo
        /// and real tests (seamless)
        /// </summary>
        [UserCodeMethod]
        public static void RunIdentificationTest(String DOM)
        {
        	//initialise variables
			int trialNumber = 0;
			//int x = 355, y = 180, width = 350, height = 420; //Crop entire card
			int xCrop = 380, yCrop = 210, widthCrop = 35, heightCrop = 115; //Crop only card number and suit
			int tPos = 0, tNeg = 0;
			int startDelay = 5000;
			bool finished = false;
			bool match = false;
			bool demo = true;
			bool facedown = true;
			ButtonTag startButton = "/dom[@domain='" + DOM + "']//button[#'instructions_button']";
			Bitmap cardDisplayed = null;
			Bitmap cardCorner;			
			Bitmap redJoker = Imaging.Load(@".\images\RJ.png");
			Imaging.FindOptions.Default.Similarity = 0.999;
			
			//Wait for start button be become enabled
			Delay.Duration(startDelay);
			
			startButton.Click();
			
			CanvasTag canvas = "/dom[@domain='" + DOM + "']//div[#displayDiv]/canvas";
			
			//Capture the corner of the card while face down to determine when the card turns face up
			cardCorner = Imaging.Crop(Imaging.CaptureImageAuto(canvas), new Rectangle(xCrop, yCrop, widthCrop, heightCrop));
			
			//Wait for first card
			Delay.Duration(2000);
			
			//Continue to make correct responses until requried correct has been met
			while (!finished) {
				//Constantly check for card turning face up
				while (facedown) {
					cardDisplayed = Imaging.Crop(Imaging.CaptureImageAuto(canvas), new Rectangle(xCrop, yCrop, widthCrop, heightCrop));
					facedown = Imaging.Contains(cardCorner, cardDisplayed);

					Report.Info("Trial No: " + (trialNumber + 1) + ", Is card facedown? " + facedown);
				}

				match = Imaging.Contains(redJoker, cardDisplayed);
				
				//Make a response and increment TPOS/TNEG/Trial count
				if (match == true) {
					Report.Info("Pressing K Key");
					Keyboard.Press("k");					
					tPos++;
				}
				else {
					Report.Info("Pressing D Key");
					Keyboard.Press("d");	
					tNeg++;
				}
				
				trialNumber++;
				facedown = true;
				Delay.Duration(100);
				
				//Check to see if demo is complete.
				//Reset the counters if we are onto the real task
				if (demo == true && tPos >= 1 && tNeg >= 1 && trialNumber >= 3) {
					demo = false;
					trialNumber = 0;
				}
					
				if (trialNumber == 30)
					finished = true;
				
			}
        }
    }
}
