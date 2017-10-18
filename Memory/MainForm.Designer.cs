namespace Memory {
	partial class MainForm {
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
			this.viewPanel = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// viewPanel
			// 
			this.viewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.viewPanel.Location = new System.Drawing.Point(0, 0);
			this.viewPanel.Name = "viewPanel";
			this.viewPanel.Size = new System.Drawing.Size(782, 553);
			this.viewPanel.TabIndex = 0;
			// 
			// Hoofdscherm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(782, 553);
			this.Controls.Add(this.viewPanel);
			this.Name = "Hoofdscherm";
			this.Text = "Memory";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel viewPanel;
	}
}

