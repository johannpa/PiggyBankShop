namespace PiggyBankShop.Models.Interfaces
{
    public interface IOrderRepository
    {
        void PlaceOrder(Order order);
    }
}
