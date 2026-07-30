using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.FinalTask
{
    public class WhatsAppNotifier : INotifier
    {
        private string PhoneNum;

        public WhatsAppNotifier(string phoneNum)
        {
            PhoneNum = phoneNum;
        }
        public void Notify(string message)
        {
            Console.WriteLine($"Sending this {message} to phone {PhoneNum}");

        }
    }
}
