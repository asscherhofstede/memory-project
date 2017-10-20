namespace Memory.Views
{
    partial class LocalMultiplayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LocalMultiplayerTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LocalMultiplayerTitle
            // 
            this.LocalMultiplayerTitle.AutoSize = true;
            this.LocalMultiplayerTitle.Location = new System.Drawing.Point(288, 38);
            this.LocalMultiplayerTitle.Name = "LocalMultiplayerTitle";
            this.LocalMultiplayerTitle.Size = new System.Drawing.Size(86, 13);
            this.LocalMultiplayerTitle.TabIndex = 0;
            this.LocalMultiplayerTitle.Text = "Local Multiplayer";
            this.LocalMultiplayerTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // LocalMultiplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 517);
            this.Controls.Add(this.LocalMultiplayerTitle);
            this.Name = "LocalMultiplayer";
            this.Text = "LocalMultiplayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LocalMultiplayerTitle;
    }
}