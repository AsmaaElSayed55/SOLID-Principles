using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.SemiFinalTask
{
    public class PaymentProcessor
    {
        public void Process(IPaymentType paymentType, double amount)
        {
            // Responsibility 1: validation
            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount");
                return;
            }       
           
        }
    }
}
