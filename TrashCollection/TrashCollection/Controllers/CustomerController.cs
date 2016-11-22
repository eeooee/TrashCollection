using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrashCollection.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Portal()
        {
            return View();
        }

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