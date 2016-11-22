using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollection.Models
{
    public class Pickup
    {
        [Key]
        int ID { get; set; }
        string daysOfWeek { get; set; }
       

    }
}