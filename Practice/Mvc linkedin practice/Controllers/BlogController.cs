using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mvc_linkedin_practice.Models;

namespace Mvc_linkedin_practice.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
        [Route("/Akila/Control")]
        public IActionResult Control()
        {
            var control = new Control
            {
                Title = "This is viewbag title"
            };

            //ViewBag.Title = "This is viewbag title";
            return View(control);
            //return new ContentResult { Content = "Control posts" };
        }
        [HttpGet, Route("/Form")]
        public IActionResult Form()
        {

            return View();

        }

        [HttpPost, Route("/Form")]
        public IActionResult Form(Control control)
        {
            control.Title = User.Identity.Name;
             return View();

        }
    }
}
