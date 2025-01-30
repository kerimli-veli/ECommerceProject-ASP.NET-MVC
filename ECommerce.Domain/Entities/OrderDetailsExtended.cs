using ECommerce.Domain.Abstraction;
using System;
using System.Collections.Generic;

namespace ECommerce.Domain.Entities;

public partial class OrderDetailsExtended : IEntity
{
    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal UnitPrice { get; set; }

    public short Quantity { get; set; }

    public float Discount { get; set; }

    public decimal? ExtendedPrice { get; set; }
}
