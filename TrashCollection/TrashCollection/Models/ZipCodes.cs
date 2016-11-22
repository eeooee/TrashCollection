using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollection.Models
{
    public class ZipCodes
    {
        [Key]
        public int ID { get; set; }
        public int zipCode { get; set; }
    }
}