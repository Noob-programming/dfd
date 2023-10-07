using System;
using System.Windows.Forms;
using Itemds.View.Forms;

namespace Itemds
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Frm_Bill());
		}
	}
}
