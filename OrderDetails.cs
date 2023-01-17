namespace ClassLibrary1
{
    public class OrderDetails
    {
        private int orderId { get; set; }
        private int productId { get; set; }
        private string? productName { get; set; }
        private int quantity { get; set; }
        private float uniCost { get; set; }
        private float subtotal { get; set; }

        public void calcPrice() { }
    }
}
