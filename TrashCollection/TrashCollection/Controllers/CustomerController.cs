using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashCollection.Models;
using TrashCollection.ViewModels;
using Microsoft.AspNet.Identity;

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

            var model = new CustomerProfileViewModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult myProfile(CustomerProfileViewModel viewModel)
        { 
            var model = new CustomerProfileViewModel();
            return View(model);



        }
        


        public ActionResult Vacation()
        {
            return View();
        }

        public ActionResult Billing(int id)
        {
            //var userId = User.Identity.GetUserIdentity();
            return View(); 
        }

        public ActionResult ChangePickUp()
        {
            var model = new ChangePickupViewModel();
            return View(model);
        }
      
    }
}