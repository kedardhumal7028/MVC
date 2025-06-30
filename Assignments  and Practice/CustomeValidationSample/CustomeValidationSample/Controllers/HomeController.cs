using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomeValidationSample.Models;

namespace CustomeValidationSample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Employee emp)
        {
            if(ModelState.IsValid)
            {
                ModelState.Clear();
                return View("Thanks");
            }
            return View();
        }
    }
}