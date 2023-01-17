namespace ClassLibrary1
{
    public class Customer : User
    {
        ShoppingCart cart;
        Order order;
        private string? customerName;
        private string? address;
        private string? email;
        private string? creditCardInfo;
        private string? shoppingInfo;
        private float? accountBalance;

        public void register() {}
        public void login() {}
        public void updateProfile() {}
        public Customer()
        {
            cart = new ShoppingCart();
            order = new Order();
        }
    }
}