using LibraryProject.Business;
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
        //Tables represented in code
        private DbSet<Book> Books { get; set; }
        private DbSet<Author> Authors { get; set; }
        private DbSet<Publisher> Publishers { get; set; }
        private DbSet<BookShop> BookShops { get; set; }
        private DbSet<City> Cities { get; set; }
        private DbSet<User> Users { get; set; }

        //Constructor
        public LibraryContext(string connectionString) : base(GetOptions(connectionString))
        {
        }

        //Retrieves connection options
        private static DbContextOptions GetOptions(string connectionString)
        {
            return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options;
        }

        //Creates Constraints
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //One-to-one relations

            modelBuilder.Entity<Publisher>()
                .HasOne(p => p.City)
                .WithMany(c => c.Publishers)
                .HasForeignKey(p => p.CityId);

            modelBuilder.Entity<BookShop>()
                .HasOne(bs => bs.City)
                .WithMany(c => c.BookShops)
                .HasForeignKey(bs => bs.CityId);

            modelBuilder.Entity<Book>()
                .HasOne(b => b.Publisher)
                .WithMany(p => p.BooksPublished)
                .HasForeignKey(b => b.PublisherId);

            //Many-to-many relations

            modelBuilder.Entity<Author>()
            .HasMany(a => a.Books)
            .WithMany(b => b.Authors)
            .UsingEntity(x => x.ToTable("AuthorBooks"));

            modelBuilder.Entity<BookShop>()
                .HasMany(bs => bs.Books)
                .WithMany(b => b.BookShops)
                .UsingEntity(x => x.ToTable("BooksShopBooks"));

            //Unique/Distinct validations

            modelBuilder.Entity<Book>()
                .HasIndex(b => b.Title)
                .IsUnique();

            modelBuilder.Entity<Publisher>()
                .HasIndex(p => p.Name)
                .IsUnique();

            modelBuilder.Entity<BookShop>()
                .HasIndex(bs => bs.Name)
                .IsUnique();
        }

        //Handles Connection String Configuration
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
