using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.SemiFinalTask
{
    public interface ISendingReceipt
    {
        void SendReceipt(IPaymentType paymentType);
    }
}
