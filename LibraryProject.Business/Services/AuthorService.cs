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

        public override string PrintInfoById(int id)
        {
            Author author = base.GetByIdAsync(id).Result;
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Author information:");
            stringBuilder.AppendLine($"Name: {author.FirstName} {author.LastName}");
            stringBuilder.AppendLine($"Books written: {author.BooksWritten}");
            stringBuilder.AppendLine($"Short biography:");
            stringBuilder.Append($"{author.ShortBiography}");
            return stringBuilder.ToString();
        }
    }
}
