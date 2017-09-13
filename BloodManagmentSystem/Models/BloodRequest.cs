using System;

namespace BloodManagmentSystem.Models
{
    public class BloodRequest
    {
        public int Id { get; set; }
        public BloodType BloodType { get; set; }
        public DateTime DueDate { get; set; }
        public string City { get; set; }
        public BloodBank Type { get; set; }

    }
}