using LibraryProject.Business;
using LibraryProject.Data.Interfaces;
using LibraryProject.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Service.Services
{
    public class AuthorService : BaseService<Author>, ICustomService<Author>
    {
        public AuthorService(IRepository _repo) : base(_repo)
        {
        }

        public Task<Author> GetByIdAsync(int id)
        {
            return repo.GetAllAsync<Author>().FirstOrDefaultAsync(x => x.Id == id);
        }

        //Prints author information
        public string PrintInfoById(int id)
        {
            Author author = GetByIdAsync(id).Result;
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
