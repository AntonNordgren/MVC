using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }

        //[Required]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter Name.")]
        public string Name { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter PhoneNumber.")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Invalid Mobile Number.")]
        public string PhoneNr { get; set; }

        //[Required]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter City.")]
        public string City { get; set; }
    }
}
