namespace Lumina_Hospital.Services.Abstract
{
    public interface ISendEmail
    {
        public void SendEmail(string email, string subject, string url, string templatePath);
    }
}
