﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace CSP.APIV2Modules
{
	public partial class Validate_CBB_Version
	{
		
		private void Init()
		{
			// Your recording specific initialization code goes here.
		}

		public void cbbVersion_Check(string cbbv, string wfInstance)
		{
			
			
			//variables
			string wf = wfInstance;
			string[] wfList = wf.Split('&');
			Boolean IsPassed = false;
			
			//looping in the WF
			foreach (string bbversion in wfList)
			{

				if (bbversion == cbbv)
				{
					Validate.AreEqual(bbversion, cbbv);
					IsPassed = true;
					break;

				}
				
			}


			if (IsPassed)
			{
				
				Report.Log(ReportLevel.Info,"Test Passed:" + cbbv);
			}
			else
			{
				string a="Current cbb version is diffrent from Expected one";
				Validate.AreEqual(a, cbbv);
				Report.Log(ReportLevel.Info,"Test Failed:" + cbbv);
			}
			
		}

	}
}
