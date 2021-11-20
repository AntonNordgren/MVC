using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class PeopleController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            PeopleMemory peopleMemory = new PeopleMemory();
            PeopleViewModel peopleViewModel = new PeopleViewModel() {
                PeopleListView = peopleMemory.Read()
            };

            return View(peopleViewModel);
        }

        [HttpPost]
        public IActionResult Index(PeopleViewModel viewModel)
        {
            PeopleMemory peopleMemory = new PeopleMemory();
            viewModel.PeopleListView.Clear();

            foreach (Person person in peopleMemory.Read())
            {

                if(viewModel.FilterString != null)
                {
                    if (person.Name.Contains(viewModel.FilterString, StringComparison.OrdinalIgnoreCase) ||
                        person.City.Contains(viewModel.FilterString, StringComparison.OrdinalIgnoreCase))
                    {
                        viewModel.PeopleListView.Add(person);
                    }
                }
                else
                {
                    viewModel.PeopleListView = peopleMemory.Read();
                    return View(viewModel);
                }
            }

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult CreatePerson(CreatePersonViewModel createPersonViewModel)
        {
            PeopleViewModel newViewModel = new PeopleViewModel();
            PeopleMemory peopleMemory = new PeopleMemory();

            if(ModelState.IsValid)
            {
                newViewModel.Name = createPersonViewModel.Name;
                newViewModel.PhoneNr = createPersonViewModel.PhoneNr;
                newViewModel.City = createPersonViewModel.City;

                newViewModel.PeopleListView = peopleMemory.Read();

                peopleMemory.Create(createPersonViewModel.Name,
                    createPersonViewModel.PhoneNr, createPersonViewModel.City);

                return View("Index", newViewModel);
            }

            return View("Index", newViewModel);
        }

        public IActionResult DeletePerson(int id)
        {
            PeopleMemory peopleMemory = new PeopleMemory();
            Person targetPerson = peopleMemory.Read(id);
            peopleMemory.Delete(targetPerson);

            return RedirectToAction("Index");
        }

    }
}
