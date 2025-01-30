using ECommerce.Application.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.Controllers
{
    public class OrderDetailExtend(IOrderDetailExtendService orderDetailExtendService) : Controller
    {
        private readonly IOrderDetailExtendService _orderDetailExtendService = orderDetailExtendService;

        public IActionResult Index()
        {
            return View();
        }
    }
}
