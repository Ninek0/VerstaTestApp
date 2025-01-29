using VerstaTestApp.Models;
using VerstaTestApp.Repository;

namespace VerstaTestApp.Service
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void PlaceOrder(OrderModel order)
        {
            _orderRepository.AddOrder(order);
        }

        public List<OrderModel> GetAllOrders()
        {
            return _orderRepository.GetOrders();
        }
    }
}
