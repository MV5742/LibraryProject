using LibraryProject.Business;
using LibraryProject.Service.Services;
using LibraryProject.Service.Utils;
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
            authorService = Session.AuthorService;
            bookService = Session.BookService;
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

            if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName) && !string.IsNullOrEmpty(bio))
            {
                Author author = new Author(firstName, lastName, bio);
                await authorService.CreateAsync(author);
                await authorService.UpdateAsync();
            }
            else
                BioBox.Text = "Not all fields have a value";
        }

        private async void AddBooksButton_Click(object sender, EventArgs e)
        {
            try
            {
                Author author = authorService.GetAllAsync()
                .FirstOrDefault(x => x.FirstName == FirstNameBox.Text && x.LastName == LastNameBox.Text);

                if (author == null)
                    throw new ArgumentException("Please provide an existing author's name");

                List<string> splitInput = BookNamesBox.Text.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

                if (splitInput.Count == 0)
                    throw new ArgumentException("No author input provided");

                List<Book> books = bookService
                    .GetAllAsync()
                    .Where(x => splitInput.Contains(x.Title))
                    .ToList();

                if (books.Count == 0)
                    throw new ArgumentException("Provided books do not exist");

                foreach (Book book in books)
                {
                    if (!author.Books.Contains(book))
                        author.Books.Add(book);
                    else
                        BioBox.Text = $"Book {book.Title} already exists\n";
                }

                await authorService.UpdateAsync();

                BioBox.Text += $"Process successful";
            }
            catch(ArgumentException ex)
            {
                BioBox.Text = ex.Message;
            }
        }
    }
}