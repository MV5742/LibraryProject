using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryProject.Business
{
    public class Book
    {
        public Book(string iSBN, string title, string description, string genre, int quantityInStock, decimal price, DateTime datePublished, int authorId, int publisherId, int bookShopId)
        {
            ISBN = iSBN;
            Title = title;
            Description = description;
            Genre = genre;
            QuantityInStock = quantityInStock;
            Price = price;
            DatePublished = datePublished;
            AuthorId = authorId;
            PublisherId = publisherId;
            BookShopId = bookShopId;
        }

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
        public decimal Price { get; set; }
        [Required]
        public DateTime DatePublished { get; set; }

        [ForeignKey("Author")]
        [Required]
        public int AuthorId { get; set; }
        [Required]
        public Author Author { get; set; }

        [ForeignKey("Publisher")]
        [Required]
        public int PublisherId { get; set; }
        [Required]
        public Publisher Publisher { get; set; }

        [ForeignKey("BookShop")]
        [Required]
        public int BookShopId { get; set; }
        [Required]
        public BookShop BookShop { get; set; }
    }
}