using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrashCollection.Models;

namespace TrashCollection.ViewModels
{
    public class CustomerProfileViewModel
    {
        public Customers customer { get; set; }
        public Addresses addresses { get; set; }
    }
}