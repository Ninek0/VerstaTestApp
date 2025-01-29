using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VerstaTestApp.Models;
using VerstaTestApp.Service;

namespace VerstaTestApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly OrderService _orderService;

        private readonly ILogger<OrderController> _logger;

        private static Random random = new Random();

        public OrderController(ILogger<OrderController> logger, OrderService orderService)
        {
            _logger = logger;
            _orderService = orderService;
        }

        public IActionResult CreateOrderPage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateOrder(OrderModel order)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            
            order.OrderCode = "VO-" + new string(Enumerable.Repeat(chars, 32).Select(s => s[random.Next(s.Length)]).ToArray());
            _orderService.PlaceOrder(order);
            return View("CreateOrderPage");
        }

        public IActionResult ListOrderPage()
        {
            List<OrderModel> orders = _orderService.GetAllOrders();
            ViewBag.Orders = orders;
            return View(orders);
        }

        public IActionResult DetailsOrderPage(int orderIndex) {
            List<OrderModel> orders = _orderService.GetAllOrders();
            return View(orders[orderIndex]);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
