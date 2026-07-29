using SOLID_Principles.InterfaceSeggrigation.Apply;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.InterfaceSeggrigation.Apply
{
    internal class Car : IDrivable
    {
        public void Drive()
        {
            Console.WriteLine($"Car ===> Driving");
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
