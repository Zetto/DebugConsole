using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DebugConsole;
using System.Diagnostics;

namespace SampleProgram {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			// Initialize debug console
			DebugConsoleInstance.Init(true);

			Application.Run(new Form1());
		}
	}
}
