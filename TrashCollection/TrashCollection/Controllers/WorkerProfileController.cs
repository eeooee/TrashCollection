using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashCollection.Models;
using TrashCollection.ViewModels;

namespace TrashCollection.Controllers
{
    public class WorkerProfileController : Controller
    {
        ApplicationDbContext context;
        public ActionResult WorkerProfile()
        {
            context = new ApplicationDbContext();
            var model = new WorkerProfileViewModel();
            return PartialView();
        }


        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult WorkerProfile(WorkerProfileViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return PartialView(model);
            }

            var worker = new Workers { nickName = model.NickName, fullName = model.FullName };
          
            return PartialView(model);

    }
    }
}