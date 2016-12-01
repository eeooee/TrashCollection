using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashCollection.Models;
using TrashCollection.ViewModels;

namespace TrashCollection.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDbContext context;

        public EmployeeController()
        {
            context = new ApplicationDbContext();
        }

        public ActionResult Portal()
        {
            return View();
        }

        public ActionResult GetRoute()
        {
            Workers workerList = new Workers();
          
            return View();  //Return specific view "Workers"
        }

        public ActionResult RouteList()
        {

            var zipCodes = context.zipCodes.AsEnumerable().ToList();
            return View(new RouteListViewModel { ZipCodes = zipCodes });
        
        


        }
        
        public ActionResult Route(int id)
        {

            //ViewBag.Message = zipCode;    
            //return View(new CustomerProfileViewModel { customer }   //comment out until method is written in customer controller

            // TODO: Filter customers further
            var zipCode = context.zipCodes.First(z => z.ID == id).zipCode;
            var customers = context.customers.Where(c => c.addresses.zip_code_id == id).ToList();

            return View(new RouteViewModel { ZipCode = zipCode, Customers = customers } );


        }

        public ActionResult RouteMap()
        {
            return View();
        }
    }
}