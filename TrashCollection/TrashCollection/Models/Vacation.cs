﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollection.Models
{
    public class Vacation
    {
        [Key]
        public int ID { get; set; }
        public bool on_vacation { get; set; }
        public DateTime returnDate { get; set; }

    }
}