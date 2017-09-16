using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using BloodManagmentSystem.Models;

namespace BloodManagmentSystem.ViewModels
{
    public class BloodRequestFormViewModel
    {
        [Range(1, int.MaxValue, ErrorMessage = "Select type")]
        public BloodType BloodType { get; set; }
        public DateTime DueDate { get; set; }
        public int Bank { get; set; }
        public string City { get; set; }
        public IEnumerable<BloodBank> Banks { get; set; }
        //public IEnumerable<BloodType> BloodTypes { get; set; }

//        public BloodRequestFormViewModel()
//        {
//            BloodTypes = Enum.GetValues(typeof(BloodType)).Cast<BloodType>();
//        }
    }
}