using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using MailKit.Security;

// TO BEDZIE DO WYWALENIA (TYLKO DLA TESTOW)
namespace InformacjeTurystyczne.Controllers
{
    public class MailController : Controller
    {
        public IActionResult Index()
        {
            
            var message = new MimeMessage();

            message.From.Add(new MailboxAddress("Informacje turystyczne", "informacje.turystyczne1@onet.pl"));

            message.To.Add(new MailboxAddress("Pawel", "pawel.s.ps777@gmail.com"));

            message.Subject = "Nowe wydarzenie!";

            message.Body = new TextPart("plain")
            {
                Text = "Zaaszły zmiany w wydarzeniu którym się interesujesz!"
            };

            using(var client = new SmtpClient())
            {
                client.Connect("smtp.poczta.onet.pl", 465, true);

                client.Authenticate("informacje.turystyczne1@onet.pl", "InfTur123");

                client.Send(message);

                client.Disconnect(true);
            }

            /*
             {
                 MailMessage message = new System.Net.Mail.MailMessage("informacje.turystyczne1@onet.pl", "pawel.s.ps777@gmail.com");

                 message.Subject = "test";

                 SmtpClient smtp = new SmtpClient();
                // smtp.UseDefaultCredentials = false;
                 smtp.Host = "smtp.poczta.onet.pl";
                 smtp.Port = 465;
                 smtp.Credentials = new System.Net.NetworkCredential("informacje.turystyczne1@onet.pl", "InfTur123");
                 smtp.EnableSsl = true;
                 message.IsBodyHtml = true;
                 smtp.Send(message);
             }
             */

            return View();
        }
    }
}