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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainPage());

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