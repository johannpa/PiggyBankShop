using Microsoft.EntityFrameworkCore;
using PiggyBankShop.Models;

namespace PiggyBankShop.Data
{
    public class PiggyBankShopDbContext : DbContext
    {
        public PiggyBankShopDbContext(DbContextOptions<PiggyBankShopDbContext> options):base(options)
        {
        }
        public DbSet<Product> Products{ get; set; }
    }
}
