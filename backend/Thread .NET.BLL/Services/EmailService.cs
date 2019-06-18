using MimeKit;
using MailKit.Net.Smtp;
using System.Threading.Tasks;
using Thread_.NET.DAL.Context;
using AutoMapper;
using Thread_.NET.BLL.Services.Abstract;

namespace Thread_.NET.BLL.Services
{
    public class EmailService: BaseService
    {
        public EmailService(ThreadContext context, IMapper mapper) : base(context, mapper) { }
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("THREAD.NET", "tatiana.gutiy@gmail.com"));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.gmail.com", 587, false);
                await client.AuthenticateAsync("tania.gutiy@gmail.com", "bot123tania123");
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }
        }
    }
}
