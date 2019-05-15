using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MLPSApplication.Models
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext() : base("Mortgage")
        {

        }

        public DbSet<RegisteredUser> RegisteredUsers { get; set; }
        public DbSet<UnRegisteredUser> UnRegisteredUsers { get; set; }
        public DbSet<LoanDetail> LoanDetails { get; set; }
        public DbSet<PropertyDetail> PropertyDetails { get; set; }
        public DbSet<Employee> Employees { get; set; }
        


    }
}