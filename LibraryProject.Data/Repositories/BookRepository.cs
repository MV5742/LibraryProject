using LibraryProject.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Data.Repositories
{
    public class BookRepository : BaseRepository<Book>
    {
        public BookRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
