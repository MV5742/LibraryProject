using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Data.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        [Required]
        public string CityName { get; set; }

        [Required]
        public ICollection<Publisher> Publishers { get; set;}
        [Required]
        public ICollection<BookShop> BookShops { get; set; }
    }
}
