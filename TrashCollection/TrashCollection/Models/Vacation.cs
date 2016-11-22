using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollection.Models
{
    public class Vacation
    {
        [Key]
        int ID { get; set; }
        bool on_vacation { get; set; }
        DateTime returnDate { get; set; }

    }
}