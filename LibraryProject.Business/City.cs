using LibraryProject.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Business
{
    public class City : IEntity
    {
        public City(string cityName)
        {
            CityName = cityName;
            Publishers = new HashSet<Publisher>();
            BookShops = new HashSet<BookShop>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string CityName { get; set; }

        [Required]
        public ICollection<Publisher> Publishers { get; set; }
        [Required]
        public ICollection<BookShop> BookShops { get; set; }
    }
}
