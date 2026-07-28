using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.SingleResponsibility.Apply
{
    internal class InvoicePrinter
    {
        private Invoice Invoice;
        public InvoicePrinter(Invoice invoice)
        {
            this.Invoice = invoice; 
        }
        public void PrintInvoice()
        {
            Console.WriteLine($"Invoice ==> Book: {Invoice.Book.Name}, Quantity: {Invoice.Quantity}, Total: {Invoice.Total}");
        }
    }
}
