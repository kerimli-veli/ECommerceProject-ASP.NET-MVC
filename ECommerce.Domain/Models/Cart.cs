namespace ECommerce.Domain.Models;

public class Cart
{
    public List<CartLine> CartLines { get; set; }
    public Cart()
    {
        CartLines = [];
    }

    public decimal Total
    {
        get
        {
            return CartLines.Sum(c => (c.Product.UnitPrice ?? 0) * c.Quantity);
        }
    }

}
