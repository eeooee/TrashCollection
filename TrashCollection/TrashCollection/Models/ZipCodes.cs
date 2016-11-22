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
        int ID { get; set; }
        int zipCode { get; set; }
    }
}