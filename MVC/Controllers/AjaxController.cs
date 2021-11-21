using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class AjaxController : Controller
    {
        public IActionResult Index()
        {
            PeopleMemory peopleMemory = new PeopleMemory();
            PeopleViewModel peopleViewModel = new PeopleViewModel()
            {
                PeopleListView = peopleMemory.Read()
            };

            if (peopleViewModel.PeopleListView.Count == 0)
            {
                peopleMemory.SeedPeople();
                peopleViewModel.PeopleListView = peopleMemory.Read();
            }

            return View();
        }

        [HttpGet]
        public IActionResult GetPeople()
        {
            PeopleMemory peopleMemory = new PeopleMemory();
            List<Person> poepleList = peopleMemory.Read();

            return PartialView("_PersonPartialView", poepleList);
        }

        [HttpPost]
        public IActionResult FindPersonById(int personId)
        {
            PeopleMemory peopleMemory = new PeopleMemory();
            Person targetPerson = peopleMemory.Read(personId);
            List<Person> poeple = new List<Person>();

            if (targetPerson != null)
            {
                poeple.Add(targetPerson);
            }

            return PartialView("_PersonPartialView", poeple);
        }

        [HttpPost]
        public IActionResult DeletePersonById(int personId)
        {
            PeopleMemory peopleMemory = new PeopleMemory();
            Person targetPerson = peopleMemory.Read(personId);
            List<Person> poeple = new List<Person>();
            bool success = false;

            if (targetPerson != null)
            {
                success = peopleMemory.Delete(targetPerson);
            }

            if (success)
            {
                return StatusCode(200);
            }

            return StatusCode(404);
        }
    }
}
