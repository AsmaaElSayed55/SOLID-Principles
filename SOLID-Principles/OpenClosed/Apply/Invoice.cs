namespace SOLID_Principles.OpenClosed.Apply
{
    internal class Invoice
    {
        public Book Book { get; set; }
        public int Quantity { get; set; }
        public decimal DiscountRate{ get; set; }
        public decimal TaxRate { get; set; }
        public decimal Total { get; set; }
        public Invoice(Book book, int quantity, decimal discountRate, decimal taxRate) {
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

    }
}
