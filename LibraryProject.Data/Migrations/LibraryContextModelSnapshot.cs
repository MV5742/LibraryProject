﻿// <auto-generated />
using System;
using LibraryProject.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryProject.Data.Migrations
{
    [DbContext(typeof(LibraryContext))]
    partial class LibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AuthorBooks", b =>
                {
                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.HasKey("AuthorId", "BookId");

                    b.HasIndex("BookId");

                    b.ToTable("AuthorBooks", "Books");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            BookId = 1
                        },
                        new
                        {
                            AuthorId = 2,
                            BookId = 1
                        });
                });

            modelBuilder.Entity("BookShopBooks", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("BookShopId")
                        .HasColumnType("int");

                    b.HasKey("BookId", "BookShopId");

                    b.HasIndex("BookShopId");

                    b.ToTable("BookShopBooks", "Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            BookShopId = 1
                        },
                        new
                        {
                            BookId = 1,
                            BookShopId = 2
                        });
                });

            modelBuilder.Entity("LibraryProject.Business.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("ShortBiography")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Ivan",
                            LastName = "Vazov",
                            ShortBiography = "bio1"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Hristo",
                            LastName = "Smirnenski",
                            ShortBiography = "bio2"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Joanne",
                            LastName = "Rowling",
                            ShortBiography = "bio3"
                        });
                });

            modelBuilder.Entity("LibraryProject.Business.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DatePublished")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<decimal>("Price")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("PublisherId")
                        .HasColumnType("int");

                    b.Property<int>("QuantityInStock")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PublisherId");

                    b.HasIndex("Title")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DatePublished = new DateTime(2023, 3, 25, 20, 5, 45, 29, DateTimeKind.Local).AddTicks(378),
                            Description = "Pod Igoto na rasbiraem esik",
                            Genre = "Tragikomedia",
                            ISBN = "9-876-543-21",
                            Price = 18.78m,
                            PublisherId = 2,
                            QuantityInStock = 42,
                            Title = "Pod Igoto na shliokavitsa"
                        });
                });

            modelBuilder.Entity("LibraryProject.Business.BookShop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("BookShops");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "ul. Slovo 14",
                            CityId = 1,
                            Name = "Kushtata na Vazov"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Abe na glavnata e, maina",
                            CityId = 2,
                            Name = "Helicon"
                        });
                });

            modelBuilder.Entity("LibraryProject.Business.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityName = "Sofia"
                        },
                        new
                        {
                            Id = 2,
                            CityName = "Plovdiv"
                        },
                        new
                        {
                            Id = 3,
                            CityName = "Varna"
                        });
                });

            modelBuilder.Entity("LibraryProject.Business.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Publishers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "ul. Smokinia 19",
                            CityId = 1,
                            Name = "Bulgarski Fener"
                        },
                        new
                        {
                            Id = 2,
                            Address = "ul. Bai Ganio 69",
                            CityId = 2,
                            Name = "Checheneca Publishing"
                        });
                });

            modelBuilder.Entity("LibraryProject.Business.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AuthorBooks", b =>
                {
                    b.HasOne("LibraryProject.Business.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryProject.Business.Book", null)
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookShopBooks", b =>
                {
                    b.HasOne("LibraryProject.Business.Book", null)
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryProject.Business.BookShop", null)
                        .WithMany()
                        .HasForeignKey("BookShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LibraryProject.Business.Book", b =>
                {
                    b.HasOne("LibraryProject.Business.Publisher", "Publisher")
                        .WithMany("BooksPublished")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("LibraryProject.Business.User", null)
                        .WithMany("Wishlist")
                        .HasForeignKey("UserId");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("LibraryProject.Business.BookShop", b =>
                {
                    b.HasOne("LibraryProject.Business.City", "City")
                        .WithMany("BookShops")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("LibraryProject.Business.Publisher", b =>
                {
                    b.HasOne("LibraryProject.Business.City", "City")
                        .WithMany("Publishers")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("LibraryProject.Business.City", b =>
                {
                    b.Navigation("BookShops");

                    b.Navigation("Publishers");
                });

            modelBuilder.Entity("LibraryProject.Business.Publisher", b =>
                {
                    b.Navigation("BooksPublished");
                });

            modelBuilder.Entity("LibraryProject.Business.User", b =>
                {
                    b.Navigation("Wishlist");
                });
#pragma warning restore 612, 618
        }
    }
}
