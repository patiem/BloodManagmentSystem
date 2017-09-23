using BloodManagmentSystem.Models;
using BloodManagmentSystem.Services;
using BloodManagmentSystem.ViewModels;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BloodManagmentSystem.Controllers
{
    public class EmailController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmailController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Index(EmailFormModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var donor = new Donor
            {
                Name = "Mike",
                Email = "cbmlody@gmail.com",
                Type = BloodType.A_Rh_plus
            };

            model.Subject = "BMS request confirmation mail";
            var emailService = new MyEmailService();
            await emailService.SendEmailAsync(model.Message, model.Subject, donor);

            return RedirectToAction("Index");
        }
    }
}