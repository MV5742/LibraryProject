using System;
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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void trendingButton_Click(object sender, EventArgs e)
        {
            TrendingPage trendingPage = new TrendingPage();
            trendingPage.Show();
            this.Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchAndViewPage search = new SearchAndViewPage();
            search.Show();
            this.Hide();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
            this.Hide();
        }

        private void ContributorLabel_Click(object sender, EventArgs e)
        {
            ContributorModeMain contributor = new ContributorModeMain();
            contributor.Show();
            this.Hide();
        }
    }
}
