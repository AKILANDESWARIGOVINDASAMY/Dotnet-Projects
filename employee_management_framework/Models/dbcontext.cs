using employee_management_framework.Models;
using System;

using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using System.Web;



namespace MVCCodefirst.Models

{

    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("Demo")

        {            
           
         }

        public DbSet<EmployeeDetails> Employeedetails { get; set; }
      //  public DbSet<Department> Department { get; set; }



    }
}

