using Postal;

namespace BloodManagmentSystem.Models
{
    public class DonorConfirmationEmail : Email
    {
        public DonorConfirmationEmail(string viewName) : base(viewName)
        {
        }

        public Donor Donor { get; set; }
    }
}