using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StronglyTypeHtmlHelper.Models;

namespace StronglyTypeHtmlHelper.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employee emp = new Employee()
            {
               Name ="Kedar Dhumal",
               Address = "Karad",
               IsEmployee = true
            };

            return View(emp);
        }


        [HttpPost]
        public ActionResult Index(Employee emp)
        {
            return View();
        }
    }
}