using Microsoft.AspNetCore.Mvc;
using MVC.Data;
using MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class CityController : Controller
    {
        private readonly ApplicationDbContext context;

        public CityController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index(CitiesViewModel ViewModel)
        {
            var allCities = context.City.ToList();

            ViewModel.Cities = allCities;
            return View(ViewModel);
        }
    }
}
