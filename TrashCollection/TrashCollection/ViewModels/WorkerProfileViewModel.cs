using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrashCollection.Models;

namespace TrashCollection.ViewModels
{
    public class WorkerProfileViewModel
    {
        public Workers workers { get; set; }
        public string FullName { get; set; }
        public string NickName { get; set; }

    }
}