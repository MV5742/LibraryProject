using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Data.Models
{
    public class Publisher
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        public string Address { get; set; }
        [Required]
        public string CityName => City.CityName;
        public int BookCount => BooksPublished.Count;
        [Required]
        public ICollection<Book> BooksPublished { get; set; }

        [ForeignKey("City")]
        [Required]
        public int CityId { get; set; }
        [Required]
        public City City { get; set; }
    }
}
