using Microsoft.AspNetCore.Mvc;
using MongoShopping.Services.MailServices;

namespace MongoShopping.Controllers
{
    public class MailController : Controller
    {
        private readonly IMailService _mailSender;

        public MailController(IMailService mailSender)
        {
            _mailSender = mailSender;
        }

        [HttpPost]
        public async Task<IActionResult> SendMail(string email)
        {
            if (!string.IsNullOrEmpty(email))
            {
                await _mailSender.SendEmailAsync(email, "Kupon Mesajı", "merhaba,hesabınıza %20 lik indirim kuponu tanımlanmıştır kod 254585 dir ");
                TempData["MailStatus"] = "Mail başarıyla gönderildi.";
            }
            else
            {
                TempData["MailStatus"] = "Lütfen mail adresi giriniz.";
            }

            // Geldiği sayfaya yönlendir
            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}
