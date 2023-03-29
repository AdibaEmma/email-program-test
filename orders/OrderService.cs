using System.Collections.Generic;
using System.Linq;

namespace EmailSenderProgram.orders
{
    public class OrderService : IOrderService
    {
        public List<string> GetCustomersWithNoOrders(List<Order> orders, List<string> allCustomers)
        {
            // Get a list of all unique customer emails from the orders
            var customersWithOrders = orders.Select(order => order.CustomerEmail).Distinct().ToList();

            // Find the customers who haven't placed any orders
            var customersWithNoOrders = allCustomers.Except(customersWithOrders).ToList();

            return customersWithNoOrders;
        }
    }
}