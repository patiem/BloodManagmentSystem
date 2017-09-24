using BloodManagmentSystem.Models;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BloodManagmentSystem.Services
{
    public class MyEmailService
    {
        public async Task<bool> SendEmailAsync(IEnumerable<Donor> donors, ControllerContext context)
        {
            var from = new MailAddress("bms.mailingservice@gmail.com");
            foreach (var donor in donors)
            {
                var to = new MailAddress(donor.Email);

                using (var mail = new MailMessage(from, to))
                {
                    mail.Subject = "BMS blood donation confirm";
                    mail.Body = RenderViewToString(context, "~/Views/Email/confirmation.cshtml", donor);
                    mail.IsBodyHtml = true;

                    using (var client = new SmtpClient())
                    {
                        await client.SendMailAsync(mail);
                    }
                }
            }

            return true;
        }

        public string RenderViewToString<T>(ControllerContext context, string viewPath, T model)
        {
            var viewEngineResult = ViewEngines.Engines.FindView(context, viewPath, null);

            var view = viewEngineResult.View;
            context.Controller.ViewData.Model = model;

            string result;

            using (var sw = new StringWriter())
            {
                var viewContext = new ViewContext(context, view, context.Controller.ViewData, context.Controller.TempData, sw);
                view.Render(viewContext, sw);

                result = sw.ToString();
            }

            return result;
        }
    }
}