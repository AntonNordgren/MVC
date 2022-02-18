using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.ViewModels
{
    public class LanguageViewModel
    {
        public IEnumerable<Person> People { get; set; }
        public IEnumerable<Language> Languages { get; set; }
        public IEnumerable<PersonLanguage> PersonLanguage { get; set; }

        public string NewLanguageInput { get; set; }

        public int LanguageId { get; set; }
        public int PersonId { get; set; }
    }
}
