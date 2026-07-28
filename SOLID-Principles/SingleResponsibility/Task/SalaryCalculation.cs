using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.SingleResponsibility.Task
{
    internal class SalaryCalculation
    {

        private Employee Employee;
        public SalaryCalculation(Employee employee)
        {
            this.Employee = employee;
        }
        public double CalculateSalary()
        {
            return Employee.BaseSalary * 1.1;
        }

    }
}
