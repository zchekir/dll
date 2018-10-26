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

namespace engine.CognitiveTests.Card
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
        /// just complete the learn test
        /// </summary>
        [UserCodeMethod]
        public static void RunOCLLearn(String DOM)
        {
        	//Initialise Variables
            Imaging.FindOptions.Default.Similarity = 0.999;
            List<Bitmap> shownCards = new List<Bitmap>();
            Bitmap cardDisplayed = null;
            Bitmap cardCorner;
            //int x = 355, y = 180, width = 350, height = 420;
            int xCrop = 380, yCrop = 210, widthCrop = 35, heightCrop = 115; //Crop only card number and suit
            int trialNumber = 0;
            int startDelay = 5000;
            bool finished = false;
            bool match = false;
            bool facedown = true;
            
            
			ButtonTag startButton = "/dom[@domain='" + DOM + "']//button[#'instructions_button']";
            
			//Wait for start button to become enabled
			Delay.Duration(startDelay);
			
			startButton.Click();
			
			CanvasTag canvas = "/dom[@domain='" + DOM + "']//div[#displayDiv]/canvas";
			
			//Capture the corner of the card while face down to determine when the card turns face up
			cardCorner = Imaging.Crop(Imaging.CaptureImageAuto(canvas), new Rectangle(xCrop, yCrop, widthCrop, heightCrop));
			
			//Wait for first card
			Delay.Duration(startDelay);
			
			//First response is always 'no'
			cardDisplayed = Imaging.Crop(Imaging.CaptureImageAuto(canvas), new Rectangle(xCrop, yCrop, widthCrop, heightCrop));
			shownCards.Add(cardDisplayed);
			Keyboard.Press("d");
			trialNumber++;

			//Continue to make responses until required correct has been met
			while (!finished) {
				//Constantly check for card turning face up
				while (facedown) {
					cardDisplayed = Imaging.Crop(Imaging.CaptureImageAuto(canvas), new Rectangle(xCrop, yCrop, widthCrop, heightCrop));
					facedown = Imaging.Contains(cardCorner, cardDisplayed);
					
					Report.Info("Trial No: " + (trialNumber + 1) + ", Is card facedown? " + facedown);
				}
						
				foreach (Bitmap img in shownCards)
				{
					match = Imaging.Contains(img, cardDisplayed);
					if (match) {
						break;
					}
				}
				
				if (match) {
					Report.Info("Pressing K Key");
					Keyboard.Press("k");
					match = false;
				}
				else {
					Report.Info("Pressing D Key");
					Keyboard.Press("d");
					shownCards.Add(cardDisplayed);
				}
				
				trialNumber++;
				facedown = true;
				Delay.Duration(100);
				
				//Allow extra delay for card to turn face up during the first few trials of each learning phase while prompts are disaplayed
				if (trialNumber == 12)
					finished = true;
				
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
            Bitmap cardCorner;
            int x = 355, y = 180, width = 350, height = 420;
            int xCrop = 380, yCrop = 210, widthCrop = 35, heightCrop = 115; //Crop only card number and suit
            int trialNumber = 0;
            int startDelay = 5000;
            int feedbackTime = 2000;
            bool finished = false;
            bool match = false;
            bool facedown = true;
            
			ButtonTag startButton = "/dom[@domain='" + DOM + "']//button[#'instructions_button']";
            
			//Wait for start button to become enabled
			Delay.Duration(startDelay);
			
			startButton.Click();
			
			CanvasTag canvas = "/dom[@domain='" + DOM + "']//div[#displayDiv]/canvas";
			
			//Capture the corner of the card while face down to determine when the card turns face up
			cardCorner = Imaging.Crop(Imaging.CaptureImageAuto(canvas), new Rectangle(xCrop, yCrop, widthCrop, heightCrop));
			
			//Wait for first card
			Delay.Duration(feedbackTime);
			
			//First response is always 'no'
			cardDisplayed = Imaging.Crop(Imaging.CaptureImageAuto(canvas), new Rectangle(x, y, width, height));
			shownCards.Add(cardDisplayed);
			Keyboard.Press("d");
			trialNumber++;
			
			//Continue to make correct responses until required correct has been met
			while (!finished) {
				//Constantly check for card turning face up
				while (facedown) {
					cardDisplayed = Imaging.Crop(Imaging.CaptureImageAuto(canvas), new Rectangle(xCrop, yCrop, widthCrop, heightCrop));
					facedown = Imaging.Contains(cardCorner, cardDisplayed);
					
					Report.Info("Trial No: " + (trialNumber + 1) + ", Is card facedown? " + facedown);
				}
				
				//Compare card displayed to each card that has been shown prevously
				foreach (Bitmap img in shownCards)
				{
					match = Imaging.Contains(img, cardDisplayed);
					if (match) {
						break;	
					}
				}
				
				if (match) {
					Report.Info("Pressing K Key");
					Keyboard.Press("k");
					match = false;
				}
				else {
					Report.Info("Pressing D Key");
					Keyboard.Press("d");
					shownCards.Add(cardDisplayed);
				}
				
				trialNumber++;
				facedown = true;
				Delay.Duration(100);
				
				if (trialNumber == 10)
					finished = true;
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
            Bitmap cardCorner;
            int x = 355, y = 180, width = 350, height = 420;
            int xCrop = 380, yCrop = 210, widthCrop = 35, heightCrop = 115; //Crop only card number and suit
            int trialNumber = 0;
            int startDelay = 5000;
            int feedbackTime = 2000;
            bool finished = false;
            bool match = false;
            bool facedown = true;
            
			ButtonTag startButton = "/dom[@domain='" + DOM + "']//div[#displayDiv]/tag/div/div/?/?/button[@innertext='START']";
            
			//Wait for start button to become enabled
			Delay.Duration(startDelay);
			
			startButton.Click();
			
			CanvasTag canvas = "/dom[@domain='" + DOM + "']//div[#displayDiv]/canvas";
			
			//Capture the corner of the card while face down to determine when the card turns face up
			cardCorner = Imaging.Crop(Imaging.CaptureImageAuto(canvas), new Rectangle(xCrop, yCrop, widthCrop, heightCrop));
			
			//Wait for first card
			Delay.Duration(feedbackTime);
			
			//First response is always 'no'
			cardDisplayed = Imaging.Crop(Imaging.CaptureImageAuto(canvas), new Rectangle(xCrop, yCrop, widthCrop, heightCrop));
			shownCards.Add(cardDisplayed);
			Keyboard.Press("d");
			trialNumber++;
			
			//Continue to make correct responses until required correct has been met
			while (!finished) {
				//Constantly check for card turning face up
				while (facedown) {
					cardDisplayed = Imaging.Crop(Imaging.CaptureImageAuto(canvas), new Rectangle(xCrop, yCrop, widthCrop, heightCrop));
					facedown = Imaging.Contains(cardCorner, cardDisplayed);
					
					Report.Info("Trial No: " + (trialNumber + 1) + ", Is card facedown? " + facedown);
				}
				
				//Compare card displayed to each card that has been shown prevously
				foreach (Bitmap img in shownCards)
				{
					match = Imaging.Contains(img, cardDisplayed);
					if (match) {
						break;	
					}
				}
				
				if (match) {
					Report.Info("Pressing K Key");
					Keyboard.Press("k");
					match = false;
				}
				else {
					Report.Info("Pressing D Key");
					Keyboard.Press("d");
					shownCards.Add(cardDisplayed);
				}
				
				trialNumber++;
				facedown = true;
				Delay.Duration(100);
				
				if (trialNumber == 80)
					finished = true;
			}
        }
    }
}
