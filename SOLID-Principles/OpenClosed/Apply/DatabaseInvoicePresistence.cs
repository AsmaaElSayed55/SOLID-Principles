namespace SOLID_Principles.OpenClosed.Apply
{
    internal class DatabaseInvoicePresistence : IInvoice
    {
        public void Save(Invoice invoice) {
            // Save the invoice to a database
            Console.WriteLine($"Invoice for {invoice.Book.Name} saved to database.");
        }
    {
    }
}
