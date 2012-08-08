using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DebugConsole {
	public sealed class DebugConsoleController {
		readonly private IDebugConsoleView mainView;
		readonly private DebugConsoleListener mainListener;
		public DebugConsoleController(DebugConsoleListener listener, IDebugConsoleView view) {
			mainView = view;
			mainListener = listener;
			mainView.ClearEvent += OnClear;
			listener.UpdateMessage += OnUpdateMessages;
			listener.RemoveMessages += OnRemoveMessages;
			listener.AddMessage += OnAddMessage;
			mainView.SetMessages(listener.GetMessages());
			mainView.Show();
		}

		public void OnAddMessage() {
			mainView.AddMessage(mainListener.GetLastMessage());
		}

		public void OnRemoveMessages() {
			mainView.SetMessages(mainListener.GetMessages());
		}

		public void OnUpdateMessages() {
			mainView.UpdateMessage(mainListener.GetLastMessage());
		}

		private void OnClear() {
			mainListener.Clear();
		}
	}
}
