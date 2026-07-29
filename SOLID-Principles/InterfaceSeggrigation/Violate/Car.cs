using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.InterfaceSeggrigation.Violate
{
    internal class Car : IVechile
    {
        public void Drive()
        {
            Console.WriteLine($"Car ===> Driving");
        }
        // this method is not applicable for Car, but we have to implement it because of the interface
        public void Fly()
        {
            Console.WriteLine($"Car Can't Fly");
        }
        public void StartEngine()
        {
            Console.WriteLine($"Car ===> Engine started");
        }
        public void StopEngine()
        {
            Console.WriteLine($"Car ===> Engine stopped");
        }
    }
}
