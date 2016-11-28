using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashCollection.Models;

namespace TrashCollection.Controllers
{
    public class CustomerController : Controller
    {

        ApplicationDbContext context;
        public ActionResult Portal()
        {
            return View();
        }

        public ActionResult myProfile()
        {

            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult myProfile([Bind()] Customers Customer)
        {
            if (ModelState.IsValid)
            {
                context.customers.Add(Customer);
                context.SaveChanges();
                return RedirectToAction("Portal");
            }
            return View(Customer);
        }
        //[HttpPost]
        //[AllowAnonymous]
        //[ValidateAntiForgeryToken]

        //public async Task<ActionResult> Profile(RegisterViewModel model)
        //{

        //}


        public ActionResult Vacation()
        {
            return View();
        }

        public ActionResult Billing()
        {
            return View(); 
        }

        public ActionResult ChangePickUp()
        {
            return View();
        }
      
    }
}