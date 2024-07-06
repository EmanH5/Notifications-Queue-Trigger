using SendGrid.Helpers.Mail;
using SendGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationQueueTrigger
{
    public static class EmailService
    {
        public static async Task SendEmailAsync(string email, string subject, string body)
        {
            var apiKey = Environment.GetEnvironmentVariable("SENDGRID_API_KEY");
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("eman.hassan4747@gmail.com", "Eman Test Queue");
            var to = new EmailAddress(email);
            var msg = MailHelper.CreateSingleEmail(from, to, subject, body,null);
            await client.SendEmailAsync(msg);
        }
    }
}
