using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.FinalTask
{
    public class OrderLogger :IOrderLogger
    {
        private Order order;
        public OrderLogger()
        {
            order=new Order();
        }
        public void Log(string message)
        {
            // Log the order details to a file or database
            Console.WriteLine($"Order {order.Id} logged at {DateTime.Now}");
        }
    }
}
