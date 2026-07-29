using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.SemiFinalTask
{
    public class PayPal : PaymentType , IPaymentType , ISendingReceipt
    {
        public void ProcessPayment( double amount)
        {
            Console.WriteLine($"Processing PayPal payment of {amount}");
        }

        override public void Logging(IPaymentType paymentType, double amount)
        {
            Console.WriteLine($"Logged: {paymentType} payment of {amount} at {DateTime.Now}");
        }

        public void SendReceipt(IPaymentType paymentType)
        {
            Console.WriteLine($"Sending receipt to {paymentType}");
        }
    }
}
