using System.Net.Mail;
using System.Net;
using Microsoft.Extensions.Configuration;

namespace MongoShopping.Services.MailServices
{
    public class MailService : IMailService
    {
        private readonly string _from;
        private readonly string _smtpUser;
        private readonly string _smtpPass;

        public MailService(IConfiguration configuration)
        {
            _from = configuration["MailSettings:From"];
            _smtpUser = configuration["MailSettings:SmtpUser"];
            _smtpPass = configuration["MailSettings:SmtpPass"];
        }

        public Task SendEmailAsync(string email, string subject, string message)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_smtpUser, _smtpPass)
            };

            var mailMessage = new MailMessage(from: _from, to: email, subject, message);
            return client.SendMailAsync(mailMessage);
        }
    }
}
