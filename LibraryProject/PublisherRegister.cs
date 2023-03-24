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
    public partial class PublisherRegister : Form
    {
        private PublisherService publisherService;
        private BookService bookService;
        private CityService cityService;
        public PublisherRegister()
        {
            InitializeComponent();
            publisherService = Program.GetServiceProvider.GetService<PublisherService>();
            bookService = Program.GetServiceProvider.GetService<BookService>();
            cityService = Program.GetServiceProvider.GetService<CityService>();
        }

        private async void RegisterButton_Click(object sender, EventArgs e)
        {
            string name = NameBox.Text;
            string address = AddressBox.Text;
            Publisher publisher = new Publisher(name, address);
            City city = cityService.GetAllAsync().FirstOrDefault(x => x.CityName == CityNameBox.Text);
            publisher.City = city;
            publisher.CityId = city.Id;
            publisherService.CreateAsync(publisher);
            await publisherService.UpdateAsync();
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
