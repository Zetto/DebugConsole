namespace DebugConsole {
	partial class DebugConsoleView {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.lvMessages = new System.Windows.Forms.ListView();
			this.colTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnClear = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cbOnTop = new System.Windows.Forms.CheckBox();
			this.cbScoll = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lvMessages
			// 
			this.lvMessages.AutoArrange = false;
			this.lvMessages.CausesValidation = false;
			this.lvMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTime,
            this.colMessage});
			this.lvMessages.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvMessages.FullRowSelect = true;
			this.lvMessages.Location = new System.Drawing.Point(0, 0);
			this.lvMessages.Name = "lvMessages";
			this.lvMessages.Size = new System.Drawing.Size(405, 280);
			this.lvMessages.TabIndex = 0;
			this.lvMessages.UseCompatibleStateImageBehavior = false;
			this.lvMessages.View = System.Windows.Forms.View.Details;
			// 
			// colTime
			// 
			this.colTime.Text = "Time";
			this.colTime.Width = 150;
			// 
			// colMessage
			// 
			this.colMessage.Text = "Message";
			this.colMessage.Width = 371;
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(3, 3);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 1;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cbOnTop);
			this.panel1.Controls.Add(this.cbScoll);
			this.panel1.Controls.Add(this.btnClear);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 280);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(405, 30);
			this.panel1.TabIndex = 2;
			// 
			// cbOnTop
			// 
			this.cbOnTop.AutoSize = true;
			this.cbOnTop.Location = new System.Drawing.Point(142, 7);
			this.cbOnTop.Name = "cbOnTop";
			this.cbOnTop.Size = new System.Drawing.Size(92, 17);
			this.cbOnTop.TabIndex = 3;
			this.cbOnTop.Text = "Always on top";
			this.cbOnTop.UseVisualStyleBackColor = true;
			this.cbOnTop.CheckedChanged += new System.EventHandler(this.cbOnTop_CheckedChanged);
			// 
			// cbScoll
			// 
			this.cbScoll.AutoSize = true;
			this.cbScoll.Checked = true;
			this.cbScoll.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbScoll.Location = new System.Drawing.Point(84, 7);
			this.cbScoll.Name = "cbScoll";
			this.cbScoll.Size = new System.Drawing.Size(52, 17);
			this.cbScoll.TabIndex = 2;
			this.cbScoll.Text = "Scroll";
			this.cbScoll.UseVisualStyleBackColor = true;
			this.cbScoll.CheckedChanged += new System.EventHandler(this.cbScoll_CheckedChanged);
			// 
			// DebugConsoleView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(405, 310);
			this.Controls.Add(this.lvMessages);
			this.Controls.Add(this.panel1);
			this.MinimumSize = new System.Drawing.Size(300, 200);
			this.Name = "DebugConsoleView";
			this.Text = "Debug console";
			this.Load += new System.EventHandler(this.DebugConsoleView_Load);
			this.Resize += new System.EventHandler(this.DebugConsoleView_Resize);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView lvMessages;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ColumnHeader colTime;
		private System.Windows.Forms.ColumnHeader colMessage;
		private System.Windows.Forms.CheckBox cbScoll;
		private System.Windows.Forms.CheckBox cbOnTop;
	}
}