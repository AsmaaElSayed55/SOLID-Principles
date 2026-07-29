using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.InterfaceSeggrigation.Violate
{
    internal interface IVechile
    {
        void StartEngine();
        void StopEngine();
        void Fly();
        void Drive();
    }
}
