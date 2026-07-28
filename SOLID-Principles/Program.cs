using SOLID_Principles.SingleResponsibility.Task;

namespace SOLID_Principles
{
    internal class Program
    {
        static void TaskOfSingleResponsibility()
        {
            // Create an Employee
            Employee employee = new() 
            { 
                Name = "John Doe", 
                Email = "john.doe@example.com" ,
                BaseSalary = 50000
            };

            // Send an email to the employee
            SendingEmail sendingEmail = new SendingEmail(employee);
            sendingEmail.SendEmail();

            // Calculate the salary of the employee
            SalaryCalculation salaryCalculation = new SalaryCalculation(employee);
            double Salary = salaryCalculation.CalculateSalary();
            Console.WriteLine($"The Salary is {Salary}");

            // Save the employee's salary to the database
            SavingToDatabase saveEmployee = new SavingToDatabase(employee);
            saveEmployee.SaveToDatabase();


        }

        static void Main(string[] args)
        {

            #region Single Responsibility 

            TaskOfSingleResponsibility();

            #endregion



        }
    }
}
