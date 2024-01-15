using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models_in_MVC.Models;

namespace Models_in_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var data = GetEmployee();
            return View(data);
        }

        public Employee GetEmployee()
        {
            return new Employee()
            {
                ID = 1,
                Name = "Kedar",
                Address = "Pune"
            };
        }
    }
}