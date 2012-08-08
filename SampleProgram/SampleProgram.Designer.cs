namespace SampleProgram {
	partial class Form1 {
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
			this.btnWriteLine = new System.Windows.Forms.Button();
			this.btnWrite = new System.Windows.Forms.Button();
			this.tbTrace = new System.Windows.Forms.TextBox();
			this.cbOptions = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// btnWriteLine
			// 
			this.btnWriteLine.Location = new System.Drawing.Point(177, 42);
			this.btnWriteLine.Name = "btnWriteLine";
			this.btnWriteLine.Size = new System.Drawing.Size(75, 23);
			this.btnWriteLine.TabIndex = 0;
			this.btnWriteLine.Text = "WriteLine";
			this.btnWriteLine.UseVisualStyleBackColor = true;
			this.btnWriteLine.Click += new System.EventHandler(this.btnWriteLine_Click);
			// 
			// btnWrite
			// 
			this.btnWrite.Location = new System.Drawing.Point(177, 12);
			this.btnWrite.Name = "btnWrite";
			this.btnWrite.Size = new System.Drawing.Size(75, 23);
			this.btnWrite.TabIndex = 1;
			this.btnWrite.Text = "Write";
			this.btnWrite.UseVisualStyleBackColor = true;
			this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
			// 
			// tbTrace
			// 
			this.tbTrace.Location = new System.Drawing.Point(12, 13);
			this.tbTrace.Name = "tbTrace";
			this.tbTrace.Size = new System.Drawing.Size(159, 20);
			this.tbTrace.TabIndex = 2;
			this.tbTrace.Text = "Write something clever!";
			// 
			// cbOptions
			// 
			this.cbOptions.FormattingEnabled = true;
			this.cbOptions.Items.AddRange(new object[] {
            "Milk",
            "Water",
            "Ooooook!"});
			this.cbOptions.Location = new System.Drawing.Point(13, 40);
			this.cbOptions.Name = "cbOptions";
			this.cbOptions.Size = new System.Drawing.Size(158, 21);
			this.cbOptions.TabIndex = 3;
			this.cbOptions.SelectedIndexChanged += new System.EventHandler(this.cbOptions_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(266, 77);
			this.Controls.Add(this.cbOptions);
			this.Controls.Add(this.tbTrace);
			this.Controls.Add(this.btnWrite);
			this.Controls.Add(this.btnWriteLine);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(282, 115);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(282, 115);
			this.Name = "Form1";
			this.Text = "Sample program";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnWriteLine;
		private System.Windows.Forms.Button btnWrite;
		private System.Windows.Forms.TextBox tbTrace;
		private System.Windows.Forms.ComboBox cbOptions;
	}
}

