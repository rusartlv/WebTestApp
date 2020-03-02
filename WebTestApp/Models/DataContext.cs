using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTestApp.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }
        public DbSet<Address> Address { get; set; }

        public DbSet<Customer> Customer { get; set; }

        public DbSet<Country> Country { get; set; }
    }
}
