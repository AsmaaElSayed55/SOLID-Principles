using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.SingleResponsibility.Task
{
    internal class SendingEmail
    {
        private Employee Employee;
        public SendingEmail(Employee employee)
        {
            this.Employee = employee;
        }
        public void SendEmail()
        {
            Console.WriteLine($"Sending email to {Employee.Email}...");
        }
    }
}
