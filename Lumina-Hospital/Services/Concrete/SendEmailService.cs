using Lumina_Hospital.Services.Abstract;
using System.Net.Mail;
using System.Net;

namespace Lumina_Hospital.Services.Concrete
{
    public class SendEmailService : ISendEmail
    {
        public void SendEmail(string email, string subject, string url, string templatePath)
        {
            MailMessage mailMessage = new();
            mailMessage.From = new MailAddress("orkhanqaragozov@gmail.com", "Lumina Hospital");
            mailMessage.To.Add(new MailAddress(email));
            mailMessage.Subject = subject;

            string body = string.Empty;
            using (StreamReader streamReader = new StreamReader(templatePath))
            {
                body = streamReader.ReadToEnd();
            }

            mailMessage.Body = body.Replace("{{link}}", url);
            mailMessage.IsBodyHtml = true;

            SmtpClient smtpClient = new();
            smtpClient.Port = 587;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential("orkhanqaragozov@gmail.com", "wrhi dcnt iiwo belq");
            smtpClient.Send(mailMessage);
        }
    }
}
