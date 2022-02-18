﻿// <auto-generated />
using MVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220217212957_langv2")]
    partial class langv2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVC.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("City");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            Name = "Stockholm"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 1,
                            Name = "Gothenburg"
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 2,
                            Name = "London"
                        },
                        new
                        {
                            Id = 4,
                            CountryId = 2,
                            Name = "Birmingham"
                        },
                        new
                        {
                            Id = 5,
                            CountryId = 3,
                            Name = "Berlin"
                        },
                        new
                        {
                            Id = 6,
                            CountryId = 3,
                            Name = "Hamburg"
                        });
                });

            modelBuilder.Entity("MVC.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Country");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Sweden"
                        },
                        new
                        {
                            Id = 2,
                            Name = "England"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Germany"
                        });
                });

            modelBuilder.Entity("MVC.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Language");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Swedish"
                        },
                        new
                        {
                            Id = 2,
                            Name = "English"
                        },
                        new
                        {
                            Id = 3,
                            Name = "German"
                        });
                });

            modelBuilder.Entity("MVC.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 1,
                            Name = "Kalle",
                            PhoneNumber = "0712-123123"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 2,
                            Name = "Anton",
                            PhoneNumber = "0732-321321"
                        },
                        new
                        {
                            Id = 3,
                            CityId = 2,
                            Name = "Billy",
                            PhoneNumber = "0713-111222"
                        },
                        new
                        {
                            Id = 4,
                            CityId = 3,
                            Name = "Stina",
                            PhoneNumber = "0714-333222"
                        },
                        new
                        {
                            Id = 5,
                            CityId = 3,
                            Name = "John",
                            PhoneNumber = "0754-333111"
                        },
                        new
                        {
                            Id = 6,
                            CityId = 4,
                            Name = "Ola",
                            PhoneNumber = "0753-234234"
                        },
                        new
                        {
                            Id = 7,
                            CityId = 5,
                            Name = "Lisa",
                            PhoneNumber = "0756-432432"
                        },
                        new
                        {
                            Id = 8,
                            CityId = 5,
                            Name = "Benny",
                            PhoneNumber = "0766-444222"
                        },
                        new
                        {
                            Id = 9,
                            CityId = 6,
                            Name = "Julia",
                            PhoneNumber = "0751-555333"
                        });
                });

            modelBuilder.Entity("MVC.Models.PersonLanguage", b =>
                {
                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.HasKey("PersonId", "LanguageId");

                    b.HasIndex("LanguageId");

                    b.ToTable("PersonLanguage");

                    b.HasData(
                        new
                        {
                            PersonId = 1,
                            LanguageId = 1
                        },
                        new
                        {
                            PersonId = 2,
                            LanguageId = 1
                        },
                        new
                        {
                            PersonId = 3,
                            LanguageId = 1
                        },
                        new
                        {
                            PersonId = 4,
                            LanguageId = 2
                        },
                        new
                        {
                            PersonId = 5,
                            LanguageId = 2
                        },
                        new
                        {
                            PersonId = 6,
                            LanguageId = 2
                        },
                        new
                        {
                            PersonId = 7,
                            LanguageId = 3
                        },
                        new
                        {
                            PersonId = 8,
                            LanguageId = 3
                        },
                        new
                        {
                            PersonId = 9,
                            LanguageId = 3
                        },
                        new
                        {
                            PersonId = 1,
                            LanguageId = 2
                        },
                        new
                        {
                            PersonId = 2,
                            LanguageId = 2
                        },
                        new
                        {
                            PersonId = 2,
                            LanguageId = 3
                        });
                });

            modelBuilder.Entity("MVC.Models.City", b =>
                {
                    b.HasOne("MVC.Models.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MVC.Models.Person", b =>
                {
                    b.HasOne("MVC.Models.City", "City")
                        .WithMany("Inhabitants")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MVC.Models.PersonLanguage", b =>
                {
                    b.HasOne("MVC.Models.Language", "Language")
                        .WithMany("Person_Language")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC.Models.Person", "Person")
                        .WithMany("Person_Language")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
