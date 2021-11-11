using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Controllers
{

    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            List<Project> projects = new List<Project>();
            projects.Add(new Project("Simple Calculator", "https://github.com/AntonNordgren/Simple-Calculator", "Simple calculator with addition, subtraction, multiplication and division."));
            projects.Add(new Project("Hangman", "https://github.com/AntonNordgren/Hangman", "Hangman game in the console"));
            projects.Add(new Project("ToDo", "https://github.com/AntonNordgren/ToDo", "Todo App in the console"));
            projects.Add(new Project("Vending Machine", "https://github.com/AntonNordgren/VendingMachine", "Vending Machine console app"));
            projects.Add(new Project("HTML CSS", "https://github.com/AntonNordgren/HTML-CSS---Assignment", "Simple html pages with css"));
            projects.Add(new Project("Sokoban", "https://github.com/AntonNordgren/Sokoban", "Sokoban game using html and javascripts"));

            Projectspage pageContent = new Projectspage("Projects", projects);

            return View(pageContent);
        }
    }
}
