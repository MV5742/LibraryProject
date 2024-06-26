﻿using LibraryProject.Business;
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
    public class BookShopService : BaseService<BookShop>, IBookShopService
    {
        public BookShopService(IRepository _repo) : base(_repo)
        {
        }

        public Task<BookShop> GetByIdAsync(int id)
        {
            return repo.GetAllAsync<BookShop>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public string PrintInfoOfEntity(BookShop entity)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Book Shop information:");
            stringBuilder.AppendLine($"Name: {entity.Name}");
            stringBuilder.AppendLine($"Address: {entity.Address}");
            stringBuilder.AppendLine($"Books Available: {entity.BookTitles}");
            return stringBuilder.ToString();
        }
    }
}
