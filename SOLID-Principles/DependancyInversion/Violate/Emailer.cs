using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.DependancyInversion.Violate
{
    internal class Emailer
    {
        public Emailer() { }
        public void SendEmail(string  message)
        {
            // Code to send email
            Console.WriteLine($"Sending email with body: {message}");
        }
    }
}
