using BloodManagmentSystem.Models;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web.Mvc;
using BloodManagmentSystem.ViewModel;

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
        public async Task<ActionResult> Index(EmailFormModel emailForm)
        {
            if (!ModelState.IsValid)
            {
                return View(emailForm);
            }
            var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
            var message = new MailMessage();
            message.To.Add(new MailAddress(emailForm.FormEmail));
            message.From = new MailAddress(emailForm.FormEmail, emailForm.FormName);
            message.Subject = "Test Mail from BMS";
            message.Body = string.Format(body, emailForm.FormName, emailForm.FormEmail, emailForm.Message);
            message.IsBodyHtml = true;

            using (var smtp = new SmtpClient())
            {
                await smtp.SendMailAsync(message);
                return RedirectToAction("Sent");
            }
        }

        public ActionResult Sent()
        {
            return View();
        }
    }
}