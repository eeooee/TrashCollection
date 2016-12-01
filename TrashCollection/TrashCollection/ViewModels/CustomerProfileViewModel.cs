using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashCollection.Models;

namespace TrashCollection.ViewModels
{
    public class CustomerProfileViewModel
    {
        public Customers customer { get; set; }
        public States states { get; set; }
        public string FullName { get; set; }
        public string NickName { get; set; }


        [Required(ErrorMessage = "Please enter an address.")]
        public string StreetAddress { get; set; }

        public string StreetAddress2 { get; set; }


        [Display(Name = "State")]
        [Required(ErrorMessage = "Please select a state.")]
        public int selectedStateId { get; set; }
        public IEnumerable<SelectListItem> StatesList { get; set; }
        [Required(ErrorMessage = "Please enter a Zip Code.")]
        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid Zip")]
        public ZipCodes zipCode { get; set; }
    }
}