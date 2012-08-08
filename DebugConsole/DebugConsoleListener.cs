using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace DebugConsole {

	public sealed class DebugConsoleItem {
		public DateTime Time { get; set; }
		public string Message { get; set; }

		public DebugConsoleItem(string message) {
			Time = DateTime.Now;
			Message = message;
		}
	}

	public sealed class DebugConsoleListener : TraceListener {
		private readonly List<DebugConsoleItem> messages = new List<DebugConsoleItem>();
		private bool newLine;
		
		public event Action AddMessage;
		public event Action UpdateMessage;
		public event Action RemoveMessages;
		private int maximum = 1000;

		public DebugConsoleListener() {
			newLine = false;
		}

		private bool ControlCount() {
			if (messages.Count > maximum && messages.Count > 0) {
				int removeCount = maximum/10;
				if (removeCount > 0) {
					try {
						messages.RemoveRange(0, removeCount);
					}
					catch (ArgumentOutOfRangeException) {
					}

				}
				if (RemoveMessages != null)
					RemoveMessages();
				return false;
			}
			return true;
		}

		public override void Write(string message) {
			if (messages.Count == 0 || newLine) {
				messages.Add(new DebugConsoleItem(message));
				if (ControlCount() && AddMessage != null)
					AddMessage();
			}
			else {
				messages[messages.Count - 1].Message += message;
				if (UpdateMessage != null)
					UpdateMessage();
			}
			newLine = false;

		}

		public override void WriteLine(string message) {
			messages.Add(new DebugConsoleItem(message));
			if (ControlCount() && AddMessage != null)
				AddMessage();
			newLine = true;
		}

		public IList<DebugConsoleItem> GetMessages() {
			return messages;
		}

		public DebugConsoleItem GetLastMessage() {
			return messages.Last();
		}

		public void SetMaximumSize(int max) {
			maximum = max;
			ControlCount();
		}

		public void Clear() {
			messages.Clear();
			if (RemoveMessages != null)
				RemoveMessages();
		}
	}
}
