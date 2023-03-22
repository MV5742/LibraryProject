﻿using LibraryProject.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Business
{
    public class BookShop : IEntity
    {
        public BookShop(string name, string address, int cityId)
        {
            Name = name;
            Address = address;
            Books = new HashSet<Book>();
            CityId = cityId;
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string Name { get; set; }
        [Required]
        [MaxLength(60)]
        public string Address { get; set; }
        [Required]
        public string CityName => City.CityName;
        [Required]
        public ICollection<Book> Books { get; set; }

        [ForeignKey("City")]
        [Required]
        public int CityId { get; set; }
        [Required]
        public City City { get; set; }
    }
}