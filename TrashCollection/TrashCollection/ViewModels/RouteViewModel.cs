using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrashCollection.Models;

namespace TrashCollection.ViewModels
{
    public class RouteViewModel
    {
        public int ZipCode { get; set; }
        public List<Customers> Customers { get; set; }
    }
}