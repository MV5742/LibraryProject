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
using LibraryProject.Service.Utils;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryProject.Presentation
{
    public partial class BookRegister : Form
    {
        private BookService bookService;
        private PublisherService publisherService;
        private AuthorService authorService;
        private BookShopService bookShopService;
        public BookRegister()
        {
            InitializeComponent();
            bookService = Session.BookService;
            publisherService = Session.PublisherService;
            authorService = Session.AuthorService;
            bookShopService = Session.BookShopService;
        }

        private void BackLabel_Click(object sender, EventArgs e)
        {
            ContributorModeMain conMain = new ContributorModeMain();
            conMain.Show();
            this.Hide();
        }

        //Creates a new instance of a book and sends it to the Service layer
        private async void RegisterBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                string iSBN = ISBNBox.Text;
                string title = TitleBox.Text;
                string description = DescriptionBox.Text;
                string genre = GenreBox.Text;
                int quantity = int.Parse(QuantityBox.Text);
                decimal price = decimal.Parse(PriceBox.Text);
                //DateTime datePublished = DateTime.Parse(DateBox.Text);

                if (string.IsNullOrEmpty(iSBN) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(genre) || price == 0m)
                {
                    throw new ArgumentException("Not all input fields have a value");
                }
                Book book = new Book(iSBN, title, description, genre, quantity, price);
                await bookService.CreateAsync(book);
                await bookService.UpdateAsync();
                DescriptionBox.Text = "Process successful";
            }
            catch (Exception ex)
            {
                DescriptionBox.Text = ex.Message;
            }
        }

        private async void AddAuthorsButton_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = bookService.GetAllAsync().FirstOrDefault(x => x.Title == TitleBox.Text);

                if (book == null)
                    throw new ArgumentException("Please provide existing book title");

                Author author = authorService.GetAllAsync().FirstOrDefault(x => x.FullName == AuthorsBox.Text);

                if (author == null)
                    throw new ArgumentException("Please provide existing author name");

                book.Author = author;
                book.AuthorId = author.Id;
                await bookService.UpdateAsync();
                DescriptionBox.Text = "Process successful";

            }
            catch(ArgumentException ex)
            {
                DescriptionBox.Text = ex.Message;
            }
        }

        private async void AddPublisherButton_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = bookService.GetAllAsync().FirstOrDefault(x => x.Title == TitleBox.Text);

                if (book == null)
                    throw new ArgumentException("Please provide existing book title");

                Publisher publisher = publisherService.GetAllAsync().FirstOrDefault(x => x.Name == publisherNameBox.Text);

                if (publisher == null)
                    throw new ArgumentException("Please provide existing publisher name");

                book.Publisher = publisher;
                book.PublisherId = publisher.Id;
                await bookService.UpdateAsync();
                DescriptionBox.Text = "Process successful";
            }
            catch(ArgumentException ex)
            {
                DescriptionBox.Text = ex.Message;
            }
        }

        private async void AddShopsButton_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = bookService.GetAllAsync().FirstOrDefault(x => x.Title == TitleBox.Text);

                if (book == null)
                    throw new ArgumentException("Please provide existing book title");

                BookShop bookShop = bookShopService.GetAllAsync().FirstOrDefault(x => x.Name == BookShopsBox.Text);

                if (bookShop == null)
                    throw new ArgumentException("Please provide existing shop name");

                book.BookShop = bookShop;
                book.BookShopId = bookShop.Id;
                await bookService.UpdateAsync();
                DescriptionBox.Text = "Process successful";
            }
            catch(ArgumentException ex)
            {
                DescriptionBox.Text = ex.Message;
            }
        }

        private void ISBNLabel_Click(object sender, EventArgs e)
        {

        }

        private void BookRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
