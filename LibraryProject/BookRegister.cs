using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryProject.Business;

namespace LibraryProject.Presentation
{
    public partial class BookRegister : Form
    {
        public BookRegister()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ContributorModeMain conMain = new ContributorModeMain();
            conMain.Show();
            this.Hide();
        }

        private void registerBookButton_Click(object sender, EventArgs e)
        {
            string iSBN = iSBNBox.Text;
            string title = titleBox.Text;
            string description = descriptionBox.Text;
            string genre = genreBox.Text;
            int quantity = int.Parse(quantityBox.Text);
            decimal price = decimal.Parse(priceBox.Text);
            DateTime datePublished = DateTime.Parse(dateBox.Text);

            //Book book = new Book();    
        }
    }
}
