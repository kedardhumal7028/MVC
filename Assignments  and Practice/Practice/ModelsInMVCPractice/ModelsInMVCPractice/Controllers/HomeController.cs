using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelsInMVCPractice.Models;

namespace ModelsInMVCPractice.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var data = GetStudent();
            return View(data);
        }

        private Student GetStudent()
        {
            return new Student()
            {
                ID = 1,
                Name = "Keds",
                Address = "Vihe"
            };
        }

    }
}