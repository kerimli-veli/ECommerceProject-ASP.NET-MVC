using ECommerce.Application.Abstract;
using ECommerce.Application.Concrete;
using ECommerce.WebUI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.Controllers
{
    public class CartController(IProductService productService , ICatSessionService catSessionService , ICartService cartService) : Controller
    {
        private readonly IProductService _productService = productService;
        private readonly ICatSessionService _catSessionService = catSessionService;
        private readonly ICartService _cartService = cartService;
        public IActionResult AddToCart(int productId )
        {
            var productToBeAdded = _productService.GetById( productId );
            var cart = _catSessionService.GetCart();
            _cartService.AddToCart(cart, productToBeAdded);
            _catSessionService.SetCart(cart);

            TempData.Add("message" , String.Format("Your product , {0} wa added successsfully to cart ", productToBeAdded.ProductName));    

            return RedirectToAction("Index" , "Product" );
        }
    }
}
