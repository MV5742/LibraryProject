using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Data.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        private string FirstName { get; set; }
        [Required]
        [MaxLength(40)]
        private string LastName { get; set; }
        private string ShortBiography { get; set; }
        private int BooksWritten { get => Books.Count; }
        public ICollection<Book> Books { get; set; }
    }
}
