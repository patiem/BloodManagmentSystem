using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BloodManagmentSystem.Models;

namespace BloodManagmentSystem.ViewModels
{
    public class BloodRequestFormViewModel
    {
        public BloodType BloodType { get; set; }
        public DateTime DueDate { get; set; }
        public string Bank { get; set; }
        public string City { get; set; }
    }
}