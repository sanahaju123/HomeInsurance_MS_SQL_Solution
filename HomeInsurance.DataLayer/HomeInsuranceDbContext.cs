using HomeInsurance.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeInsurance.DataLayer
{
    public class HomeInsuranceDbContext : DbContext
    {
        public HomeInsuranceDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Residence> Residences { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Policy> Policies { get; set; }

    }
}