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
        [Required(ErrorMessage = "Не указано имя")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 50 символов")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Не указан электронный адрес")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
        public string Email { get; set; }

        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Gender")]
        public Gender CustomerGender { get; set; }
        public List<Address> Orders { get; set; }
    }
}
