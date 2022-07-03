using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelsInMVC.Models;

namespace ModelsInMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var data = GetEmployee();
            return View(data);
        }


        private Employee GetEmployee()
        {
            return new Employee()
            {
                ID = 1,
                Name = "Kedar",
                Address = "Karad"
            };
        }
    }
}