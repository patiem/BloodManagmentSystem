using BloodManagmentSystem.Models;
using BloodManagmentSystem.Repositories;
using Postal;
using System.Web.Mvc;

namespace BloodManagmentSystem.Controllers
{
    public class EmailController : Controller
    {
        private readonly IDonorRepository _donorRepository;

        public EmailController()
        {
            _donorRepository = new DonorRepository();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Preview()
        {
            dynamic email = new DonorConfirmationEmail("Confirmation")
            {
                Donor = new Donor
                {
                    BloodType = BloodType.AB_Rh_minus,
                    City = "Krakow",
                    Email = "cbmlody@gmail.com",
                    Id = 1,
                    Name = "Edward"
                }
            };

            return new EmailViewResult(email);
        }

        public ActionResult SendEmail(BloodType bloodType)
        {
            var donors = _donorRepository.GetAvailableDonorsWithMatchingBloodType(bloodType);

            foreach (var donor in donors)
            {
                dynamic email = new DonorConfirmationEmail("Confirmation")
                {
                    Donor = donor
                };
                email.Send();
            }

            return RedirectToAction("Index", "Email");
        }
    }
}