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

        private void authorButton_Click(object sender, EventArgs e)
        {

        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            BookRegister bookRegister = new BookRegister();
            bookRegister.Show();
            this.Hide();
        }

        private void publisherButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }

        private void ChangeView()
        {
            checkButton.Visible = false;
            checkButton.Enabled = false;
            passwordLabel.Visible = false;
            passwordBox.Visible = false;
            welcomeLabel.Visible = true;
            bookButton.Visible = true;
            publisherButton.Visible = true;
            authorButton.Visible = true;
            bookShopButton.Visible = true;
        }
    }
}
