using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.SingleResponsibility.Apply
{
    internal class InvoicePresetince
    {
        private Invoice Invoice;
        public InvoicePresetince(Invoice invoice)
        {
            this.Invoice = invoice;
        }
        public void SaveInvoiceToFile(string fileName)
        {
            // Save invoice details to File
            Console.WriteLine($"Invoice related to book : {Invoice.Book.Name} saved to : {fileName}");
        }
    }
}
