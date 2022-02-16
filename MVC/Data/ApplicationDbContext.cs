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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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









            // Countries
            //modelBuilder.Entity<Country>().HasData(new Country { Name = "Sweden" });
            //modelBuilder.Entity<Country>().HasData(new Country { Name = "Norway" });
            //modelBuilder.Entity<Country>().HasData(new Country { Name = "Finland" });

            // Cities
            //modelBuilder.Entity<City>().HasData(new City { Name = "Stockholm", CountryId = 1 });
            //modelBuilder.Entity<City>().HasData(new City { Name = "Gothenburg", CountryId = 1 });
            //modelBuilder.Entity<City>().HasData(new City { Name = "Malmö", CountryId = 1 });

            //modelBuilder.Entity<City>().HasData(new City { Name = "Oslo", CountryId = 2 });
            //modelBuilder.Entity<City>().HasData(new City { Name = "Bergen", CountryId = 2 });
            //modelBuilder.Entity<City>().HasData(new City { Name = "Stavanger", CountryId = 2 });

            //modelBuilder.Entity<City>().HasData(new City { Name = "Helsinki", CountryId = 3 });
            //modelBuilder.Entity<City>().HasData(new City { Name = "Espoo", CountryId = 3 });
            //modelBuilder.Entity<City>().HasData(new City { Name = "Tampere", CountryId = 3 });

            // People

            // modelBuilder.Entity<Person>().HasData(new Person { PersonId = 1, Name = "Anton", PhoneNr = "123123123" });


            // var City1 = new City { Id = 1, Name = "Gothenburg", }

            // modelBuilder.Entity<Person>().

            //modelBuilder.Entity<Person>().HasData(new Person { PersonId = 1, Name = "Anton", PhoneNr = "123123123", City = new City { Id = 1, Name = "Gothenburg" } });
            //modelBuilder.Entity<Person>().HasData(new Person { PersonId = 2, Name = "Kalle", PhoneNr = "231231231", City = new City { Id = 2, Name = "Malmö" } });
            //modelBuilder.Entity<Person>().HasData(new Person { PersonId = 3, Name = "Pelle", PhoneNr = "321321321", City = new City { Id = 3, Name = "Stockholm" } });
        }
    }
}
