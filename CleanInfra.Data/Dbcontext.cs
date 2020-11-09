using CleanDomain;
using Microsoft.EntityFrameworkCore;
using Employeemanagementsystem;

namespace CleanInfraData
{
    public class Dbcontext : DbContext
        {
        public Dbcontext(DbContextOptions options) : base(options)
            {
            }
            public DbSet<Employee> Employeedetails { get; set; }

        }

}

