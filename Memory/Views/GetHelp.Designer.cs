namespace Memory.Views
{
    partial class GetHelp
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
            this.BackToMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackToMainMenu
            // 
            this.BackToMainMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BackToMainMenu.Location = new System.Drawing.Point(12, 408);
            this.BackToMainMenu.Name = "BackToMainMenu";
            this.BackToMainMenu.Size = new System.Drawing.Size(69, 29);
            this.BackToMainMenu.TabIndex = 9;
            this.BackToMainMenu.Text = "Back";
            this.BackToMainMenu.UseVisualStyleBackColor = true;
            this.BackToMainMenu.Click += new System.EventHandler(this.BackToMainMenu_Click);
            // 
            // GetHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 449);
            this.Controls.Add(this.BackToMainMenu);
            this.Name = "GetHelp";
            this.Text = "Get Help";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackToMainMenu;
    }
}