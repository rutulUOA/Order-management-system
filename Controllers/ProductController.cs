using sampleapp.context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sampleapp.Controllers
{
    public class ProductController : Controller
    {

        RutulTrailEntities1 dbObj = new RutulTrailEntities1();
        // GET: Product
        public ActionResult Product()
        {
            return View("ProductOrder");
        }

        [HttpPost]
        public ActionResult PlaceOrder(OrderTable model)
        {
            var datastock = dbObj.Product_table.Where(m => m.ID == model.Product_table.ID).FirstOrDefault().Items_In_Stock;
            if (datastock <= 1)
                ModelState.AddModelError("ProductID", "Product is out of stock");
            if (ModelState.IsValid)
            {
                OrderTable obj = new OrderTable();
                //var prodId = dbObj.Product_table.Where(m => m.Product_Name == model.Product_table.Product_Name).FirstOrDefault().ID;
                obj.ProductID = model.Product_table.ID;
                obj.UserID = model.UserTable.ID;
                obj.Status = "ordered";
                obj.Product_table = dbObj.Product_table.Where(m => m.ID == model.Product_table.ID).FirstOrDefault();
                obj.UserTable = dbObj.UserTables.Where(m => m.ID == model.UserTable.ID).FirstOrDefault();
                obj.Product_table.Items_In_Stock -= 1;
                
                if (model.ID == 0)
                    dbObj.OrderTables.Add(obj);
                else
                    dbObj.Entry(obj).State = EntityState.Modified; 
                dbObj.SaveChanges();
                ViewData["NumbeOfItemsInStock"] = obj.Product_table.Items_In_Stock;
                ModelState.Clear();
            }
            //ModelState.Clear();
            return View("ProductOrder");
        }

        public ActionResult GetAllOrders()
        {
            var result = dbObj.OrderTables.ToList();
            return View(result);
        }

        //public ActionResult 
    }
}