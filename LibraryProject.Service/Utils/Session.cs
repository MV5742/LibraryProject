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

        private static AuthorService authorService = new AuthorService(repo);
        public static AuthorService AuthorService { get => new AuthorService(repo); }
    }
}
