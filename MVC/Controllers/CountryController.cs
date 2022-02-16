using Microsoft.AspNetCore.Mvc;
using MVC.Data;
using MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class CountryController : Controller
    {
        private readonly ApplicationDbContext context;

        public CountryController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index(CountriesViewModel ViewModel)
        {
            var allCountries = context.Country.ToList();

            ViewModel.Countries = allCountries;
            return View(ViewModel);
        }
    }
}
