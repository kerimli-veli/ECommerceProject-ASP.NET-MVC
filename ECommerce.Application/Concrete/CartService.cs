using ECommerce.Application.Abstract;
using ECommerce.Domain.Entities;
using ECommerce.Domain.Models;

namespace ECommerce.Application.Concrete
{
    public class CartService : ICartService
    {
        public void AddToCart(Cart cart, Product product)
        {
            CartLine cartLine = cart.CartLines.FirstOrDefault(cl => cl.Product.ProductId == product.ProductId)!;
            if (cartLine != null)
                cartLine.Quantity++;
            else
            {
                cart.CartLines.Add(new CartLine { Quantity = 1, Product = product });
            }
        }

        public List<CartLine> List(Cart cart)
        {
            return cart.CartLines;
        }

        public void RemoveFromCart(Cart cart, int productId)
        {
            cart.CartLines.Remove(cart.CartLines.FirstOrDefault(c => c.Product.ProductId == productId)!);
        }
    }
}
