using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebTestApp.Models
{
    public enum Gender
    {
        [Display(Name = "Male")]
        Male,

        [Display(Name = "Female")]
        Female
    }
    public class Customer
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Gender")]
        public Gender CustomerGender { get; set; }
        public List<Address> Orders { get; set; }
    }
}
