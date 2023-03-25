using LibraryProject.Business;
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
    public class UserService : BaseService<User>, IUserService
    {
        public UserService(IRepository _repo) : base(_repo)
        {
        }

        public Task<User> GetByIdAsync(int id)
        {
            return repo.GetAllAsync<User>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public string PrintInfoOfEntity(User entity)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("User information:");
            stringBuilder.AppendLine($"Username: {entity.Username}");
            stringBuilder.AppendLine($"Email: {entity.Email}");
            stringBuilder.AppendLine($"Password: {entity.Password}");
            stringBuilder.AppendLine($"Books in wishlist: {entity.WishlistTitles}");
            return stringBuilder.ToString();
        }
    }
}
