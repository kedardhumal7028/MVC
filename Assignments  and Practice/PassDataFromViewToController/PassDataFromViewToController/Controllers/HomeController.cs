using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace PassDataFromViewToController.Controllers
{
    public class HomeController : Controller
    {
       [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string PostUsingParameter(string firstName, string lastName)
        {
            return "From Parameter -" + firstName + " " + lastName;
        }

        [HttpPost]
        public string PostUsingRequest()
        {
            string firstName = Request["firstName"];
            string lastName = Request["lastName"];
            return "From Request " + firstName + " " + lastName;
        }

        public string UsingFormCollection(FormCollection form)
        {
            string firstName = form["firstName"];
            string lastName = form["lastName"];
            return "From Form Collection " + firstName + " " + lastName;
        }
    }
}