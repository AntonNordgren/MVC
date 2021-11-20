using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Person
    {
        private readonly int _PersonId;
        public int PersonId { get { return _PersonId; } }
        public string Name { get; set; }
        public string PhoneNr { get; set; }
        public string City { get; set; }

        public Person(int id, string name, string phoneNr, string city)
        {
            _PersonId = id;
            Name = name;
            PhoneNr = phoneNr;
            City = city;
        }
    }
}
