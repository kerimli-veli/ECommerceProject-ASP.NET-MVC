using ECommerce.Application.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.Controllers
{
    public class OrderDetail(IOrderDetailService orderDetailService) : Controller
    {
        private readonly IOrderDetailService _orderDetailService = orderDetailService;

        public IActionResult Index()
        {
            return View();
        }
    }
}
