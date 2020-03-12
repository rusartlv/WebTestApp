using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebTestApp.Models
{
    public class Address
    {
        public int Id { get; set; }
        
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

        [Required]
        [StringLength(70, MinimumLength = 3, ErrorMessage = "The limit of the line length in 3–70 characters")]
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Line length must be up to 30 characters")]
        public string City { get; set; }

        [StringLength(8, ErrorMessage = "Line length must be up to 8 characters")]
        public string Zip { get; set; }

        [Required]
        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public Country Country { get;set; }
    }
}
