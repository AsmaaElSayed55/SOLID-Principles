using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.InterfaceSeggrigation.Apply
{
    internal class Airplane : IFlyable , IDrivable
    {
        public void Fly()
        {
            Console.WriteLine($"Airplane ===> Flying");
        }
        public void Drive()
        {
            Console.WriteLine($"Airplane ===> Driving");
        }
        public void StartEngine()
        {
            Console.WriteLine($"Airplane ===> Engine started");
        }
        public void StopEngine()
        {
            Console.WriteLine($"Airplane ===> Engine stopped");
        }

    }
}
