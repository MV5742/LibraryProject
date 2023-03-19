using LibraryProject.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Data.Context
{
    public class LibraryContext : DbContext
    {
        private DbSet<Book> Books { get; set; }
        private DbSet<Author> Authors { get; set; }
        private DbSet<Publisher> Publishers { get; set; }
        private DbSet<BookShop> BookShops { get; set; }
        private DbSet<City> Cities { get; set; }

        public LibraryContext(string connectionString) : base(GetOptions(connectionString))
        {
        }

        private static DbContextOptions GetOptions(string connectionString)
        {
            return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(b => b.AuthorId);

            modelBuilder.Entity<Book>()
                .HasOne(b => b.Publisher)
                .WithMany(p => p.BooksPublished)
                .HasForeignKey(b => b.PublisherId);

            modelBuilder.Entity<Book>()
                .HasOne(b => b.BookShop)
                .WithMany(bs => bs.Books)
                .HasForeignKey(b => b.BookShopId);

            modelBuilder.Entity<Publisher>()
                .HasOne(p => p.City)
                .WithMany(c => c.Publishers)
                .HasForeignKey(p => p.CityId);

            modelBuilder.Entity<BookShop>()
                .HasOne(bs => bs.City)
                .WithMany(c => c.BookShops)
                .HasForeignKey(bs => bs.CityId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json")
                    .Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("LibraryConnection"));
            }
        }
    }
}
