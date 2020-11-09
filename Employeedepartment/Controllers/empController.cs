using Employeedepartment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employeedepartment.Controllers
{
    public class empController : Controller
    {
        // GET: emp
        public ActionResult Index()
        {
            using (var context = new EmployeeContext())

            {

                List<Employee> EmployeeDetails = context.Employeedetails.ToList();

                Employee emp = new Employee();
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
            using (var context = new EmployeeContext())

            {
                List<Dept> department = context.Department.ToList();

                Dept dept = new Dept();
                dept.Deptid = 12;
                dept.DeptName = "ECE";

                context.Department.Add(dept);
                context.SaveChanges();
                department = context.Department.ToList();

            }

            return View();
        }
    }
}