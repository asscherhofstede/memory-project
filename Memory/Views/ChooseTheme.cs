﻿using System;
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
    public partial class ChooseTheme : Form
    {
        public ChooseTheme()
        {
            InitializeComponent();
        }

        private void BackToMainMenu_Click(object sender, EventArgs e)
        {
            MainForm.LoadView("hoofdscherm");
        }


        private void ThemeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
    }
}
