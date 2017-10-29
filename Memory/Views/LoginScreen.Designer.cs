using System;

namespace Memory.Views
{
    partial class LoginScreen
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
            this.Login = new System.Windows.Forms.Button();
            this.UserEmail = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Title_MainScreen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Login.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Login.Location = new System.Drawing.Point(463, 406);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(69, 29);
            this.Login.TabIndex = 9;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.BackToMainMenu_Click);
            // 
            // UserEmail
            // 
            this.UserEmail.AutoSize = true;
            this.UserEmail.BackColor = System.Drawing.Color.Transparent;
            this.UserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserEmail.Location = new System.Drawing.Point(252, 223);
            this.UserEmail.Name = "UserEmail";
            this.UserEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserEmail.Size = new System.Drawing.Size(91, 16);
            this.UserEmail.TabIndex = 10;
            this.UserEmail.Text = "User email: ";
            
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(260, 321);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(84, 16);
            this.Password.TabIndex = 11;
            this.Password.Text = "Password: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(341, 221);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(341, 319);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 20);
            this.textBox2.TabIndex = 13;
            // 
            // Title_MainScreen
            // 
            this.Title_MainScreen.AutoSize = true;
            this.Title_MainScreen.BackColor = System.Drawing.Color.Transparent;
            this.Title_MainScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_MainScreen.Location = new System.Drawing.Point(307, 23);
            this.Title_MainScreen.Name = "Title_MainScreen";
            this.Title_MainScreen.Size = new System.Drawing.Size(170, 25);
            this.Title_MainScreen.TabIndex = 14;
            this.Title_MainScreen.Text = "Memory Game ";
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Memory.Properties.Resources.BackGround;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Title_MainScreen);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserEmail);
            this.Controls.Add(this.Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginScreen";
            this.Text = "Login Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label UserEmail;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Title_MainScreen;
    }
}