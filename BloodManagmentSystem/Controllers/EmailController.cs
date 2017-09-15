using BloodManagmentSystem.Services;
using BloodManagmentSystem.ViewModel;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BloodManagmentSystem.Controllers
{
    public class EmailController : Controller
    {
        // GET
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

            var emailService = new MyEmailService();
            await emailService.SendEmailAsync(model.To, model.Message, model.Subject);
            return RedirectToAction("Index");
        }
    }
}