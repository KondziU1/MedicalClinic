using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using Microsoft.Extensions.Configuration;
using SystemAdministrationModule.Models;
using SendGrid.SmtpApi;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace SystemAdministrationModule.Services
{
    public class EmailService
    {
        private readonly string senderEmail = "essa@ellstore.pl";
        private readonly string senderName = "Clinc EU";
        private readonly string smtpServer = "live.smtp.mailtrap.io";
        private readonly int smtpPort = 587;
        private readonly string smtpUsername = "api";
        private readonly string smtpPassword = "05d7f33be25b41fdd0adbf9e71cde811";

        public async Task SendVerificationEmail(string recipientEmail, string token)
        {
            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress(senderName, senderEmail));
            message.To.Add(new MailboxAddress("", recipientEmail));
            message.Subject = "Verify your email address";

            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = $"<p>Your verification token is: {token}</p>";
            message.Body = bodyBuilder.ToMessageBody();

            using (MailKit.Net.Smtp.SmtpClient client = new MailKit.Net.Smtp.SmtpClient())
            {
                await client.ConnectAsync(smtpServer, smtpPort, SecureSocketOptions.StartTls);
                await client.AuthenticateAsync(smtpUsername, smtpPassword);
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }
        }
        public async Task SendResetPasswordLinkEmail(string recipientEmail, string token, int userId)
        {
            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress(senderName, senderEmail));
            message.To.Add(new MailboxAddress("", recipientEmail));
            message.Subject = "Reset password";

            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = $"<p>Your reset password code is: {token}</p>";
            message.Body = bodyBuilder.ToMessageBody();

            using (MailKit.Net.Smtp.SmtpClient client = new MailKit.Net.Smtp.SmtpClient())
            {
                await client.ConnectAsync(smtpServer, smtpPort, SecureSocketOptions.StartTls);
                await client.AuthenticateAsync(smtpUsername, smtpPassword);
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }
        }

        public async Task SendEmail(string recipientEmail, string subject, string htmlBody)
        {
            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress(senderName, senderEmail));
            message.To.Add(new MailboxAddress("", recipientEmail));
            message.Subject = subject;

            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = $"<p>{htmlBody}</p>";
            message.Body = bodyBuilder.ToMessageBody();

            using (MailKit.Net.Smtp.SmtpClient client = new MailKit.Net.Smtp.SmtpClient())
            {
                await client.ConnectAsync(smtpServer, smtpPort, SecureSocketOptions.StartTls);
                await client.AuthenticateAsync(smtpUsername, smtpPassword);
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }
        }

        /*
        private readonly string _apiKey = "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";
        private readonly string _senderEmail;
        private readonly string _senderName;

        public EmailService(string senderEmail, string senderName)
        {
            _senderEmail = senderEmail;
            _senderName = senderName;
        }

        public void SendVerificationEmail(string recipientEmail, string token)
        {
            Configuration.Default.ApiKey.Add("api-key", _apiKey);
            var apiInstance = new TransactionalEmailsApi(Configuration.Default);

            // Prepare email message
            var subject = "Verify your email address";
            var textContent = $"Your verification token is: {token}";
            var sender = new SendSmtpEmailSender(_senderEmail, _senderName);
            var to = new List<SendSmtpEmailTo> { new SendSmtpEmailTo(recipientEmail) };
            var message = new SendSmtpEmail(sender, to, null, null, subject, textContent);

            // Send email message
            try
            {
                CreateSmtpEmail result = apiInstance.SendTransacEmail(message);
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling TransactionalEmailsApi.SendTransacEmail: " + e.Message);
            }
        }
        */

    }
}
