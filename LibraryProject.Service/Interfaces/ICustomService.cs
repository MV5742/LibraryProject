using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Service.Interfaces
{
    //Specific interface for the purpose of this project 
    public interface ICustomService<TEntity>
    {
        public string PrintInfoById(int id);

        public Task<TEntity> GetByIdAsync(int id);
    }
}
