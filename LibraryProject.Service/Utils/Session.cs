using LibraryProject.Data.Context;
using LibraryProject.Data.Repositories;
using LibraryProject.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Service.Utils
{
    public static class Session
    {
        private static BaseRepository repo = new BaseRepository(
            new LibraryContext(Configuration.GetConnectionString("LibraryConnection")));

        //Fields
        private static AuthorService authorService = new AuthorService(repo);
        private static BookService bookService = new BookService(repo);
        private static BookShopService bookShopService = new BookShopService(repo);
        private static CityService cityService = new CityService(repo);
        private static PublisherService publisherService = new PublisherService(repo);
        private static UserService userService = new UserService(repo);

        //Public getter properties
        public static AuthorService AuthorService { get => authorService; }
        public static BookService BookService { get => bookService; }
        public static BookShopService BookShopService { get => bookShopService; }
        public static CityService CityService { get => cityService; }
        public static PublisherService PublisherService { get => new PublisherService(repo); }
        public static UserService UserService { get => new UserService(repo); }
    }
}
