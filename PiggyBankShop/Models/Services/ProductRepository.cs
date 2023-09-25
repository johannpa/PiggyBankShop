using PiggyBankShop.Models.Interfaces;

namespace PiggyBankShop.Models.Services
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> ProductsList = new List<Product>()
        {
            new Product { Id = 1, Name = "Big Pig", Price = 35, Detail = "Les tirelires sont populaires auprès des enfants pour les aider à apprendre à économiser de l'argent...", ImageUrl="https://t3.ftcdn.net/jpg/00/61/45/26/360_F_61452654_zeYz36bPOmoRvlbya4ZfUebgQBHmnaXd.jpg"},
            new Product { Id = 2, Name = "Middle Pig", Price = 25, Detail = "Les tirelires sont populaires auprès des enfants pour les aider à apprendre à économiser de l'argent ...", ImageUrl="https://t3.ftcdn.net/jpg/00/61/45/26/360_F_61452654_zeYz36bPOmoRvlbya4ZfUebgQBHmnaXd.jpg"},
            new Product { Id = 3, Name = "Little Pig", Price = 15, Detail = "Les tirelires sont populaires auprès des enfants pour les aider à apprendre à économiser de l'argent ...", ImageUrl="https://t3.ftcdn.net/jpg/00/61/45/26/360_F_61452654_zeYz36bPOmoRvlbya4ZfUebgQBHmnaXd.jpg"},
        };
        public IEnumerable<Product> GetAllProducts()
        {
            return ProductsList;
        }

        public Product GetProductDetail(int id)
        {
            return ProductsList.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetTrendingProducts()
        {
            return ProductsList.Where(p => p.IsTrendingProduct);
        }
    }
}
