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
        private AuthorService authorService;
        private BookService bookService;
        public AuthorRegister()
        {
            InitializeComponent();
            authorService = Program.GetServiceProvider.GetService<AuthorService>();
            bookService = Program.GetServiceProvider.GetService<BookService>();
        }

        private void backLabel_Click(object sender, EventArgs e)
        {
            ContributorModeMain main = new ContributorModeMain();
            main.Show();
            this.Hide();
        }

        private async void addAuthorButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameBox.Text;
            string lastName = lastNameBox.Text;
            string bio = bioBox.Text;
            Author author = new Author(firstName, lastName, bio);
            await authorService.CreateAsync(author);
        }

        private async void addBooksButton_Click(object sender, EventArgs e)
        {
            Author author = authorService.GetAllAsync()
                .FirstOrDefault(x => x.FullName == firstNameBox.Text + " " + lastNameBox.Text);

            List<Book> books = bookService
                .GetAllAsync()
                .Where(x => bookNamesBox.Text.Split(", ", StringSplitOptions.RemoveEmptyEntries).Contains(x.Title))
                .ToList();
            foreach (Book book in books)
            {
                author.Books.Add(book);
            }
            await authorService.UpdateAsync();
        }

        private void bioLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
