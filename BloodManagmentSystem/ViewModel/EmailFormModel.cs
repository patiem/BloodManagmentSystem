using System.ComponentModel.DataAnnotations;

namespace BloodManagmentSystem.ViewModel
{
    public class EmailFormModel
    {
        [Required]
        public string FormName { get; set; }

        [Required]
        public string FormEmail { get; set; }

        [Required]
        public string Message { get; set; }
    }
}