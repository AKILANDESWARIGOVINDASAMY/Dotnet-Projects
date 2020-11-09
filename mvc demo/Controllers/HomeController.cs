using mvc_demo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mynamespace
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult mytableview()
        {
            ViewBag.Message = "Your contact page.";
            Employeedata obj = new Employeedata();
            var Values = obj.Dbconnect();
            ViewBag.Values = Values;
            return View();
        }
    }
}