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
			int xCrop = 380, yCrop = 210, widthCrop = 35, heightCrop = 115; //Crop only card number and suit
			bool finished = false;
			bool facedown = true;
			int startDelay = 5000;
            ButtonTag startButton = "/dom[@domain='" + DOM + "']//button[#'instructions_button']";
            CanvasTag canvas;
            Bitmap cardCorner;
            Bitmap cardDisplayed;
            Imaging.FindOptions.Default.Similarity = 0.999;
	
            //wait for start button to become active
			Delay.Duration(startDelay);
			
			startButton.Click();
			
			canvas = "/dom[@domain='" + DOM + "']//div[#displayDiv]/canvas";
			
			//Capture the corner of the card while face down to determine when the card turns face up
			cardCorner = Imaging.Crop(Imaging.CaptureImageAuto(canvas), new Rectangle(xCrop, yCrop, widthCrop, heightCrop));
			
			//Continue to make correct responses until required correct has been met
			while (!finished) {
				//Constantly check for card turning face up
				while (facedown) {
					cardDisplayed = Imaging.Crop(Imaging.CaptureImageAuto(canvas), new Rectangle(xCrop, yCrop, widthCrop, heightCrop));
					facedown = Imaging.Contains(cardCorner, cardDisplayed);
					
					Report.Info("Trial No: " + (trialNumber + 1) + ", Is card facedown? " + facedown);
				}
				
				Report.Info("Pressing K Key");
				Keyboard.Press("k");
				
				trialNumber++;
				facedown = true;
				Delay.Duration(100);
				
				if (trialNumber == 5)
					finished = true;
			}
        }
        
        
        /// <summary>
        /// This will pick up from the Detection Instructions screen and 
        /// complete the standard configuration which consists of the demo
        /// and real tests (seamless)
        /// </summary>
        [UserCodeMethod]
        public static void RunDetectionTest(String DOM)
        {
        	//initialise variables
            int trialNumber = 0;
            int xCrop = 380, yCrop = 210, widthCrop = 35, heightCrop = 115; //Crop only card number and suit
            int maxTrials = 38;
            bool finished = false;
            bool facedown = true;
            int startDelay = 5000;
            ButtonTag startButton = "/dom[@domain='" + DOM + "']//button[#'instructions_button']";
            CanvasTag canvas;
            Bitmap cardCorner;
            Bitmap cardDisplayed;
            Imaging.FindOptions.Default.Similarity = 0.999;
            
            //wait for start button to become active
			Delay.Duration(startDelay);
			
			startButton.Click();
			
			canvas = "/dom[@domain='" + DOM + "']//div[#displayDiv]/canvas";
			
			//Capture the corner of the card while face down to determine when the card turns face up
			cardCorner = Imaging.Crop(Imaging.CaptureImageAuto(canvas), new Rectangle(xCrop, yCrop, widthCrop, heightCrop));
			
			//Continue to make responses for 38 trials (35 for real task and 3 for demo task)
			while (!finished) {
				//Constantly check for card turning face up
				while (facedown) {
					cardDisplayed = Imaging.Crop(Imaging.CaptureImageAuto(canvas), new Rectangle(xCrop, yCrop, widthCrop, heightCrop));
					facedown = Imaging.Contains(cardCorner, cardDisplayed);
					
					Report.Info("Trial No: " + (trialNumber + 1) + ", Is card facedown? " + facedown);
				}
				
				Report.Info("Pressing K Key");				
				Keyboard.Press("k");
				
				trialNumber++;
				facedown = true;
				Delay.Duration(100);
				
				if (trialNumber == maxTrials)
					finished = true;
			}
        }
    }
}
