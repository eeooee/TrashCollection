using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashCollection.Models;


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
            var zipCodes = context.zipCodes.AsEnumerable().ToList();
            return View(new PortalViewModel { ZipCodes = zipCodes });
        }

        public ActionResult GetRoute()
        {
            Workers workerList = new Workers();
          
            return View();  //Return specific view "Workers"
        }

        public ActionResult RouteList()
        {
           
            return View();
        }

        public ActionResult RouteMap()
        {
            return View();
        }
    }
}