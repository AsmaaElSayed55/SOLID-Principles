using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.FinalTask
{
    public class Order
    {

        public int Id { get; set; }
        public string CustomerEmail { get; set; }
        public int Amount { get; set; }
        public IPaymentMethod PaymentType { get; set; } // "CreditCard", "PayPal", "Crypto"
        public INotifier NotifyVia { get; set; }   // "Email", "SMS" 
        public Order()
        {

        }
        public Order(int id,int amount,string customerEmail)
        {
            Id= id;
            Amount= amount;
            CustomerEmail= customerEmail;

            OrderValidator orderValidator = new OrderValidator();
            orderValidator.Validate(Amount);
        }
    }
}
