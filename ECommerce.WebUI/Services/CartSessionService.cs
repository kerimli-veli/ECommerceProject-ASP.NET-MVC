using ECommerce.Domain.Models;
using ECommerce.WebUI.Extensions;

namespace ECommerce.WebUI.Services
{
    public class CartSessionService(IHttpContextAccessor contextAccessor) : ICatSessionService
    {
        private readonly IHttpContextAccessor _contextAccessor = contextAccessor;
        public Cart GetCart()
        {
            
                Cart cartToCheck = _contextAccessor.HttpContext.Session.GetObject<Cart>("cart");
                if (cartToCheck == null)
                {
                    _contextAccessor.HttpContext.Session.SetObject("cart", new Cart { });
                    cartToCheck = _contextAccessor.HttpContext.Session.GetObject<Cart>("cart");
                }
            
            return cartToCheck;
        }

        public void SetCart(Cart cart)
        {
            _contextAccessor.HttpContext!.Session.SetObject("cart", cart);
        }
    }

}
