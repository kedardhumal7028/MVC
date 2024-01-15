using InventoryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventoryManagementSystem.Controllers
{
    public class PurchaseController : Controller
    {
        Inventory_Management_SystemEntities db = new Inventory_Management_SystemEntities();

        // GET: Purchase
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult DisplayPurchase()
        {
            List<Purchase> list = db.Purchase.OrderByDescending(x => x.id).ToList();
            return View(list);
        }

        [HttpGet]
        public ActionResult PurchaseProduct()
        {
            List<string> list = db.Products.Select(x => x.Product_name).ToList();
            ViewBag.ProductName = new SelectList(list);
            return View();
        }

        [HttpPost]
        public ActionResult PurchaseProduct(Purchase pur)
        {
            db.Purchase.Add(pur);
            db.SaveChanges();
            return RedirectToAction("DisplayPurchase");
        }

        [HttpGet]
        public ActionResult DeleteProduct(int id)
        {
            Purchase p = db.Purchase.Where(x => x.id == id).SingleOrDefault();
            return View(p);
        }

        [HttpPost]
        public ActionResult DeleteProduct(int id, Purchase purchase)
        {
            Purchase p = db.Purchase.Where(x => x.id == id).SingleOrDefault();
            db.Purchase.Remove(p);
            db.SaveChanges();
            return RedirectToAction("DisplayPurchase");
        }





        [HttpGet]
        public ActionResult Detail(int id)
        {
            // Retrieve the purchase from the Purchases table based on the provided id
            Purchase purchase = db.Purchase.Find(id);

            if (purchase != null)
            {
                return View(purchase);
            }
            else
            {
                // Handle the case where the purchase with the given id is not found
                return HttpNotFound(); // You can customize this based on your needs
            }
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            Purchase p = (Purchase)db.Purchase.Where(x => x.id == id).SingleOrDefault();
            List<string> list = db.Products.Select(x => x.Product_name).ToList();
            ViewBag.ProductName = new SelectList(list);
            return View(p);
        }


        [HttpPost]
        public ActionResult Edit(int id, Purchase pur)
        {
            Purchase p = db.Purchase.Where(x => x.id == id).SingleOrDefault();
            p.Purchase_date = pur.Purchase_date;
            p.Purchase_prod = pur.Purchase_prod;
            p.Purchase_qnty = pur.Purchase_qnty;
            db.SaveChanges();
            return RedirectToAction("DisplayPurchase");
        }

    }
}