using System.Collections.Generic;
using System.Globalization;
using NUnit.Framework;
using DebugConsole;

namespace DebugConsoleTests {
	[TestFixture]
	class ListenerTests {
		const string TestMessage1 = "Test message 1";
		const string TestMessage2 = "Test message 2";
		const string TestMessage3 = "Test message 3";

		[Test]
		public void ShouldWriteMoreMessagesToOneLine() {
			var listener = new DebugConsoleListener();
			listener.Write(TestMessage1);
			listener.Write(TestMessage2);
			listener.Write(TestMessage3);
			IList<DebugConsoleItem> messages = listener.GetMessages();
			Assert.AreEqual(messages[0].Message, (TestMessage1 + TestMessage2 + TestMessage3));
		}

		[Test]
		public void ShouldWriteNewLine() {
			var listener = new DebugConsoleListener();
			listener.WriteLine(TestMessage1);
			listener.WriteLine(TestMessage2);
			IList<DebugConsoleItem> messages = listener.GetMessages();
			Assert.AreEqual(messages.Count, 2);
		}

		[Test]
		public void ShouldWriteNewLineAfteNormalWrite() {
			var listener = new DebugConsoleListener();
			listener.Write(TestMessage1);
			listener.WriteLine(TestMessage2);
			IList<DebugConsoleItem> messages = listener.GetMessages();
			Assert.AreEqual(messages.Count, 2);
		}

		[Test]
		public void ShouldWriteNewLineAfteNewLineWrite() {
			var listener = new DebugConsoleListener();
			listener.WriteLine(TestMessage2);
			listener.Write(TestMessage1);
			IList<DebugConsoleItem> messages = listener.GetMessages();
			Assert.AreEqual(messages.Count, 2);
		}

		[Test]
		public void ShouldRaiseNewMessageEvent() {
			var listener = new DebugConsoleListener();
			bool raised = false;
			listener.AddMessage += () => {
				raised = true;
			};
			listener.WriteLine(TestMessage2);
			Assert.IsTrue(raised);
		}

		[Test]
		public void ShouldRaiseUpdateMessageEvent() {
			var listener = new DebugConsoleListener();
			bool raised = false;
			listener.UpdateMessage += () => {
				raised = true;
			};
			listener.Write(TestMessage1);
			listener.Write(TestMessage2);
			Assert.IsTrue(raised);
		}

		[Test]
		public void ShouldRaiseRemoveMessagesEvent() {
			var listener = new DebugConsoleListener();
			bool raised = false;
			listener.RemoveMessages += () => { raised = true; };
			listener.SetMaximumSize(100);
			for (int i = 0; i < 101; i++)
				listener.WriteLine(i.ToString(CultureInfo.InvariantCulture));
			Assert.IsTrue(raised);
		}

		[Test]
		public void ShouldRemoveFirstTenMessages() {
			var listener = new DebugConsoleListener();
			listener.SetMaximumSize(100);
			for (int i=0;i<101;i++) 
				listener.WriteLine(i.ToString(CultureInfo.InvariantCulture));
			Assert.AreEqual(91,listener.GetMessages().Count);
			Assert.AreEqual(listener.GetMessages()[0].Message,"10");
			Assert.AreEqual(listener.GetMessages()[listener.GetMessages().Count -1 ].Message, "100");
		}

		[Test]
		public void ShouldClearMessages() {
			var listener = new DebugConsoleListener();
			listener.WriteLine(TestMessage1);
			bool raised = false;
			listener.RemoveMessages += () => {
				raised = true;
			};
			listener.Clear();
			Assert.AreEqual(0,listener.GetMessages().Count);		
			Assert.IsTrue(raised);
		}
	}
}
