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
    public partial class GameSettings : Form
    {
        public GameSettings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm.LoadView("spelscherm");
        }

        private void BackToMainMenu_Click(object sender, EventArgs e)
        {
            MainForm.LoadView("hoofdscherm");

        }

        public void GridSize4x4_Click(object sender, EventArgs e)
        {
            int yAmount = 4;
            int xAmount = 4;
        }

        public void GridSize6x4_Click(object sender, EventArgs e)
        {

        }

        public void GridSize8x8_Click(object sender, EventArgs e)
        {

        }
    }
}
