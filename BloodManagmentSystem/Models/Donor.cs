using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BloodManagmentSystem.Models
{
    public class Donor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public BloodType BloodType { get; set; }
    }
}