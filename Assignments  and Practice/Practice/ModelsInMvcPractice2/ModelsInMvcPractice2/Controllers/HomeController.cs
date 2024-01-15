using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelsInMvcPractice2.Models;

namespace ModelsInMvcPractice2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var data = GetTechers();
            return View(data);
        }


        private Techers GetTechers()
        {
            return new Techers()
            {
                ID = 1,
                Name = "Kedar",
                Surname = "Dhumal"
            };
        }
    }


}