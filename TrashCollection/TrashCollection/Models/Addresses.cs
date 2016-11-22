using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollection.Models
{
    public class Addresses
    {
        [Key]
        int ID { get; set; }
        [ForeignKey("zipCodes")]
        int zip_code_id { get; set; }
        ZipCodes zipCodes { get; set; }
        string street_address_line1 { get; set; }
        string street_address_line2 { get; set; }
        int city_id { get; set; }
        int state_id { get; set; }

    }
}