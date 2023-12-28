using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace FoodOrder.Controllers
{

    [Authorize]
    public class EmailController : ControllerBase
    {
        [HttpPost]
        public string SendEmail(string gmail,string firstname, string phoneNumber, string adress)
        {

            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("aisha.jones@ethereal.email"));
            email.To.Add(MailboxAddress.Parse("aisha.jones@ethereal.email"));
            email.Subject = "FastEat";
            email.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text =$"{firstname}/{phoneNumber}/{adress}/ Merhaba Siparişini aldık, hemen geliyoruz"
            };

            using var smtp = new SmtpClient();
            smtp.Connect("smtp.ethereal.email", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("aisha.jones@ethereal.email", "yS45a8XJyenUN9FTHx");
            smtp.Send(email);
            smtp.Disconnect(true);


            return "ok";
        }
    }
}

