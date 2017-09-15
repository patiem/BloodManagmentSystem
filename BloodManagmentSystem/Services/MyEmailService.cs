﻿using System.Net.Mail;
using System.Threading.Tasks;

namespace BloodManagmentSystem.Services
{
    public class MyEmailService
    {
        public async Task<bool> SendEmailAsync(string modelTo, string modelMessage, string modelSubject)
        {
            var from = new MailAddress("bms.mailingservice@gmail.com");
            var to = new MailAddress(modelTo);

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