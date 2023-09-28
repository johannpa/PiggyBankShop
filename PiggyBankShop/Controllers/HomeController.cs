using Microsoft.AspNetCore.Mvc;
using PiggyBankShop.Models.Interfaces;

namespace PiggyBankShop.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            
            return View(_productRepository.GetTrendingProducts());
        }
    }
}
