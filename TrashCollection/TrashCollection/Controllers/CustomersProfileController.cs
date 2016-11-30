using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using TrashCollection.Models;
using TrashCollection.Migrations;
using System.Data;
using TrashCollection.ViewModels;
using System.Collections.Generic;

namespace TrashCollection.Controllers
{
    public class CustomersProfileController : Controller
    {
       ApplicationDbContext context;

        // GET: CustomersProfile
        public ActionResult _CustomersProfile()
        {
            var model = new CustomerProfileViewModel();
            var states = GetAllStates();
            model.StatesList = GetSelectListItems(states);
            return PartialView(model);
        }

        
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult _CustomersProfile(CustomerProfileViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var address = new Addresses
                {
                    street_address_line1 = model.StreetAddress,
                    street_address_line2 = model.StreetAddress2,
                    zipCodes = model.zipCode,
                    state_id = model.selectedStateId,
                };

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        private IEnumerable<States> GetAllStates()
        {
            List<States> statesList = new List<States>();
            foreach (States state in context.states)
            {
                statesList.Add(state);

            }
            return statesList;
        }
        private IEnumerable<SelectListItem> GetSelectListItems(IEnumerable<States> elements)
        {
            var selectList = new List<SelectListItem>();
            foreach (var element in elements)
            {
                selectList.Add(new SelectListItem
                {
                    Value = element.ID.ToString(),
                    Text = element.name,
                });
            }
            return selectList;
        }
    }

}