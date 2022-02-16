using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public ICollection<Person> Inhabitants { get; set; }

        [Required]
        [ForeignKey("CountryId")]
        public int CountryId { get; set; }

        public Country Country { get; set; }
    }
}