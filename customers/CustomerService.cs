using System;
using System.Collections.Generic;
using System.Linq;

namespace EmailSenderProgram.customers
{
    internal class CustomerService : ICustomerService
    {
        private readonly List<Customer> _customers = DataLayer.ListCustomers();
        public List<Customer> GetNewlyRegisteredCustomers(int daysBeforeCurrentDay)
        {
            // Calculate the date range to look for newly registered customers
            var startDate = DateTime.Now.AddDays(-daysBeforeCurrentDay);

            // Filter the list of customers to get those registered within the date range
            var newlyRegisteredCustomers = _customers.Where(c => c.CreatedDateTime >= startDate).ToList();

            return newlyRegisteredCustomers;
        }
    }
}
