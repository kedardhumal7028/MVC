using EmployeeMgt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace EmployeeMgt.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        [Route("Signup")]
        public ActionResult SignUp()
        {
            return View();
        }

        [Route("Signup")]
        [HttpPost]
        public ActionResult SignUp(SignUpUserModel userModel)
        {
            using (EmployeeMgtEntities1 DB = new EmployeeMgtEntities1())
            {
                SignUpUserModel SU = new SignUpUserModel();

                SU.FirstName = userModel.FirstName;
                SU.Surname = userModel.Surname;
                SU.Username = userModel.Username;
                SU.Password = userModel.Password;
                SU.Token = userModel.Token;

                object p = DB.SignUpUserModel.Add(SU);
                DB.SaveChanges();
            }
            return View("Sucess");
                
        }
    }
}