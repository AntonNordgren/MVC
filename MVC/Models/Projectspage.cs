using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Projectspage
    {
        public string header;
        public List<Project> projects;

        public Projectspage(string header, List<Project> projects)
        {
            this.header = header;
            this.projects = projects;
        }
    }
}
