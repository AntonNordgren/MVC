using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Project
    {
        public string name { get; set; }
        public string url { get; set; }

        public string description { get; set; }

        public Project(string name, string url, string description)
        {
            this.name = name;
            this.url = url;
            this.description = description;
        }
    }
}
