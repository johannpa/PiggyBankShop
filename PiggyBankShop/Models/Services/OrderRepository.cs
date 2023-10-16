using PiggyBankShop.Data;
using PiggyBankShop.Models.Interfaces;

namespace PiggyBankShop.Models.Services
{
    public class OrderRepository : IOrderRepository
    {
        private PiggyBankShopDbContext _dbContext;
        private IShoppingCartRepository _shoppingCartRepository;

        public OrderRepository(PiggyBankShopDbContext dbContext, IShoppingCartRepository shoppingCartRepository)
        {
            _dbContext = dbContext;
            _shoppingCartRepository = shoppingCartRepository;
        }
        public void PlaceOrder(Order order)
        {
            var shoppingCartItems = _shoppingCartRepository.GetShoppingCartItems();
            order.OrderDetails = new List<OrderDetail>();
            foreach (var item in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Quantity = item.Qty,
                    ProductId = item.Product.Id,
                    Price = item.Product.Price
                };
                order.OrderDetails.Add(orderDetail);
            }
            order.OrderPlaced = DateTime.Now;
            order.OrderTotal = _shoppingCartRepository.GetShoppingCartTotal();
            _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();
        }
    }
}
