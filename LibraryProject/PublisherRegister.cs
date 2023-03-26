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
    public partial class PublisherRegister : Form
    {
        private PublisherService publisherService;
        private BookService bookService;
        private CityService cityService;
        public PublisherRegister()
        {
            InitializeComponent();
            publisherService = Session.PublisherService;
            bookService = Session.BookService;
            cityService = Session.CityService;
        }

        private async void RegisterButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = NameBox.Text;
                string address = AddressBox.Text;

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address))
                {
                    throw new ArgumentException("Not all input fields contain a value");
                }

                Publisher publisher = new Publisher(name, address);
                City city = cityService.GetAllAsync().FirstOrDefault(x => x.CityName == CityNameBox.Text);
                publisher.City = city;
                publisher.CityId = city.Id;
                await publisherService.CreateAsync(publisher);
                await publisherService.UpdateAsync();
                BookNamesBox.Text = "Process Successful";
            }
            catch(ArgumentException ex)
            {
                BookNamesBox.Text = ex.Message;
            }
        }

        private async void AddBooksButton_Click(object sender, EventArgs e)
        {
            Publisher publisher = publisherService.GetAllAsync().FirstOrDefault(x => x.Name == NameBox.Text);
            List<Book> books = bookService
                .GetAllAsync()
                .Where(x => BookNamesBox.Text.Split(", ", StringSplitOptions.RemoveEmptyEntries).Contains(x.Title))
                .ToList();
            foreach (Book book in books)
            {
                publisher.BooksPublished.Add(book);
            }
            await publisherService.UpdateAsync();
        }

        private void BackLabel_Click(object sender, EventArgs e)
        {
            ContributorModeMain main = new ContributorModeMain();
            main.Show();
            this.Close();
        }
    }
}
