using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebTestApp.Models
{
    public class Address
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer;

        [Required(ErrorMessage = "Не указана улица")]
        [StringLength(70, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 70 символов")]
        public string StreetAddress { get; set; }

        [Required(ErrorMessage = "Не указан город")]
        [StringLength(30, ErrorMessage = "Длина строки должна быть до 30 символов")]
        public string City { get; set; }

        [StringLength(8, ErrorMessage = "Длина строки должна быть до 8 символов")]
        public string Zip { get; set; }
        public int CountryId { get; set; }
        public Country Country;
    }
}
