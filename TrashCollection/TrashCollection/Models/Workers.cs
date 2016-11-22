using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollection.Models
{
    public class Workers
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("zipCodes")]
        public int zip_code_id { get; set; }
        public ZipCodes zipCodes { get; set; }
        public string fullName { get; set; }
        public string nickName { get; set; }
    }
}