using Microsoft.AspNetCore.Identity.UI.Services;

namespace Games_project.Utilities
{
    public class Emailsender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Task.CompletedTask;
        }
    }
}
