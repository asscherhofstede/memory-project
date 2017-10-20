namespace Memory.Views
{
    partial class ChooseTheme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseTheme));
            this.BackToMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackToMainMenu
            // 
            resources.ApplyResources(this.BackToMainMenu, "BackToMainMenu");
            this.BackToMainMenu.Name = "BackToMainMenu";
            this.BackToMainMenu.UseVisualStyleBackColor = true;
            this.BackToMainMenu.Click += new System.EventHandler(this.BackToMainMenu_Click);
            // 
            // ChooseTheme
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BackToMainMenu);
            this.Name = "ChooseTheme";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackToMainMenu;
    }
}