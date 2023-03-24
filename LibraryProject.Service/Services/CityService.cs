using LibraryProject.Business;
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
    public class CityService : BaseService<City>, ICustomService<City>
    {
        public CityService(IRepository _repo) : base(_repo)
        {
        }

        public Task<City> GetByIdAsync(int id)
        {
            return repo.GetAllAsync<City>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public string PrintInfoById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
