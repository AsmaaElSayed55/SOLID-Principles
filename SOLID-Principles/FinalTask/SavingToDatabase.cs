using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.FinalTask
{
    public class SavingToDatabase : ISavingOrder
    {
        public void Save(Order order)
        {
            Console.WriteLine($"Saving {order} to database...");
        }
    }
}
