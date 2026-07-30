using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.DependancyInversion.Apply
{
    internal interface INotifier
    {
        void Send(string message);

    }
}
