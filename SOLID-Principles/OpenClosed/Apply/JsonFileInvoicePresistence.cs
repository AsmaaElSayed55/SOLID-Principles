namespace SOLID_Principles.OpenClosed.Apply
{
    internal class JsonFileInvoicePresistence: IInvoice
    {
        public void Save(Invoice invoice) {
            // Save the invoice to a JSON file
            Console.WriteLine($"Invoice for {invoice.Book.Name} saved to JSON file.");
        }
    }
}
