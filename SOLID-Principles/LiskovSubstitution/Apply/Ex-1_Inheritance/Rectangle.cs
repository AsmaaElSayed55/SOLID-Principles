using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.LiskovSubstitution.Apply
{
    internal class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public override int GetArea()
        {
            return Width * Height;
        }
    }
}
