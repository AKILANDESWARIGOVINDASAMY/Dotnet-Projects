using employee_management_framework.Models;
using MVCCodefirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace employee_management_framework.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var context = new EmployeeContext())

            {
                List<EmployeeDetails> EmployeeDetails = context.Employeedetails.ToList();

                EmployeeDetails emp = new EmployeeDetails();
                emp.Name = "asdfa";
                emp.Address = "adsfasdf";

                context.Employeedetails.Add(emp);
                context.SaveChanges();
                EmployeeDetails = context.Employeedetails.ToList();

            }
            return View();
        }

        public ActionResult About()
        {
            /*using (var context = new EmployeeContext())

            {
                List<Department> department = context.Department.ToList();

                Department dept = new Department();
                dept.Deptid = 12;
                dept.DeptName = "ECE";

                context.Department.Add(dept);
                context.SaveChanges();
                department = context.Department.ToList();

            }*/

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}