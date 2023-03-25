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
    public class PublisherService : BaseService<Publisher>, IPublisherService
    {
        public PublisherService(IRepository _repo) : base(_repo)
        {
        }
        public Task<Publisher> GetByIdAsync(int id)
        {
            return repo.GetAllAsync<Publisher>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public string PrintInfoOfEntity(Publisher entity)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Publisher information:");
            stringBuilder.AppendLine($"Name: {entity.Name}");
            stringBuilder.AppendLine($"Address: {entity.Address}");
            stringBuilder.AppendLine($"City: {entity.CityName}");
            stringBuilder.AppendLine($"Books Published Count: {entity.BookCount}");
            stringBuilder.AppendLine($"Books Published Titles: {entity.BookTitles}");
            return stringBuilder.ToString();
        }
    }
}
