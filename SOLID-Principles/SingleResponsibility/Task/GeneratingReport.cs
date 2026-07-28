using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SOLID_Principles.SingleResponsibility.Task
{
    internal class GeneratingReport
    {
        private Employee Employee;
        public GeneratingReport(Employee employee)
        {
            this.Employee = employee;
        }
        public void GenerateReport()
        {
            Console.WriteLine($"Report for {Employee.Name}: Salary = {Employee.BaseSalary}");
        }
    }
}
