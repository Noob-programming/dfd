﻿using itemStock.Forms;
using System;
using System.Windows.Forms;

namespace itemStock
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
			Application.Run(new Frm_Stock());
		}
	}
}