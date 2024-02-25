using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBagAndViewData.Models;

namespace ViewBagAndViewData.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Hi Keds... Welcome to Home Index.";
            ViewBag.MyList = new List<string>() {"Kedar","Suraj","Chaitya","Abhi" };

            List<Employee> emplist = new List<Employee>()
            {
                new Employee(){Email = "keds@gmail.com", Id = 1, Name = "Keds" },
                new Employee() {Email = "Suraj@gmail.com", Id = 2, Name = "Suraj" },
                new Employee(){Email = "Chaitya@gmail.com", Id = 3, Name = "Chaitya"},
                new Employee(){Email = "Abhi@gmail.com", Id = 4, Name = "Abhi" }
            };
            ViewBag.Myemplist = emplist;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Hi Keds...Welcome to Home About.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Hi Keds... Welcome to Home Contact.";

            return View();
        }
    }
}