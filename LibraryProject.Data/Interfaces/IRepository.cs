using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Data.Interfaces
{
    //The interface for Repository classes
    public interface IRepository
    {
        DbSet<T> GetDbSet<T>() where T : class;
        IQueryable<T> GetAllAsync<T>() where T : class;
        Task Add<T>(T entity) where T : class;
        Task Update();
        void Remove<T>(T entity) where T : class;

        // Removed GetByIdAsync because it should be in the Service layer
    }
}
