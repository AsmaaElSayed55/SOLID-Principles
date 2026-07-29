using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.SemiFinalTask
{
    public class Crypto : PaymentType , IPaymentType ,ISendingReceipt
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing crypto payment of {amount}");
        }
        public void SendReceipt(IPaymentType paymentType)
        {
            Console.WriteLine($"Sending receipt to {paymentType}");
        }
        public override void Logging(IPaymentType paymentType, double amount)
        {
            Console.WriteLine($"Logged: {paymentType} payment of {amount} at {DateTime.Now}");
        }
    }
}
