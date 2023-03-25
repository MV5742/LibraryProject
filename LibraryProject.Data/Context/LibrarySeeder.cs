using LibraryProject.Business;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Data.Context
{
    public static class LibrarySeeder
    {
        public static void SeedStartingData(ModelBuilder modelBuilder)
        {
            //Authors => Id, FirstName, LastName, ShortBiography

            modelBuilder.Entity<Author>().HasData(
                new {Id = 1, FirstName = "Ivan", LastName = "Vazov", ShortBiography = "bio1"},
                new {Id = 2, FirstName = "Hristo", LastName = "Smirnenski", ShortBiography = "bio2" },
                new {Id = 3, FirstName = "Joanne", LastName = "Rowling", ShortBiography = "bio3"}
                );

            //Cities => CityName (should have named it "Name")
            modelBuilder.Entity<City>().HasData(
                new {Id = 1, CityName = "Sofia"},
                new {Id = 2, CityName = "Plovdiv"},
                new {Id = 3, CityName = "Varna"}
                );

            //Publisher => Name, Address, CityId
            modelBuilder.Entity<Publisher>().HasData(
                new {Id = 1, Name = "Bulgarski Fener", Address = "ul. Smokinia 19", CityId = 1},
                new {Id = 2, Name = "Checheneca Publishing", Address = "ul. Bai Ganio 69", CityId = 2}
                );

            //BookShops => Id, Name, Address, CityId

            modelBuilder.Entity<BookShop>().HasData(
                new {Id = 1, Name = "Kushtata na Vazov", Address = "ul. Slovo 14", CityId = 1},
                new {Id = 2, Name = "Helicon", Address = "Abe na glavnata e, maina", CityId = 2}
                );

            //Book => ISBN, Title, Description, Genre, QuantityInStock, Price, DatePublished, PublisherId

            modelBuilder.Entity<Book>().HasData(
                new {Id = 1, ISBN = "9-876-543-21", Title = "Pod Igoto na shliokavitsa", Description = "Pod Igoto na rasbiraem esik", Genre = "Tragikomedia", QuantityInStock = 42, Price = 18.78m, DatePublished = DateTime.Now, PublisherId = 2}
                );
        }
    }
}
