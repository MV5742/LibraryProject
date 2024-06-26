﻿using LibraryProject.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryProject.Business
{
    public class Publisher : IEntity
    {
        //Constructor(s)
        public Publisher(string name, string address)
        {
            Name = name;
            Address = address;
            BooksPublished = new HashSet<Book>();
        }

        //Properties

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        public string Address { get; set; }

        //Dependencies

        [Required]
        public ICollection<Book> BooksPublished { get; set; }

        [ForeignKey("City")]
        [Required]
        public int CityId { get; set; }
        [Required]
        public City City { get; set; }
        public string CityName => City.CityName;
        public int BookCount => BooksPublished.Count;
        public string BookTitles => string.Join(", ", BooksPublished.Select(x => x.Title).ToList());
    }
}
