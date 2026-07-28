namespace SOLID_Principles.OpenClosed.Apply
{
    internal class FileInvoicePresistence : IInvoice
    {
        public void Save(Invoice invoice) {
            // Save the invoice to a file
            Console.WriteLine($"Invoice for {invoice.Book.Name} saved to file.");
        }
    }
}
