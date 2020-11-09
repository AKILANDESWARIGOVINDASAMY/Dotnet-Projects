using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
//using Microsoft.EntityFrameworkCore;
namespace Employeedepartment.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("Demostring")
        {
        }
        public DbSet<Employee> Employeedetails { get; set; }
        public DbSet<Dept> Department { get; set; }
    }
}