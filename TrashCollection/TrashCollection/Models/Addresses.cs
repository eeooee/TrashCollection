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
        public int ID { get; set; }
        [ForeignKey("zipCodes")]
        public int zip_code_id { get; set; }
        public ZipCodes zipCodes { get; set; }
        public string street_address_line1 { get; set; }
        public string street_address_line2 { get; set; }
        public int city_id { get; set; }
        public int state_id { get; set; }

    }
}