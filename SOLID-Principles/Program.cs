
using SOLID_Principles.DependancyInversion.Apply;
using SOLID_Principles.FinalTask;
using SOLID_Principles.InterfaceSeggrigation.Apply;
using SOLID_Principles.LiskovSubstitution.Apply;
using SOLID_Principles.LiskovSubstitution.Apply.Ex_2_Interface;
using SOLID_Principles.LiskovSubstitution.Violate.Ex_1_Inheritance;
using SOLID_Principles.SemiFinalTask;
using SOLID_Principles.SingleResponsibility.Task;
using System.Reflection;

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
            SingleResponsibility.Task.SavingToDatabase saveEmployee = new SingleResponsibility.Task.SavingToDatabase(employee);
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

        static void InterfaceSeggrigation()
        {
            Car car = new Car();
            car.StartEngine();
            car.StopEngine();

            Airplane airplane = new Airplane();
            airplane.StartEngine();
            airplane.StopEngine();
            airplane.Fly();


        }

        static void DependancyInversion()
        {
            WeatherTracker weatherTracker = new WeatherTracker(new Emailer()); // passing any object that implements INotifier interface
            weatherTracker.SetCurrentConditions("Hot");

            WeatherTracker weatherTracker2 = new WeatherTracker(new SMS()); // passing any object that implements INotifier interface
            weatherTracker2.SetCurrentConditions("Hot");

        }

        static void FinalTask()
        {
            IPaymentMethod paymentMethod = new CreditCardPayment();
            paymentMethod.Pay(233.98);

            paymentMethod = new CryptoPayment();
            paymentMethod.Pay(32642.3);

            paymentMethod = new PayPalPayment();
            paymentMethod.Pay(247824.98);


            // New Payment Method is Visa Payment

            paymentMethod = new VisaPayment();
            paymentMethod.Pay(4628752);


            FinalTask.INotifier notifier = new FinalTask.EmailNotifier("asmaa@gmail.com");
            notifier.Notify("Email Meesage");

            notifier = new SmsNotifier();
            notifier.Notify("SMS Meesage");

            notifier = new WhatsAppNotifier("0107467284628");
            notifier.Notify("WhatsApp Meesage");

            Order order = new Order()
            {
                Id = 2425,
                Amount = 0, // Non Parametrize Constructor Call OrderValidator Constructor class that check by default 
                CustomerEmail = "vgsaw@gmail.com",
                PaymentType = new PayPalPayment()
            };

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

            #region Semi Final Task

            //  SemiFinalTask();

            #endregion

            #region InterfaceSeggrigation

            #endregion


            #region DependancyInversion

            //  DependancyInversion();

            #endregion


            FinalTask();

        }
    }
}
