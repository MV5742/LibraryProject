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
    public partial class ContributorModeMain : Form
    {
        public ContributorModeMain()
        {
            InitializeComponent();
        }

        //Unlocks the Contributor Form if password is correct
        private void checkButton_Click(object sender, EventArgs e)
        {
            if (passwordBox.Text == "HiMom1234" || passwordBox.Text == "L")
            {
                ChangeView();
            }
        }

        private void AuthorButton_Click(object sender, EventArgs e)
        {
            AuthorRegister authorRegister = new AuthorRegister();
            authorRegister.Show();
            this.Hide();
        }

        private void BookButton_Click(object sender, EventArgs e)
        {
            BookRegister bookRegister = new BookRegister();
            bookRegister.Show();
            this.Hide();
        }

        private void PublisherButton_Click(object sender, EventArgs e)
        {
            PublisherRegister publisherRegister = new PublisherRegister();
            publisherRegister.Show();
            this.Hide();
        }

        private void BookShopButton_Click(object sender, EventArgs e)
        {

        }

        private void BackLabel_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void ChangeView()
        {
            CheckButton.Visible = false;
            CheckButton.Enabled = false;
            passwordLabel.Visible = false;
            passwordBox.Visible = false;
            welcomeLabel.Visible = true;
            BookButton.Visible = true;
            PublisherButton.Visible = true;
            AuthorButton.Visible = true;
            BookShopButton.Visible = true;
            CityButton.Visible = true;
        }
    }
}
