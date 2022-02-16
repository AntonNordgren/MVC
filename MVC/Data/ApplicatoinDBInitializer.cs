using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Data
{
    public class ApplicatoinDBInitializer
    {

        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using var serviceScope = applicationBuilder.ApplicationServices.CreateScope();
            var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

            context.Database.EnsureCreated();

            if (!context.Country.Any())
            {
                context.Country.AddRange(new List<Country>()
                {
                    new Country()
                    {
                        Name = "Sweden",
                    },
                    new Country()
                    {
                        Name = "Norway"
                    },
                    new Country()
                    {
                        Name = "Denmark"
                    },
                });

                context.SaveChanges();
            }

            if (!context.City.Any())
            {
                context.City.AddRange(new List<City>()
                {
                    new City()
                    {
                        CountryId = 1,
                        Name = "Stockholm"
                    },

                    new City()
                    {
                        CountryId = 1,
                        Name = "Gothenburg"
                    },

                    new City()
                    {
                        CountryId = 2,
                        Name = "Oslo"
                    },

                    new City()
                    {
                        CountryId = 3,
                        Name = "Copenhagen"
                    },

                });

                context.SaveChanges();
            }

            if (!context.People.Any())
            {
                context.People.AddRange(new List<Person>()
                {
                    new Person()
                    {
                        Name = "Kalle",
                        PhoneNumber = "0753-321321",
                        CityId = 1
                    },
                    new Person()
                    {
                        Name = "Anton",
                        PhoneNumber = "0753-123123",
                        CityId = 2
                    },
                    new Person()
                    {
                        Name = "Hans",
                        PhoneNumber = "0753-111222",
                        CityId = 1
                    },

                    new Person()
                    {
                        Name = "Stina",
                        PhoneNumber = "0753-333111",
                        CityId = 3
                    },

                    new Person()
                    {
                        Name = "Bill",
                        PhoneNumber = "0753-333111",
                        CityId = 3
                    },

                    new Person()
                    {
                        Name = "Börje",
                        PhoneNumber = "0753-231231",
                        CityId = 3
                    },

                    new Person()
                    {
                        Name = "Lisa",
                        PhoneNumber = "0753-444111",
                        CityId = 2
                    },

                });

                context.SaveChanges();
            }


        }
    }
}