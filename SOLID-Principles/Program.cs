
using SOLID_Principles.LiskovSubstitution.Apply;
using SOLID_Principles.LiskovSubstitution.Apply.Ex_2_Interface;
using SOLID_Principles.LiskovSubstitution.Violate.Ex_1_Inheritance;
using SOLID_Principles.SemiFinalTask;
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

        static void LiskovSubstitution()
        {
            SOLID_Principles.LiskovSubstitution.Violate.Ex_1_Inheritance.Rectangle square = new SOLID_Principles.LiskovSubstitution.Violate.Ex_1_Inheritance.Square(); // reference of base(parent) class pointing to derived(child) class

            square.Width = 5;
            square.Height = 10;

            Console.WriteLine(square.GetArea()); // Expected: 50, Actual: 100

            square.Width = 5;

            Console.WriteLine(square.GetArea()); // expected: 50, Actual: 25
        }

        static void LiskovSubstitutionApply()
        {
            Shape rect = new SOLID_Principles.LiskovSubstitution.Apply.Rectangle { Width = 5, Height = 10 };

            Shape square = new SOLID_Principles.LiskovSubstitution.Apply.Square { Side = 7 };

            Console.WriteLine(rect.GetArea());
            Console.WriteLine(square.GetArea());
        }
        static void LiskovSubstitutionApplyStartBike(IBike bike)
        {
            bike.Speed();
            bike.TurnOnEngine();
            Console.WriteLine("///////////////////");
        }

        static void SemiFinalTask()
        {            

            PayPal payPal = new PayPal();
            payPal.ProcessPayment(100.0);
            payPal.Logging(payPal, 100.0);
            payPal.SendReceipt(payPal);


            CreditCard creditCard = new CreditCard();
            creditCard.ProcessPayment(200.9);
            creditCard.Logging(creditCard, 200.9);
            creditCard.SendReceipt(creditCard);

            Crypto crypto = new Crypto();
            crypto.ProcessPayment(400.0);
            crypto.Logging(crypto, 400.0);
            crypto.SendReceipt(crypto);
        }
        static void Main(string[] args)
        {

            #region Single Responsibility 

            //  TaskOfSingleResponsibility();

            #endregion

            #region Open Closed



            #endregion

            #region LiskovSubstitution

          //  LiskovSubstitution();

            #endregion

            #region LiskovSubstitution Apply

          //  LiskovSubstitutionApply();

            IBike motorBike = new MotorBike();
           // LiskovSubstitutionApplyStartBike(motorBike);

            IBike bicycle = new Bicycle();
           // LiskovSubstitutionApplyStartBike(bicycle);

            #endregion

            #region MyRegion

            SemiFinalTask();

            #endregion

        }
    }
}
