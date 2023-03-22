using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryProject.Data.Context;
using LibraryProject.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibraryProject.Data.Repositories
{
    public abstract class BaseRepository : IRepository
    {
        protected DbContext Context  { get; set; }

        protected BaseRepository(LibraryContext context)
        {
            this.Context = context;
        }

        public DbSet<T> GetDbSet<T>() where T : class
        {
            return Context.Set<T>();
        }

        public async Task Add<T>(T entity) where T : class
        {
            await GetDbSet<T>().AddAsync(entity);
        }

        public IQueryable<T> GetAllAsync<T>() where T : class
        {
            return GetDbSet<T>()
                .AsQueryable();
        }

        public void Remove<T>(T entity) where T : class
        {
            GetDbSet<T>().Remove(entity);
        }

        public async Task Update<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
