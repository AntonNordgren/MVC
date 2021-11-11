using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            Content sideContent = new Content("About");
            return View(sideContent);
        }
    }
}
