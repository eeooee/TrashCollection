using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashCollection.Models;
using System.Data.Entity;

namespace TrashCollection.Controllers
{
    public class RolesController : Controller
    {
        ApplicationDbContext context; 

        public RolesController()
        {
            context = new ApplicationDbContext();
        }

        public ActionResult Portal()
        {
            var roles = context.Roles.ToList();
            return View(roles);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Create(FormCollection collection)
        {
           try
            {
                
                context.Roles.Add(new IdentityRole()
                {
                    Name = collection["RoleName"]
                });
                context.SaveChanges();
                ViewBag.ResultMessage = "Role Created Successfully!";
                return RedirectToAction("Index");

            }
            catch { return View();
            }
        }
    }
}