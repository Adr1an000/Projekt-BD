using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using MailKit.Security;
using System.Net.Mail;
using SmtpClient = System.Net.Mail.SmtpClient;

namespace InformacjeTurystyczne.Controllers
{
    public class MailController : Controller
    {
        public IActionResult Index()
        {
            /*
            var message = new MimeMessage();

            message.From.Add(new MailboxAddress("Informacje turystyczne", "informacjeturystyczne.projekt@zohomail.eu"));

            message.To.Add(new MailboxAddress("Pawel", "pawel.s.ps777@gmail.com"));

            message.Subject = "Nowe wydarzenie!";

            message.Body = new TextPart("plain")
            {
                Text = "Zaaszły zmiany w wydarzeniu którym się interesujesz!"
            };

            using(var client = new SmtpClient())
            {
                client.Connect("smtp.zoho.com", 465, false);

                client.Authenticate("informacjeturystyczne.projekt@zohomail.eu", "InfTur123");

                client.Send(message);

                client.Disconnect(true);
            }
            */
           
            {
                MailMessage message = new System.Net.Mail.MailMessage("informacjeturystyczne.projekt@zohomail.eu", "pawel.s.ps777@gmail.com");

                message.Subject = "test";

                SmtpClient smtp = new SmtpClient();
               // smtp.UseDefaultCredentials = false;
                smtp.Host = "smtp.zoho.com";
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("informacjeturystyczne.projekt@zohomail.eu", "InfTur123");
                smtp.EnableSsl = true;
                message.IsBodyHtml = true;
                smtp.Send(message);
            }
            

            return View();
        }
    }
}