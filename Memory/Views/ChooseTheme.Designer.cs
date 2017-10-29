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
            this.ThemeBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BackToMainMenu
            // 
            resources.ApplyResources(this.BackToMainMenu, "BackToMainMenu");
            this.BackToMainMenu.Name = "BackToMainMenu";
            this.BackToMainMenu.UseVisualStyleBackColor = true;
            this.BackToMainMenu.Click += new System.EventHandler(this.BackToMainMenu_Click);
            // 
            // ThemeBox
            // 
            this.ThemeBox.BackColor = System.Drawing.Color.White;
            this.ThemeBox.FormattingEnabled = true;
            this.ThemeBox.Items.AddRange(new object[] {
            resources.GetString("ThemeBox.Items"),
            resources.GetString("ThemeBox.Items1"),
            resources.GetString("ThemeBox.Items2"),
            resources.GetString("ThemeBox.Items3")});
            resources.ApplyResources(this.ThemeBox, "ThemeBox");
            this.ThemeBox.Name = "ThemeBox";
            this.ThemeBox.SelectedIndexChanged += new System.EventHandler(this.ThemeBox_SelectedIndexChanged);
            // 
            // ChooseTheme
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Memory.Properties.Resources.BackGround;
            this.Controls.Add(this.ThemeBox);
            this.Controls.Add(this.BackToMainMenu);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChooseTheme";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackToMainMenu;
        public System.Windows.Forms.ComboBox ThemeBox;
    }
}