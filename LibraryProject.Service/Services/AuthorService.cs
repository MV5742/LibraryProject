using LibraryProject.Business;
using LibraryProject.Business.Interfaces;
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
    public class AuthorService : BaseService<Author>, IAuthorService

    {
        public AuthorService(IRepository _repo) : base(_repo)
        {
        }

        public Task<Author> GetByIdAsync(int id)
        {
            return repo.GetAllAsync<Author>().FirstOrDefaultAsync(x => x.Id == id);
        }

        //Prints author information
        public string PrintInfoOfEntity(Author entity)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Author information:");
            stringBuilder.AppendLine($"Name: {entity.FirstName} {entity.LastName}");
            stringBuilder.AppendLine($"Books written: {entity.BooksWritten}");
            stringBuilder.AppendLine($"Short biography:");
            stringBuilder.Append($"{entity.ShortBiography}");
            return stringBuilder.ToString();
        }
    }
}
