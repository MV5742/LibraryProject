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
        public static IServiceProvider GetServiceProvider { get; private set; }
        [STAThread]
        static void Main()
        {
            ///Runs the MainPage Form
            ApplicationConfiguration.Initialize();
            Application.Run(new MainPage());

            //Sets up the service provider who is responsible for implementing the Dependency Injection Pattern
            IServiceProvider serviceProvider = new ServiceCollection()
            .AddDbContext<LibraryContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("LibraryConnection")))
            .AddScoped<IRepository, BaseRepository>()
            .AddScoped<IBaseService<Book>, BookService>()
            .BuildServiceProvider();
            GetServiceProvider = serviceProvider;
        }
    }
}