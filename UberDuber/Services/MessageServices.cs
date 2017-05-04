using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Configuration;
using System.Net;

namespace UberDuber.Services
{
    // This class is used by the application to send Email and SMS
    // when you turn on two-factor authentication in ASP.NET Identity.
    // For more details see this link https://go.microsoft.com/fwlink/?LinkID=532713
   public class AuthMessageSender : IEmailSender, ISmsSender
    {
        public AuthMessageSender(IOptions<AuthMessageSenderOptions> optionsAccessor)
        {
            Options = optionsAccessor.Value;
        }
        public AuthMessageSenderOptions Options { get; } //set only via Secret Manager
        public Task SendEmailAsync(string email, string subject, string message)
        {
            SendAsync(email, subject, message).Wait();
            return Task.FromResult(0);
        }

        public async Task SendAsync(string email, string subject, string message)
        {
            var sentFrom = "andrewmoore46@gmail.com";
            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            var gmailUser = Options.gmailUser;
            var gmailPassword = Options.gmailPassword;
            System.Net.NetworkCredential credentials = new NetworkCredential(
                 gmailUser,
                 gmailPassword
                 );
            client.EnableSsl = true;
            client.Credentials = credentials;
            var mail = new System.Net.Mail.MailMessage(sentFrom,email);
            mail.Subject = subject;
            mail.Body = message;
            await client.SendMailAsync(mail);
        }

        public Task SendSmsAsync(string number, string message)
        {
            var accountSid = Options.accountSid;
            var authToken = Options.authToken;
            TwilioClient.Init(accountSid, authToken);
            var msg = MessageResource.Create(
              to: new PhoneNumber(number),
              from: new PhoneNumber("+1(613)9021242"),
              body: message);
            return Task.FromResult(0);
        }
    }
}





