namespace Memory.Views {
	partial class Spelscherm {
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.BackToMainMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DelayTimer = new System.Windows.Forms.Timer(this.components);
            this.lul = new System.Windows.Forms.Label();
            this.TimerCunt = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(643, 241);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spelscherm";
            // 
            // BackToMainMenu
            // 
            this.BackToMainMenu.Location = new System.Drawing.Point(703, 520);
            this.BackToMainMenu.Name = "BackToMainMenu";
            this.BackToMainMenu.Size = new System.Drawing.Size(69, 29);
            this.BackToMainMenu.TabIndex = 1;
            this.BackToMainMenu.Text = "Back";
            this.BackToMainMenu.UseVisualStyleBackColor = true;
            this.BackToMainMenu.Click += new System.EventHandler(this.BackToMainMenu_CLick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 561);
            this.panel1.TabIndex = 1;
            // 
            // DelayTimer
            // 
            this.DelayTimer.Interval = 1500;
            this.DelayTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lul
            // 
            this.lul.AutoSize = true;
            this.lul.Location = new System.Drawing.Point(593, 331);
            this.lul.Name = "lul";
            this.lul.Size = new System.Drawing.Size(33, 13);
            this.lul.TabIndex = 2;
            this.lul.Text = "Timer";
            // 
            // TimerCunt
            // 
            this.TimerCunt.AutoSize = true;
            this.TimerCunt.Location = new System.Drawing.Point(673, 331);
            this.TimerCunt.Name = "TimerCunt";
            this.TimerCunt.Size = new System.Drawing.Size(0, 13);
            this.TimerCunt.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(632, 328);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // Spelscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Memory.Properties.Resources.BackGround;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.BackToMainMenu);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TimerCunt);
            this.Controls.Add(this.lul);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Spelscherm";
            this.Text = "Spelscherm";
            this.Load += new System.EventHandler(this.Spelscherm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackToMainMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer DelayTimer;
        private System.Windows.Forms.Label lul;
        private System.Windows.Forms.Label TimerCunt;
        private System.Windows.Forms.TextBox textBox1;
    }
}