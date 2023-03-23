﻿using LibraryProject.Business;
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
    public class PublisherService : BaseService<Publisher>, ICustomService<Publisher>
    {
        public PublisherService(IRepository _repo) : base(_repo)
        {
        }
        public Task<Publisher> GetByIdAsync(int id)
        {
            return repo.GetAllAsync<Publisher>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public string PrintInfoById(int id)
        {
            throw new NotImplementedException();
        }
    }
}