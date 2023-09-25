using Microsoft.AspNetCore.Mvc;
using PiggyBankShop.Models.Interfaces;

namespace PiggyBankShop.Controllers
{
    public class ProductsController : Controller
    {
        private IProductRepository productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IActionResult Shop()
        {
            return View(productRepository.GetAllProducts());
        }
    }
}
