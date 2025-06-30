using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutInMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        [Route("Employees")]
        public ActionResult GetList()
        {
            return View();
        }

        [Route("NewEmployee")]
        public ActionResult AddEmployee()
        {
            return View();
        }
    }
}