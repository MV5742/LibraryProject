using LibraryProject.Business.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryProject.Business
{
    public class Book : IEntity
    {
        //Constructor(s)
        public Book(string iSBN, string title, string description, string genre, int quantityInStock, decimal price)
        {
            ISBN = iSBN;
            Title = title;
            Description = description;
            Genre = genre;
            QuantityInStock = quantityInStock;
            Price = price;
            DatePublished = DateTime.Now;
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
        [ForeignKey("Author")]
        [Required]
        public int AuthorId { get; set; }
        [Required]
        public Author Author { get; set; }
        [ForeignKey("BookShop")]
        [Required]
        public int BookShopId { get; set; }
        [Required]
        public BookShop BookShop { get; set; }
        public string AuthorName => Author.FullName;
        public string ShopName => BookShop.Name;
    }
}