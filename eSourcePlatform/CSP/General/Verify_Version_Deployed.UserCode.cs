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

namespace CSP.General
{
    public partial class Verify_Version_Deployed
    {
    	
      
        private void Init()
        {
           
        }
        
       // Server version validation
        public void VersionValidation()
        {
			Validate.AreEqual(engine.Helpers.WebService.Sversion,ServerVersion );
        }

    }
}
