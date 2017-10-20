namespace Memory.Views
{
    partial class Laadscherm
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
            this.LoadScreen = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoadScreen
            // 
            this.LoadScreen.AutoSize = true;
            this.LoadScreen.Location = new System.Drawing.Point(238, 39);
            this.LoadScreen.Name = "LoadScreen";
            this.LoadScreen.Size = new System.Drawing.Size(62, 13);
            this.LoadScreen.TabIndex = 0;
            this.LoadScreen.Text = "Load Game";
            this.LoadScreen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LoadScreen.Click += new System.EventHandler(this.LoadScreen_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Laadscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 449);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LoadScreen);
            this.Name = "Laadscherm";
            this.Text = "Laadscherm";
            this.Load += new System.EventHandler(this.Laadscherm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoadScreen;
        private System.Windows.Forms.Button button1;
    }
}