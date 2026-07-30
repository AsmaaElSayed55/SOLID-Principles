using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.SingleResponsibility.Violate
{
    internal class Invoice
    {
        public Emailer Book { get; set; }
        public int Quantity { get; set; }
        public decimal DiscountRate{ get; set; }
        public decimal TaxRate { get; set; }
        public decimal Total { get; set; }
        public Invoice(Emailer book, int quantity, decimal discountRate, decimal taxRate) {
            Book = book;
            Quantity = quantity;
            DiscountRate = discountRate;
            TaxRate = taxRate;
            Total = CalculateTotal();
        }

        private decimal CalculateTotal() {
            var subTotal = (Book.Price-(Book.Price * DiscountRate))*Quantity;
            return subTotal*(1 + TaxRate);
        }
        public void PrintInvoice() {
            Console.WriteLine($"Invoice ==> Book: {Book.Name}, Quantity: {Quantity}, Total: {Total}");
        }

        public void SaveInvoiceToFile(string fileName) {
            // Save invoice details to File
            Console.WriteLine($"Invoice saved to : {fileName}");
        }

    }
}
