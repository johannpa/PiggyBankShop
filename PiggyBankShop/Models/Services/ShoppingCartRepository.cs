using PiggyBankShop.Data;
using PiggyBankShop.Models.Interfaces;

namespace PiggyBankShop.Models.Services
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private PiggyBankShopDbContext dbContext;
        public ShoppingCartRepository(PiggyBankShopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<ShoppingCartItem>? ShoppingCartItems { get ; set ; }

        public void AddToCart(Product product)
        {
            throw new NotImplementedException();
        }

        public void CleanCart()
        {
            throw new NotImplementedException();
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            throw new NotImplementedException();
        }

        public decimal GetShoppingCartTotal()
        {
            throw new NotImplementedException();
        }

        public int RemoveFromCart(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
