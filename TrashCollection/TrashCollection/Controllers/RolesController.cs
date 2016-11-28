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
                return RedirectToAction("Portal");

            }
            catch { return View();
            }
        }

        public ActionResult Delete(string RoleName)
        {
            var thisRole = context.Roles.Where(r => r.Name.Equals(RoleName, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();
            context.Roles.Remove(thisRole);
            context.SaveChanges();
            return RedirectToAction("Portal");
        }

        public ActionResult Manage()
        {
            var list = context.Roles.OrderBy(r => r.Name).ToList().Select(rr =>
              new SelectListItem { Value = rr.Name.ToString(), Text = rr.Name }).ToList();
            ViewBag.Roles = list;
            return View();
        }
    }
}