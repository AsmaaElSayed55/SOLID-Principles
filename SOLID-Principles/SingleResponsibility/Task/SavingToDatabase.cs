using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SOLID_Principles.SingleResponsibility.Task
{
    internal class SavingToDatabase
    {
        private Employee Employee;
        public SavingToDatabase(Employee employee)
        {
            this.Employee = employee;
        }
        public void SaveToDatabase()
        {
            Console.WriteLine($"Saving {Employee.Name} to database...");
        }

    }
}
