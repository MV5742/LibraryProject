using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Service.Interfaces
{
    public interface ICustomService<TEntity>
    {
        public string PrintInfoById(int id);

        public Task<TEntity> GetByIdAsync(int id);
    }
}
