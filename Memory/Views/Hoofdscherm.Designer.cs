namespace Memory.Views {
	partial class Hoofdscherm {
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
            this.MainMenu = new System.Windows.Forms.Label();
            this.Singleplayer = new System.Windows.Forms.Button();
            this.LoadGame = new System.Windows.Forms.Button();
            this.LocalMultiplayer = new System.Windows.Forms.Button();
            this.OnlineMultiplayer = new System.Windows.Forms.Button();
            this.ChooseTheme = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.AutoSize = true;
            this.MainMenu.Location = new System.Drawing.Point(230, 86);
            this.MainMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(60, 13);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "Main Menu";
            this.MainMenu.Click += new System.EventHandler(this.label1_Click);
            // 
            // Singleplayer
            // 
            this.Singleplayer.Location = new System.Drawing.Point(201, 155);
            this.Singleplayer.Name = "Singleplayer";
            this.Singleplayer.Size = new System.Drawing.Size(120, 29);
            this.Singleplayer.TabIndex = 1;
            this.Singleplayer.Text = "Singleplayer";
            this.Singleplayer.UseVisualStyleBackColor = true;
            this.Singleplayer.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // LoadGame
            // 
            this.LoadGame.Location = new System.Drawing.Point(201, 190);
            this.LoadGame.Name = "LoadGame";
            this.LoadGame.Size = new System.Drawing.Size(120, 29);
            this.LoadGame.TabIndex = 2;
            this.LoadGame.Text = "Load game";
            this.LoadGame.UseVisualStyleBackColor = true;
            this.LoadGame.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // LocalMultiplayer
            // 
            this.LocalMultiplayer.Location = new System.Drawing.Point(201, 225);
            this.LocalMultiplayer.Name = "LocalMultiplayer";
            this.LocalMultiplayer.Size = new System.Drawing.Size(120, 29);
            this.LocalMultiplayer.TabIndex = 3;
            this.LocalMultiplayer.Text = "Local Multiplayer";
            this.LocalMultiplayer.UseVisualStyleBackColor = true;
            this.LocalMultiplayer.Click += new System.EventHandler(this.LocalMultiplayer_Click);
            // 
            // OnlineMultiplayer
            // 
            this.OnlineMultiplayer.Location = new System.Drawing.Point(201, 260);
            this.OnlineMultiplayer.Name = "OnlineMultiplayer";
            this.OnlineMultiplayer.Size = new System.Drawing.Size(120, 29);
            this.OnlineMultiplayer.TabIndex = 4;
            this.OnlineMultiplayer.Text = "Online Multiplayer";
            this.OnlineMultiplayer.UseVisualStyleBackColor = true;
            this.OnlineMultiplayer.Click += new System.EventHandler(this.button3_Click);
            // 
            // ChooseTheme
            // 
            this.ChooseTheme.Location = new System.Drawing.Point(201, 295);
            this.ChooseTheme.Name = "ChooseTheme";
            this.ChooseTheme.Size = new System.Drawing.Size(120, 29);
            this.ChooseTheme.TabIndex = 5;
            this.ChooseTheme.Text = "Choose Theme";
            this.ChooseTheme.UseVisualStyleBackColor = true;
            this.ChooseTheme.Click += new System.EventHandler(this.button4_Click);
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(201, 330);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(120, 29);
            this.Quit.TabIndex = 6;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(473, 396);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(69, 29);
            this.Help.TabIndex = 7;
            this.Help.Text = "Get Help";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.button6_Click);
            // 
            // Hoofdscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 516);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.ChooseTheme);
            this.Controls.Add(this.OnlineMultiplayer);
            this.Controls.Add(this.LocalMultiplayer);
            this.Controls.Add(this.LoadGame);
            this.Controls.Add(this.Singleplayer);
            this.Controls.Add(this.MainMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Hoofdscherm";
            this.Text = "Hoofdscherm";
            this.Load += new System.EventHandler(this.Hoofdscherm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label MainMenu;
        private System.Windows.Forms.Button Singleplayer;
        private System.Windows.Forms.Button LoadGame;
        private System.Windows.Forms.Button LocalMultiplayer;
        private System.Windows.Forms.Button OnlineMultiplayer;
        private System.Windows.Forms.Button ChooseTheme;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button Help;
    }
}