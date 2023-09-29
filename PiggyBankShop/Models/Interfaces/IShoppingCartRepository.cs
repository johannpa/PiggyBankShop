namespace PiggyBankShop.Models.Interfaces
{
    public interface IShoppingCartRepository
    {
        void AddToCart(Product product);
        int RemoveFromCart(Product product);
        List<ShoppingCartItem> GetShoppingCartItems();
        void CleanCart();
        decimal GetShoppingCartTotal();
        public List<ShoppingCartItem>? ShoppingCartItems { get; set; }
    }
}
