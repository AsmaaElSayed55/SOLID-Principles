using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.FinalTask
{
    public class PayPalPayment : IPaymentMethod
    {
        public void Pay(double amount)
        {
            Console.WriteLine("Charging PayPal...");

        }
    }
}
