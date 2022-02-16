using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.ViewModels
{
    public class CitiesViewModel
    {
        public IEnumerable<City> Cities { get; set; }
    }
}
