using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DebugConsole {
	public interface IDebugConsoleView {

		event Action ClearEvent;

		void Show();
		void SetMessages(IList<DebugConsoleItem> messages);
		void AddMessage(DebugConsoleItem message);
		void UpdateMessage(DebugConsoleItem message);
	}
}
