﻿// <auto-generated />
using System;
using LibraryAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace LibraryAPI.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220206140441_fixImageNameSeed")]
    partial class fixImageNameSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            Image = "placeholder.png",
                            Name = "Marko"
                        },
                        new
                        {
                            Id = 2,
                            Biography = "ovo je biografija",
                            BirthdayDate = new DateTime(2018, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "example@gmail.com",
                            Image = "placeholder.png",
                            Name = "Ivan"
                        },
                        new
                        {
                            Id = 3,
                            Biography = "ovo je biografija",
                            BirthdayDate = new DateTime(2015, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mail@gmail.com",
                            Image = "placeholder.png",
                            Name = "Filip"
                        },
                        new
                        {
                            Id = 4,
                            Biography = "ovo je biografija",
                            BirthdayDate = new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "tin@gmail.com",
                            Image = "placeholder.png",
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

                    b.Property<string>("ISBN")
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
                            ISBN = "978-3-16-148410-0",
                            Image = "placeholder.png",
                            Pages = 100,
                            Price = 55.24f,
                            PublisherId = 1,
                            Title = "knjiga1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "ovo je opissssssssss",
                            ISBN = "978-3-16-148410-1",
                            Image = "placeholder.png",
                            Pages = 180,
                            Price = 87.54f,
                            PublisherId = 3,
                            Title = "knjiga2"
                        },
                        new
                        {
                            Id = 3,
                            Description = "ovo je opisddsdsdss",
                            ISBN = "978-3-16-148410-2",
                            Image = "placeholder.png",
                            Pages = 120,
                            Price = 65.84f,
                            PublisherId = 4,
                            Title = "knjiga3"
                        },
                        new
                        {
                            Id = 4,
                            Description = "ovo je opisdsdsdsdss",
                            ISBN = "978-3-16-148410-3",
                            Image = "placeholder.png",
                            Pages = 150,
                            Price = 50.14f,
                            PublisherId = 2,
                            Title = "knjiga4"
                        },
                        new
                        {
                            Id = 5,
                            Description = "dssdsdsdsadsadsads",
                            ISBN = "978-3-16-148410-4",
                            Image = "placeholder.png",
                            Pages = 110,
                            Price = 25.54f,
                            PublisherId = 2,
                            Title = "knjiga5"
                        });
                });

            modelBuilder.Entity("LibraryAPI.Models.BookCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<int>("BookId")
                        .HasColumnType("integer");

                    b.HasKey("CategoryId", "BookId");

                    b.HasIndex("BookId");

                    b.ToTable("BooksCategories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            BookId = 1
                        },
                        new
                        {
                            CategoryId = 2,
                            BookId = 1
                        },
                        new
                        {
                            CategoryId = 3,
                            BookId = 2
                        },
                        new
                        {
                            CategoryId = 2,
                            BookId = 3
                        },
                        new
                        {
                            CategoryId = 4,
                            BookId = 3
                        },
                        new
                        {
                            CategoryId = 5,
                            BookId = 3
                        },
                        new
                        {
                            CategoryId = 4,
                            BookId = 4
                        },
                        new
                        {
                            CategoryId = 3,
                            BookId = 5
                        });
                });

            modelBuilder.Entity("LibraryAPI.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Science"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Philosophy"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Computer science"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Sport"
                        },
                        new
                        {
                            Id = 5,
                            Name = "History"
                        });
                });

            modelBuilder.Entity("LibraryAPI.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("integer");

                    b.Property<string>("Text")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 1,
                            Text = "first comment",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            BookId = 2,
                            Text = "first comment",
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            BookId = 2,
                            Text = "first comment",
                            UserId = 3
                        });
                });

            modelBuilder.Entity("LibraryAPI.Models.Loan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsReturned")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("LoanDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("Loans");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 1,
                            IsReturned = true,
                            LoanDate = new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnDate = new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            BookId = 2,
                            IsReturned = false,
                            LoanDate = new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnDate = new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 3
                        },
                        new
                        {
                            Id = 3,
                            BookId = 3,
                            IsReturned = true,
                            LoanDate = new DateTime(2022, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnDate = new DateTime(2022, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            BookId = 2,
                            IsReturned = true,
                            LoanDate = new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnDate = new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
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

            modelBuilder.Entity("LibraryAPI.Models.Registration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<DateTime>("SubmissionDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Registrations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "imeprezime@fsre.sum.ba",
                            SubmissionDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("LibraryAPI.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 1,
                            TimeStamp = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            BookId = 3,
                            TimeStamp = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            BookId = 2,
                            TimeStamp = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 3
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

            modelBuilder.Entity("LibraryAPI.Models.BookCategory", b =>
                {
                    b.HasOne("LibraryAPI.Models.Book", "Book")
                        .WithMany("BookCategory")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryAPI.Models.Category", "Category")
                        .WithMany("BookCategory")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("LibraryAPI.Models.Comment", b =>
                {
                    b.HasOne("LibraryAPI.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LibraryAPI.Models.Loan", b =>
                {
                    b.HasOne("LibraryAPI.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
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
                                    Road = "ulica bez imena",
                                    ZipCode = "88000"
                                },
                                new
                                {
                                    PublisherId = 2,
                                    City = "Split",
                                    Country = "HR",
                                    Road = "splitska ulica",
                                    ZipCode = "80012"
                                },
                                new
                                {
                                    PublisherId = 3,
                                    City = "Sarajevo",
                                    Country = "BiH",
                                    Road = "sarajevska ulica",
                                    ZipCode = "70005"
                                },
                                new
                                {
                                    PublisherId = 4,
                                    City = "Split",
                                    Country = "HR",
                                    Road = "zagrebacka ulica",
                                    ZipCode = "80077"
                                });
                        });

                    b.Navigation("Address");
                });

            modelBuilder.Entity("LibraryAPI.Models.Reservation", b =>
                {
                    b.HasOne("LibraryAPI.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LibraryAPI.Models.Author", b =>
                {
                    b.Navigation("AuthorBook");
                });

            modelBuilder.Entity("LibraryAPI.Models.Book", b =>
                {
                    b.Navigation("AuthorBook");

                    b.Navigation("BookCategory");
                });

            modelBuilder.Entity("LibraryAPI.Models.Category", b =>
                {
                    b.Navigation("BookCategory");
                });

            modelBuilder.Entity("LibraryAPI.Models.Publisher", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
