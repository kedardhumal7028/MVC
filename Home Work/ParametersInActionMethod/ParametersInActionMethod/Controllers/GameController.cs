using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ParametersInActionMethod.Controllers
{
    public class GameController : Controller
    {
    //    // GET: Game
    //    public ActionResult Index()
    //    {
    //        return View();
    //    }



        public string Name(string name)
        {
            return "Welcome to  = " + name;
        }

        public string FullName(string first,string last)
        {
            return "Your First Name is = " + first + " and last Name is = " + last;
            
        }
       
    }
}