﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.Presentation
{
    public partial class TrendingPage : Form
    {
        public TrendingPage()
        {
            InitializeComponent();
        }

        private void BackLabel_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
        }
    }
}
