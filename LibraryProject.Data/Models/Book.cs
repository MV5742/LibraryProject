﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryProject.Data.Models
{
    public class Book
    {
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