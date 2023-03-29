using System;
using System.Collections.Generic;
using EmailSenderProgram;
using EmailSenderProgram.customers;
using EmailSenderProgram.email;
using EmailSenderProgram.orders;

namespace EmailSenderProgram
{
    internal class Program
	{
		/// <summary>
		/// This application is run everyday
		/// </summary>
		/// <param name="args"></param>
		 static void Main(string[] args)
        {
			IEmailService emailService = new EmailService();
			ICustomerService customerService = new CustomerService();
			IOrderService orderService = new OrderService();

            INotificationService notificationService = new NotificationService(
                    emailService,
					customerService,
					orderService
                );

			var success = false;
            try
			{
				Console.WriteLine("Sending Welcome mail...");
                success = notificationService.SendWelcomeMails();

#if DEBUG
                Console.WriteLine("Sending Comeback mail...");
                success = notificationService.SendComebackMails();
#else
                if (DateTime.Now.DayOfWeek.Equals(DayOfWeek.Monday))
				{
					Console.WriteLine("Sending Comeback mail...");
					success = notificationService.SendComebackMails();
				}
#endif


                Console.WriteLine(success
                    ? "All mails are sent successfully!"
                    : "Oops, something went wrong while sending mails...");
            }
			catch (Exception ex)
			{
				Console.WriteLine("Oops, something went wrong: " + ex.Message);
			}

			Console.ReadKey();
		}
    }
}