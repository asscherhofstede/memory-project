﻿using System;
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            MainForm.LoadView("Spelscherm");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            MainForm.LoadView("Laadscherm");
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Hoofdscherm_Load(object sender, EventArgs e)
        {

        }

        private void LocalMultiplayer_Click(object sender, EventArgs e)
        {
            MainForm.LoadView("LocalMultiplayer");

        }
    
    }
}
