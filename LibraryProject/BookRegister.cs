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
            string iSBN = ISBNBox.Text;
            string title = TitleBox.Text;
            string description = DescriptionBox.Text;
            string genre = GenreBox.Text;
            int quantity = int.Parse(QuantityBox.Text);
            decimal price = decimal.Parse(PriceBox.Text);
            DateTime datePublished = DateTime.Parse(DateBox.Text);
            Book book = new Book(iSBN, title, description, genre, quantity, price, datePublished);
            await bookService.CreateAsync(book);
            await bookService.UpdateAsync();
        }

        private async void AddAuthorsButton_Click(object sender, EventArgs e)
        {
            Book book = bookService.GetAllAsync().FirstOrDefault(x => x.Title == TitleBox.Text);
            List<Author> authors = authorService
                .GetAllAsync()
                .Where(x => AuthorsBox.Text.Split(", ", StringSplitOptions.RemoveEmptyEntries).Contains(x.FullName))
                .ToList();
            foreach (Author author in authors)
            {
                book.Authors.Add(author);
            }
            await bookService.UpdateAsync();
        }

        private async void AddPublisherButton_Click(object sender, EventArgs e)
        {
            Book book = bookService.GetAllAsync().FirstOrDefault(x => x.Title == TitleBox.Text);
            Publisher publisher = publisherService.GetAllAsync().FirstOrDefault(x => x.Name == publisherNameBox.Text);
            book.Publisher = publisher;
            book.PublisherId = publisher.Id;
            await bookService.UpdateAsync();
        }

        private async void AddShopsButton_Click(object sender, EventArgs e)
        {
            Book book = bookService.GetAllAsync().FirstOrDefault(x => x.Title == TitleBox.Text);
            List<BookShop> bookShops = bookShopService
                .GetAllAsync()
                .Where(x => BookShopsBox.Text.Split(", ", StringSplitOptions.RemoveEmptyEntries).Contains(x.Name))
                .ToList();
            foreach (BookShop bookShop in bookShops)
            {
                book.BookShops.Add(bookShop);
            }
            await bookService.UpdateAsync();
        }

        private void ISBNLabel_Click(object sender, EventArgs e)
        {

        }

        private void BookRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
