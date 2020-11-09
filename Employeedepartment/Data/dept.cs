using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Employeedepartment.Data
{
    public class Dept  
    {
        [Key]
        public int Deptid { get; set; }
        public string DeptName { get; set; }
    }
}