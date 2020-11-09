using System;

using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;

using System.Linq;

using System.Web;



namespace MVCCodefirst.Models

{

    public class EmployeeDetails

    {

        [Key]

        public int EmpID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }
        public int Pincode { get; set; }


    }

}