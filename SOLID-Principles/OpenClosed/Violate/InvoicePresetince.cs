using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.OpenClosed.Violate
{
    internal class InvoicePresetince
    {
        public Invoice Invoice;
        public InvoicePresetince(Invoice invoice)
        {
            this.Invoice = invoice;
        }

        // Saving
        public void SaveInvoice(string SavingWay)
        {
            if(SavingWay=="File")
            {
                Console.WriteLine($"Invoice related to book : {Invoice.Book.Name} saved to File");
            }
            else if(SavingWay=="Database")
            {
                Console.WriteLine($"Invoice related to book : {Invoice.Book.Name} saved to Database");
            }
            // For new saving way, we need to modify this class which is violating the Open Closed Principle
            else if (SavingWay=="Cloud")
            {
                Console.WriteLine($"Invoice related to book : {Invoice.Book.Name} saved to Cloud");
            }
            else
            {
                Console.WriteLine($"Invoice related to book : {Invoice.Book.Name} saved to Unknown");
            }
        }
    }
}
