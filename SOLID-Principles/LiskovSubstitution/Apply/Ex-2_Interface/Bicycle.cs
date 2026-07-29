using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.LiskovSubstitution.Apply.Ex_2_Interface
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
            // Bicycles do not have engines, so this method can be left empty or throw an exception if needed.
            // For example, we can throw a NotImplementedException to indicate that this operation is not applicable for bicycles.
            throw new NotImplementedException("Bicycle does not have an engine.");

        }


    }
}
