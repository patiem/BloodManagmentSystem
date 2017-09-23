using BloodManagmentSystem.Models;
using System.Net.Mail;
using System.Threading.Tasks;

namespace BloodManagmentSystem.Services
{
    public class MyEmailService
    {
        public async Task<bool> SendEmailAsync(string modelMessage, string modelSubject, Donor donor)
        {
            var from = new MailAddress("bms.mailingservice@gmail.com");
            var to = new MailAddress(donor.Email);

            using (var mail = new MailMessage(from, to))
            {
                mail.Subject = modelSubject;
                mail.Body = modelMessage;
                mail.IsBodyHtml = true;

                using (var client = new SmtpClient())
                {
                    await client.SendMailAsync(mail);
                }
            }
            return true;
        }
    }
}