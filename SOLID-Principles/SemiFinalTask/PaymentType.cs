using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.SemiFinalTask
{
    public class PaymentType 
    {
        public virtual void Logging(IPaymentType paymentType, double amount)
        {
            Console.WriteLine($"Logged: {paymentType} payment of {amount} at {DateTime.Now}");
        }
    }
}
