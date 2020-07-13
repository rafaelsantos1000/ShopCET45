using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShopCET45.Web.Data.Repositories;
using System.Threading.Tasks;

namespace ShopCET45.Web.Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {

        private readonly IOrderRepository _orderRepository;

        public OrdersController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }


        public async Task<IActionResult> Index()
        {
            var model = await _orderRepository.GetOrdersAsync(this.User.Identity.Name);
            return View(model);
        }

    }
}
