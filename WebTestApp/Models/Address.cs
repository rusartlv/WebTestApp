using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTestApp.Models
{
    public class Address
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public Customer Client;
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public int Zip { get; set; }
        public int CountryId { get; set; }
        public Country Country;
    }
}
