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
    public partial class BookShopRegister : Form
    {
        private CityService cityService;
        private BookShopService bookShopService;
        private BookService bookService;
        public BookShopRegister()
        {
            InitializeComponent();
            cityService = ServiceLocator.GetService<CityService>();
            bookShopService = ServiceLocator.GetService<BookShopService>();
            bookService = ServiceLocator.GetService<BookService>();
        }

        private async void RegisterButton_Click(object sender, EventArgs e)
        {
            string name = NameBox.Text;
            string address = AddressBox.Text;
            City city = cityService.GetAllAsync().FirstOrDefault(x => x.CityName == CityNameBox.Text);
            BookShop bookShop = new BookShop(name, address);
            bookShop.City = city;
            bookShop.CityId = city.Id;
            await bookShopService.CreateAsync(bookShop);
            await bookShopService.UpdateAsync();
        }

        private void BackLabel_Click(object sender, EventArgs e)
        {
            ContributorModeMain main = new ContributorModeMain();
            main.Show();
            this.Hide();
        }

        private async void AddBooksButton_Click(object sender, EventArgs e)
        {
            BookShop bookShop = bookShopService.GetAllAsync().FirstOrDefault(x => x.Name == NameBox.Text);
            List<Book> books = bookService
                .GetAllAsync()
                .Where(x => BookNamesBox.Text.Split(", ", StringSplitOptions.RemoveEmptyEntries).Contains(x.Title))
                .ToList();
            foreach (Book book in books)
            {
                bookShop.Books.Add(book);
            }
            await bookShopService.UpdateAsync();
        }
    }
}
