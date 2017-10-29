namespace Memory.Views
{
    partial class GameSettings
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
            this.StartGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BackToMainMenu = new System.Windows.Forms.Button();
            this.GridSize4x4 = new System.Windows.Forms.Button();
            this.GridSize8x8 = new System.Windows.Forms.Button();
            this.GridSize6x4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartGame
            // 
            this.StartGame.Location = new System.Drawing.Point(697, 526);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(75, 23);
            this.StartGame.TabIndex = 0;
            this.StartGame.Text = "Start Game";
            this.StartGame.UseVisualStyleBackColor = true;
            this.StartGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Grid Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "khf";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Player 2";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(75, 156);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(73, 43);
            this.listBox1.TabIndex = 5;
            // 
            // BackToMainMenu
            // 
            this.BackToMainMenu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BackToMainMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BackToMainMenu.Location = new System.Drawing.Point(12, 526);
            this.BackToMainMenu.Name = "BackToMainMenu";
            this.BackToMainMenu.Size = new System.Drawing.Size(69, 29);
            this.BackToMainMenu.TabIndex = 10;
            this.BackToMainMenu.Text = "Back";
            this.BackToMainMenu.UseVisualStyleBackColor = true;
            this.BackToMainMenu.Click += new System.EventHandler(this.BackToMainMenu_Click);
            // 
            // GridSize4x4
            // 
            this.GridSize4x4.Location = new System.Drawing.Point(75, 243);
            this.GridSize4x4.Name = "GridSize4x4";
            this.GridSize4x4.Size = new System.Drawing.Size(75, 75);
            this.GridSize4x4.TabIndex = 12;
            this.GridSize4x4.Text = "4 x 4";
            this.GridSize4x4.UseVisualStyleBackColor = true;
            this.GridSize4x4.Click += new System.EventHandler(this.GridSize4x4_Click);
            // 
            // GridSize8x8
            // 
            this.GridSize8x8.Location = new System.Drawing.Point(307, 243);
            this.GridSize8x8.Name = "GridSize8x8";
            this.GridSize8x8.Size = new System.Drawing.Size(75, 75);
            this.GridSize8x8.TabIndex = 13;
            this.GridSize8x8.Text = "8 x 8";
            this.GridSize8x8.UseVisualStyleBackColor = true;
            this.GridSize8x8.Click += new System.EventHandler(this.GridSize8x8_Click);
            // 
            // GridSize6x4
            // 
            this.GridSize6x4.Location = new System.Drawing.Point(189, 243);
            this.GridSize6x4.Name = "GridSize6x4";
            this.GridSize6x4.Size = new System.Drawing.Size(75, 75);
            this.GridSize6x4.TabIndex = 14;
            this.GridSize6x4.Text = "6 x 4";
            this.GridSize6x4.UseVisualStyleBackColor = true;
            this.GridSize6x4.Click += new System.EventHandler(this.GridSize6x4_Click);
            // 
            // GameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Memory.Properties.Resources.BackGround;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.GridSize6x4);
            this.Controls.Add(this.GridSize8x8);
            this.Controls.Add(this.GridSize4x4);
            this.Controls.Add(this.BackToMainMenu);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GameSettings";
            this.Text = "GameSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BackToMainMenu;
        private System.Windows.Forms.Button GridSize4x4;
        private System.Windows.Forms.Button GridSize8x8;
        private System.Windows.Forms.Button GridSize6x4;
    }
}