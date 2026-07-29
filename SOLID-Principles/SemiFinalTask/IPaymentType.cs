using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.SemiFinalTask
{
    public interface IPaymentType
    {
        void ProcessPayment(double amount);
    }
}
