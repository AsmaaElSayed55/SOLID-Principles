using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.FinalTask
{
    public class OrderValidator
    {
        public bool Validate(int amount) { 
            return amount > 0;
        }
    }
}
