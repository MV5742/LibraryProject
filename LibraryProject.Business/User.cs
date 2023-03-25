using LibraryProject.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryProject.Business
{
    public class User : IEntity
    {
        //Constructor(s)

        public User(string username, string email, string password, DateTime dateCreated)
        {
            Username = username;
            Email = email;
            Password = password;
            DateCreated = dateCreated;
            Wishlist = new HashSet<Book>();
        }

        //Properties

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        public string Username { get; set; }
        [Required]
        [MaxLength(45)]
        public string Email { get; set; }
        [Required]
        [MaxLength(25)]
        public string Password { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }

        //Dependencies

        [Required]
        public ICollection<Book> Wishlist { get; set; }

        public string WishlistTitles => string.Join(", ", Wishlist.Select(x => x.Title).ToList());
    }
}
