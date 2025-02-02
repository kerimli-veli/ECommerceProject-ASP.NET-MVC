using ECommerce.Domain.Models;

namespace ECommerce.WebUI.Services
{
    public interface ICatSessionService
    {
        Cart GetCart();
       
        void SetCart(Cart cart);
    }
}
