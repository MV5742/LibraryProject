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
    public abstract class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        protected readonly IRepository repo;

        public BaseService(IRepository _repo)
        {
            repo = _repo;
        }

        //CRUD 

        public virtual IQueryable<TEntity> GetAllAsync()
        {
            return repo.GetAllAsync<TEntity>();
        }

        public virtual async Task CreateAsync(TEntity entity)
        {
            await repo.Add(entity);
        }

        public virtual async Task UpdateAsync(TEntity entity)
        {
            //Does not modify anything. It just sets the state to modified and saves the changes. Still needs logic

            repo.Update(entity);
        }

        public virtual async Task DeleteAsync(TEntity entity)
        {
            repo.Remove(entity);
        }
    }
}
