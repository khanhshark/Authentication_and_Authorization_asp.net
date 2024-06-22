using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Managerment.Service.Models;

namespace User.Managerment.Service.Services
{
    public class EmailServices : IEmailServices
    {
        private readonly EmailConfiguration emailConfig;
        public EmailServices(EmailConfiguration EmailConfig) => emailConfig = EmailConfig;
        public void SendEmail(Message message)
        {
           
            var emailMessage = CreateEmailMessage(message);
            Send(emailMessage);
        }

        private void Send(MimeMessage EmailMessage)
        {
            using var client = new SmtpClient();
            try
            {
                client.Connect(emailConfig.SmtpServer, emailConfig.Port, true);
                client.AuthenticationMechanisms.Remove("XOAUTH2");
                client.Authenticate(emailConfig.UserName, emailConfig.Password);
                client.Send(EmailMessage);
            }
            catch
            {
                throw;
            }
            finally
            {
                client.Disconnect(true);
                client.Dispose();
            }

        }

        private MimeMessage CreateEmailMessage(Message message)
        {
            var EmailMessage = new MimeMessage();
            EmailMessage.From.Add(new MailboxAddress("email", emailConfig.Form));
            EmailMessage.To.AddRange(message.To);
            EmailMessage.Subject = message.Subject;
            EmailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Text) { Text = message.Content };
            return EmailMessage;
        }
    }
}
