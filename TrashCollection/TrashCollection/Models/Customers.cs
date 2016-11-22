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
        int ID { get; set; }
        [ForeignKey("Vacation")]
        int vacation_id { get; set; }
        Vacation vacation { get; set; }
        [ForeignKey("Addresses")]
        int address_id { get; set; }
        Addresses addresses { get; set; }
        [ForeignKey("Pickup")]   
        int pickup_id { get; set; }
        Pickup pickup { get; set; }
        string fullName { get; set; }
        string nickName { get; set; }
        double accountBalance { get; set; }

    }
}