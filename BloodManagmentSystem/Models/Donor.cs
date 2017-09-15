using System.ComponentModel.DataAnnotations;

namespace BloodManagmentSystem.Models
{
    public class Donor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Your name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The email address is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The city is required.")]
        [StringLength(50)]
        public string City { get; set; }

        [Required(ErrorMessage = "Choose your blood type, please.")]
        public BloodType BloodType { get; set; }
    }
}