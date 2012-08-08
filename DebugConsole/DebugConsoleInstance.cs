using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace DebugConsole {
	public sealed class DebugConsoleInstance {
		private readonly DebugConsoleListener listener = new DebugConsoleListener();
		private readonly DebugConsoleView view = new DebugConsoleView();
		private readonly DebugConsoleController controller;
		private static DebugConsoleInstance instance = null;

		private DebugConsoleInstance() {
			Debug.Listeners.Add(listener);
			controller = new DebugConsoleController(listener, view);
		}

		public static void Init(bool exclusive = false) {
			if (instance == null) {
				if (exclusive)
					Debug.Listeners.Clear();
				instance = new DebugConsoleInstance();
			}
		}
	}
}
