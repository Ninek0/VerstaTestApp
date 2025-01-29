using VerstaTestApp.DataBase;
using VerstaTestApp.Models;

namespace VerstaTestApp.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DataBaseContext _dataBaseContext;
        public OrderRepository(DataBaseContext context) {
            _dataBaseContext = context;
        }


        public void AddOrder(OrderModel order) {
            _dataBaseContext.Orders.Add(order);
            _dataBaseContext.SaveChanges();
        }

        public List<OrderModel> GetOrders() { 
            return _dataBaseContext.Orders.ToList();
        }
    }
}
