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
        public Author(string firstName, string lastName, string shortBiography)
        {
            FirstName = firstName;
            LastName = lastName;
            ShortBiography = shortBiography;
            Books = new HashSet<Book>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(40)]
        public string LastName { get; set; }
        public string ShortBiography { get; set; }
        public int BooksWritten { get => Books.Count; }
        [Required]
        public ICollection<Book> Books { get; set; }
    }
}
