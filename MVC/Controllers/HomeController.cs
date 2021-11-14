using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Content sideContent = new Content("About");
            return View(sideContent);
        }
    }

    public class DoctorController : Controller
    {
        [HttpGet]
        public IActionResult FeverCheck()
        {
            return View(new FeverCheckViewModel(null, ""));
        }

        [HttpPost]
        public IActionResult FeverCheck(int? temp)
        {
            if(temp != null)
            {
                string stringResult = UtilityFeverCheck.CheckFever(temp);
                return View(new FeverCheckViewModel(temp, stringResult));
            }
            return View(new FeverCheckViewModel(null, ""));
        }
    }
}
