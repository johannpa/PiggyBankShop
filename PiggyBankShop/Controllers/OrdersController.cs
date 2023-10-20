using Microsoft.AspNetCore.Mvc;
using PiggyBankShop.Models;
using PiggyBankShop.Models.Interfaces;

namespace PiggyBankShop.Controllers
{
    public class OrdersController : Controller
    {
        private IOrderRepository _orderRepository;
        private IShoppingCartRepository _shoppingCartRepository;
        public OrdersController(
            IOrderRepository orderRepository, 
            IShoppingCartRepository shoppingCartRepository)
        {
            _orderRepository = orderRepository;
            _shoppingCartRepository = shoppingCartRepository;
        }
        public IActionResult Checkout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            _orderRepository.PlaceOrder(order);
            _shoppingCartRepository.CleanCart();
            HttpContext.Session.SetInt32("CartCount", 0);
            return Redirect("CheckoutComplete");
        }

        public IActionResult CheckoutComplete()
        {
            return View();
        }
    }
}
