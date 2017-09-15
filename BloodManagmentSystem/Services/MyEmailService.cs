using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace BloodManagmentSystem.Services
{
    public class MyEmailService
    {
        public async Task<bool> SendEmailAsync(string modelTo, string modelMessage, string modelSubject)
        {
            var from = new MailAddress("cbmlody@gmail.com");
            var to = new MailAddress(modelTo);

            const string host = "smtp.gmail.com";

            const string userName = "cbmlody@gmail.com";
            const string password = "Gr4phicu$";
            bool.TryParse("true", out var enableSsl);
            bool.TryParse("false", out var useDefaultCredentials);

            int.TryParse("587", out var port);

            using (var mail = new MailMessage(from, to))
            {
                mail.Subject = modelSubject;
                mail.Body = modelMessage;
                mail.IsBodyHtml = true;

                using (var client = new SmtpClient())
                {
                    client.Host = host;
                    client.EnableSsl = enableSsl;
                    client.Port = port;
                    client.UseDefaultCredentials = useDefaultCredentials;

                    if (!client.UseDefaultCredentials && !string.IsNullOrEmpty(userName) &&
                        !string.IsNullOrEmpty(password))
                    {
                        client.Credentials = new NetworkCredential(userName, password);
                    }

                    await client.SendMailAsync(mail);
                }
            }
            return true;
        }
    }
}