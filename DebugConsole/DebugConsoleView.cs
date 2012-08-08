using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DebugConsole {
	public partial class DebugConsoleView : Form, IDebugConsoleView {
		private readonly ContextMenuStrip menu = new ContextMenuStrip();

		public DebugConsoleView() {
			InitializeComponent();
			menu.Items.Add(new ToolStripMenuItem("Copy selected",null,OnCopySelected));
			menu.Items.Add(new ToolStripMenuItem("Copy selected text", null, OnCopySelectedText));
			menu.Items.Add(new ToolStripSeparator());
			menu.Items.Add(new ToolStripMenuItem("Select all", null, OnSelectAll));
			lvMessages.ContextMenuStrip = menu;
		}

		void OnCopySelected(object sender, EventArgs e) {
			var builder = new StringBuilder();
			foreach (ListViewItem item in lvMessages.SelectedItems) {
				builder.Append(item.Text);
				builder.Append("\t");
				builder.Append(item.SubItems[1].Text);
				builder.AppendLine();
			}
			Clipboard.SetText(builder.ToString());
		}

		void OnCopySelectedText(object sender, EventArgs e) {
			var builder = new StringBuilder();
			foreach (ListViewItem item in lvMessages.SelectedItems) {
				builder.Append(item.SubItems[1].Text);
				builder.AppendLine();
			}
			Clipboard.SetText(builder.ToString());
		}

		void OnSelectAll(object sender, EventArgs e) {
			foreach (ListViewItem item in lvMessages.Items) {
				item.Selected = true;
			}
		}

		public event Action ClearEvent;

		private void DebugConsoleView_Load(object sender, System.EventArgs e) {
			SizeLastColumn();
		}

		private void DebugConsoleView_Resize(object sender, System.EventArgs e) {
			SizeLastColumn();
		}

		private void SizeLastColumn() {
			lvMessages.Columns[lvMessages.Columns.Count - 1].Width = -2;
		}


		private void AddMessagePrivate(DebugConsoleItem message) {
			var item = new ListViewItem(message.Time.ToString("dd-MM-yyyy hh:mm:ss.fff"));
			item.SubItems.Add(message.Message);
			lvMessages.Items.Add(item);
		}

		private void TryScroll() {
			if (cbScoll.Checked && lvMessages.Items.Count > 0)
				lvMessages.EnsureVisible(lvMessages.Items.Count - 1);
		}

		public void SetMessages(IList<DebugConsoleItem> messages) {
			lvMessages.Items.Clear();
			foreach (var message in messages) 
				AddMessage(message);
			TryScroll();
		}

		public void AddMessage(DebugConsoleItem message) {
			AddMessagePrivate(message);
			TryScroll();
		}

		public void UpdateMessage(DebugConsoleItem message) {
			if (lvMessages.Items.Count <= 0)
				return;
			ListViewItem item = lvMessages.Items[lvMessages.Items.Count - 1];
			item.SubItems[1].Text = message.Message; 
		}

		private void btnClear_Click(object sender, EventArgs e) {
			if (ClearEvent != null)
				ClearEvent();
		}

		private void cbScoll_CheckedChanged(object sender, EventArgs e) {
			TryScroll();
		}

		private void cbOnTop_CheckedChanged(object sender, EventArgs e) {
			this.TopMost = cbOnTop.Checked;
		}
	}
}
