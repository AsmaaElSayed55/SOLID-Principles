using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.LiskovSubstitution.Violate.Ex_2_Interface
{
    internal class Bicycle : IBike
    {
        int speed;
        public void Speed()
        {
            speed = 20;
        }
        
        public void TurnOnEngine()
        {
            throw new NotImplementedException("Bicycle does not have an engine.");
        }

    }
}
