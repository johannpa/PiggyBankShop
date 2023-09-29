using Microsoft.AspNetCore.Mvc;
using PiggyBankShop.Models.Interfaces;

namespace PiggyBankShop.Controllers
{
    public class ShoppingCartController1 : Controller
    {
        private IShoppingCartRepository shoppingCartRepository;
        private IProductRepository productRepository;

        public ShoppingCartController1(IShoppingCartRepository shoppingCartRepository, IProductRepository productRepository)
        {
            this.shoppingCartRepository = shoppingCartRepository;
            this.productRepository = productRepository;
        }
        public IActionResult Index()
        {
            var items = shoppingCartRepository.GetShoppingCartItems();
            shoppingCartRepository.ShoppingCartItems = items;
            return View(items);
        }

        public RedirectToActionResult AddToShoppingCart(int pId)
        {
            var product = productRepository.GetAllProducts().FirstOrDefault(p => p.Id == pId);
            if(product != null)
            {
                shoppingCartRepository.AddToCart(product);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int pId)
        {
            var product = productRepository.GetAllProducts().FirstOrDefault(p => p.Id == pId);
            if (product != null)
            {
                shoppingCartRepository.RemoveFromCart(product);
            }
            return RedirectToAction("Index");
        }
    }
}
