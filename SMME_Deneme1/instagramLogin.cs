﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMME_Deneme1
{
    public partial class instagramLogin : Form
    {
        public instagramLogin()
        {
            InitializeComponent();
        }

       

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            girisEkranı grs = new girisEkranı();
            this.Hide();
            grs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setting set = new setting();
            set.Show();
        }
    }
}
