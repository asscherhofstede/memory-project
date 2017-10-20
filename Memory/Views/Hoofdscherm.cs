using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory.Views {

    public partial class Hoofdscherm : Form {
        public Hoofdscherm() {
            InitializeComponent();
        }

        private void LocalMultiplayer_Click(object sender, EventArgs e)
        {
            MainForm.LoadView("LocalMultiplayer");
        }

        private void SinglePlayer_Click(object sender, EventArgs e)
        {
            MainForm.LoadView("spelscherm");
        }

        private void Load_Click(object sender, EventArgs e)
        {
            MainForm.LoadView("Laadscherm");
        }

        private void OnlineMultiplayer_Click(object sender, EventArgs e)
        {
            MainForm.LoadView("OnlineMultiplayer");
        }

        private void Theme_Click(object sender, EventArgs e)
        {
            MainForm.LoadView("ChooseTheme");
        }

        private void GetHelp_Click(object sender, EventArgs e)
        {
            MainForm.LoadView("GetHelp");
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            DialogResult quit = MessageBox.Show("Are you sure you want to quit?", "Memory Game", MessageBoxButtons.YesNo);
            if (quit == DialogResult.Yes)
                Application.ExitThread();
        }
    }
}
