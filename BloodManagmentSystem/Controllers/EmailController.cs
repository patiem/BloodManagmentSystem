﻿using BloodManagmentSystem.Models;
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

            var donor = new Donor("Mike", "cbmlody@gmail.com");
            model.To = donor.Email;
            model.Subject = "BMS request confirmation mail";
            var emailService = new MyEmailService();
            await emailService.SendEmailAsync(model.To, model.Message, model.Subject);

            return RedirectToAction("Index");
        }
    }
}