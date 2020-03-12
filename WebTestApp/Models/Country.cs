using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebTestApp.Models
{
    public class Country
    {
        public int Id { get; set; }
        [Required]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        public virtual List<Address> Addresses { get; set; }
    }
}
