using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Employeedepartment.Data
{
    public class Employee
    {
            [Key]
            public int EmpID { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public int Pincode { get; set; }
            public Dept Department { get; set; }
    }
}
