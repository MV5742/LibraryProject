using Microsoft.Extensions.DependencyInjection;
using LibraryProject.Data.Context;
using Microsoft.EntityFrameworkCore;
using LibraryProject.Data.Interfaces;
using LibraryProject.Data.Repositories;
using LibraryProject.Service.Interfaces;
using LibraryProject.Service.Services;
using LibraryProject.Business;

namespace LibraryProject.Presentation
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            //Starts the app
            ApplicationConfiguration.Initialize();

            //Sets up the service provider who is responsible for implementing the Dependency Injection Pattern
            IServiceProvider serviceProvider = new ServiceCollection()
            .AddDbContext<LibraryContext>(options =>
             options.UseSqlServer(Configuration.GetConnectionString("LibraryConnection")))
            .AddScoped<IRepository, BaseRepository>()
            .AddScoped<IBaseService<Book>, BookService>()
            .AddScoped<IBaseService<Publisher>, PublisherService>()
            .AddScoped<IBaseService<Author>, AuthorService>()
            .AddScoped<IBaseService<BookShop>, BookShopService>()
            .AddScoped<IBaseService<City>, CityService>()
            .AddScoped<IBaseService<User>, UserService>()
            .BuildServiceProvider();
            
            ServiceLocator.SetServiceProvider(serviceProvider);

            //Runs the MainPage Form
            Application.Run(new MainPage());
        }
    }
}