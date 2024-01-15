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
       
        public ActionResult Index(Student stu)
        {
            
            return View();
        }
    }
}