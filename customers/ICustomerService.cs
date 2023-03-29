using System.Collections.Generic;

namespace EmailSenderProgram.customers
{
    public interface ICustomerService
    {
        List<Customer> GetNewlyRegisteredCustomers(int daysBeforeCurrentDay);
    }
}   