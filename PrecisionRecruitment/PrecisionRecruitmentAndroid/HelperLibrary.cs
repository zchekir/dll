/*
 * Created by Ranorex
 * User: DWood
 * Date: 1/02/2019
 * Time: 4:19 PM
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

namespace PrecisionRecruitmentAndroid
{
    /// <summary>
    /// Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class HelperLibrary
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        /// <summary>
        /// Holds an instance of the PrecisionRecruitment repository.
        /// </summary>
        public static PrecisionRecruitmentAndroidRepository repo = PrecisionRecruitmentAndroidRepository.Instance;
        
         /// <summary>
        /// Presses the keys passed in. This will be uesed to trigger the change event for mobile testing when
        /// text fields are set using the 'setValue' method
        /// </summary>
        [UserCodeMethod]
        public static void TriggerChange(string keys)
        {
       		repo.RanorexBrowser.Dom.Self.PressKeys(keys);
        }
    }
}
