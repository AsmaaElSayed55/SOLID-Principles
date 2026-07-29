using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.LiskovSubstitution.Violate.Ex_1_Inheritance
{
    public class Square : Rectangle
    {
        override public int Width
        {
            set
            {
                base.Width = value; 
                base.Height = value;
            }
        }

        override public int Height
        {
            set
            {
                base.Width = value; 
                base.Height = value;
            }
        }
    }
}
