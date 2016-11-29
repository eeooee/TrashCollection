using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrashCollection.Models;

namespace TrashCollection.ViewModels
{
    public class ChangePickupViewModel
    {
        public Pickup pickup { get; set; }
        public DayOfWeek days { get; set; }
    }
}