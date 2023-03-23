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
        private PublisherService publisherService;
        private AuthorService authorService;
        private BookShopService bookShopService;
        public BookRegister()
        {
            InitializeComponent();
            bookService = Program.GetServiceProvider.GetService<BookService>();
            publisherService = Program.GetServiceProvider.GetService<PublisherService>();
            authorService = Program.GetServiceProvider.GetService<AuthorService>();
            bookShopService = Program.GetServiceProvider.GetService<BookShopService>();
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
            Publisher publisher = publisherService.GetAllAsync().FirstOrDefault(x => x.Name == publisherNameBox.Text);
            List<Author> authors = authorService
                .GetAllAsync()
                .Where(x => AuthorsBox.Text.Split(", ", StringSplitOptions.RemoveEmptyEntries).Contains(x.FullName))
                .ToList();
            List<BookShop> bookShops = bookShopService
                .GetAllAsync()
                .Where(x => bookShopsBox.Text.Split(", ", StringSplitOptions.RemoveEmptyEntries).Contains(x.Name))
                .ToList();
            Book book = new Book(iSBN, title, description, genre, quantity, price, datePublished, publisher.Id);
            book.Publisher = publisher;
            book.Authors = authors;
            book.BookShops = bookShops;
            bookService.CreateAsync(book);
        }
    }
}
