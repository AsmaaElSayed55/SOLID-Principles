using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.FinalTask
{
    public class EmailNotifier : INotifier
    {
        private string CustomerEmail;

        public EmailNotifier(string customerEmail)
        {
            CustomerEmail = customerEmail;
        }

        public void Notify(string message)
        {
            Console.WriteLine($"Sending this {message} to email {CustomerEmail}");
        }
    }
}
