using MVC_CrudOperation1.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CrudOperation1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        db_TestEntities dbObj = new db_TestEntities();
        public ActionResult Student()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddStudent(tbl_Student model)
        {
            tbl_Student obj = new tbl_Student();
            obj.Name = model.Name;
            obj.FName = model.FName;
            obj.Email = model.Email;
            obj.Mobile = model.Mobile;
            obj.Description = model.Description;

            dbObj.tbl_Student.Add(obj);
            dbObj.SaveChanges();

            return View("Student");
        }

       
    }
}