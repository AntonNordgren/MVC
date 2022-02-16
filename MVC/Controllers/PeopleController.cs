using Microsoft.AspNetCore.Mvc;
using MVC.Data;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class PeopleController : Controller
    {

        private readonly ApplicationDbContext _dbContext;

        public PeopleController(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        [HttpGet]
        public IActionResult Index(PeopleViewModel ViewModel)
        {
            //PeopleViewModel peopleViewModel = new PeopleViewModel()
            //{
            //    PeopleListView = _dbContext.People.ToList()
            //};

            //if (_dbContext.People.Count() == 0)
            //{
            //    var listOfCities = new List<City>
            //    {
            //        new City { Id = 1, Name = "Gothenburg",  }
            //    }

            //    var listOfPeople = new List<Person> {
            //        new Person { Name = "Anton", PhoneNr = "123123123", },
            //        new Person { Name = "Kalle", PhoneNr = "321321321", },
            //        new Person { Name = "Pelle", PhoneNr = "231231231", },
            //    };

            //    listOfPeople.ForEach(person => _dbContext.Add(person));
            //    _dbContext.SaveChanges();

            //}

            //return View(peopleViewModel);

            var allPeople = _dbContext.People.ToList();

            foreach(var person in allPeople)
            {
                person.City = _dbContext.City.Find(person.CityId);
            }

            ViewModel.PeopleListView = allPeople;

            return View(ViewModel);
        }

        [HttpPost]
        public IActionResult Index()
        {

            //if (viewModel.FilterString != null)
            //{
            //    viewModel.PeopleListView = _dbContext.People.Where(
            //        person => person.Name.Contains(viewModel.FilterString) ||
            //        person.City.Name.Contains(viewModel.FilterString)).ToList();

            //    return View(viewModel);

            //}
            //else
            //{
            //    viewModel.PeopleListView = _dbContext.People.ToList();
            //    return View(viewModel);
            //}
            
            return View();
        }

        [HttpPost]
        public IActionResult CreatePerson(Person newPerson)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Add<Person>(newPerson);
                _dbContext.SaveChanges();
            }

            PeopleViewModel newPeopleViewModel = new PeopleViewModel()
            {
                PeopleListView = _dbContext.People.ToList(),
                FilterString = ""
            };

            return View("Index", newPeopleViewModel);
        }

        public IActionResult DeletePerson(int id)
        {
            Person targetPerson = _dbContext.People.Find(id);

            _dbContext.Remove(targetPerson);
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
