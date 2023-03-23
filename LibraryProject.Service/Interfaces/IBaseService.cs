using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Service.Interfaces
{
    //The interface that provides the CRUD functionallity for the Service classes
    public interface IBaseService<TEntity>
    {
        IQueryable<TEntity> GetAllAsync();
        Task CreateAsync(TEntity entity);
        Task UpdateAsync();
        Task DeleteAsync(TEntity entity);
    }
}
