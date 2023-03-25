using LibraryProject.Business;
using LibraryProject.Service.Services;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class AuthorRegister : Form
    {
        private AuthorService? authorService;
        private BookService? bookService;
        public AuthorRegister()
        {
            InitializeComponent();
            authorService = ServiceLocator.GetService<AuthorService>();
            bookService = ServiceLocator.GetService<BookService>();
        }

        private void BackLabel_Click(object sender, EventArgs e)
        {
            ContributorModeMain main = new ContributorModeMain();
            main.Show();
            this.Hide();
        }

        private async void AddAuthorButton_Click(object sender, EventArgs e)
        {
            string firstName = FirstNameBox.Text;
            string lastName = LastNameBox.Text;
            string bio = BioBox.Text;
            Author author = new Author(firstName, lastName, bio);
            await authorService.CreateAsync(author);
            await authorService.UpdateAsync();
        }

        private async void AddBooksButton_Click(object sender, EventArgs e)
        {
            Author author = authorService.GetAllAsync()
                .FirstOrDefault(x => x.FullName == FirstNameBox.Text + " " + LastNameBox.Text);

            List<Book> books = bookService
                .GetAllAsync()
                .Where(x => BookNamesBox.Text.Split(", ", StringSplitOptions.RemoveEmptyEntries).Contains(x.Title))
                .ToList();
            foreach (Book book in books)
            {
                author.Books.Add(book);
            }
            await authorService.UpdateAsync();
        }
    }
}
