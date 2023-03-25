using LibraryProject.Business;
using LibraryProject.Service.Services;
using LibraryProject.Service.Utils;
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
    public partial class SearchAndViewPage : Form
    {
        private BookService bookService;
        private PublisherService publisherService;
        private AuthorService authorService;
        private BookShopService bookShopService;

        public SearchAndViewPage()
        {
            InitializeComponent();
            bookService = Session.BookService;
            publisherService = Session.PublisherService;
            authorService = Session.AuthorService;
            bookShopService = Session.BookShopService;
        }

        private void AuthorButton_Click(object sender, EventArgs e)
        {
            //TODO
            Book book = bookService.GetAllAsync().FirstOrDefault(x => x.Title == SearchTitleBox.Text);
            StringBuilder sb = new StringBuilder();
            ExtraInfoBox.Text = bookService.PrintInfoOfEntity(book);
        }

        private void BookView_Load(object sender, EventArgs e)
        {

        }

        private void BackLabel_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void PublisherButton_Click(object sender, EventArgs e)
        {

        }

        private void BookShopButton_Click(object sender, EventArgs e)
        {

        }

        private void AddToWishlistButton_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Book book = bookService.GetAllAsync().FirstOrDefault(x => x.Title == SearchTitleBox.Text);
            
            if (book != null)
            {
                TitleLabel.Text = book.Title;
                BookInfoBox.Text = bookService.PrintInfoOfEntity(book);
                BookSummaryBox.Text = book.Description;
            }
            else
            {
                TitleLabel.Text = "No book found";
            }
        }
    }
}
