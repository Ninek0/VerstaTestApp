using VerstaTestApp.Models;

namespace VerstaTestApp.Repository
{
    public interface IOrderRepository
    {
        void AddOrder(OrderModel order);
        List<OrderModel> GetOrders();
    }
}
