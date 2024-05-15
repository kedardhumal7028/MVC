using Student_Crud_Operation.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;


namespace Student_Crud_Operation.Controllers
{
    public class StudentController : Controller
    {

        Crud_OperationDBEntities dbobj = new Crud_OperationDBEntities();
        
        public ActionResult Student()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddStudent(Contact model)
        {

            if(ModelState.IsValid)
            {
                Contact obj = new Contact();
                obj.FirstName = model.FirstName;
                obj.MiddleName = model.MiddleName;
                obj.SurName = model.SurName;
                obj.MobileNo = model.MobileNo;
                obj.State = model.State;
                obj.Country = model.Country;
                obj.District = model.District;
                obj.Address = model.Address;
                obj.PostalCode = model.PostalCode;
                obj.Location = model.Location;
                obj.CreateDate = model.CreateDate;

                dbobj.Contact.Add(obj);
                dbobj.SaveChanges();
            }

            ModelState.Clear();

            return View("Student");
        }


        public ActionResult AllRecords()
        {
            var allRecords = dbobj.Contact.ToList();
            return View(allRecords);
        }


        
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = dbobj.Contact.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Contact contact)
        {
            if (ModelState.IsValid)
            {
                dbobj.Entry(contact).State = EntityState.Modified;
                dbobj.SaveChanges();
                return RedirectToAction("AllRecords");
            }
            return View(contact);
        }

        
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = dbobj.Contact.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Contact contact = dbobj.Contact.Find(id);
            dbobj.Contact.Remove(contact);
            dbobj.SaveChanges();
            return RedirectToAction("AllRecords");
        }

        public ActionResult SearchStudent(int? searchId)
        {
            if (searchId.HasValue)
            {
                var student = dbobj.Contact.FirstOrDefault(c => c.ID == searchId.Value);
                if (student != null)
                {
                    return View(student);
                }
            }

            else
            {
                ViewBag.Message = "Record with the provided ID does not exist.";
                return View();
            }
            return View();
        }






    }
}