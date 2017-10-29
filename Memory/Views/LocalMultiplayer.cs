using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory.Views
{
    public partial class LocalMultiplayer : Form
    {
        public LocalMultiplayer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BackToMainMenu_Click(object sender, EventArgs e)
        {
            MainForm.LoadView("hoofdscherm");
        }
    }
}
