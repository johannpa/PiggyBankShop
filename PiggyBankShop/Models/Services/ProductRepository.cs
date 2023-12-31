﻿using PiggyBankShop.Data;
using PiggyBankShop.Models.Interfaces;

namespace PiggyBankShop.Models.Services
{
    public class ProductRepository : IProductRepository
    {
        private PiggyBankShopDbContext dbContext;

        public ProductRepository(PiggyBankShopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return dbContext.Products;
        }

        public Product? GetProductDetail(int id)
        {
            return dbContext.Products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetTrendingProducts()
        {
            return dbContext.Products.Where(p => p.IsTrendingProduct);
        }
    }
}
