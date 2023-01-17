namespace ClassLibrary1
{
    public class Order
    {
        OrderDetails detail;
        ShopingInfo shopInf;
        private int orderId { get; set; }
        private string? dateCreated { get; set; }
        private string? dateShipped { get; set; }
        private string? customerName { get; set; }
        private string? customerId { get; set; }
        private string? status { get; set; }
        private string? shoppingId { get; set; }

        public void placeOrder() { }

        public Order()
        {
            detail = new OrderDetails();
            shopInf = new ShopingInfo();
        }
    }
}
