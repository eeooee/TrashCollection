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
        int ID { get; set; }
        [ForeignKey("ZipCodes")]
        int zip_code_id { get; set; }
        ZipCodes zipCodes { get; set; }
        string fullName { get; set; }
        string nickName { get; set; }
    }
}