using LibraryProject.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Service.Services
{
    public class BookService : BaseService<Book>
    {
        public BookService(DbContext dbContext) : base(dbContext)
        {
        }

        public override string PrintInfoById(int id)
        {
            //Finish method + make book-author/pub/shop many to many
            StringBuilder stringBuilder = new StringBuilder();
            Book book = GetByIdAsync(id).Result;
            stringBuilder.AppendLine("Book information:");
            stringBuilder.AppendLine($"Title: {book.Title}");
            stringBuilder.AppendLine($"Author: {book.Author.FullName}");
            stringBuilder.AppendLine($"ISBN: {book.ISBN}");
            stringBuilder.AppendLine($"Genre: {book.Genre}");
            stringBuilder.AppendLine($"NumberInStock: {book.QuantityInStock}");
            stringBuilder.AppendLine($"Date published: {book.DatePublished}");
            stringBuilder.AppendLine($"Available in [ShopNames]");
            return stringBuilder.ToString();
        }
    }
}
