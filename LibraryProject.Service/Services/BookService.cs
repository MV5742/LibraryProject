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
    public class BookService : BaseService<Book>, IBookService
    {
        public BookService(IRepository _repo) : base(_repo)
        {
        }

        public Task<Book> GetByIdAsync(int id)
        {
            return repo.GetAllAsync<Book>().FirstOrDefaultAsync(x => x.Id == id);
        }

        //Prints book information
        public string PrintInfoOfEntity(Book entity)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Book information:");
            stringBuilder.AppendLine($"Title: {entity.Title}");
            //stringBuilder.AppendLine($"Author(s): {entity.AuthorName}");
            stringBuilder.AppendLine($"ISBN: {entity.ISBN}");
            stringBuilder.AppendLine($"Genre: {entity.Genre}");
            stringBuilder.AppendLine($"NumberInStock: {entity.QuantityInStock}");
            stringBuilder.AppendLine($"Price: {entity.Price}");
            stringBuilder.AppendLine($"Date published: {entity.DatePublished}");
            //stringBuilder.AppendLine($"Available in {entity.ShopName}");
            return stringBuilder.ToString();
        }
    }
}
