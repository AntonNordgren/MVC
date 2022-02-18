using Microsoft.AspNetCore.Mvc;
using MVC.Data;
using MVC.Models;
using MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class LanguageController : Controller
    {
        private readonly ApplicationDbContext context;

        public LanguageController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Index(LanguageViewModel ViewModel)
        {
            ViewModel.People = context.People.ToList();
            ViewModel.Languages = context.Language.ToList();
            ViewModel.PersonLanguage = context.PersonLanguage.ToList();

            return View(ViewModel);
        }

        [HttpPost]
        public IActionResult AddLanguage(string NewLanguageInput)
        {

            var result = context.Language
                .Where(language => language.Name == NewLanguageInput)
                .FirstOrDefault<Language>();

            if(result == null)
            {
                context.Language.Add(new Language { Name = NewLanguageInput });
                context.SaveChanges();
            }


            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult AddLanguageToPerson(int PersonId, int LanguageId)
        {

            if (!context.PersonLanguage.Any(pl => pl.PersonId == PersonId && pl.LanguageId == LanguageId))
            {
                context.PersonLanguage.Add(new PersonLanguage()
                {
                    PersonId = PersonId,
                    LanguageId = LanguageId
                });

                context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
