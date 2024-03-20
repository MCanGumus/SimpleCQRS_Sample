using Shared.Abstractions;
using Shared.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Concretes
{
    public class MailService : IMailService
    {
        public Task SendMessageAsync(string to, string subject, string body)
        {
            try
            {
                System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
                message.IsBodyHtml = true;
                message.Subject = subject;
                message.To.Add(to);
                message.From = new MailAddress("", "");

                SmtpClient client = new SmtpClient("smtp.sendgrid.net");
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("", "");
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Port = 587;
                client.Timeout = 99999;
                client.EnableSsl = false;

                client.Send(message);

                return Task.CompletedTask;
            }
            catch (Exception ex)
            {
                return Task.FromException(ex);
            }

        }
    }
}
