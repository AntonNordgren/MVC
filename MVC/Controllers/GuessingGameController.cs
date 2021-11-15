using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class GuessingGameController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

            if(HttpContext.Session.GetInt32("The Number") == null)
            {
                Random rnd = new Random();
                int theNumber = rnd.Next(1, 101);

                HttpContext.Session.SetInt32("The Number", theNumber);
            }

            ViewBag.Message = "No Guesses Yet";
            return View();
        }

        [HttpPost]
        public IActionResult Index(int guess)
        {
            if(guess < 1 || guess > 100)
            {
                ViewBag.Message = "Invalid Guess";
            }
            else
            {
                if (guess == HttpContext.Session.GetInt32("The Number"))
                {
                    ViewBag.Message = "You got it right! New number added, play again";

                    Random rnd = new Random();
                    int theNumber = rnd.Next(1, 101);

                    HttpContext.Session.SetInt32("The Number", theNumber);
                }
                else
                {

                    if(guess < HttpContext.Session.GetInt32("The Number"))
                    {

                        ViewBag.Message = "It's higher!";
                    }
                    else if (guess > HttpContext.Session.GetInt32("The Number")) {

                        ViewBag.Message = "It's lower!";
                    }
                }
            }


            return View();
        }
    }
}
