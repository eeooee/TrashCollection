using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollection.Models
{
    public class Customers
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("vacation")]
        public int vacation_id { get; set; }
        public Vacation vacation { get; set; }
        [ForeignKey("addresses")]
        public int address_id { get; set; }
        public Addresses addresses { get; set; }
        [ForeignKey("pickup")]
        public int pickup_id { get; set; }
        public Pickup pickup { get; set; }
        public string fullName { get; set; }
        public string nickName { get; set; }
        public double accountBalance { get; set; }

    }
}