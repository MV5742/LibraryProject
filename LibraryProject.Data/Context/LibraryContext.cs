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
            //Seeding
            //Put seeding method below

            LibrarySeeder.SeedStartingData(modelBuilder);

            //One-to-many relations

            modelBuilder.Entity<Publisher>()
                .HasOne(p => p.City)
                .WithMany(c => c.Publishers)
                .HasForeignKey(p => p.CityId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<BookShop>()
                .HasOne(bs => bs.City)
                .WithMany(c => c.BookShops)
                .HasForeignKey(bs => bs.CityId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Book>()
                .HasOne(b => b.Publisher)
                .WithMany(p => p.BooksPublished)
                .HasForeignKey(b => b.PublisherId)
                .OnDelete(DeleteBehavior.Restrict);

            //Many-to-many relations

            //AuthorBooks
            modelBuilder.SharedTypeEntity<Dictionary<string, object>>("AuthorBooks", builder =>

            {
                builder.Property<int>("AuthorId");
                builder.Property<int>("BookId");
            });
            
            modelBuilder.Entity<Author>()
                .HasMany(x => x.Books)
                .WithMany(x => x.Authors)
                .UsingEntity<Dictionary<string, object>>("AuthorBooks",
                    x => x.HasOne<Book>().WithMany().HasForeignKey("BookId"),
                    x => x.HasOne<Author>().WithMany().HasForeignKey("AuthorId"),
                    x => x.ToTable("AuthorBooks", "Books").HasData(
                        new {BookId = 1, AuthorId = 1} 
                        ));
            
            //BookShopBooks
            modelBuilder.SharedTypeEntity<Dictionary<string, object>>("BookShopBooks", builder =>

            {
                builder.Property<int>("BookShopId");
                builder.Property<int>("BookId");
            });
            
            modelBuilder.Entity<BookShop>()
                .HasMany(x => x.Books)
                .WithMany(x => x.BookShops)
                .UsingEntity<Dictionary<string, object>>("BookShopBooks",
                    x => x.HasOne<Book>().WithMany().HasForeignKey("BookId"),
                    x => x.HasOne<BookShop>().WithMany().HasForeignKey("BookShopId"),
                    x => x.ToTable("BookShopBooks", "Books").HasData(
                        new {BookId = 1, BookShopId = 1} 
                        ));

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
