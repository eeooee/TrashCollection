using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollection.Models
{
    public class Pickup
    {
        [Key]
        public int ID { get; set; }
        public string daysOfWeek { get; set; }

    }
}