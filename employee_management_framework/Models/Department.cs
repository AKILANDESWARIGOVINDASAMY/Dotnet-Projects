using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace employee_management_framework.Models
{
    public class Department
    {
        [Key]
        public int Deptid { get; set; }
        public string DeptName { get; set; }
    }
}