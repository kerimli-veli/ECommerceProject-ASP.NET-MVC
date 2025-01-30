using ECommerce.Domain.Abstraction;
using System;
using System.Collections.Generic;

namespace ECommerce.Domain.Entities;

public partial class SummaryOfSalesByQuarter : IEntity
{
    public DateTime? ShippedDate { get; set; }

    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
