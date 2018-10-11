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

namespace PrecisionRecruitment.UsersPage
{
    public partial class Search_User_Email
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }
		
        /// <summary>
        /// This will replace any '+' characters in the Email address before entering into the search field.
        /// If a plus is entered, the system reads this as a space and the user will not be found. We need to
        /// encode the plus symbol for the search to work correctly
        /// </summary>
        /// <param name="inputtagInfo">Element we want to enter the Email address into</param>
        public void Enter_Email(RepoItemInfo inputtagInfo)
        {
        	if (Username.Contains("+"))
        	{
        		Report.Log(ReportLevel.Info, "User", "Replacing all '+' symbols with the encoded symbol");
        		Username = Username.Replace("+", "%2B");
        	}
        	
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Username' with focus on 'inputtagInfo'.", inputtagInfo);
            inputtagInfo.FindAdapter<InputTag>().PressKeys(Username, 1);
        }

    }
}
