﻿// <auto-generated />
using System;
using LibraryAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace LibraryAPI.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("LibraryAPI.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Biography")
                        .HasColumnType("text");

                    b.Property<DateTime>("BirthdayDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Biography = "ovo je biografija",
                            BirthdayDate = new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "email@gmail.com",
                            Image = "http://slika.jpeg",
                            Name = "Marko"
                        },
                        new
                        {
                            Id = 2,
                            Biography = "ovo je biografija",
                            BirthdayDate = new DateTime(2018, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "example@gmail.com",
                            Image = "http://slika.jpeg",
                            Name = "Ivan"
                        },
                        new
                        {
                            Id = 3,
                            Biography = "ovo je biografija",
                            BirthdayDate = new DateTime(2015, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mail@gmail.com",
                            Image = "http://slika.jpeg",
                            Name = "Filip"
                        },
                        new
                        {
                            Id = 4,
                            Biography = "ovo je biografija",
                            BirthdayDate = new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "tin@gmail.com",
                            Image = "http://slika.jpeg",
                            Name = "Tin"
                        });
                });

            modelBuilder.Entity("LibraryAPI.Models.AuthorBook", b =>
                {
                    b.Property<int>("AuthorId")
                        .HasColumnType("integer");

                    b.Property<int>("BookId")
                        .HasColumnType("integer");

                    b.HasKey("AuthorId", "BookId");

                    b.HasIndex("BookId");

                    b.ToTable("AuthorsBooks");

                    b.HasData(
                        new
                        {
                            AuthorId = 4,
                            BookId = 4
                        },
                        new
                        {
                            AuthorId = 4,
                            BookId = 5
                        },
                        new
                        {
                            AuthorId = 3,
                            BookId = 2
                        },
                        new
                        {
                            AuthorId = 3,
                            BookId = 1
                        },
                        new
                        {
                            AuthorId = 1,
                            BookId = 2
                        },
                        new
                        {
                            AuthorId = 2,
                            BookId = 3
                        });
                });

            modelBuilder.Entity("LibraryAPI.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<int>("Pages")
                        .HasColumnType("integer");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("PublisherId")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("PublisherId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "ovo je opisssssss",
                            Image = "http://slika.jpeg",
                            Pages = 100,
                            Price = 55.24f,
                            PublisherId = 1,
                            Title = "knjiga1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "ovo je opissssssssss",
                            Image = "http://slika.jpeg",
                            Pages = 180,
                            Price = 87.54f,
                            PublisherId = 3,
                            Title = "knjiga2"
                        },
                        new
                        {
                            Id = 3,
                            Description = "ovo je opisddsdsdss",
                            Image = "http://slika.jpeg",
                            Pages = 120,
                            Price = 65.84f,
                            PublisherId = 4,
                            Title = "knjiga3"
                        },
                        new
                        {
                            Id = 4,
                            Description = "ovo je opisdsdsdsdss",
                            Image = "http://slika.jpeg",
                            Pages = 150,
                            Price = 50.14f,
                            PublisherId = 2,
                            Title = "knjiga4"
                        },
                        new
                        {
                            Id = 5,
                            Description = "dssdsdsdsadsadsads",
                            Image = "http://slika.jpeg",
                            Pages = 110,
                            Price = 25.54f,
                            PublisherId = 2,
                            Title = "knjiga5"
                        });
                });

            modelBuilder.Entity("LibraryAPI.Models.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Publishers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Marko"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ivan"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Mate"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Igor"
                        });
                });

            modelBuilder.Entity("LibraryAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("GroupType")
                        .HasColumnType("integer");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GroupType = 1,
                            Password = "Admin1",
                            UserName = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            GroupType = 2,
                            Password = "User2",
                            UserName = "User"
                        },
                        new
                        {
                            Id = 3,
                            GroupType = 2,
                            Password = "filip123",
                            UserName = "Filip"
                        });
                });

            modelBuilder.Entity("LibraryAPI.Models.AuthorBook", b =>
                {
                    b.HasOne("LibraryAPI.Models.Author", "Author")
                        .WithMany("AuthorBook")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryAPI.Models.Book", "Book")
                        .WithMany("AuthorBook")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("LibraryAPI.Models.Book", b =>
                {
                    b.HasOne("LibraryAPI.Models.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("LibraryAPI.Models.Publisher", b =>
                {
                    b.OwnsOne("LibraryAPI.Models.Address", "Address", b1 =>
                        {
                            b1.Property<int>("PublisherId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("integer")
                                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                            b1.Property<string>("City")
                                .HasColumnType("text");

                            b1.Property<string>("Country")
                                .HasColumnType("text");

                            b1.Property<string>("Road")
                                .HasColumnType("text");

                            b1.Property<string>("ZipCode")
                                .HasColumnType("text");

                            b1.HasKey("PublisherId");

                            b1.ToTable("Publishers");

                            b1.WithOwner()
                                .HasForeignKey("PublisherId");

                            b1.HasData(
                                new
                                {
                                    PublisherId = 1,
                                    City = "Mostar",
                                    Country = "BiH",
                                    Road = "ulicaaaaaaaaa",
                                    ZipCode = "88000"
                                },
                                new
                                {
                                    PublisherId = 2,
                                    City = "Split",
                                    Country = "HR",
                                    Road = "splitskaaaaa",
                                    ZipCode = "80012"
                                },
                                new
                                {
                                    PublisherId = 3,
                                    City = "Sarajevo",
                                    Country = "BiH",
                                    Road = "sarajevssssssska",
                                    ZipCode = "70005"
                                },
                                new
                                {
                                    PublisherId = 4,
                                    City = "Split",
                                    Country = "HR",
                                    Road = "splitsssska",
                                    ZipCode = "80077"
                                });
                        });

                    b.Navigation("Address");
                });

            modelBuilder.Entity("LibraryAPI.Models.Author", b =>
                {
                    b.Navigation("AuthorBook");
                });

            modelBuilder.Entity("LibraryAPI.Models.Book", b =>
                {
                    b.Navigation("AuthorBook");
                });

            modelBuilder.Entity("LibraryAPI.Models.Publisher", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
