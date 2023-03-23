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
    public class BookService : BaseService<Book>, ICustomService<Book>
    {
        public BookService(IRepository _repo) : base(_repo)
        {
        }

        public Task<Book> GetByIdAsync(int id)
        {
            return repo.GetAllAsync<Book>().FirstOrDefaultAsync(x => x.Id == id);
        }

        //Prints book information
        public string PrintInfoById(int id)
        {
            //Finish method + make book-author/pub/shop many to many
            StringBuilder stringBuilder = new StringBuilder();
            Book book = GetByIdAsync(id).Result;
            stringBuilder.AppendLine("Book information:");
            stringBuilder.AppendLine($"Title: {book.Title}");
            stringBuilder.AppendLine($"Author(s): {book.AuthorNames}");
            stringBuilder.AppendLine($"ISBN: {book.ISBN}");
            stringBuilder.AppendLine($"Genre: {book.Genre}");
            stringBuilder.AppendLine($"NumberInStock: {book.QuantityInStock}");
            stringBuilder.AppendLine($"Date published: {book.DatePublished}");
            stringBuilder.AppendLine($"Available in [ShopNames]");
            return stringBuilder.ToString();
        }
    }
}
