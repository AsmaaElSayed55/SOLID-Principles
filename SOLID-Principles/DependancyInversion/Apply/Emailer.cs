using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.DependancyInversion.Apply
{
    internal class Emailer : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending email with body: {message}");
        }
    }
}
