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
    public partial class CityRegister : Form
    {
        private PublisherService publisherService;
        private CityService cityService;
        private BookShopService bookShopService;
        public CityRegister()
        {
            InitializeComponent();
            cityService = Session.CityService;
            publisherService = Session.PublisherService;
            bookShopService = Session.BookShopService;
        }

        private void BackLabel_Click(object sender, EventArgs e)
        {
            ContributorModeMain main = new ContributorModeMain();
            main.Show();
            this.Hide();
        }

        private async void RegisterCityButton_Click(object sender, EventArgs e)
        {
            string cityName = CityNameBox.Text;
            City city = new City(cityName);
            await cityService.CreateAsync(city);
            await cityService.UpdateAsync();
        }

        private async void AddPublishersButton_Click(object sender, EventArgs e)
        {
            City city = cityService.GetAllAsync().FirstOrDefault(x => x.CityName == CityNameBox.Text);
            List<Publisher> publishers = publisherService
                .GetAllAsync()
                .Where(x => PublisherNameBox.Text.Split(", ", StringSplitOptions.RemoveEmptyEntries).Contains(x.Name))
                .ToList();
            foreach (Publisher publisher in publishers)
            {
                city.Publishers.Add(publisher);
            }
            await cityService.UpdateAsync();
        }

        private async void AddBookShopsButton_Click(object sender, EventArgs e)
        {
            City city = cityService.GetAllAsync().FirstOrDefault(x => x.CityName == CityNameBox.Text);
            List<BookShop> bookShops = bookShopService
                .GetAllAsync()
                .Where(x => PublisherNameBox.Text.Split(", ", StringSplitOptions.RemoveEmptyEntries).Contains(x.Name))
                .ToList();
            foreach (BookShop bookShop in bookShops)
            {
                city.BookShops.Add(bookShop);
            }
            await cityService.UpdateAsync();
        }
    }
}
