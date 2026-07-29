using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.LiskovSubstitution.Apply.Ex_2_Interface
{
    internal class MotorBike : IBike
    {
        int speed;
        bool isEngineOn;
        public void Speed()
        {
            speed = 100;
        }
        public void TurnOnEngine()
        {
            isEngineOn = true;
        }
    }
}
