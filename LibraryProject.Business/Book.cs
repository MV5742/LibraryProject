using LibraryProject.Business.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryProject.Business
{
    public class Book : IEntity
    {
        //Constructor(s)
        public Book(string iSBN, string title, string description, string genre, int quantityInStock, decimal price, DateTime datePublished, int publisherId)
        {
            ISBN = iSBN;
            Title = title;
            Description = description;
            Genre = genre;
            QuantityInStock = quantityInStock;
            Price = price;
            DatePublished = datePublished;
            Authors = new HashSet<Author>();
            BookShops = new HashSet<BookShop>();
            PublisherId = publisherId;
        }

        //Properties

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(13)]
        public string ISBN { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        [MaxLength(30)]
        public string Genre { get; set; }
        [Required]
        public int QuantityInStock { get; set; }
        [Required]
        [Precision(10, 2)]
        public decimal Price { get; set; }
        [Required]
        public DateTime DatePublished { get; set; }

        //Dependencies

        [ForeignKey("Publisher")]
        [Required]
        public int PublisherId { get; set; }
        [Required]
        public Publisher Publisher { get; set; }
        [Required]
        public ICollection<Author> Authors { get; set; }
        [Required]
        public ICollection<BookShop> BookShops { get; set; }
        public string AuthorNames => string.Join(", ", Authors.Select(x => x.FullName).ToList());
    }
}