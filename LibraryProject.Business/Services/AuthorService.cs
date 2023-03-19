using LibraryProject.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Service.Services
{
    public class AuthorService : BaseService<Author>
    {
        public AuthorService(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
