using System;
using System.Net.Mail;

namespace EmailSenderProgram.email
{
    public class EmailService : IEmailService
    {
        public void SendEmail(string email, EmailType type)
        {
            var mailMessage = new MailMessage();
            const string voucherSubject = "EOComebackToUs";


            try
            {
                mailMessage.From = new MailAddress("info@EO.com");
                mailMessage.To.Add(email);
                var subject = string.Empty;
                var mailBody = string.Empty;

                // Set subject and body based on email type
                switch (type)
                {
                    case EmailType.Welcome:
                        subject = "Welcome as a new customer at EO!";
                        mailBody = "Hi " + email +
                                           "<br>We would like to welcome you as customer on our site!<br><br>Best Regards,<br>EO Team";
                        break;
                    case EmailType.Comeback:
                         subject = "Come back to EO!";
                        mailBody = "Hi " + email +
                                           "<br>We miss you as a customer. Our shop is filled with nice products. Here is a voucher that gives you 50 kr to shop for." +
                                           "<br>Voucher: " + voucherSubject +
                                           "<br><br>Best Regards,<br>EO Team";
                        break;
                    default:
                        throw new ArgumentException("Invalid email type.");
                }

                mailMessage.Subject = subject;
                mailMessage.Body = mailBody;

#if DEBUG
                //Don't send mails in debug mode, just write the emails in console
                Console.WriteLine("Send mail to:" + email);
#else
					var smtp = new SmtpClient("yoursmtphost");
                    smtp.Send(mailMessage);
#endif


            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}