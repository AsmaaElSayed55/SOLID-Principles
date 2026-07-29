using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.LiskovSubstitution.Apply
{
    public class Square : Shape
    {
        public int Side { get; set; }
        public override int GetArea()
        {
            return Side * Side;
        }
    }
}
