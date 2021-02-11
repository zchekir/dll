/*
 * Created by Ranorex
 * User: zchekir
 * Date: 2/10/2021
 * Time: 11:21 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */

using System;
using System.Windows.Forms;

namespace Eisia
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
