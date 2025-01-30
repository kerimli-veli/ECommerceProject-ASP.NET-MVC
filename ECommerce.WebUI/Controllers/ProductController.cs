using ECommerce.Application.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.Controllers;

public class ProductController(IProductService productService) : Controller
{
    private readonly IProductService _productService = productService;

    public IActionResult Index()
    {
        return View();
    }
}
