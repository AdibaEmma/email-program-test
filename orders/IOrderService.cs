using System.Collections.Generic;

namespace EmailSenderProgram.orders
{
    public interface IOrderService
    {
        List<string> GetCustomersWithNoOrders(List<Order> orders, List<string> allCustomers);


    }
}