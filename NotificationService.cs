using System;
using System.Linq;
using EmailSenderProgram.customers;
using EmailSenderProgram.email;
using EmailSenderProgram.orders;

namespace EmailSenderProgram
{
    public class NotificationService : INotificationService
    {
        private readonly IOrderService _orderService;
        private readonly IEmailService _emailService;
        private readonly ICustomerService _customerService;

        public NotificationService(IEmailService emailService, ICustomerService customerService, IOrderService orderService)
        {
            this._emailService = emailService;
            this._customerService = customerService;
            this._orderService = orderService;
        }

        /// <summary>
        /// Send Welcome mail
        /// </summary>
        /// <returns>boolean</returns>
        public bool SendWelcomeMails()
        {
            try
            {
                var newlyRegisteredCustomers = this._customerService.GetNewlyRegisteredCustomers(1);

                newlyRegisteredCustomers.ForEach(customer =>
                {
                    this._emailService.SendEmail(customer.Email, EmailType.Welcome);
                });


                //All mails are sent! Success!
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool SendComebackMails()
        {
            try
            {

                var customers = DataLayer.ListCustomers();
                var orders = DataLayer.ListOrders();

                var customersEmailList = customers.Select(customer => customer.Email).ToList();

                var customersWIthNoOrders = this._orderService.GetCustomersWithNoOrders(orders, customersEmailList);
                customersWIthNoOrders.ForEach(customerEmail =>
                {
                    this._emailService.SendEmail(customerEmail, EmailType.Comeback);
                });
				
                //All mails are sent! Success!
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}