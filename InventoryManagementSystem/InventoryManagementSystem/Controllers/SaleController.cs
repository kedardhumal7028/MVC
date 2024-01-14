using InventoryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventoryManagementSystem.Controllers
{
    public class SaleController : Controller
    {
        Inventory_Management_SystemEntities db = new Inventory_Management_SystemEntities();

        // GET: Sale
        public ActionResult Index()
        {
            return View();
        }
    }
}