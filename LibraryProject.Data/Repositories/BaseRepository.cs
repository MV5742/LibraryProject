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
    //Implements the Repository pattern.
    //Doesn't take a generic type at creation to increase abstraction by not creating different repositories for all entities
    //Instead it expects a generic type to be given when methods are called so it can use the appropriate DbSet
    public class BaseRepository : IRepository
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

        //CRUD

        public async Task Add<T>(T entity) where T : class
        {
            await GetDbSet<T>().AddAsync(entity);
            await Context.SaveChangesAsync();
        }

        public IQueryable<T> GetAllAsync<T>() where T : class
        {
            return GetDbSet<T>()
                .AsQueryable();
        }

        public void Remove<T>(T entity) where T : class
        {
            GetDbSet<T>().Remove(entity);
            //Does Async do anything here?
            Context.SaveChangesAsync();
        }

        //Fix this when needed
        public async Task Update()
        {
            await Context.SaveChangesAsync();
        }
    }
}
