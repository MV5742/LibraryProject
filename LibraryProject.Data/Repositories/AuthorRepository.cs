using LibraryProject.Business;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Data.Repositories
{
    internal class AuthorRepository : BaseRepository<Author>
    {
        public AuthorRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
