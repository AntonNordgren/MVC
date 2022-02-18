using Microsoft.EntityFrameworkCore;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Person> People { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<City> City { get; set; }

        public DbSet<Language> Language { get; set; }
        public DbSet<PersonLanguage> PersonLanguage { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<PersonLanguage>().HasKey(pl => new { pl.PersonId, pl.LanguageId });

            modelBuilder.Entity<PersonLanguage>()
                .HasOne<Person>(pl => pl.Person)
                .WithMany(l => l.Person_Language)
                .HasForeignKey(pl => pl.PersonId);

            modelBuilder.Entity<PersonLanguage>()
                .HasOne<Language>(pl => pl.Language)
                .WithMany(p => p.Person_Language)
                .HasForeignKey(pl => pl.LanguageId);

            // Languges
            modelBuilder.Entity<Language>().HasData(new Language { Id = 1, Name = "Swedish" });
            modelBuilder.Entity<Language>().HasData(new Language { Id = 2, Name = "English" });
            modelBuilder.Entity<Language>().HasData(new Language { Id = 3, Name = "German" });

            // Countries
            modelBuilder.Entity<Country>().HasData(new Country { Id = 1, Name = "Sweden" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 2, Name = "England" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 3, Name = "Germany" });

            // Cities
            modelBuilder.Entity<City>().HasData(new City { Id = 1, Name = "Stockholm", CountryId = 1 });
            modelBuilder.Entity<City>().HasData(new City { Id = 2, Name = "Gothenburg", CountryId = 1 });
            modelBuilder.Entity<City>().HasData(new City { Id = 3, Name = "London", CountryId = 2 });
            modelBuilder.Entity<City>().HasData(new City { Id = 4, Name = "Birmingham", CountryId = 2 });
            modelBuilder.Entity<City>().HasData(new City { Id = 5, Name = "Berlin", CountryId = 3 });
            modelBuilder.Entity<City>().HasData(new City { Id = 6, Name = "Hamburg", CountryId = 3 });

            // People
            modelBuilder.Entity<Person>().HasData(new Person { Id = 1, Name = "Kalle", PhoneNumber = "0712-123123", CityId = 1 });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 2, Name = "Anton", PhoneNumber = "0732-321321", CityId = 2 });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 3, Name = "Billy", PhoneNumber = "0713-111222", CityId = 2 });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 4, Name = "Stina", PhoneNumber = "0714-333222", CityId = 3 });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 5, Name = "John",  PhoneNumber = "0754-333111", CityId = 3 });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 6, Name = "Ola",   PhoneNumber = "0753-234234", CityId = 4 });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 7, Name = "Lisa",  PhoneNumber = "0756-432432", CityId = 5 });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 8, Name = "Benny", PhoneNumber = "0766-444222", CityId = 5 });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 9, Name = "Julia", PhoneNumber = "0751-555333", CityId = 6 });

            // PersonLanguages
            modelBuilder.Entity<PersonLanguage>().HasData(new PersonLanguage { PersonId = 1, LanguageId = 1 });
            modelBuilder.Entity<PersonLanguage>().HasData(new PersonLanguage { PersonId = 2, LanguageId = 1 });
            modelBuilder.Entity<PersonLanguage>().HasData(new PersonLanguage { PersonId = 3, LanguageId = 1 });
            modelBuilder.Entity<PersonLanguage>().HasData(new PersonLanguage { PersonId = 4, LanguageId = 2 });
            modelBuilder.Entity<PersonLanguage>().HasData(new PersonLanguage { PersonId = 5, LanguageId = 2 });
            modelBuilder.Entity<PersonLanguage>().HasData(new PersonLanguage { PersonId = 6, LanguageId = 2 });
            modelBuilder.Entity<PersonLanguage>().HasData(new PersonLanguage { PersonId = 7, LanguageId = 3 });
            modelBuilder.Entity<PersonLanguage>().HasData(new PersonLanguage { PersonId = 8, LanguageId = 3 });
            modelBuilder.Entity<PersonLanguage>().HasData(new PersonLanguage { PersonId = 9, LanguageId = 3 });

            modelBuilder.Entity<PersonLanguage>().HasData(new PersonLanguage { PersonId = 1, LanguageId = 2 });
            modelBuilder.Entity<PersonLanguage>().HasData(new PersonLanguage { PersonId = 2, LanguageId = 2 });
            modelBuilder.Entity<PersonLanguage>().HasData(new PersonLanguage { PersonId = 2, LanguageId = 3 });
        }
    }
}
