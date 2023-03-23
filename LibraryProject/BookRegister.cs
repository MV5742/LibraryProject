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
using LibraryProject.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryProject.Presentation
{
    public partial class BookRegister : Form
    {
        private BookService bookService;
        public BookRegister()
        {
            InitializeComponent();
            bookService = Program.GetServiceProvider.GetService<BookService>();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ContributorModeMain conMain = new ContributorModeMain();
            conMain.Show();
            this.Hide();
        }

        //Creates a new instance of a book and sends it to the Service layer
        private void registerBookButton_Click(object sender, EventArgs e)
        {
            string iSBN = iSBNBox.Text;
            string title = titleBox.Text;
            string description = descriptionBox.Text;
            string genre = genreBox.Text;
            int quantity = int.Parse(quantityBox.Text);
            decimal price = decimal.Parse(priceBox.Text);
            DateTime datePublished = DateTime.Parse(dateBox.Text);
            //needs to have PublisherService
            //int publisherId

            //change last argument (should NOT be 0)
            Book book = new Book(iSBN, title, description, genre, quantity, price, datePublished, 0);    
        }
    }
}
