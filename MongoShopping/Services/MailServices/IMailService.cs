namespace MongoShopping.Services.MailServices
{
    public interface IMailService
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
