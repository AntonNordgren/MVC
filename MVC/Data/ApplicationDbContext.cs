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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(new Person { PersonId = 1, Name = "Anton", PhoneNr = "123123123", City = "Gothenburg" });
            modelBuilder.Entity<Person>().HasData(new Person { PersonId = 2, Name = "Kalle", PhoneNr = "231231231", City = "Stockholm" });
            modelBuilder.Entity<Person>().HasData(new Person { PersonId = 3, Name = "Pelle", PhoneNr = "321321321", City = "Malmö" });
        }
    }
}
